﻿using System;
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
    public partial class fQuanLyXeGui : Form
    {
        public fQuanLyXeGui()
        {
            InitializeComponent();
        }

        private void btnGuiXe_Click(object sender, EventArgs e)
        {
            //panel Move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnGuiXe.Height;
            this.pnlMove.Top = this.btnGuiXe.Top;
            //end panel move

            //border change color
            this.btnGuiXe.BorderColor = Color.Black;
            this.btnBaiXe.BorderColor = Color.White;
            this.btnDoanhThu.BorderColor = Color.White;
            //end

            this.openChildForm(new fGuiXe(this));
        }

        //private void btnPhiGui_Click(object sender, EventArgs e)
        //{
        //    //panel move
        //    this.pnlMove.Visible = true;
        //    this.pnlMove.Height = this.btnPhiGui.Height;
        //    this.pnlMove.Top = this.btnPhiGui.Top;
        //    //end panel move

        //    this.openChildForm(new fphiGui());
        //}

        private void btnBaiXe_Click(object sender, EventArgs e)
        {
            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnBaiXe.Height;
            this.pnlMove.Top = this.btnBaiXe.Top;
            //end panel move

            //border change color
            this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.Black;
            this.btnDoanhThu.BorderColor = Color.White;
            //end

            this.openChildForm(new fBaiXe(this));
        }

        private void btnDoanhThu_Click(object sender, EventArgs e)
        {
            //panel move
            this.pnlMove.Visible = true;
            this.pnlMove.Height = this.btnDoanhThu.Height;
            this.pnlMove.Top = this.btnDoanhThu.Top;
            //end panel move

            //border change color
            this.btnGuiXe.BorderColor = Color.White;
            this.btnBaiXe.BorderColor = Color.White;
            this.btnDoanhThu.BorderColor = Color.Black;
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
    }
}