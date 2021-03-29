using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void gunaLinkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://athonyducthang.ueuo.com/profile.html");
        }

        private void btnLogIn_Click(object sender, EventArgs e)
        {
            this.uC_Login1.Visible = true;
            this.uC_Signin1.Visible = false;
            if (this.btnSignIn.BaseColor1 == Color.DimGray)
            {
                this.btnSignIn.BaseColor1 = Color.LightPink;
                this.btnSignIn.BaseColor2 = Color.LightBlue;
                this.btnSignIn.BorderColor = Color.Black;
            }
            this.uC_Login1.BringToFront();
            this.btnLogIn.BaseColor1 = Color.DimGray;
            this.btnLogIn.BaseColor2 = Color.DimGray;
            this.btnLogIn.BorderSize = 1;
            this.btnLogIn.BorderColor = Color.White;
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.uC_Signin1.Visible = true;
            this.uC_Login1.Visible = false;
            if (this.btnLogIn.BaseColor1 == Color.DimGray)
            {
                this.btnLogIn.BaseColor1 = Color.LightGreen;
                this.btnLogIn.BaseColor2 = Color.DeepSkyBlue;
                this.btnLogIn.BorderColor = Color.Black;
            }
            this.uC_Signin1.BringToFront();
            this.btnSignIn.BaseColor1 = Color.DimGray;
            this.btnSignIn.BaseColor2 = Color.DimGray;
            this.btnSignIn.BorderSize = 1;
            this.btnSignIn.BorderColor = Color.White;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Are you sure ?!?", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) != System.Windows.Forms.DialogResult.OK)
            {
                e.Cancel = true;
            }
        }

        private void uC_Signin1_Load(object sender, EventArgs e)
        {
            this.uC_Signin1.SetParent(this);
        }

        private void uC_Login1_Load(object sender, EventArgs e)
        {
            this.uC_Login1.SetParent(this);
        }
    }
}
