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
    public partial class fotherServices_Fix : Form
    {
        fQuanLyXe fQuanLy = new fQuanLyXe();
        vehicleFixBUS vehicleFixBUS = new vehicleFixBUS();
        vehicleBUS vehBUS = new vehicleBUS();
        vehicleWashBUS vehicleWashBUS = new vehicleWashBUS();
        vehicleParkingBUS vehicleParkingBUS = new vehicleParkingBUS();

        public fotherServices_Fix(fQuanLyXe fQuanLy)
        {
            InitializeComponent();
            this.fQuanLy = fQuanLy;
        }

        //btn EXIT
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
            this.fQuanLy.pnlMove.Visible = false;
        }
        //end btn EXIT

        //private void designDataGridView(int i1, int i2)
        //{
        //    this.dgv.ReadOnly = true;
        //    DataGridViewImageColumn picCol = new DataGridViewImageColumn();
        //    DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

        //    picCol = (DataGridViewImageColumn)this.dgv.Columns[i1];
        //    picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //    picCol2 = (DataGridViewImageColumn)this.dgv.Columns[i2];
        //    picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
        //    this.dgv.AllowUserToAddRows = false;
        //}

        private void fotherServices_Fix_Load(object sender, EventArgs e)
        {
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 80;
            this.dgv.AllowUserToAddRows = false;
            if (this.vehicleFixBUS.getVehicleFix_info_all() != null)
            {
                this.dgv.DataSource = this.vehicleFixBUS.getVehicleFix_info_all();
                //this.designDataGridView(3, 4);
            }
            else
                this.dgv.DataSource = null;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearPnl();
            DataTable table = this.vehicleFixBUS.getStatus(this.dgv.CurrentRow.Cells[0].Value.ToString());
            int park = Convert.ToInt32(table.Rows[0]["park"].ToString());
            //int fix = Convert.ToInt32(table.Rows[0]["fix"].ToString());
            int wash = Convert.ToInt32(table.Rows[0]["wash"].ToString());
            if (park == 0)
            {
                this.sinhbtnPark();   
            }

            if (wash == 0)
            {
                this.sinhbtnWash();
            }
        }

        //clear panel
        private void clearPnl()
        {
            if (this.flpService.Controls.Count != 0)
                this.flpService.Controls.Clear();
        }
        //end

        //sinh btn park
        private void sinhbtnPark()
        {
            //design
            Guna.UI.WinForms.GunaGradientButton btnPark = new Guna.UI.WinForms.GunaGradientButton();
            btnPark.Text = "PARK";
            btnPark.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnPark.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnPark.ForeColor = Color.DarkGreen;
            btnPark.Radius = 4;
            btnPark.Image = null;
            btnPark.BaseColor1 = Color.White;
            btnPark.BaseColor2 = Color.Gray;
            btnPark.OnHoverBaseColor1 = Color.Gray;
            btnPark.OnHoverBaseColor2 = Color.White;
            //end design

            this.flpService.Controls.Add(btnPark);
            btnPark.Click += new System.EventHandler(this.btnPark_Click);
        }
        //end sinh btn park

        //sinh btn wash
        private void sinhbtnWash()
        {
            //design
            Guna.UI.WinForms.GunaGradientButton btnWash = new Guna.UI.WinForms.GunaGradientButton();
            btnWash.Text = "WASH";
            btnWash.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnWash.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnWash.ForeColor = Color.DarkGreen;
            btnWash.Radius = 4;
            btnWash.Image = null;
            btnWash.BaseColor1 = Color.White;
            btnWash.BaseColor2 = Color.Gray;
            btnWash.OnHoverBaseColor1 = Color.Gray;
            btnWash.OnHoverBaseColor2 = Color.White;
            //design

            this.flpService.Controls.Add(btnWash);
            btnWash.Click += new System.EventHandler(this.btnWash_Click);
        }
        //end sinh btn wash

        private void btnWash_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[2].Value);

            vehicleWashDTO vehicleWashDTO = new vehicleWashDTO(id, type);
            if (this.vehBUS.UpdateStatusVehicle(id, "WASH", 1) && this.vehicleWashBUS.insertVehicleWash(vehicleWashDTO))
            {
                this.fotherServices_Fix_Load(sender, e);
                MessageBox.Show("Successfully");
            }
            else
                MessageBox.Show("Unsuccessfully");
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[2].Value);

            this.fQuanLy.openChildForm(new fphiGuiXe(id, this.fQuanLy, 2));
        }
    }
}
