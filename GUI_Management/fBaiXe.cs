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

namespace GUI_Management
{
    public partial class fBaiXe : Form
    {
        fQuanLyXeGui formQuanLyXeGui;
        vehicleBUS VehicleBUS = new vehicleBUS();

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

        private void fBaiXe_Load(object sender, EventArgs e)
        {
            //danh sach xe dap
            List<int> IDbicycle = VehicleBUS.danhSachID(0);
            foreach (var item in IDbicycle)
            {
                Button btnBike = new Button();
                btnBike.Text = item.ToString();
                btnBike.AutoSize = true;
                this.flpKhuA.Controls.Add(btnBike);
            }

            //danh sach motor
            List<int> IDmotor = VehicleBUS.danhSachID(1);
            foreach(var item in IDmotor)
            {
                Button btnMotor = new Button();
                btnMotor.Text = item.ToString();
                btnMotor.AutoSize = true;
                this.flpKhuB.Controls.Add(btnMotor);
            }

            //danh sach xe hoi
            List<int> IDcar = VehicleBUS.danhSachID(2);
            foreach (var item in IDcar)
            {
                Button btnCar = new Button();
                btnCar.Text = item.ToString();
                btnCar.AutoSize = true;
                this.flpKhuC.Controls.Add(btnCar    );
            }
        }
    }
}
