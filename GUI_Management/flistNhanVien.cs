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
        nhanVienBaoVeBUS nhanVienBaoVeBUS = new nhanVienBaoVeBUS();
        nhanVienSuaXeBUS nhanVienSuaXeBUS = new nhanVienSuaXeBUS();
        nhanVienRuaXeBUS nhanVienRuaXeBUS = new nhanVienRuaXeBUS();
        nhanVienHopDongBUS nhanVienHopDongBUS = new nhanVienHopDongBUS();
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
                if (this.rbNo.Checked == true)
                {
                    if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxKhac.Checked == true && this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true))
                    {
                        this.LoadDGV_ordinary(index, table);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_Gender(index, table, "Nam");
                    }
                    else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_Gender(index, table, "Nữ");
                    }
                    else if (this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == false)
                    {
                        this.LoadDGV_Gender(index, table, "Khác");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_GenderAndGender(index, table, "Nam", "Nữ");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                    {
                        this.LoadDGV_GenderAndGender(index, table, "Nam", "Khác");
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true)
                    {
                        this.LoadDGV_GenderAndGender(index, table, "Nữ", "Khác");
                    }
                }   
                else
                {
                    if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxKhac.Checked == true && this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true))
                    {
                        this.LoadDGV_ordinary_Giua2Ngay(index, table);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_Gender_Giua2Ngay(index, table, "Nam");
                    }
                    else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_Gender_Giua2Ngay(index, table, "Nữ");
                    }
                    else if (this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == false)
                    {
                        this.LoadDGV_Gender_Giua2Ngay(index, table, "Khác");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                    {
                        this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nam", "Nữ");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                    {
                        this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nam", "Khác");
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true)
                    {
                        this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nữ", "Khác");
                    }
                }    
            }    
        }

        private void LoadDGV_Gender_Giua2Ngay(int index, DataTable table, string gender)
        {
            DateTime dt1 = this.dtp1.Value;
            DateTime dt2 = this.dtp2.Value;

            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeThoGender_Giua2Ngay(typeTho, gender, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeThoGender_Giua2Ngay(typeTho, gender, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeThoGender_Giua2Ngay(typeTho, gender, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeThoGender_Giua2Ngay(typeTho, gender, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployeesGender_Giua2Ngay(gender, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void LoadDGV_GenderAndGender_Giua2Ngay(int index, DataTable table, string gender1, string gender2)
        {
            DateTime dt1 = this.dtp1.Value;
            DateTime dt2 = this.dtp2.Value;

            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender_Giua2Ngay(typeTho, gender1, gender2, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender_Giua2Ngay(typeTho, gender1, gender2, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender_Giua2Ngay(typeTho, gender1, gender2, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender_Giua2Ngay(typeTho, gender1, gender2, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployeesGenderAndGender_Giua2Ngay(gender1, gender2, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void LoadDGV_ordinary_Giua2Ngay(int index, DataTable table)
        {
            DateTime dt1 = this.dtp1.Value;
            DateTime dt2 = this.dtp2.Value;

            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeTho_Giua2Ngay(typeTho, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeTho_Giua2Ngay(typeTho, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeTho_Giua2Ngay(typeTho, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeTho_Giua2Ngay(typeTho, dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployees_Giua2Ngay(dt1, dt2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void LoadDGV_ordinary(int index, DataTable table)
        {
            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeTho(typeTho);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeTho(typeTho);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeTho(typeTho);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeTho(typeTho);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployees();
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void LoadDGV_GenderAndGender(int index, DataTable table, string gender1, string gender2)
        {
            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender(typeTho, gender1, gender2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender(typeTho, gender1, gender2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender(typeTho, gender1, gender2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeThoGenderAndGender(typeTho, gender1, gender2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployeesGenderAndGender(gender1, gender2);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void LoadDGV_Gender(int index, DataTable table, string gender)
        {
            if (index == 0)
            {
                string typeTho = "Bảo Vệ";
                table = this.nhanVienBUS.getNv_typeThoGender(typeTho, gender);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 1)
            {
                string typeTho = "Thợ Sửa";
                table = this.nhanVienBUS.getNv_typeThoGender(typeTho, gender);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 2)
            {
                string typeTho = "Thợ Rửa";
                table = this.nhanVienBUS.getNv_typeThoGender(typeTho, gender);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else if (index == 3)
            {
                string typeTho = "Nhân Viên";
                table = this.nhanVienBUS.getNv_typeThoGender(typeTho, gender);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
            else
            {
                table = this.nhanVienBUS.getAllEmployeesGender(gender);
                this.dgv.DataSource = table;
                this.designDataGridView(5);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (this.txtSearch.Text != "")
            {
                this.dgv.RowTemplate.Height = 80;
                if (this.rbNo.Checked == true)
                {
                    if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true))
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandName(this.txtSearch.Text);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender(this.txtSearch.Text, "Nam");
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender(this.txtSearch.Text, "Nữ");
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender(this.txtSearch.Text, "Khác");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender(this.txtSearch.Text, "Nam", "Khác");
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender(this.txtSearch.Text, "Nam", "Nữ");
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender(this.txtSearch.Text, "Nữ", "Khác");
                    }
                }   
                else
                {
                    if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true))
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandName_Giua2Ngay(this.txtSearch.Text, this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender_Giua2Ngay(this.txtSearch.Text, "Nam", this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender_Giua2Ngay(this.txtSearch.Text, "Nữ", this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGender_Giua2Ngay(this.txtSearch.Text, "Khác", this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender_Giua2Ngay(this.txtSearch.Text, "Nam", "Khác", this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender_Giua2Ngay(this.txtSearch.Text, "Nam", "Nữ", this.dtp1.Value, this.dtp2.Value);
                    }
                    else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == true)
                    {
                        this.dgv.DataSource = this.nhanVienBUS.getEmployee_ByIDandNameGenderGender_Giua2Ngay(this.txtSearch.Text, "Nữ", "Khác", this.dtp1.Value, this.dtp2.Value);
                    }
                }    
                this.designDataGridView(5);
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

        private void XoaAccount(string typeTho, string id)
        {
            if (typeTho == "Bảo Vệ")
            {
                if (this.nhanVienBaoVeBUS.RemoveBAOVE(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên Bảo Vệ", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công nhân viên Bảo Vệ", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeTho == "Thợ Sửa")
            {
                if (this.nhanVienSuaXeBUS.RemoveNhanVienSuaXe(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên Sửa Xe", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công nhân viên Sửa Xe", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else if (typeTho == "Thợ Rửa")
            {
                if (this.nhanVienRuaXeBUS.RemoveNhanVienRuaXe(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên Rửa Xe", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công nhân viên Rửa Xe", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                if (this.nhanVienHopDongBUS.RemoveNhanVienHopDong(id))
                {
                    MessageBox.Show("Xóa thành công nhân viên Hợp Đồng", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Xóa không thành công nhân viên Hợp Đồng", "Xóa Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgv.CurrentRow.Cells[0].Value.ToString().Trim();
                string typeTho = this.dgv.CurrentRow.Cells[4].Value.ToString().Trim();

                if (MessageBox.Show("Are you sure", "List Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    ////this.Reset(typeTho);
                    //Xóa bảng khóa phụ chứa id, usename, password và status
                    this.XoaAccount(typeTho, id);
                    
                    if (this.nhanVienBUS.DelEmployee(id))
                    {
                        MessageBox.Show("Xóa Thành Công", "List Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        //this.divShift(typeTho);
                        this.cbFilter.SelectedIndex = 4;
                        DataTable table = this.nhanVienBUS.getAllEmployees();
                        this.dgv.DataSource = table;
                        this.designDataGridView(5);
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
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString().Trim();
            string name = this.dgv.CurrentRow.Cells[1].Value.ToString().Trim();
            DateTime dob = DateTime.Parse(this.dgv.CurrentRow.Cells[2].Value.ToString());
            string gender = this.dgv.CurrentRow.Cells[3].Value.ToString().Trim();
            string typeTho = this.dgv.CurrentRow.Cells[4].Value.ToString().Trim();
            Byte[] pic = new Byte[0];
            pic = (Byte[])(this.dgv.CurrentRow.Cells[5].Value);
            MemoryStream ms = new MemoryStream(pic);
                
            form.txtId_CMND.Text = id;
            form.txtTenNV.Text = name;
            form.dtpDoB.Value = dob;
            form.cbSex.SelectedIndex = this.indexGender(gender);
            form.cbTypeTho.SelectedIndex = this.indexTypeTho(typeTho);
            form.pbNhanVien.Image = Image.FromStream(ms);
            form.pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
            
            if (this.kTraLeader(typeTho, id))
            {
                form.rbYes.Checked = true;
            }
            else
            {
                form.rbNo.Checked = true;
            }

            DataTable table = new DataTable();
            if (typeTho == "Bảo Vệ")
            {
                table = this.nhanVienBaoVeBUS.getInfo_byID(id);
            }    
            else if (typeTho == "Thợ Sửa")
            {
                table = this.nhanVienSuaXeBUS.getInfo_byID(id);
            }    
            else if (typeTho == "Thợ Rửa")
            {
                table = this.nhanVienRuaXeBUS.getInfo_byID(id);
            }    
            else
            {
                table = this.nhanVienHopDongBUS.getInfo_byID(id);
            }    

            if (table != null)
            {
                form.txtUsername.Text = table.Rows[0][1].ToString().Trim();
                form.txtPassword.Text = table.Rows[0][2].ToString().Trim();
            }    

            this.fQuanLyNhanVien.openChildForm(form);
        }

        private bool kTraLeader(string typeTho, string id)
        {
            if (typeTho == "Bảo Vệ")
            {
                DataTable table = this.nhanVienBaoVeBUS.getInfoLeader();
                if (table != null)
                {
                    if (table.Rows[0][0].ToString().Trim() == id)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } 
                else
                {
                    return false;
                }    
            }    
            else if (typeTho == "Thợ Sửa")
            {
                DataTable table = this.nhanVienSuaXeBUS.getInfoLeader();
                if (table != null)
                {
                    if (table.Rows[0][0].ToString().Trim() == id)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }   
                else
                {
                    return false;
                }    
            }    
            else if (typeTho == "Thợ Rửa")
            {
                DataTable table = this.nhanVienRuaXeBUS.getInfoLeader();
                if (table != null)
                {
                    if (table.Rows[0][0].ToString().Trim() == id)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
                else
                {
                    return false;
                }    
            }    
            else
            {
                DataTable table = this.nhanVienHopDongBUS.getInfoLeader();
                if (table != null)
                {
                    if (table.Rows[0][0].ToString().Trim() == id)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                } 
                else
                {
                    return false;
                }    
            }    
        }

        private void flistNhanVien_Load(object sender, EventArgs e)
        {
        }

        private void checkBoxNam_Click(object sender, EventArgs e)
        {
            if (this.cbFilter.SelectedIndex != -1)
            {
                DataTable table = new DataTable();
                if (this.rbNo.Checked == true)
                {
                    if (this.checkBoxNam.Checked == true)
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nam", "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nữ", "Khác");
                        }
                    }
                }
                else
                {
                    if (this.checkBoxNam.Checked == true)
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam", "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ", "Khác");
                        }
                    }
                }    
            }
        }

        private void checkBoxNu_Click(object sender, EventArgs e)
        {
            if (this.cbFilter.SelectedIndex != -1)
            {
                DataTable table = new DataTable();
                if (this.rbNo.Checked == true)
                {
                    if (this.checkBoxNu.Checked == true)
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nam", "Nữ");
                        }
                        else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nữ", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                    }
                }    
                else
                {
                    if (this.checkBoxNu.Checked == true)
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam", "Nữ");
                        }
                        else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNam.Checked == true && this.checkBoxKhac.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else if (this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == true)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                    }
                }    
            }
        }

        private void checkBoxKhac_Click(object sender, EventArgs e)
        {
            if (this.cbFilter.SelectedIndex != -1)
            {
                DataTable table = new DataTable();
                if (this.rbNo.Checked == true)
                {
                    if (this.checkBoxKhac.Checked == true)
                    {
                        if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Khác", "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == true)
                        {
                            this.LoadDGV_Gender(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender(this.cbFilter.SelectedIndex, table, "Nữ", "Nam");
                        }
                    }
                }    
                else
                {
                    if (this.checkBoxKhac.Checked == true)
                    {
                        if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Khác");
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Khác", "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == true)
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam", "Khác");
                        }
                        else
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                    }
                    else
                    {
                        if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false)
                        {
                            this.LoadDGV_ordinary_Giua2Ngay(this.cbFilter.SelectedIndex, table);
                        }
                        else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ");
                        }
                        else if (this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == true)
                        {
                            this.LoadDGV_Gender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nam");
                        }
                        else
                        {
                            this.LoadDGV_GenderAndGender_Giua2Ngay(this.cbFilter.SelectedIndex, table, "Nữ", "Nam");
                        }
                    }
                }    
            }
        }

        private void rbYes_Click(object sender, EventArgs e)
        {
            if (this.cbFilter.SelectedIndex != -1)
            {
                this.dgv.RowTemplate.Height = 80;
                int index = this.cbFilter.SelectedIndex;
                DataTable table = new DataTable();
                if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxKhac.Checked == true && this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true))
                {
                    this.LoadDGV_ordinary_Giua2Ngay(index, table);
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_Gender_Giua2Ngay(index, table, "Nam");
                }
                else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_Gender_Giua2Ngay(index, table, "Nữ");
                }
                else if (this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == false)
                {
                    this.LoadDGV_Gender_Giua2Ngay(index, table, "Khác");
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nam", "Nữ");
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                {
                    this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nam", "Khác");
                }
                else if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true)
                {
                    this.LoadDGV_GenderAndGender_Giua2Ngay(index, table, "Nữ", "Khác");
                }
            }    
        }

        private void rbNo_Click(object sender, EventArgs e)
        {
            if (this.cbFilter.SelectedIndex != -1)
            {
                this.dgv.RowTemplate.Height = 80;
                int index = this.cbFilter.SelectedIndex;
                DataTable table = new DataTable();
                if ((this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false) || (this.checkBoxKhac.Checked == true && this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true))
                {
                    this.LoadDGV_ordinary(index, table);
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_Gender(index, table, "Nam");
                }
                else if (this.checkBoxNu.Checked == true && this.checkBoxNam.Checked == false && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_Gender(index, table, "Nữ");
                }
                else if (this.checkBoxKhac.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxNam.Checked == false)
                {
                    this.LoadDGV_Gender(index, table, "Khác");
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == false)
                {
                    this.LoadDGV_GenderAndGender(index, table, "Nam", "Nữ");
                }
                else if (this.checkBoxNam.Checked == true && this.checkBoxNu.Checked == false && this.checkBoxKhac.Checked == true)
                {
                    this.LoadDGV_GenderAndGender(index, table, "Nam", "Khác");
                }
                else if (this.checkBoxNam.Checked == false && this.checkBoxNu.Checked == true && this.checkBoxKhac.Checked == true)
                {
                    this.LoadDGV_GenderAndGender(index, table, "Nữ", "Khác");
                }
            }
        }
    }
}
