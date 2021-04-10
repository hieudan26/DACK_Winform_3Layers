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
        vehicleParkingDTO vel = new vehicleParkingDTO();
        vehicleParkingBUS vehBUS = new vehicleParkingBUS();
        fQuanLyXeGui formQuanLyXeGui;

        public fphiGui(vehicleDTO Vel,fQuanLyXeGui fQuanLy)
        {
            InitializeComponent();

            this.vel.id = Vel.id;
            this.formQuanLyXeGui = fQuanLy;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
            int thu = (int)day.DayOfWeek;
            phiGuiBUS.UpdatePhi(thu);
            this.UpdatePhi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.vel.typeGui = this.cbLoaiGui.SelectedIndex;
            this.vel.ngayGui = DateTime.Now;

            if (this.vehBUS.insertVehicle(this.vel))
            {
                MessageBox.Show("Insert Successfully");
            }
            else
                MessageBox.Show("Insert Failed");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fGuiXe f = new fGuiXe(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }
    }
}
