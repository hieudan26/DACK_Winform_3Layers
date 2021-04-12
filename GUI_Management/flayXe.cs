using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using DTO_Management;

namespace GUI_Management
{
    public partial class flayXe : Form
    {
        doanhThuParkingBUS doanhThuBUS = new doanhThuParkingBUS();
        vehicleParkingBUS vehParkingBUS = new vehicleParkingBUS();
        vehicleBUS vehBUS = new vehicleBUS();
        public flayXe()
        {
            InitializeComponent();
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeFilter.SelectedIndex;
            if (this.cbTypeFilter.SelectedIndex == 3) // Lọc xe đạp
            {
                DataTable table = this.vehParkingBUS.getVehicleExpired();
                dgvXe.DataSource = table;
            }   
            else if (this.cbTypeFilter.SelectedIndex < 3)  // Lọc xe máy
            {
                DataTable table = this.vehParkingBUS.danhSachXetheoLoai(index);
                dgvXe.DataSource = table;
            }
            else if (this.cbTypeFilter.SelectedIndex == 4 )  // Lọc xe máy
            {
                DataTable table = this.vehParkingBUS.getVehicleNotExpired();
                dgvXe.DataSource = table;
            }
            else
            {
                DataTable table = this.vehParkingBUS.getAllVehicle();
                dgvXe.DataSource = table;
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string IDxe = this.dgvXe.CurrentRow.Cells[0].Value.ToString();
            MessageBox.Show("Do you want to take out : " + IDxe, "Take Out vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            try
            {
                if (true)
                {
                    if (this.vehParkingBUS.DelVehicle(IDxe) && this.vehBUS.DelVehicle(IDxe))
                        MessageBox.Show("Vehicle is taken out");
                    else
                        MessageBox.Show("Vehicle is taken out Error");
                    DataTable table = this.vehParkingBUS.getAllVehicle();
                    dgvXe.DataSource = table;
                    this.cbTypeFilter.SelectedIndex = 5;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }
    }
}
