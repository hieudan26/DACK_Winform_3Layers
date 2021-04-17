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
    public partial class fphiGuiXe : Form
    {
        vehicleParkingDTO vel = new vehicleParkingDTO();
        vehicleParkingBUS vehBUS = new vehicleParkingBUS();
        fQuanLyXe formQuanLyXeGui;

        public fphiGuiXe(string id,fQuanLyXe fQuanLy)
        {
            InitializeComponent();

            this.vel.id = id;
            this.formQuanLyXeGui = fQuanLy;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UpdatePhi()
        {
            this.labelGio.Text = "Giá theo giờ:       ..........." + phiDichVuGuiXeDTO.PhiGio + " VND";
            this.labelNgay.Text = "Giá theo ngày:    ..........." + phiDichVuGuiXeDTO.PhiNgay + " VND";
            this.labelTuan.Text = "Giá theo tuần:     ..........." + phiDichVuGuiXeDTO.PhiTuan + " VND";
            this.labelThang.Text = "Giá theo tháng:   ..........." + phiDichVuGuiXeDTO.PhiThang + " VND";
        }

        private void fphiGui_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;
            this.dtPicker.Value = day;
            int thu = (int)day.DayOfWeek;
            phiDichVuGuiXeBUS.UpdatePhi(thu);
            this.UpdatePhi();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            this.vel.typeGui = this.cbLoaiGui.SelectedIndex;
            this.vel.ngayGui = DateTime.Now;

            if (this.vehBUS.insertVehicle(this.vel))
            {
                MessageBox.Show("Insert Successfully");
                this.cbLoaiGui.SelectedIndex = -1;
            }
            else
                MessageBox.Show("Insert Failed");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fVehicle f = new fVehicle(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }
    }
}
