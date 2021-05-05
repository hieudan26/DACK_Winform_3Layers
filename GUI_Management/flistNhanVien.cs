using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using DTO_Management;

namespace GUI_Management
{
    public partial class flistNhanVien : Form
    {
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        phongBanBUS phongBanBUS = new phongBanBUS();
        fQuanLyNhanVien fQuanLyNhanVien = new fQuanLyNhanVien();
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();

        public flistNhanVien(fQuanLyNhanVien fQuanLy)
        {
            InitializeComponent();
            this.fQuanLyNhanVien = fQuanLy;
        }

        //design dgv
        private void designDataGridView(int i1)
        {
            if (this.dgv.DataSource != null)
            {
                this.dgv.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                picCol = (DataGridViewImageColumn)this.dgv.Columns[i1];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                this.dgv.AllowUserToAddRows = false;
            }  
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.dgv.RowTemplate.Height = 80;
            DataTable table = new DataTable();
            if (this.cbFilter.SelectedIndex != -1)
            {
                int index = this.cbFilter.SelectedIndex;
                if (index == 0)
                {
                    string typeTho = "Bảo Vệ";
                    table = this.nhanVienBUS.getNv_typeTho(typeTho);
                    this.dgv.DataSource = table;
                    this.designDataGridView(6);
                }    
                else if (index == 1)
                {
                    string typeTho = "Thợ Sửa";
                    table = this.nhanVienBUS.getNv_typeTho(typeTho);
                    this.dgv.DataSource = table;
                    this.designDataGridView(6);
                }    
                else if (index == 2)
                {
                    string typeTho = "Thợ Rửa";
                    table = this.nhanVienBUS.getNv_typeTho(typeTho);
                    this.dgv.DataSource = table;
                    this.designDataGridView(6);
                }    
                else if (index == 3)
                {
                    string typeTho = "Nhân Viên";
                    table = this.nhanVienBUS.getNv_typeTho(typeTho);
                    this.dgv.DataSource = table;
                    this.designDataGridView(6);
                }    
                else 
                {
                    table = this.nhanVienBUS.getAllEmployees();
                    this.dgv.DataSource = table;
                    this.designDataGridView(6);
                }    
            }    
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text != "")
            {
                this.dgv.RowTemplate.Height = 80;
                this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandName(this.txtSearch.Text);
                this.designDataGridView(6);
            }    
            else
            {
                MessageBox.Show("Maybe you must to fill search textbox", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void Reset(string typeTho)
        {
            if (typeTho == "Bảo Vệ")
            {
                this.shift_BaoVeBUS.ResetShift_BaoVe();
            }
            else if (typeTho == "Thợ Sửa")
            {
                this.shift_ThoSuaXeBUS.ResetShift_ThoSuaXe();
            }    
            else if (typeTho == "Thợ Rửa")
            {
                this.shift_ThoRuaXeBUS.ResetShift_ThoRuaXe();
            }    
            else
            {
                this.shift_NhanVienBUS.ResetShift_NhanVien();
            }    
        }
        
        private void divShift(string typeTho)
        {
            if (typeTho == "Bảo Vệ")
            {   
                this.shift_BaoVeBUS.chiaCaBaoVe();
            }
            else if (typeTho == "Thợ Sửa")
            {
                this.shift_ThoSuaXeBUS.chiaCaThoSuaXe();
            }
            else if (typeTho == "Thợ Rửa")
            {
                 this.shift_ThoRuaXeBUS.chiaCaThoRuaXe();
            }
            else
            {
                this.shift_NhanVienBUS.chiaCaNhanVien();
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
                string id_dept = this.dgv.CurrentRow.Cells[2].Value.ToString();
                string typeTho = this.dgv.CurrentRow.Cells[5].Value.ToString().Trim();

                if (MessageBox.Show("Are you sure", "List Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Reset(typeTho);
                    if (this.phongBanBUS.ktraLeader(id))
                    {
                        if (this.phongBanBUS.reset_leaderId_Department(id_dept))
                        {
                            MessageBox.Show("Xóa Trưởng Phòng Thành Công", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                        else
                            MessageBox.Show("Xóa Trưởng Phòng Không Thành Công", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    /////////////////////////////////////////////////////////////////////////////
                    if (this.nhanVienBUS.DelEmployee(id))
                    {
                        MessageBox.Show("Xóa Thành Công", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.divShift(typeTho);
                        this.cbFilter.SelectedIndex = 4;
                        DataTable table = this.nhanVienBUS.getAllEmployees();
                        this.dgv.DataSource = table;
                        this.designDataGridView(6);
                    }
                    else
                    {
                        MessageBox.Show("Xóa Không Thành Công", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int indexTypeTho(string typeTho)
        {
            if (typeTho == "Bảo Vệ")
            {
                return 0;
            }    
            else if (typeTho == "Thợ Sửa")
            {
                return 1;
            }    
            else if (typeTho == "Thợ Rửa")
            {
                return 2;
            }    
            else
            {
                return 3;
            }    
        }

        private int indexGender(string gender)
        {
            if (gender == "Nam")
            {
                return 0;
            }    
            else if (gender == "Nữ")
            {
                return 1;
            }    
            else
            {
                return 2;
            }
        }

        private void dgv_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            finfoNhanVien form = new finfoNhanVien();
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            string name = this.dgv.CurrentRow.Cells[1].Value.ToString();
            DateTime dob = DateTime.Parse(this.dgv.CurrentRow.Cells[3].Value.ToString());
            string gender = this.dgv.CurrentRow.Cells[4].Value.ToString();
            string typeTho = this.dgv.CurrentRow.Cells[5].Value.ToString();
            Byte[] pic = new Byte[0];
            pic = (Byte[])(this.dgv.CurrentRow.Cells[6].Value);
            MemoryStream ms = new MemoryStream(pic);
                
            form.txtId_CMND.Text = id;
            form.txtTenNV.Text = name;
            form.dtpDoB.Value = dob;
            form.cbSex.SelectedIndex = this.indexGender(gender);
            form.cbTypeTho.SelectedIndex = this.indexTypeTho(typeTho);
            form.pbNhanVien.Image = Image.FromStream(ms);
            form.pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            if (this.phongBanBUS.ktraLeader(id))
            {
                form.rbYes.Checked = true;
            }
            else
            {
                form.rbNo.Checked = true;
            }
            this.fQuanLyNhanVien.openChildForm(form);
        }
    }
}
