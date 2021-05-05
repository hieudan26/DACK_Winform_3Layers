using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;
using System.IO;

namespace GUI_Management
{
    public partial class faddNhanVien : Form
    {
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        phongBanBUS phongBanBUS = new phongBanBUS();
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();

        public faddNhanVien()
        {
            InitializeComponent();
        }

        private void btnUpImg_Click(object sender, EventArgs e)
        {
            if (this.txtId_CMND.Text != "")
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    this.pbNhanVien.Image = Image.FromFile(opf.FileName);
                }
            }
            else
            {
                MessageBox.Show("Can't add image, pls fill cmnd txtbox", "Upload Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private string Dept_name()
        {
            string dept_name = "";
            if(this.cbTypeTho.SelectedIndex != -1)
            {
                string typeTho = this.cbTypeTho.Text;
                if (typeTho == "Bảo Vệ")
                {
                    dept_name = "Phòng Bảo Vệ";
                }    
                else if (typeTho == "Thợ Sửa")
                {
                    dept_name = "Phòng Sửa Xe";
                }   
                else if (typeTho == "Nhân Viên")
                {
                    dept_name = "Phòng Nhân Viên";
                }    
                else
                {
                    dept_name = "Phòng Rửa Xe";
                }
                return dept_name;
            }    
            else
            {
                return dept_name;
            }    
        }

        private string Dept_Id()
        {
            string dept_id = "";
            string dept_name = this.Dept_name();
            if (dept_name != "")
            {
                DataTable table = this.phongBanBUS.getPhongBan_byName(dept_name);
                dept_id = table.Rows[0]["id"].ToString();
                return dept_id;
            }
            else
            {
                return dept_id;
            }
        }    

        //đk người lao động > 15 < 65
        private bool checkDoB(DateTime dob)
        {
            int year_dob = dob.Year;
            int year_cur = DateTime.Now.Year;
            if (year_cur - year_dob < 15 || year_cur - year_dob > 65)
            {
                return false;
            }
            else
            {
                return true;
            }
        }   

        private bool checkLeader()
        {
            if (this.rbYes.Checked == true || this.rbNo.Checked == true)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }

        private bool verify()
        {
            if (this.txtId_CMND.Text == "" || this.txtTenNV.Text == "" || this.cbSex.SelectedIndex == -1 || this.cbTypeTho.SelectedIndex == -1
                || this.pbNhanVien.Image == null || !this.checkLeader())
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }

        private void divShift(string typeTho)
        {
            if (typeTho == "Bảo Vệ")
            {
                if (this.shift_BaoVeBUS.getALLShift_BaoVe() == null)
                {
                    this.shift_BaoVeBUS.chiaCaBaoVe();
                }    
                else
                {
                    this.shift_BaoVeBUS.ResetShift_BaoVe();
                    this.shift_BaoVeBUS.chiaCaBaoVe();
                }    
            }    
            else if (typeTho == "Thợ Sửa")
            {
                if (this.shift_ThoSuaXeBUS.getALLShift_ThoSuaXe() == null)
                {
                    this.shift_ThoSuaXeBUS.chiaCaThoSuaXe();
                }
                else
                {
                    this.shift_ThoSuaXeBUS.ResetShift_ThoSuaXe();
                    this.shift_ThoSuaXeBUS.chiaCaThoSuaXe();
                }    
            }    
            else if (typeTho == "Thợ Rửa")
            {
                if (this.shift_ThoRuaXeBUS.getALLShift_ThoRuaXe() == null)
                {
                    this.shift_ThoRuaXeBUS.chiaCaThoRuaXe();
                }    
                else
                {
                    this.shift_ThoRuaXeBUS.ResetShift_ThoRuaXe();
                    this.shift_ThoRuaXeBUS.chiaCaThoRuaXe();
                }    
            }    
            else
            {
                if (this.shift_NhanVienBUS.getALLShift_NhanVien() == null)
                {
                    this.shift_NhanVienBUS.chiaCaNhanVien();
                }    
                else
                {
                    this.shift_NhanVienBUS.ResetShift_NhanVien();
                    this.shift_NhanVienBUS.chiaCaNhanVien();
                }    
            }    
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (this.verify())
            {
                string name = this.txtTenNV.Text;
                string id_cmnd = this.txtId_CMND.Text;
                string dept_id = this.Dept_Id(); // ""
                DateTime dob = this.dtpDoB.Value;
                if (this.checkDoB(dob))
                {
                    string sex = this.cbSex.Text;
                    string typeTho = this.cbTypeTho.Text;
                    MessageBox.Show(typeTho + "/");
                    MemoryStream pic = new MemoryStream();
                    this.pbNhanVien.Image.Save(pic, this.pbNhanVien.Image.RawFormat);
                    nhanVienDTO nhanVienDTO = new nhanVienDTO(id_cmnd, name, dept_id, dob, sex, pic, typeTho);
                    if (this.rbYes.Checked == true)
                    {
                        if (this.phongBanBUS.ktraTruongPhong(dept_id)) // ==true chưa có trưởng phòng
                        {
                            if (this.nhanVienBUS.insertEmployee(nhanVienDTO) && this.phongBanBUS.update_leaderId_Department(dept_id, id_cmnd))
                            {
                                MessageBox.Show("Thêm nhân viên_trưởng phòng thành công", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                this.divShift(typeTho);
                            }    
                            else
                            {
                                MessageBox.Show("Thêm nhân viên_trưởng phòng không thành công", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        }    
                        else
                        {
                            MessageBox.Show("Phòng Ban đã có trưởng phòng", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }    
                    }    
                    else
                    {
                        if (this.nhanVienBUS.insertEmployee(nhanVienDTO))
                        {
                            MessageBox.Show("Thêm nhân viên thành công", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.divShift(typeTho);
                        }
                        else
                        {
                            MessageBox.Show("Thêm nhân viên không thành công", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                }
                else
                {
                    MessageBox.Show("U must be > 15 years old or < 65 years old. Ok ?", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }    
            else
            {
                MessageBox.Show("Empty Fields", "Add Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }
    }
}
