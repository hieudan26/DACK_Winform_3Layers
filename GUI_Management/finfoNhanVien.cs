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
    public partial class finfoNhanVien : Form
    {
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        nhanVienBaoVeBUS nhanVienBaoVeBUS = new nhanVienBaoVeBUS();
        nhanVienSuaXeBUS nhanVienSuaXeBUS = new nhanVienSuaXeBUS();
        nhanVienRuaXeBUS nhanVienRuaXeBUS = new nhanVienRuaXeBUS();
        nhanVienHopDongBUS nhanVienHopDongBUS = new nhanVienHopDongBUS();
        phongBanBUS phongBanBUS = new phongBanBUS();
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        private int flag;

        public finfoNhanVien(int flag)
        {
            InitializeComponent();
            this.flag = flag;
        }

        private void finfoNhanVien_Load(object sender, EventArgs e)
        {
            if (this.flag == 1)
            {
                this.btnFind.Visible = false;
                this.btnRemove.Visible = false;
                this.btnExit.Visible = true;
            }    
        }

        private void resetForm()
        {
            this.txtId_CMND.Text = "";
            this.txtTenNV.Text = "";
            //this.rbNo.Checked = false;
            this.rbYes.Checked = false;
            this.cbSex.SelectedIndex = -1;
            this.cbTypeTho.SelectedIndex = -1;
            this.dtpDoB.Value = DateTime.Now;
            this.pbNhanVien.Image = null;
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
                if (this.cbTypeTho.SelectedIndex != -1)
                {
                    string IDEmployee = this.txtId_CMND.Text.Trim();
                    string typeTho = this.cbTypeTho.Text.Trim();
                    if (MessageBox.Show("Are you sure ?!?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (typeTho == "Bảo Vệ")
                        {
                            if (this.nhanVienBaoVeBUS.RemoveBAOVE(IDEmployee))
                            {
                                MessageBox.Show("Xóa thành công Account Bảo Vệ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }    
                            else
                            {
                                MessageBox.Show("Xóa không thành công Account Bảo Vệ", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        }
                        else if (typeTho == "Thợ Sửa")
                        {
                            if (this.nhanVienSuaXeBUS.RemoveNhanVienSuaXe(IDEmployee))
                            {
                                MessageBox.Show("Xóa thành công Account Sửa Xe", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }   
                            else
                            {
                                MessageBox.Show("Xóa không thành công Account Sửa Xe", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        }    
                        else if (typeTho == "Thợ Rửa")
                        {
                            if (this.nhanVienRuaXeBUS.RemoveNhanVienRuaXe(IDEmployee))
                            {
                                MessageBox.Show("Xóa thành công Account Rửa Xe", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }    
                            else
                            {
                                MessageBox.Show("Xóa không thành công Account Rửa Xe", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        }    
                        else
                        {
                            if (this.nhanVienHopDongBUS.RemoveNhanVienHopDong(IDEmployee))
                            {
                                MessageBox.Show("Xóa thành công Account NV Hợp Đồng", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa không thành công Account NV Hợp Đồng", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }    
                        } 
                        
                        ///////////////////////Remove Main////////////////////////
                        
                        if (this.nhanVienBUS.DelEmployee(IDEmployee))
                        {
                            MessageBox.Show("Xóa nhân viên thành công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }    
                        else
                        {
                            MessageBox.Show("Xóa nhân viên không thành công", "Delete", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nhanVienBUS.getEmployee_byID(this.txtId_CMND.Text) != null)
                {
                    string id = this.txtId_CMND.Text.Trim();
                    DataTable table = this.nhanVienBUS.getEmployee_byID(id);
                    this.txtTenNV.Text = table.Rows[0][1].ToString().Trim();
                    this.dtpDoB.Value = DateTime.Parse(table.Rows[0][2].ToString());
                    this.cbSex.Text = table.Rows[0][3].ToString().Trim();
                    this.cbTypeTho.Text = table.Rows[0][4].ToString().Trim();
                    Byte[] pic = new Byte[0];
                    pic = (Byte[])(table.Rows[0][5]);
                    MemoryStream ms = new MemoryStream(pic);
                    this.pbNhanVien.Image = Image.FromStream(ms);
                    this.pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;

                    if (this.kTraLeader(table.Rows[0][4].ToString().Trim(), this.txtId_CMND.Text.Trim()))
                    {
                        this.rbYes.Checked = true;
                    }    
                    else
                    {
                        this.rbNo.Checked = true;
                    }

                    table.Clear();
                    if (this.cbTypeTho.Text.Trim() == "Bảo Vệ")
                    {
                        table = this.nhanVienBaoVeBUS.getInfo_byID(id);
                    }
                    else if (this.cbTypeTho.Text.Trim() == "Thợ Sửa")
                    {
                        table = this.nhanVienSuaXeBUS.getInfo_byID(id);
                    }
                    else if (this.cbTypeTho.Text.Trim() == "Thợ Rửa")
                    {
                        table = this.nhanVienRuaXeBUS.getInfo_byID(id);
                    }
                    else
                    {
                        table = this.nhanVienHopDongBUS.getInfo_byID(id);
                    }

                    if (table != null)
                    {
                        this.txtUsername.Text = table.Rows[0][1].ToString();
                        this.txtPassword.Text = table.Rows[0][2].ToString();
                    }
                }
                else
                {
                    MessageBox.Show("Không tìm thấy nhân viên", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private string getIdDept_ByTypeTho(string typeTho)
        {
            string dept = "";
            if (typeTho == "Bảo Vệ")
            {
                dept = "Phòng Bảo Vệ";
            }
            else if (typeTho == "Thợ Sửa")
            {
                dept = "Phòng Sửa Xe";
            }
            else
            {
                dept = "Phòng Rửa Xe";
            }

            DataTable table = this.phongBanBUS.getPhongBan_byName(dept);
            return table.Rows[0]["id"].ToString();
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

        private void xuLyEdit()
        {
            string id = this.txtId_CMND.Text.Trim();
            string name = this.txtTenNV.Text.Trim();
            DateTime dt = this.dtpDoB.Value;
            string gender = this.cbSex.Text.Trim();
            string typeTho = this.cbTypeTho.Text.Trim();
            MemoryStream pic = new MemoryStream();
            this.pbNhanVien.Image.Save(pic, this.pbNhanVien.Image.RawFormat);

            //update bảng 1
            if (this.nhanVienBUS.UpdateInfoEmployee(name, dt, gender, typeTho, pic, id))
            {
                MessageBox.Show("Edit nhân viên thành công", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } 
            else
            {
                MessageBox.Show("Edit nhân viên không thành công", "Edit", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            //update bảng 2
            this.EditAccountPassword(id, typeTho);
        }

        private void EditAccountPassword(string id, string typeTho)
        {
            string Username = this.txtUsername.Text.Trim();
            string Password = this.txtPassword.Text.Trim();
            if (this.rbNo.Checked == true)
            {
                if (typeTho == "Bảo Vệ")
                {
                    if (this.nhanVienBaoVeBUS.UpdateAccountBaoVe(id, Username, Password, 0))
                    {
                        MessageBox.Show("Edit tài khoản Bảo Vệ thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }                  
                    else
                    {
                        MessageBox.Show("Edit tài khoản Bảo Vệ không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                else if (typeTho == "Thợ Sửa")
                {
                    if (this.nhanVienSuaXeBUS.UpdateAccountNVSuaXe(id, Username, Password, 0))
                    {
                        MessageBox.Show("Edit tài khoản Thợ Sửa thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Edit tài khoản Thợ Sửa không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
                else if (typeTho == "Thợ Rửa")
                {
                    if (this.nhanVienRuaXeBUS.UpdateAccountNVRuaXe(id, Username, Password, 0))
                    {
                        MessageBox.Show("Edit tài khoản Thợ Rửa thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }   
                    else
                    {
                        MessageBox.Show("Edit tài khoản Thợ Rửa không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
                else
                {
                    if (this.nhanVienHopDongBUS.UpdateAccountNVHopDong(id, Username, Password, 0))
                    {
                        MessageBox.Show("Edit tài khoản NV Hợp Đồng thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }   
                    else
                    {
                        MessageBox.Show("Edit tài khoản NV Hợp Đồng không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
            }   
            else
            {
                if (typeTho == "Bảo Vệ")
                {
                    if (this.nhanVienBaoVeBUS.leaderExist())
                    {
                        if (this.nhanVienBaoVeBUS.UpdateAccountBaoVe(id, Username, Password, 0))
                        {
                            MessageBox.Show("Edit tài khoản Bảo Vệ thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Bảo Vệ không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                    else
                    {
                        if (this.nhanVienBaoVeBUS.UpdateAccountBaoVe(id, Username, Password, 1))
                        {
                            MessageBox.Show("Edit tài khoản Bảo Vệ_Leader thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Bảo Vệ_Leader không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                }    
                else if (typeTho == "Thợ Sửa")
                {
                    if (this.nhanVienSuaXeBUS.leaderExist())
                    {
                        if (this.nhanVienSuaXeBUS.UpdateAccountNVSuaXe(id, Username, Password, 0))
                        {
                            MessageBox.Show("Edit tài khoản Thợ Sửa thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Thợ Sửa không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }   
                    else
                    {
                        if (this.nhanVienSuaXeBUS.UpdateAccountNVSuaXe(id, Username, Password, 1))
                        {
                            MessageBox.Show("Edit tài khoản Thợ Sửa_Leader thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Thợ Sửa_Leader không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }    
                else if (typeTho == "Thợ Rửa")
                {
                    if (this.nhanVienRuaXeBUS.leaderExist())
                    {
                        if (this.nhanVienRuaXeBUS.UpdateAccountNVRuaXe(id, Username, Password, 0))
                        {
                            MessageBox.Show("Edit tài khoản Thợ Rửa thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Thợ Rửa không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        if (this.nhanVienRuaXeBUS.UpdateAccountNVRuaXe(id, Username, Password, 1))
                        {
                            MessageBox.Show("Edit tài khoản Thợ Rửa_Leader thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản Thợ Rửa_Leader không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }  
                else
                {
                    if (this.nhanVienHopDongBUS.leaderExist())
                    {
                        if (this.nhanVienHopDongBUS.UpdateAccountNVHopDong(id, Username, Password, 0))
                        {
                            MessageBox.Show("Edit tài khoản NV Hợp Đồng thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản NV Hợp Đồng không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                    else
                    {
                        if (this.nhanVienHopDongBUS.UpdateAccountNVHopDong(id, Username, Password, 1))
                        {
                            MessageBox.Show("Edit tài khoản NV Hợp Đồng_Leader thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Edit tài khoản NV Hợp Đồng_Leader không thành công", "Edit Tài Khoản", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }    
                }    
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.verify())
                {
                    if (this.checkDoB(this.dtpDoB.Value))
                    {
                        this.xuLyEdit();
                    }
                    else
                    {
                        MessageBox.Show("U must be > 15 years old or < 65 years old. Ok ?", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
