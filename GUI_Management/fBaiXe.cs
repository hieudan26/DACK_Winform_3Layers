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
    public partial class fBaiXe : Form
    {
        fQuanLyXeGui formQuanLyXeGui;

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
    }
}
