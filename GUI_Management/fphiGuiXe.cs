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
        vehicleParkingBUS vehParkBus = new vehicleParkingBUS();
        fQuanLyXe formQuanLyXeGui;
        vehicleBUS vehicleBUS = new vehicleBUS();
        int indexform;
        public fphiGuiXe(string id,fQuanLyXe fQuanLy,int indexform)
        {
            InitializeComponent();

            this.vel.id = id;
            this.formQuanLyXeGui = fQuanLy;
            this.indexform = indexform;
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

            if (this.vehParkBus.insertVehicle(this.vel) && this.vehicleBUS.UpdateStatusVehicle(this.vel.id, "PARK", 1))
            {
                MessageBox.Show("Insert Successfully");
                this.cbLoaiGui.SelectedIndex = -1;
                fVehicle f = new fVehicle(formQuanLyXeGui);
                formQuanLyXeGui.openChildForm(f);
                
            }
            else
                MessageBox.Show("Insert Failed");
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch(this.indexform)
            {
                case 0:
                    {
                        fVehicle f = new fVehicle(formQuanLyXeGui);
                        formQuanLyXeGui.openChildForm(f);
                        break;
                    }
                case 1:
                    {
                        fotherServices_Park f = new fotherServices_Park(formQuanLyXeGui);
                        formQuanLyXeGui.openChildForm(f);
                        break;
                    }
                case 2:
                    {
                        fotherServices_Fix f = new fotherServices_Fix(formQuanLyXeGui);
                        formQuanLyXeGui.openChildForm(f);
                        break;
                    }
                case 3:
                    {
                        fotherServices_Wash f = new fotherServices_Wash(formQuanLyXeGui);
                        formQuanLyXeGui.openChildForm(f);
                        break;
                    }
            }
        }
    }
}
