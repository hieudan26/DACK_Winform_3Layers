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

        //add veh
        private void btnAddService_Click(object sender, EventArgs e)
        {
            if (this.isCollapsed_1 == false)
                this.HiddenPark();
            if (this.isCollapsed_2 == false)
                this.HiddenFix();
            if (this.isCollapsed_3 == false)
                this.HiddenWash();
            //panel move
            this.PanelMoveAdd();
            //end panel move

            this.openChildForm(new fVehicle(this));
        }
        //end add veh

        //Gửi
        private void btnBaiXe_Click(object sender, EventArgs e)
        {
            this.PanelMoveParkService();
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.Black;
            this.btnLayXe.BorderColor = Color.White;
            this.btnOther_Park.BorderColor = Color.White;
            //end

            this.openChildForm(new fbaiXe(this));
        }


        private void btnLayXe_Click(object sender, EventArgs e)
        {
            this.PanelMoveParkService();
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.White;
            this.btnLayXe.BorderColor = Color.Black;
            this.btnOther_Park.BorderColor = Color.White;
            //end

            this.openChildForm(new flayXeGui(this));
        }

        private void btnOther_Park_Click(object sender, EventArgs e)
        {
            this.PanelMoveParkService();
            //border change color
            //this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.White;
            this.btnLayXe.BorderColor = Color.White;
            this.btnOther_Park.BorderColor = Color.Black;
            //end

            this.openChildForm(new fotherServices_Park(this));
        }

        private void timer1_XeGui_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_1)
            {
                this.pnlDropDownParkService.Height += 90;
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
                this.pnlDropDownParkService.Height -= 90;
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
            if (this.isCollapsed_2 == false)
                this.HiddenFix();
            if (this.isCollapsed_3 == false)
                this.HiddenWash();
            this.timer1_ParkService.Start();

            //panel move
            this.PanelMoveParkService();
            //end panel move
        }
        //end gửi

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

        //exit
        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        //end exit

        //play with image
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
        //end

        //fix
        private void timer1_FixService_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_2)
            {
                this.pnlDropDownFixService.Height += 90;
                if (this.pnlDropDownFixService.Size == this.pnlDropDownFixService.MaximumSize)
                {
                    this.btnDoanhThu.Visible = false;
                    this.pnlDropDownWashService.Visible = false;
                    this.timer1_FixService.Stop();
                    this.isCollapsed_2 = false;
                }
            }
            else
            {
                this.pnlDropDownFixService.Height -= 90;
                if (this.pnlDropDownFixService.Size == this.pnlDropDownFixService.MinimumSize)
                {
                    this.btnDoanhThu.Visible = true;
                    this.pnlDropDownWashService.Visible = true;
                    this.timer1_FixService.Stop();
                    this.isCollapsed_2 = true;
                }
            }
        }

        private void btnFixService_Click(object sender, EventArgs e)
        {
            if (this.isCollapsed_1 == false)
                this.HiddenPark();
            if (this.isCollapsed_3 == false)
                this.HiddenWash();
            this.timer1_FixService.Start();

            //panel move
            this.PanelMoveFix();
            //end panel move
        }

        //Mở đki cho xe chọn 2 dịch vụ còn lại trong danh sách sửa
        private void btnOther_Fix_Click(object sender, EventArgs e)
        {
            this.PanelMoveFix();
            this.openChildForm(new fotherServices_Fix(this));
        }

        //Thông tin xe sửa
        private void btnInfoFix_Vehicle_Click_1(object sender, EventArgs e)
        {
            this.PanelMoveFix();
            this.openChildForm(new finfoXeSua(this));
        }
        //end fix

        //wash
        private void btnWashService_Click(object sender, EventArgs e)
        {
            if (this.isCollapsed_1 == false)
                this.HiddenPark();
            if (this.isCollapsed_2 == false)
                this.HiddenFix();
            this.timer1_WashService.Start();

            //panel move
            this.PanelMoveWash();
            //end panel move
        }

        private void timer1_WashService_Tick(object sender, EventArgs e)
        {
            if (this.isCollapsed_3)
            {
                this.pnlDropDownWashService.Height += 90;
                if (this.pnlDropDownWashService.Size == this.pnlDropDownWashService.MaximumSize)
                {
                    this.btnDoanhThu.Visible = false;
                    this.timer1_WashService.Stop();
                    this.isCollapsed_3 = false;
                }
            }
            else
            {
                this.pnlDropDownWashService.Height -= 500;
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
            this.PanelMoveWash();
            this.openChildForm(new finfoXeRua(this));
        }

        private void btnOther_Wash_Click(object sender, EventArgs e)
        {
            this.PanelMoveWash();
            this.openChildForm(new fotherServices_Wash(this));
        }
        //end wash

        //Doanh thu
        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            if (this.isCollapsed_1 == false)
                this.HiddenPark();
            if (this.isCollapsed_2 == false)
                this.HiddenFix();
            if (this.isCollapsed_3 == false)
                this.HiddenWash();

            //panel move
            this.PanelMoveDoanhThu();
            //end panel move

            this.openChildForm(new fdoanhThu(this));
        }
        //end doanh thu

        private void HiddenPark()
        {
            this.pnlDropDownParkService.Size = this.pnlDropDownParkService.MinimumSize;
            this.pnlDropDownFixService.Visible = true;
            this.pnlDropDownWashService.Visible = true;
            this.isCollapsed_1 = true;
        }

        private void HiddenFix()
        {
            this.pnlDropDownFixService.Size = this.pnlDropDownFixService.MinimumSize;
            this.btnDoanhThu.Visible = true;
            this.pnlDropDownWashService.Visible = true;
            this.isCollapsed_2 = true;
        }

        private void HiddenWash()
        {
            this.pnlDropDownWashService.Size = this.pnlDropDownWashService.MinimumSize;
            this.btnDoanhThu.Visible = true;
            this.isCollapsed_3 = true;
        }

        private void PanelMoveAdd()
        {
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnAddService.Height;
            this.pnlMove.Top = this.btnAddService.Top;
        }

        private void PanelMoveParkService()
        {
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownParkService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownParkService.Top;
        }

        private void PanelMoveFix()
        {
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownFixService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownFixService.Top;
        }

        private void PanelMoveWash()
        {
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.pnlDropDownWashService.MinimumSize.Height;
            this.pnlMove.Top = this.pnlDropDownWashService.Top;
        }

        private void PanelMoveDoanhThu()
        {
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnDoanhThu.Height;
            this.pnlMove.Top = this.btnDoanhThu.Top;
        }

        private void pnlChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnlMove_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}