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
    public partial class fotherServices_Wash : Form
    {
        fQuanLyXe fQuanLy = new fQuanLyXe();
        vehicleWashBUS vehicleWashBUS = new vehicleWashBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();

        public fotherServices_Wash(fQuanLyXe fQuanLy)
        {
            InitializeComponent();
            this.fQuanLy = fQuanLy;
        }

        //btn EXIT
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fQuanLy.pnlMove.Visible = false;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.DarkGray;
            this.btnExit.ForeColor = Color.Black;
        }

        private void btnExit_MouseMove(object sender, MouseEventArgs e)
        {
            this.btnExit.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = Color.White;
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

        private void fotherServices_Wash_Load(object sender, EventArgs e)
        {
            this.dgv.RowTemplate.Height = 80;
            if (this.vehicleWashBUS.getAllVehicleWash() != null)
            {
                this.dgv.DataSource = this.vehicleWashBUS.getAllVehicleWash();
                this.designDataGridView(2, 3);

            }
            else
                this.dgv.DataSource = null;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.clearpnl();
            DataTable table = this.vehicleWashBUS.getStatus(this.dgv.CurrentRow.Cells[0].Value.ToString());
            int park = Convert.ToInt32(table.Rows[0]["park"].ToString());
            int fix = Convert.ToInt32(table.Rows[0]["fix"].ToString());
            //int wash = Convert.ToInt32(table.Rows[0]["wash"].ToString());
            if (park == 0)
            {
                this.sinhbtnPark();
            }
            //#f8a5c2//#f1f2f6//248, 165, 194//241, 242, 246
            if (fix == 0)
            {
                this.sinhbtnFix();
            }
        }

        //Làm sạch panel (vì mỗi object xe có trạng thái dịch vụ khác nhau)
        private void clearpnl()
        {
            if (this.flpService.Controls.Count != 0)
                this.flpService.Controls.Clear();
        }
        //end

        //sinh button Fix
        private void sinhbtnFix()
        {
            //design btn
            Guna.UI.WinForms.GunaGradientButton btnFix = new Guna.UI.WinForms.GunaGradientButton();
            btnFix.Text = "FIX";
            btnFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            btnFix.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnFix.ForeColor = Color.DarkGreen;
            btnFix.Radius = 4;
            btnFix.Image = null;
            btnFix.BaseColor1 = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            btnFix.BaseColor2 = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            btnFix.OnHoverBaseColor1 = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            btnFix.OnHoverBaseColor2 = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            //end design

            //thêm vào panel và thêm event click
            this.flpService.Controls.Add(btnFix);
            btnFix.Click += new System.EventHandler(this.btnFix_Click);
        }
        //end button Fix

        //sinh button Park
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
            btnPark.BaseColor1 = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            btnPark.BaseColor2 = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            btnPark.OnHoverBaseColor1 = Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(242)))), ((int)(((byte)(246)))));
            btnPark.OnHoverBaseColor2 = Color.FromArgb(((int)(((byte)(248)))), ((int)(((byte)(165)))), ((int)(((byte)(194)))));
            //end design

            //thêm vào panel và tạo event click
            this.flpService.Controls.Add(btnPark);
            btnPark.Click += new System.EventHandler(this.btnPark_Click);
        }
        //end sinh button Park

        private void btnFix_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[1].Value);

            this.fQuanLy.openChildForm(new fphiSuaXe(id, this.fQuanLy, type, 3));
        }

        private void btnPark_Click(object sender, EventArgs e)
        {
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            int type = Convert.ToInt32(this.dgv.CurrentRow.Cells[1].Value);

            this.fQuanLy.openChildForm(new fphiGuiXe(id, this.fQuanLy, 3));
        }
    }
}
