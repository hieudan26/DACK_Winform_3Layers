using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management
{
    public partial class fQuanLyXe : Form
    {
        public bool isCollapsed_1 = true;
        public bool isCollapsed_2 = true;
        public bool isCollapsed_3 = true;

        public fQuanLyXe()
        {
            InitializeComponent();
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnAddService.Height;
            this.pnlMove.Top = this.btnAddService.Top;
            //end panel move

            this.openChildForm(new fVehicle(this));
        }

        private void btnBaiXe_Click(object sender, EventArgs e)
        {
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.Black;
            this.btnLayXe.BorderColor = Color.White;
            //end

            this.openChildForm(new fbaiXe(this));
        }


        private void btnLayXe_Click(object sender, EventArgs e)
        {
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.White;
            this.btnLayXe.BorderColor = Color.Black;
            //end

            this.openChildForm(new flayXeGui(this));
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            //this.btnBaiXe.BorderColor = Color.White;
            //this.btnLayXe.BorderColor = Color.White;
            //this.btnDoanhThu.BorderColor = Color.Black;
            //end

            this.openChildForm(new fdoanhThu(this));
        }

        //open child form
        private Form activeForm = null;
        public void openChildForm(Form childForm)
        {
            if (this.activeForm != null)
            {
                this.activeForm.Close();
            }
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.pnlChildForm.Controls.Add(childForm);
            this.pnlChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
        //end

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gunaCirclePictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        Point mdLoc;
        private void pbLoad_MouseDown(object sender, MouseEventArgs e)
        {
            this.mdLoc = e.Location;
        }

        private void pbLoad_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                int dx = e.X - mdLoc.X;
                int dy = e.Y - mdLoc.Y;
                this.pbLoad.Location = new Point(this.pbLoad.Left + dx, this.pbLoad.Top + dy);
            }
        }

        private void timer1_XeGui_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_1)
            {
                this.pnlDropDownParkService.Height += 30;
                if (this.pnlDropDownParkService.Size == this.pnlDropDownParkService.MaximumSize)
                {
                    this.pnlDropDownFixService.Visible = false;
                    this.pnlDropDownWashService.Visible = false;
                    this.timer1_ParkService.Stop();
                    this.isCollapsed_1 = false;
                }
            }    
            else
            {
                this.pnlDropDownParkService.Height -= 30;
                if (this.pnlDropDownParkService.Size == this.pnlDropDownParkService.MinimumSize)
                {
                    this.pnlDropDownFixService.Visible = true;
                    this.pnlDropDownWashService.Visible = true;
                    this.timer1_ParkService.Stop();
                    this.isCollapsed_1 = true;
                }
            }    
        }

        private void btnXeGui_Click(object sender, EventArgs e)
        {
            this.timer1_ParkService.Start();
            
            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownParkService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownParkService.Top;
            //end panel move
        }

        private void timer1_FixService_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_2)
            {
                this.pnlDropDownFixService.Height += 30;
                if (this.pnlDropDownFixService.Size == this.pnlDropDownFixService.MaximumSize)
                {
                    this.pnlDropDownWashService.Visible = false;
                    this.timer1_FixService.Stop();
                    this.isCollapsed_2 = false;
                }
            }
            else
            {
                this.pnlDropDownFixService.Height -= 30;
                if (this.pnlDropDownFixService.Size == this.pnlDropDownFixService.MinimumSize)
                {
                    this.pnlDropDownWashService.Visible = true;
                    this.timer1_FixService.Stop();
                    this.isCollapsed_2 = true;
                }
            }
        }

        private void btnFixService_Click(object sender, EventArgs e)
        {
            this.timer1_FixService.Start();

            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownFixService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownFixService.Top;
            //end panel move
        }

        //Mở đki cho xe chọn 2 dịch vụ còn lại trong danh sách sửa
        private void btnOther_Fix_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fotherServices_Fix(this));
        }

        //Thông tin xe sửa
        private void btnInfoFix_Vehicle_Click_1(object sender, EventArgs e)
        {
            this.openChildForm(new finfoXeSua(this));
        }

        private void btnWashService_Click(object sender, EventArgs e)
        {
            this.timer1_WashService.Start();

            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownWashService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownWashService.Top;
            //end panel move
        }

        private void timer1_WashService_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_3)
            {
                this.pnlDropDownWashService.Height += 30;
                if (this.pnlDropDownWashService.Size == this.pnlDropDownWashService.MaximumSize)
                {
                    this.btnDoanhThu.Visible = false;
                    this.timer1_WashService.Stop();
                    this.isCollapsed_3 = false;
                }
            }
            else
            {
                this.pnlDropDownWashService.Height -= 30;
                if (this.pnlDropDownWashService.Size == this.pnlDropDownWashService.MinimumSize)
                {
                    this.btnDoanhThu.Visible = true;
                    this.timer1_WashService.Stop();
                    this.isCollapsed_3 = true;
                }
            }
        }

        private void btnThanhToan_Wash_Click(object sender, EventArgs e)
        {
            this.openChildForm(new finfoXeRua(this));
        }

        private void btnOther_Wash_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fotherServices_Wash(this));
        }

        private void btnOther_Park_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fotherServices_Park(this));
        }
    }
}