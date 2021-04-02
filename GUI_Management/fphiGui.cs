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

namespace GUI_Management
{
    public partial class fphiGui : Form
    {
        vehicleDTO vel = new vehicleDTO();
        vehicleBUS vehBUS = new vehicleBUS();
        public fphiGui(vehicleDTO Vel)
        {
            InitializeComponent();
            this.vel = Vel;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            vehBUS.insertGuiXe(this.vel, 1);
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.DarkGray;
            this.btnExit.ForeColor = Color.Black;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
        private void UpdatePhi()
        {
            this.labelGio.Text = "Giá theo giờ:   " + phiGuiDTO.PhiGio;
            this.labelNgay.Text = "Giá theo ngày:   " + phiGuiDTO.PhiNgay;
            this.labelTuan.Text = "Giá theo tuần:   " + phiGuiDTO.PhiTuan;
            this.labelThang.Text = "Giá theo tháng:   " + phiGuiDTO.PhiThang;
        }
        private void fphiGui_Load(object sender, EventArgs e)
        {
            phiGuiBUS.UpdatePhi();
            this.UpdatePhi();
        }
    }
}
