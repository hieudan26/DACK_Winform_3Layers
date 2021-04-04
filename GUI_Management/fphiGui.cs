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
        //fQuanLyXeGui formQuanLyXeGui;

        public fphiGui(vehicleDTO Vel)
        {
            InitializeComponent();

            this.vel = Vel;
            //this.formQuanLyXeGui = fQuanLy;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            //this.formQuanLyXeGui.pnlMove.Visible = false;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            vel.ADDGuiXe(this.cbLoaiGui.SelectedIndex, DateTime.Now);
            if(vehBUS.insertVehicle(this.vel))
            {
                MessageBox.Show("Insert Successfully");
            }
            else
                MessageBox.Show("Insert Failed");
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
            this.labelGio.Text = "Giá theo giờ:       ..........." + phiGuiDTO.PhiGio + " VND";
            this.labelNgay.Text = "Giá theo ngày:    ..........." + phiGuiDTO.PhiNgay + " VND";
            this.labelTuan.Text = "Giá theo tuần:     ..........." + phiGuiDTO.PhiTuan + " VND";
            this.labelThang.Text = "Giá theo tháng:   ..........." + phiGuiDTO.PhiThang + " VND";
        }
        private void fphiGui_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;
            int thu = 1;//(int)day.DayOfWeek;
            phiGuiBUS.UpdatePhi(thu);
            this.UpdatePhi();
        }
    }
}
