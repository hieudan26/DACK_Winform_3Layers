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
    public partial class fotherServices_Park : Form
    {
        fQuanLyXe fQuanLy = new fQuanLyXe();
        vehicleBUS vehBUS = new vehicleBUS();
        vehicleParkingBUS vehicleParkingBUS = new vehicleParkingBUS();
        vehicleWashBUS vehicleWashBUS = new vehicleWashBUS();

        public fotherServices_Park(fQuanLyXe quanLyXe)
        {
            InitializeComponent();
            this.fQuanLy = quanLyXe;
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
        //End btn EXIT

        private void designDataGridView(int i1, int i2)
        {
            this.dgv.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            picCol = (DataGridViewImageColumn)this.dgv.Columns[i1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)this.dgv.Columns[i2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dgv.AllowUserToAddRows = false;
        }

        private void fotherServices_Park_Load(object sender, EventArgs e)
        {
            this.dgv.RowTemplate.Height = 80;
            if (this.vehicleParkingBUS.getAllVehicle() != null)
            {
                this.dgv.DataSource = this.vehicleParkingBUS.getAllVehicle();
                this.designDataGridView(2, 3);
                
            }
            else
                this.dgv.DataSource = null;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearPnl();
            DataTable table = this.vehicleParkingBUS.getStatus(this.dgv.CurrentRow.Cells[0].Value.ToString());
            //int park = Convert.ToInt32(table.Rows[0]["park"].ToString());
            int fix = Convert.ToInt32(table.Rows[0]["fix"].ToString());
            int wash = Convert.ToInt32(table.Rows[0]["wash"].ToString());
            if (fix == 0)
            {
                this.sinhbtnFix();
            }

            if (wash == 0)
            {
                this.sinhbtnWash();
            }
        }

        //clear pnl
        private void clearPnl()
        {
            if (this.flpService.Controls.Count != 0)
                this.flpService.Controls.Clear();
        }
        //end

        //sinh btn fix
        private void sinhbtnFix()
        {
            //design
            Guna.UI.WinForms.GunaGradientButton btnFix = new Guna.UI.WinForms.GunaGradientButton();
            btnFix.Text = "FIX";
            btnFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnFix.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFix.ForeColor = Color.DarkGreen;
            btnFix.Radius = 4;
            btnFix.Image = null;
            btnFix.BaseColor1 = Color.White;
            btnFix.BaseColor2 = Color.Gray;
            btnFix.OnHoverBaseColor1 = Color.Gray;
            btnFix.OnHoverBaseColor2 = Color.White;
            //end design

            this.flpService.Controls.Add(btnFix);
            btnFix.Click += new System.EventHandler(this.btnFix_Click);
        }
        //end sinh btn fix

        //sinh btn wash
        private void sinhbtnWash()
        {
            //desin
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
            //end design

            this.flpService.Controls.Add(btnWash);
            btnWash.Click += new System.EventHandler(this.btnWash_Click);
        }
        //end sinh btn wash

        private void btnWash_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[1].Value);

            vehicleWashDTO vehicleWashDTO = new vehicleWashDTO(id, type);
            if (this.vehBUS.UpdateStatusVehicle(id, "WASH", 1) && this.vehicleWashBUS.insertVehicleWash(vehicleWashDTO))
            {
                MessageBox.Show("Successfully");
                this.fotherServices_Park_Load(sender, e);
            }    
            else
                MessageBox.Show("Unsuccessfully");
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[1].Value);

            this.fotherServices_Park_Load(sender, e);
            this.fQuanLy.openChildForm(new fphiSuaXe(id, this.fQuanLy, type, 1));
        }
    }
}
