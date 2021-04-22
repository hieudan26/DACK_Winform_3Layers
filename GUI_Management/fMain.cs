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
            fQuanLyXe form = new fQuanLyXe();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }

        private void jobsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void quảnLýNhânViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            fQuanLyNhanVien form = new fQuanLyNhanVien();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
