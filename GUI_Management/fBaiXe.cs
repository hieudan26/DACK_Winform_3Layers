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
    public partial class fBaiXe : Form
    {
        fQuanLyXeGui formQuanLyXeGui;
        vehicleBUS VehicleBUS = new vehicleBUS();
        vehicleDTO vehicleDTO = new vehicleDTO();
        //public int ID;

        public fBaiXe(fQuanLyXeGui fQuanLy)
        {
            InitializeComponent();
            this.formQuanLyXeGui = fQuanLy;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formQuanLyXeGui.pnlMove.Visible = false;
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

        private Guna.UI.Lib.ScrollBar.PanelScrollHelper vScrollHelper1;

        private void fBaiXe_Load(object sender, EventArgs e)
        {
            //danh sach xe dap
            List<int> IDbicycle = VehicleBUS.danhSachID(0);

            foreach (var item in IDbicycle)
            {
                vScrollHelper1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(this.flpKhuA, this.gunaVScrollBar1, true);
                

                Guna.UI.WinForms.GunaGradientButton btnBike = new Guna.UI.WinForms.GunaGradientButton();
                btnBike.Text = item.ToString();

                //design button
                btnBike.Width = 130;
                btnBike.Height = 40;
                btnBike.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnBike.BaseColor1 = Color.AntiqueWhite;
                btnBike.BaseColor2 = Color.LightPink;
                btnBike.Image = null;
                btnBike.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                btnBike.ForeColor = Color.Black;
                btnBike.Radius = 3;
                btnBike.OnHoverBaseColor1 = Color.LightPink;
                btnBike.OnHoverBaseColor2 = Color.AntiqueWhite;
                btnBike.BorderSize = 2;
                btnBike.BorderColor = Color.Black;
                //end

                //event click
                //this.ID = item;
                btnBike.Click += new System.EventHandler(this.btnBike_Click);
                //end

                this.flpKhuA.Controls.Add(btnBike);
            }

            //danh sach motor
            List<int> IDmotor = VehicleBUS.danhSachID(1);
            foreach(var item in IDmotor)
            {
                vScrollHelper1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(this.flpKhuB, this.gunaVScrollBar2, true);

                Guna.UI.WinForms.GunaGradientButton btnMotor = new Guna.UI.WinForms.GunaGradientButton();
                btnMotor.Text = item.ToString();

                //design button
                btnMotor.Width = 130;
                btnMotor.Height = 40;
                btnMotor.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnMotor.BaseColor1 = Color.AntiqueWhite;
                btnMotor.BaseColor2 = Color.LightPink;
                btnMotor.Image = null;
                btnMotor.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                btnMotor.ForeColor = Color.Black;
                btnMotor.Radius = 5;
                btnMotor.OnHoverBaseColor1 = Color.LightPink;
                btnMotor.OnHoverBaseColor2 = Color.AntiqueWhite;
                btnMotor.BorderSize = 2;
                btnMotor.BorderColor = Color.Black;
                //end

                //event click
                btnMotor.Click += new System.EventHandler(this.btnMotor_Click);
                //end

                this.flpKhuB.Controls.Add(btnMotor);
            }

            //danh sach xe hoi
            List<int> IDcar = VehicleBUS.danhSachID(2);
            foreach (var item in IDcar)
            {
                vScrollHelper1 = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(this.flpKhuC, this.gunaVScrollBar3, true);

                Guna.UI.WinForms.GunaGradientButton btnCar = new Guna.UI.WinForms.GunaGradientButton();
                btnCar.Text = item.ToString();

                //design button
                btnCar.Width = 130;
                btnCar.Height = 40;
                btnCar.Font = new System.Drawing.Font("Times New Roman", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                btnCar.BaseColor1 = Color.AntiqueWhite;
                btnCar.BaseColor2 = Color.LightPink;
                btnCar.Image = null;
                btnCar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
                btnCar.ForeColor = Color.Black;
                btnCar.Radius = 5;
                btnCar.OnHoverBaseColor1 = Color.LightPink;
                btnCar.OnHoverBaseColor2 = Color.AntiqueWhite;
                btnCar.BorderSize = 2;
                btnCar.BorderColor = Color.Black;
                //end

                //event click
                btnCar.Click += new System.EventHandler(this.btnCar_Click);
                //end

                this.flpKhuC.Controls.Add(btnCar);
            }

            //Hien thi trạng thái bãi giữ xe
            int soChoTrongKhuA = 100 - this.VehicleBUS.countVehicleType(0);
            this.lbStatusA.Font = new System.Drawing.Font("Times New Roman", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusA.Text = "Khu A còn: " + soChoTrongKhuA + " chỗ trống";

            int soChoTrongKhuB = 100 - this.VehicleBUS.countVehicleType(1);
            this.lbStatusB.Font = new System.Drawing.Font("Times New Roman", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusB.Text = "Khu B còn: " + soChoTrongKhuB + " chỗ trống";

            int soChoTrongKhuC = 100 - this.VehicleBUS.countVehicleType(2);
            this.lbStatusC.Font = new System.Drawing.Font("Times New Roman", 7F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbStatusC.Text = "Khu C còn: " + soChoTrongKhuC + " chỗ trống";
        }

        private void btnCar_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaGradientButton btn = sender as Guna.UI.WinForms.GunaGradientButton;
            int id = Convert.ToInt32(btn.Text);

            finfoXe form = new finfoXe(formQuanLyXeGui);
            DataTable table = this.VehicleBUS.getVehicleByID(id);
            Byte[] pic = new Byte[0];
            pic = (Byte[])(table.Rows[0]["img1"]);
            MemoryStream ms = new MemoryStream(pic);
            form.pBHinh1.Image = Image.FromStream(ms);
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;

            Byte[] pic2 = new Byte[0];
            pic2 = (Byte[])(table.Rows[0]["img2"]);
            MemoryStream ms2 = new MemoryStream(pic2);
            form.pBHinh2.Image = Image.FromStream(ms2);
            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;

            form.txtID.Text = id.ToString();

            form.txtLoaiXe.Text = "Xe Hơi";

            form.lbHinh1.Text = "Bảng Số";

            form.lbHinh2.Text = "Hiệu Xe";

            int thu = this.xacDinhThu();

            String loaiGui = this.LoaiGui(id);


            int phi_theo_thu = this.VehicleBUS.layTienTheoThu(thu, loaiGui);

            form.txtTongTien.Text = phi_theo_thu.ToString();

            this.formQuanLyXeGui.openChildForm(form);

        }

        private void btnMotor_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaGradientButton btn = sender as Guna.UI.WinForms.GunaGradientButton;
            int id = Convert.ToInt32(btn.Text);

            finfoXe form = new finfoXe(formQuanLyXeGui);
            DataTable table = this.VehicleBUS.getVehicleByID(id);
            Byte[] pic = new Byte[0];
            pic = (Byte[])(table.Rows[0]["img1"]);
            MemoryStream ms = new MemoryStream(pic);
            form.pBHinh1.Image = Image.FromStream(ms);
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;

            Byte[] pic2 = new Byte[0];
            pic2 = (Byte[])(table.Rows[0]["img2"]);
            MemoryStream ms2 = new MemoryStream(pic2);
            form.pBHinh2.Image = Image.FromStream(ms2);
            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;

            form.txtID.Text = id.ToString();

            form.txtLoaiXe.Text = "Xe Motor";

            form.lbHinh1.Text = "Bảng Số";

            form.lbHinh2.Text = "Người Gửi";

            int thu = this.xacDinhThu();

            String loaiGui = this.LoaiGui(id);


            int phi_theo_thu = this.VehicleBUS.layTienTheoThu(thu, loaiGui);

            form.txtTongTien.Text = phi_theo_thu.ToString();

            this.formQuanLyXeGui.openChildForm(form);
        }

        private void btnBike_Click(object sender, EventArgs e)
        {
            Guna.UI.WinForms.GunaGradientButton btn = sender as Guna.UI.WinForms.GunaGradientButton;
            int id = Convert.ToInt32(btn.Text);

            finfoXe form = new finfoXe(formQuanLyXeGui);
            DataTable table = this.VehicleBUS.getVehicleByID(id);
            Byte[] pic = new Byte[0];
            pic = (Byte[])(table.Rows[0]["img1"]);
            MemoryStream ms = new MemoryStream(pic);
            form.pBHinh1.Image = Image.FromStream(ms);
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;

            Byte[] pic2 = new Byte[0];
            pic2 = (Byte[])(table.Rows[0]["img2"]);
            MemoryStream ms2 = new MemoryStream(pic2);
            form.pBHinh2.Image = Image.FromStream(ms2);
            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;

            form.txtID.Text = id.ToString();

            form.txtLoaiXe.Text = "Xe Dap";

            form.lbHinh1.Text = "Hình Xe";

            form.lbHinh2.Text = "Người Gửi";

            //Xác định thứ trong tuần
            int thu = this.xacDinhThu();

            String loaiGui = this.LoaiGui(id);


            int phi_theo_thu = this.VehicleBUS.layTienTheoThu(thu, loaiGui);

            form.txtTongTien.Text = phi_theo_thu.ToString();
            
            this.formQuanLyXeGui.openChildForm(form);
        }

        public int xacDinhThu()
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
                thu = 8;

            return thu;
        }

        public string LoaiGui(int id)
        {
            string LoaiGui = "";
            int lg = this.VehicleBUS.getTypeGuiXe(id);
            if (lg == 0)
            {
                LoaiGui = "gio";
            }    
            else if (lg == 1)
            {
                LoaiGui = "ngay";
            }    
            else if (lg == 2)
            {
                LoaiGui = "tuan";
            }    
            else
            {
                LoaiGui = "thang";
            }
            return LoaiGui;
        }
    }
}
