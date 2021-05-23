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
using Microsoft.Office.Interop.Word;
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
        fProgressBar formLoad = new fProgressBar();

        public flistNhanVien(fQuanLyNhanVien fQuanLy)
        {
            InitializeComponent();
            this.fQuanLyNhanVien = fQuanLy;
        }

        private void loadPB()
        {
            this.timer1.Start();
            formLoad.ShowDialog();
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
            System.Data.DataTable table = new System.Data.DataTable();
            if (this.cbFilter.SelectedIndex != -1)
            {
                this.loadPB();
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

        private void LoadDGV_Gender_Giua2Ngay(int index, System.Data.DataTable table, string gender)
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

        private void LoadDGV_GenderAndGender_Giua2Ngay(int index, System.Data.DataTable table, string gender1, string gender2)
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

        private void LoadDGV_ordinary_Giua2Ngay(int index, System.Data.DataTable table)
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

        private void LoadDGV_ordinary(int index, System.Data.DataTable table)
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

        private void LoadDGV_GenderAndGender(int index, System.Data.DataTable table, string gender1, string gender2)
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

        private void LoadDGV_Gender(int index, System.Data.DataTable table, string gender)
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
                this.loadPB();
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
                this.shift_ThoSuaXeBUS.ResetShift_ThoSuaXe_New();
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
                        this.loadPB();
                        System.Data.DataTable table = this.nhanVienBUS.getAllEmployees();
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
            finfoNhanVien form = new finfoNhanVien(0);
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

            System.Data.DataTable table = new System.Data.DataTable();
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
                System.Data.DataTable table = this.nhanVienBaoVeBUS.getInfoLeader();
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
                System.Data.DataTable table = this.nhanVienSuaXeBUS.getInfoLeader();
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
                System.Data.DataTable table = this.nhanVienRuaXeBUS.getInfoLeader();
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
                System.Data.DataTable table = this.nhanVienHopDongBUS.getInfoLeader();
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
                System.Data.DataTable table = new System.Data.DataTable();
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
                System.Data.DataTable table = new System.Data.DataTable();
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
                        if (this.checkBoxKhac.Checked == false && this.checkBoxNam.Checked == false)
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
                System.Data.DataTable table = new System.Data.DataTable();
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
                System.Data.DataTable table = new System.Data.DataTable();
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
                System.Data.DataTable table = new System.Data.DataTable();
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

        private void timer1_Tick(object sender, EventArgs e)
        {
            ////fProgressBar form = new fProgressBar();
            this.formLoad.gunaCircleProgressBar1.Increment(25);

            if (formLoad.gunaCircleProgressBar1.Value >= formLoad.gunaCircleProgressBar1.Maximum)
            {
                timer1.Stop();
                formLoad.Close();
                //this.formQuanLyXeGui.btnBaiXe.BorderColor = Color.White;
                //this.formQuanLyXeGui.btnBaiXe.ForeColor = Color.Black;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {

        }

        private void A_Click(object sender, EventArgs e)
        {
            if(this.cbFilter.SelectedItem != null)
            {
                string nameType = this.cbFilter.SelectedItem.ToString().Trim();
                if (nameType == "Tất Cả")
                    nameType = "";

                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "DOCX files(*.docx)|*.docx";
                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    Export_Data_To_Word(this.dgv, savefile.FileName, nameType);
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("You have choose one in combobox");
            }    
            
        }
        public void CreateDocument(string docFilePath, Image image)
        {
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Nếu tạo một Document
            _Document oDoc = oWord.Documents.Add();
            //Nếu mở một Document
            //Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Open(docFilePath, ReadOnly: false, Visible: true);

            //Để xem điều gì đang xảy ra trong khi điền tập tài liệu từ Visible = true
            oWord.Visible = true;

            //Chèn ảnh từ mảng byte vào MS Word, sử dụng Clipboard để dán Image vào tài liệu
            Object oMissing = System.Reflection.Missing.Value;
            Clipboard.SetDataObject(image);
            var oPara = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara.Range.Paste();
            oPara.Range.InsertParagraphAfter();

            //Nếu tạo document
            oDoc.SaveAs(docFilePath);
            //Nếu mở một document
            //oDoc.Save();
            oDoc.Close();
            oWord.Quit();
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }
        public void Export_Data_To_Word(DataGridView DGV, string filename, string nameType)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                winword.ShowAnimation = false;
                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.Content.SetRange(0, 0);
                document.Content.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;


                Microsoft.Office.Interop.Word.Paragraph paraHeading = document.Content.Paragraphs.Add(ref missing);
                paraHeading.Range.Text = "Công Ty TNHH MTV SPKT";
                paraHeading.Range.Font.Size = 14;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();

                paraHeading.Range.Text = "Phòng nhân sự";
                paraHeading.Range.Font.Size = 16;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                System.Data.DataTable table = DGV.DataSource as System.Data.DataTable;
                this.ExporterObjects_Paragraph(ref document, table, "Danh sách nhân viên " + nameType);



                // Word.WdParagraphAlignment.wdAlignParagraphRight;
                //Save the document
                document.SaveAs2(filename);

                ((Microsoft.Office.Interop.Word._Document)document).Close(ref missing, ref missing, ref missing);
                ((Microsoft.Office.Interop.Word._Application)winword).Quit(ref missing, ref missing, ref missing);


                MessageBox.Show("Document created successfully !");
                System.Diagnostics.Process.Start(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ExporterObjects_Paragraph(ref Document document, System.Data.DataTable datatable, string namePara)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 13;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.Text = "\n" + namePara;
                para.Range.InsertParagraphAfter();


                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 10;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                if (datatable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.AllowAutoFit = true;
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "ID Nhân Viên";
                    firstTable.Cell(1, 2).Range.Text = "Tên Nhân Viên";
                    firstTable.Cell(1, 3).Range.Text = "Ngày Sinh";
                    firstTable.Cell(1, 4).Range.Text = "Giới Tính";
                    firstTable.Cell(1, 5).Range.Text = "Loại Thợ";
                    firstTable.Cell(1, 6).Range.Text = "Ảnh Nhân Viên";

                    Object beforeRow = Type.Missing;

                    para.Range.Font.Bold = 0;
                    para.Range.Font.Size = 10;
                    para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        firstTable.Rows.Add(ref beforeRow);
                        firstTable.Cell(i + 2, 1).Range.Text = datatable.Rows[i][0].ToString();
                        firstTable.Cell(i + 2, 2).Range.Text = datatable.Rows[i][1].ToString();
                        firstTable.Cell(i + 2, 3).Range.Text = DateTime.Parse(datatable.Rows[i][2].ToString()).ToString("dd/MM/yyyy");
                        firstTable.Cell(i + 2, 4).Range.Text = datatable.Rows[i][3].ToString();
                        firstTable.Cell(i + 2, 5).Range.Text = datatable.Rows[i][4].ToString();
                    }
                    byte[] imgbyte;
                    MemoryStream ms;
                    Image finalPic;
                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        imgbyte = (byte[])datatable.Rows[i][5];
                        ms = new MemoryStream(imgbyte);
                        finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(50, 50)));
                        Clipboard.SetDataObject(finalPic);
                        firstTable.Cell(i + 2, 6).Range.Paste();
                        firstTable.Cell(i + 2, 6).Range.InsertParagraph();
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "ID Nhân Viên";
                    firstTable.Cell(1, 2).Range.Text = "Tên Nhân Viên";
                    firstTable.Cell(1, 3).Range.Text = "Ngày Sinh";
                    firstTable.Cell(1, 4).Range.Text = "Giới Tính";
                    firstTable.Cell(1, 5).Range.Text = "Loại Thợ";
                    firstTable.Cell(1, 6).Range.Text = "Ảnh Nhân Viên";
                    Object beforeRow = Type.Missing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Err " + ex.Message);
            }
        }
    }
}
