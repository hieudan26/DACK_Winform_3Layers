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
    public partial class fWelcome : Form
    {
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        nhanVienBaoVeBUS nhanVienBaoVeBUS = new nhanVienBaoVeBUS();
        nhanVienSuaXeBUS nhanVienSuaXeBUS = new nhanVienSuaXeBUS();
        nhanVienRuaXeBUS nhanVienRuaXeBUS = new nhanVienRuaXeBUS();
        nhanVienHopDongBUS nhanVienHopDongBUS = new nhanVienHopDongBUS();
        private string username = ""; 
        private string password = "";

        public fWelcome()
        {
            InitializeComponent();
        }

        private void fWelcome_Load(object sender, EventArgs e)
        {
            string idNhanVien = Global.GlobalEmployeeId;
            try
            {
                DataTable table = this.nhanVienBUS.getEmployee_byID(idNhanVien);

                if (table != null)
                {
                    this.LoadForm(table);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadForm(DataTable table)
        {
            string hoTen = table.Rows[0][1].ToString();
            this.lbWel.Text = "Họ và Tên: " + hoTen;
            byte[] pic = (byte[])table.Rows[0][5];
            MemoryStream picture = new MemoryStream(pic);
            this.picBox.Image = Image.FromStream(picture);
            this.lbTypeTho.Text = table.Rows[0][4].ToString().Trim();
            this.LoadTextButton(this.lbTypeTho.Text.Trim());
        }

        private void LoadTextButton(string typeTho)
        {
            if (typeTho == "Bảo Vệ")
            {
                this.btnWork.Text = "Trông coi xe";
            }
            else if (typeTho == "Thợ Sửa")
            {
                this.btnWork.Text = "Sửa Xe";
            }
            else if (typeTho == "Thợ Rửa")
            {
                this.btnWork.Text = "Rửa xe";
            }    
            else
            {
                this.btnWork.Text = "Quản lý hợp đồng";
            }    
        }

        private int gender(string gender)
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

        private int loaiTho(string typeTho)
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

        private int kTraLeader(string typeTho, string idemployee)
        {
            DataTable table = new DataTable();
            if (typeTho == "Bảo Vệ")
            {
                table = this.nhanVienBaoVeBUS.getInfo_byID(idemployee);
            }    
            else if (typeTho == "Thợ Sửa")
            {
                table = this.nhanVienSuaXeBUS.getInfo_byID(idemployee);
            }
            else if (typeTho == "Thợ Rửa")
            {
                table = this.nhanVienRuaXeBUS.getInfo_byID(idemployee);
            }
            else
            {
                table = this.nhanVienHopDongBUS.getInfo_byID(idemployee);
            }

            this.username = table.Rows[0][1].ToString().Trim();
            this.password = table.Rows[0][2].ToString().Trim();

            ///////////////////
            if (bool.Parse(table.Rows[0][3].ToString()) == true)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            finfoNhanVien form = new finfoNhanVien(1);
            try
            {
                DataTable table = this.nhanVienBUS.getEmployee_byID(Global.GlobalEmployeeId);
                form.txtId_CMND.Text = Global.GlobalEmployeeId.Trim();
                form.txtTenNV.Text = table.Rows[0][1].ToString().Trim();
                form.dtpDoB.Value = DateTime.Parse(table.Rows[0][2].ToString().Trim());
                form.cbSex.SelectedIndex = this.gender(table.Rows[0][3].ToString().Trim());
                form.cbTypeTho.SelectedIndex = this.loaiTho(table.Rows[0][4].ToString().Trim());
                if (this.kTraLeader(table.Rows[0][4].ToString().Trim(), Global.GlobalEmployeeId.Trim()) == 1)
                {
                    form.rbYes.Checked = true;
                }    
                else
                {
                    form.rbNo.Checked = true;
                }
                byte[] pic = (byte[])table.Rows[0][5];
                MemoryStream picture = new MemoryStream(pic);
                form.pbNhanVien.Image = Image.FromStream(picture);
                ////////////////////////////////
                form.txtUsername.Text = this.username;
                form.txtPassword.Text = this.password;
                form.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void llbRefresh_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.fWelcome_Load(sender, e);
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnWork_Click(object sender, EventArgs e)
        {
            string typeTho = this.lbTypeTho.Text.Trim();
            if (typeTho == "Bảo Vệ" || typeTho == "Thợ Sửa" || typeTho == "Thợ Rửa")
            {
                fQuanLyXe form = new fQuanLyXe();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }  
            else
            {
                fMain form = new fMain();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }    
                //{
                //    //form.btnDoanhThu.Enabled = false;
                //    form.btnFixService.Enabled = false;
                //    form.btnWashService.Enabled = false;
                //}
                //else if (this.lbTypeTho.Text.Trim() == "Thợ Sửa")
                //{
                //    form.btnParkService.Enabled = false;
                //    //form.btnDoanhThu.Enabled = false;
                //    form.btnWashService.Enabled = false;
                //}
                //else /*if (this.lbTypeTho.Text.Trim() == "Thợ Rửa")*/
                //{
                //    form.btnParkService.Enabled = false;
                //    //form.btnDoanhThu.Enabled = false;
                //    form.btnFixService.Enabled = false;
                //}
        }
    }
}
