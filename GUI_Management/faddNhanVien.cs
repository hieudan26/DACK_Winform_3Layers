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
        nhanVienBaoVeBUS nhanVienBaoVeBUS = new nhanVienBaoVeBUS();
        nhanVienSuaXeBUS nhanVienSuaXeBUS = new nhanVienSuaXeBUS();
        nhanVienRuaXeBUS nhanVienRuaXeBUS = new nhanVienRuaXeBUS();
        nhanVienHopDongBUS nhanVienHopDongBUS = new nhanVienHopDongBUS();
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
                || this.pbNhanVien.Image == null || !this.checkLeader() || this.txtUsername.Text == "" || this.txtPassword.Text == "")
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

        private void insertTho_NhanVien(int flag, string id_cmnd, string username, string password, int status)
        {
            try
            {
                if (status == 0)
                {
                    if (flag == 0) //bảo vệ
                    {
                        nhanVienBaoVeDTO nhanVienBaoVeDTO = new nhanVienBaoVeDTO(id_cmnd, username, password, status);
                        if (this.nhanVienBaoVeBUS.insertnhanVienBaoVe(nhanVienBaoVeDTO))
                        {
                            MessageBox.Show("Thêm tài khoản Bảo Vệ thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản Bảo Vệ không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (flag == 1) //nhân viên sửa xe
                    {
                        nhanVienSuaXeDTO nhanVienSuaXeDTO = new nhanVienSuaXeDTO(id_cmnd, username, password, status);
                        if (this.nhanVienSuaXeBUS.insertnhanVienSuaXe(nhanVienSuaXeDTO))
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else if (flag == 2) //nhân viên rửa xe
                    {
                        nhanVienRuaXeDTO nhanVienRuaXeDTO = new nhanVienRuaXeDTO(id_cmnd, username, password, status);
                        if (this.nhanVienRuaXeBUS.insertnhanVienRuaXe(nhanVienRuaXeDTO))
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else //nhân viên phòng hợp đồng
                    {
                        nhanVienHopDongDTO nhanVienHopDongDTO = new nhanVienHopDongDTO(id_cmnd, username, password, status);
                        if (this.nhanVienHopDongBUS.insertnhanVienHopDong(nhanVienHopDongDTO))
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }    
                else
                {
                    if (flag == 0) //bảo vệ
                    {
                        if (this.nhanVienBaoVeBUS.leaderExist()) // tồn tại
                        {
                            MessageBox.Show("Ban Bảo Vệ đã có Trưởng Phòng", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nhanVienBaoVeDTO nhanVienBaoVeDTO = new nhanVienBaoVeDTO(id_cmnd, username, password, 0);
                            if (this.nhanVienBaoVeBUS.insertnhanVienBaoVe(nhanVienBaoVeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Bảo Vệ thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Bảo Vệ không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                        else
                        {
                            nhanVienBaoVeDTO nhanVienBaoVeDTO = new nhanVienBaoVeDTO(id_cmnd, username, password, status);
                            if (this.nhanVienBaoVeBUS.insertnhanVienBaoVe(nhanVienBaoVeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Bảo Vệ_Trưởng Phòng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Bảo Vệ_Trưởng Phòng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                    }
                    else if (flag == 1)
                    {
                        if (this.nhanVienSuaXeBUS.leaderExist())
                        {
                            MessageBox.Show("Ban Sửa Xe đã có Trưởng Phòng", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nhanVienSuaXeDTO nhanVienSuaXeDTO = new nhanVienSuaXeDTO(id_cmnd, username, password, 0);
                            if (this.nhanVienSuaXeBUS.insertnhanVienSuaXe(nhanVienSuaXeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            nhanVienSuaXeDTO nhanVienSuaXeDTO = new nhanVienSuaXeDTO(id_cmnd, username, password, status);
                            if (this.nhanVienSuaXeBUS.insertnhanVienSuaXe(nhanVienSuaXeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe_Trưởng Phòng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Sửa Xe_Trưởng Phòng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }    
                    else if (flag == 2) //rửa
                    {
                        if (this.nhanVienRuaXeBUS.leaderExist())
                        {
                            MessageBox.Show("Ban Rửa Xe đã có Trưởng Phòng", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nhanVienRuaXeDTO nhanVienRuaXeDTO = new nhanVienRuaXeDTO(id_cmnd, username, password, 0);
                            if (this.nhanVienRuaXeBUS.insertnhanVienRuaXe(nhanVienRuaXeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                        else
                        {
                            nhanVienRuaXeDTO nhanVienRuaXeDTO = new nhanVienRuaXeDTO(id_cmnd, username, password, status);
                            if (this.nhanVienRuaXeBUS.insertnhanVienRuaXe(nhanVienRuaXeDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe_Trưởng Phòng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Rửa Xe_Trưởng Phòng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                    }
                    else //hợp đồng 
                    {
                        if (this.nhanVienHopDongBUS.leaderExist())
                        {
                            MessageBox.Show("Ban Nhân Viên Hợp Đồng đã có Trưởng Phòng", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            nhanVienHopDongDTO nhanVienHopDongDTO = new nhanVienHopDongDTO(id_cmnd, username, password, 0);
                            if (this.nhanVienHopDongBUS.insertnhanVienHopDong(nhanVienHopDongDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            nhanVienHopDongDTO nhanVienHopDongDTO = new nhanVienHopDongDTO(id_cmnd, username, password, status);
                            if (this.nhanVienHopDongBUS.insertnhanVienHopDong(nhanVienHopDongDTO))
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng_Trưởng Phòng thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Thêm tài khoản Nhân viên Hợp Đồng_Trưởng Phòng không thành công", "Tài khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }    
                    }    
                }    
            }    
            catch (Exception e)
            {
                MessageBox.Show("Error: ", e.Message);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.verify())
                {
                    string name = this.txtTenNV.Text.Trim();
                    string id_cmnd = this.txtId_CMND.Text.Trim();
                    DateTime dob = this.dtpDoB.Value;
                    if (this.checkDoB(dob))
                    {
                        string sex = this.cbSex.Text.Trim();
                        string typeTho = this.cbTypeTho.Text.Trim();
                        //MessageBox.Show(typeTho + "/");
                        string username = this.txtUsername.Text.Trim();
                        string password = this.txtPassword.Text.Trim();
                        MemoryStream pic = new MemoryStream();
                        this.pbNhanVien.Image.Save(pic, this.pbNhanVien.Image.RawFormat);
                        nhanVienDTO nhanVienDTO = new nhanVienDTO(id_cmnd, name, dob, sex, pic, typeTho);
                        if (this.nhanVienBUS.insertEmployee(nhanVienDTO))
                        {
                            MessageBox.Show("Thêm nhân viên thành công", "Thêm nhân viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.rbNo.Checked == true)
                            {
                                if (this.cbTypeTho.SelectedIndex == 0) //bảo vệ
                                {
                                    this.insertTho_NhanVien(0, id_cmnd, username, password, 0);
                                    this.divShift("Bảo Vệ");
                                }
                                else if (this.cbTypeTho.SelectedIndex == 1) //thợ sửa xe
                                {
                                    this.insertTho_NhanVien(1, id_cmnd, username, password, 0);
                                    this.divShift("Thợ Sửa");
                                }    
                                else if (this.cbTypeTho.SelectedIndex == 2) //thợ rửa xe
                                {
                                    this.insertTho_NhanVien(2, id_cmnd, username, password, 0);
                                    this.divShift("Thợ Rửa");
                                } 
                                else
                                {
                                    this.insertTho_NhanVien(3, id_cmnd, username, password, 0);
                                    this.divShift("Nhân Viên");
                                }    
                            }
                            else if (this.rbYes.Checked == true)
                            {
                                if (this.cbTypeTho.SelectedIndex == 0) //bảo vệ
                                {
                                    this.insertTho_NhanVien(0, id_cmnd, username, password, 1);
                                    this.divShift("Bảo Vệ");
                                }
                                else if (this.cbTypeTho.SelectedIndex == 1) //thợ sửa xe
                                {
                                    this.insertTho_NhanVien(1, id_cmnd, username, password, 1);
                                    this.divShift("Thợ Sửa");
                                }
                                else if (this.cbTypeTho.SelectedIndex == 2) //thợ rửa xe
                                {
                                    this.insertTho_NhanVien(2, id_cmnd, username, password, 1);
                                    this.divShift("Thợ Rửa");
                                }
                                else
                                {
                                    this.insertTho_NhanVien(3, id_cmnd, username, password, 1);
                                    this.divShift("Nhân Viên");
                                }
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
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
