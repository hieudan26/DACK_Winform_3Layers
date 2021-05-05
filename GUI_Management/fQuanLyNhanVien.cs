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
    public partial class fQuanLyNhanVien : Form
    {
        

        private Form activeForm = null;
        public fQuanLyNhanVien()
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
        //end EXIT

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

        private void btnAddEmployee_Click(object sender, EventArgs e)
        {
            this.openChildForm(new faddNhanVien());
        }

        private void btnDanhSach_Click(object sender, EventArgs e)
        {
            this.openChildForm(new flistNhanVien(this));
        }

        private void btnInfoNhanVien_Click(object sender, EventArgs e)
        {
            this.openChildForm(new finfoNhanVien());
        }

        //tets
        //shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        //divShiftBUS divShiftBUS = new divShiftBUS();
        private void btnSchedule_Click(object sender, EventArgs e)
        {
            this.openChildForm(new fShift());
        }
    }
}
