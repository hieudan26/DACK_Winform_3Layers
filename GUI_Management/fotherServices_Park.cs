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

        private MemoryStream picture(DataTable table, string img)
        {
            Byte[] pic = new Byte[0];
            pic = (Byte[])(table.Rows[0][img]);
            MemoryStream ms = new MemoryStream(pic);
            return ms;
        }

        private int xacDinhThu()
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
                thu = 8;

            return thu;
        }

        private string LoaiGui(int type)
        {
            string LoaiGui = "";

            if (type == 0)
            {
                LoaiGui = "hourFee";
            }
            else if (type == 1)
            {
                LoaiGui = "dateFee";
            }
            else if (type == 2)
            {
                LoaiGui = "weekFee";
            }
            else
            {
                LoaiGui = "monthFee";
            }
            return LoaiGui;
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
            finfoXeGui form = new finfoXeGui(fQuanLy, "Other");
            string id = this.dgv.CurrentRow.Cells[0].Value.ToString();
            DataTable table = this.vehicleParkingBUS.getVehicleByID(id);
            form.pBHinh1.Image = Image.FromStream(this.picture(table, "img1"));
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;

            form.pBHinh2.Image = Image.FromStream(this.picture(table, "img2"));
            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;

            form.txtID.Text = id.ToString();

            if (int.Parse(table.Rows[0]["type"].ToString()) == 0)
            {
                form.txtLoaiXe.Text = "Xe Đạp";
                form.lbHinh1.Text = "Hình Xe";
                form.lbHinh2.Text = "Người Gửi";
            }
            else if (int.Parse(table.Rows[0]["type"].ToString()) == 1)
            {
                form.txtLoaiXe.Text = "Xe Máy";
                form.lbHinh1.Text = "Bảng Số";
                form.lbHinh2.Text = "Người Gửi";
            }
            else
            {
                form.txtLoaiXe.Text = "Xe Hơi";
                form.lbHinh1.Text = "Bảng Số";
                form.lbHinh2.Text = "Hiệu Xe";
            }


            //Xác định thứ trong tuần
            int thu = this.xacDinhThu();

            String loaiGui = this.LoaiGui(int.Parse(table.Rows[0]["typePark"].ToString()));

            form.txtLoaiGui.Text = loaiGui;

            int phi_theo_thu = 0;
            if (loaiGui != "")
            {
                phi_theo_thu = this.vehicleParkingBUS.layTienTheoThu(thu, loaiGui);
            }

            form.txtDTGui.Text = table.Rows[0]["timeIn"].ToString();

            form.txtTongTien.Text = phi_theo_thu.ToString();

            this.fQuanLy.openChildForm(form);
        }
    }
}
