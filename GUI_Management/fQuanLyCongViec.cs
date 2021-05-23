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
    public partial class fQuanLyCongViec : Form
    {
        private Form activeForm = null;

        public fQuanLyCongViec()
        {
            InitializeComponent();
        }

        //EXIT
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
        }
        //End EXIT

        //open child form
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
        //end open child form

        private void btnPhiSuaXe_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fEdit_phiSuaXe());
        }

        private void gunaGradientButton2_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fEdit_dichVuSuaXe());
        }

        private void gunaGradientButton3_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fEdit_phiRuaXe());
        }

        private void btnSalary_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fEdit_SalaryPerHour());
        }
    }
}
