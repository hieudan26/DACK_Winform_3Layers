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
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void fMain_Load(object sender, EventArgs e)
        {
            //AthonyducThang
            this.axWindowsMediaPlayer1.URL = @"E:\HK2_21\Lập trình trên Window HK2_21\car washing phineas.mp4";

            //Đan
            //this.axWindowsMediaPlayer1.URL = @"";
        }

        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 0 || Global.GlobalEmployeeType == 5 || Global.GlobalEmployeeType == 1 || Global.GlobalEmployeeType == 2
                || Global.GlobalEmployeeType == 6 || Global.GlobalEmployeeType == 7 || Global.GlobalEmployeeType == 4)///
            {
                fQuanLyXe form = new fQuanLyXe();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 4 || Global.GlobalEmployeeType == 5 || Global.GlobalEmployeeType == 6
                || Global.GlobalEmployeeType == 7 || Global.GlobalEmployeeType == 8)///
            {
                fQuanLyNhanVien form = new fQuanLyNhanVien();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            { 
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
            }    
        }

        private void quảnLýCôngViệcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 4 || Global.GlobalEmployeeType == 5 || Global.GlobalEmployeeType == 6
                || Global.GlobalEmployeeType == 7 || Global.GlobalEmployeeType == 8)
            {
                fQuanLyCongViec form = new fQuanLyCongViec();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thêmKháchHàngToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 3 || Global.GlobalEmployeeType == 8 || Global.GlobalEmployeeType == 4)
            {
                faddKhach form = new faddKhach(0);
                form.Text = "Khách Thuê Xe Form";
                this.Hide();
                form.ShowDialog();
                this.Show();
            }    
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void thêmKháchHàngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 3 || Global.GlobalEmployeeType == 8 || Global.GlobalEmployeeType == 4)
            {
                faddKhach form = new faddKhach(1);
                form.Text = "Khách Cho Thuê Xe Form";
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void làmHợpĐồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 3 || Global.GlobalEmployeeType == 8 || Global.GlobalEmployeeType == 4)
            {
                flienKetVehicle form = new flienKetVehicle();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void thanhToánHợpĐồngToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (Global.GlobalEmployeeType == 3 || Global.GlobalEmployeeType == 8 || Global.GlobalEmployeeType == 4)
            {
                flamHopDongChoThue form = new flamHopDongChoThue();
                this.Hide();
                form.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Bạn không có quyền hạn này", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void vehicleManagemenyToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void liencesManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýHợpĐồngToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
