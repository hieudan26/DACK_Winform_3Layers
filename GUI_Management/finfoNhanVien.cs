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
        phongBanBUS phongBanBUS = new phongBanBUS();
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();

        public finfoNhanVien()
        {
            InitializeComponent();
        }

        private void finfoNhanVien_Load(object sender, EventArgs e)
        {

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
                if (MessageBox.Show("Are you sure ?", "Info Nhân Viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    this.Reset(this.cbTypeTho.Text);
                    if (this.rbYes.Checked == true)
                    {
                        if (this.phongBanBUS.reset_leaderId_Department(this.txtId_CMND.Text))
                        {
                            MessageBox.Show("Xóa trưởng phòng thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            //this.divShift(this.cbTypeTho.Text);
                        }
                        else
                        {
                            MessageBox.Show("Xóa trưởng phòng không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    if (this.nhanVienBUS.DelEmployee(this.txtId_CMND.Text))
                    {
                        MessageBox.Show("Xóa nhân viên thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.resetForm();
                        this.divShift(this.cbTypeTho.Text);
                    }
                    else
                    {
                        MessageBox.Show("Xóa nhân viên không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.nhanVienBUS.getEmployee_byID(this.txtId_CMND.Text) != null)
                {
                    DataTable table = this.nhanVienBUS.getEmployee_byID(this.txtId_CMND.Text);
                    this.txtTenNV.Text = table.Rows[0]["name"].ToString();
                    this.dtpDoB.Value = DateTime.Parse(table.Rows[0][3].ToString());
                    this.cbSex.Text = table.Rows[0]["gender"].ToString();
                    this.cbTypeTho.Text = table.Rows[0]["typeTho"].ToString();
                    Byte[] pic = new Byte[0];
                    pic = (Byte[])(table.Rows[0]["img"]);
                    MemoryStream ms = new MemoryStream(pic);
                    this.pbNhanVien.Image = Image.FromStream(ms);
                    this.pbNhanVien.SizeMode = PictureBoxSizeMode.StretchImage;
                    if (this.phongBanBUS.ktraLeader(this.txtId_CMND.Text))
                    {
                        this.rbYes.Checked = true;
                    }    
                    else
                    {
                        this.rbNo.Checked = true;
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
            string dept_id = this.getIdDept_ByTypeTho(this.cbTypeTho.Text);
            MemoryStream pic = new MemoryStream();
            this.pbNhanVien.Image.Save(pic, this.pbNhanVien.Image.RawFormat);
            //ktra có chọn leader ko
            if (this.rbYes.Checked == true)
            {
                if (this.cbTypeTho.SelectedIndex != -1)
                {
                    if (this.phongBanBUS.ktraLeader(this.txtId_CMND.Text)) //là trưởng phòng sẵn rồi
                    {
                        //edit
                        if (this.nhanVienBUS.UpdateInfoEmployee(this.txtTenNV.Text, this.dtpDoB.Value, this.cbSex.Text, this.cbTypeTho.Text, pic, this.txtId_CMND.Text))
                        {
                            MessageBox.Show("Sửa nhân viên_trưởng phòng thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Sửa nhân viên_trưởng phòng không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else //ko phải là trưởng phòng nhưng edit thành trưởng phòng
                    {
                        //ktra phòng đã có lead chưa
                        if (!this.phongBanBUS.ktraTruongPhong(dept_id)) //phòng đã có trưởng phòng
                        {
                            MessageBox.Show("Phòng đã có trưởng phòng", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                        else //chưa có trưởng phòng
                        {
                            if (this.nhanVienBUS.UpdateInfoEmployee(this.txtTenNV.Text, this.dtpDoB.Value, this.cbSex.Text, this.cbTypeTho.Text, pic, this.txtId_CMND.Text)
                                && this.phongBanBUS.update_leaderId_Department(dept_id, this.txtId_CMND.Text))
                            {
                                MessageBox.Show("Sửa nhân viên_trưởng phòng thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Sửa nhân viên_trưởng phòng không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            else // ko chọn lead
            {
                if (this.phongBanBUS.ktraLeader(this.txtId_CMND.Text))   //ktra có phải trưởng phòng hay không => nếu là trưởng phòng
                {
                    if (this.phongBanBUS.reset_leaderId_Department(dept_id) &&
                        this.nhanVienBUS.UpdateInfoEmployee(this.txtTenNV.Text, this.dtpDoB.Value, this.cbSex.Text, this.cbTypeTho.Text, pic, this.txtId_CMND.Text))
                    {
                        MessageBox.Show("Sửa nhân viên thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else //ko phải trưởng phòng, ko chọn lead 
                {
                    if (this.nhanVienBUS.UpdateInfoEmployee(this.txtTenNV.Text, this.dtpDoB.Value, this.cbSex.Text, this.cbTypeTho.Text, pic, this.txtId_CMND.Text))
                    {
                        MessageBox.Show("Sửa nhân viên thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Sửa nhân viên không thành công", "Info Nhân Viên", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
