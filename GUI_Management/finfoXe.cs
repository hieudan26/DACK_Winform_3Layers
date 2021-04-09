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
using DTO_Management;
using BUS_Management;

namespace GUI_Management
{
    public partial class finfoXe : Form
    {
        vehicleDTO vehicleDTO = new vehicleDTO();
        vehicleBUS vehicleBUS = new vehicleBUS();
        fQuanLyXeGui formQuanLyXeGui;
        string type;
        public finfoXe(fQuanLyXeGui formQuanLyXeGui, string type)
        {
            InitializeComponent();
            //this.vehicleDTO = vel;
            //this.vehicleDTO.ID = id;
            this.formQuanLyXeGui = formQuanLyXeGui;
            this.type = type;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "BaiXe": { this.BacktoBaiXe(); break; }
                case "DoanhThu": { this.BacktoDoanhThu(); break; }
            }
        }

        public void BacktoBaiXe()
        {
            fBaiXe f = new fBaiXe(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }

        public void BacktoDoanhThu()
        {
            fdoanhThu f = new fdoanhThu(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }

        private bool verify()
        {
            if (this.txtID.Text == "" || this.txtLoaiGui.Text == "" || this.txtLoaiXe.Text == ""
                || this.txtDTGui.Text == "" || this.pBHinh1.Image == null || this.pBHinh2.Image == null)
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(this.txtID.Text);
            int loaiXe;
            if (this.txtLoaiXe.Text == "Xe Đạp")
            {
                loaiXe = 0;
            }    
            else if (this.txtLoaiXe.Text == "Xe Máy")
            {
                loaiXe = 1;
            }    
            else
            {
                loaiXe = 2;
            }    

            MemoryStream pic1 = new MemoryStream();
            MemoryStream pic2 = new MemoryStream();

            int loaiGui;
            if (this.txtLoaiGui.Text == "hourFee")
            {
                loaiGui = 0;
            }    
            else if (this.txtLoaiGui.Text == "dateFee")
            {
                loaiGui = 1;
            }    
            else if (this.txtLoaiGui.Text == "weekFee")
            { 
                loaiGui = 2;
            }
            else
            {
                loaiGui = 3;
            } 
                

            DateTime timeIn = Convert.ToDateTime(this.txtDTGui.Text);

            if (this.verify())
            {
                try
                {
                    this.pBHinh1.Image.Save(pic1, this.pBHinh1.Image.RawFormat);
                    this.pBHinh2.Image.Save(pic2, this.pBHinh2.Image.RawFormat);
                    if (this.vehicleBUS.UpdateInfoVehicle(id, loaiXe, loaiGui, pic1, pic2, timeIn))
                    {
                        MessageBox.Show("Vehicle Information Updated", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                    {
                        MessageBox.Show("Error", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnUpImg1_Click(object sender, EventArgs e)
        {

            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pBHinh1.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnUpImg2_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *.gif";
            if (opf.ShowDialog() == DialogResult.OK)
            {
                this.pBHinh2.Image = Image.FromFile(opf.FileName);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(this.txtID.Text);
                if (MessageBox.Show("Are You Sure ?!?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.vehicleBUS.DelVehicle(id))
                    {
                        MessageBox.Show("Vehicle Deleted", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtID.Text = "";
                        this.txtLoaiGui.Text = "";
                        this.txtLoaiXe.Text = "";
                        this.txtTongTien.Text = "";
                        this.txtDTGui.Text = DateTime.Now.ToString();
                        this.pBHinh2.Image = null;
                        this.pBHinh1.Image = null;
                    }
                    else
                        MessageBox.Show("Vehicle Not Deleted", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
