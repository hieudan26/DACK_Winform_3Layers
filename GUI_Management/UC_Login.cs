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
    public partial class UC_Login : UserControl
    {
        AccountBUS accBUS = new AccountBUS();
        public UC_Login()
        {
            InitializeComponent();
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "Write your username")
            {
                this.txtUser.Text = "";
                this.txtUser.ForeColor = Color.Black;
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "")
            {
                this.txtUser.Text = "Write your username";
                this.txtUser.ForeColor = Color.Silver;
            }
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUser.Text != "Write your username")
            {
                this.txtUser.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUser.ForeColor = Color.Black;
            }
            else
            {
                this.txtUser.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUser.ForeColor = Color.Silver;
            }
        }

        private void btnLog_Click(object sender, EventArgs e)
        {
            if (this.txtUser.Text == "" || this.txtPass.Text == "")
            {
                MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                AccountDTO acc = new AccountDTO(0, this.txtUser.Text, this.txtPass.Text);

                if (this.accBUS.loginAccount(acc))
                {
                    fMain form = new fMain();
                    this.Hide();
                    form.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void txtUserCurr_Enter(object sender, EventArgs e)
        {
            if (this.txtUserCurr.Text == "Write your username")
            {
                this.txtUserCurr.Text = "";
                this.txtUserCurr.ForeColor = Color.Black;
            }
        }

        private void txtUserCurr_Leave(object sender, EventArgs e)
        {
            if (this.txtUserCurr.Text == "")
            {
                this.txtUserCurr.Text = "Write your username";
                this.txtUserCurr.ForeColor = Color.Silver;
            }
        }

        private void txtUserCurr_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUserCurr.Text != "Write your username")
            {
                this.txtUserCurr.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUserCurr.ForeColor = Color.Black;
            }
            else
            {
                this.txtUserCurr.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUserCurr.ForeColor = Color.Silver;
            }
        }

        private void txtUserNew_Leave(object sender, EventArgs e)
        {
            if (this.txtUserNew.Text == "")
            {
                this.txtUserNew.Text = "Write your username";
                this.txtUserNew.ForeColor = Color.Silver;
            }
        }

        private void txtUserNew_Enter(object sender, EventArgs e)
        {
            if (this.txtUserNew.Text == "Write your username")
            {
                this.txtUserNew.Text = "";
                this.txtUserNew.ForeColor = Color.Black;
            }
        }

        private void txtUserNew_TextChanged(object sender, EventArgs e)
        {
            if (this.txtUserNew.Text != "Write your username")
            {
                this.txtUserNew.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUserNew.ForeColor = Color.Black;
            }
            else
            {
                this.txtUserNew.Font = new System.Drawing.Font("Times New Roman", 8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                this.txtUserNew.ForeColor = Color.Silver;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.txtPass.Text = "";
            this.txtUser.Text = "";
            this.txtUserCurr.Text = "";
            this.txtUserNew.Text = "";
            this.txtPassNew.Text = "";
            this.txtPassCurr.Text = "";
            this.Visible = false;
            f.btnLogIn.BaseColor1 = Color.Magenta;
            f.btnLogIn.BaseColor2 = Color.DeepSkyBlue;
            f.btnLogIn.BorderColor = Color.White;
            f.btnLogIn.ForeColor = Color.White;
        }

        Form1 f;
        
        public void SetParent(Form1 F)
        {
            this.f = F;
        }

        private void ImaBtnShowPass_Click(object sender, EventArgs e)
        {
            if (this.txtPass.UseSystemPasswordChar == true)
            {
                this.ImaBtnShowPass.BackColor = Color.Empty;
                this.txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                this.ImaBtnShowPass.BackColor = Color.Black;
                this.txtPass.UseSystemPasswordChar = true;
            }
        }

        private void ImgBtn1_Click(object sender, EventArgs e)
        {
            if (this.txtPassCurr.UseSystemPasswordChar == true)
            {
                this.ImgBtn1.BackColor = Color.Empty;
                this.txtPassCurr.UseSystemPasswordChar = false;
            }
            else
            {
                this.ImgBtn1.BackColor = Color.Black;
                this.txtPassCurr.UseSystemPasswordChar = true;
            }
        }

        private void ImgBtn2_Click(object sender, EventArgs e)
        {
            if (this.txtPassNew.UseSystemPasswordChar == true)
            {
                this.ImgBtn2.BackColor = Color.Empty;
                this.txtPassNew.UseSystemPasswordChar = false;
            }
            else
            {
                this.ImgBtn2.BackColor = Color.Black;
                this.txtPassNew.UseSystemPasswordChar = true;
            }
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            AccountDTO accold = new AccountDTO(0, this.txtUserCurr.Text, this.txtPassCurr.Text);
            AccountDTO accnew = new AccountDTO(0, this.txtUserNew.Text, this.txtPassNew.Text);

            if (accBUS.changeInfoAccount(accold, accnew))
            {
                MessageBox.Show("Successfully");
            }
            else
                MessageBox.Show("Unsuccessfully!! Maybe account not exists");
        }

        private void lLForgotPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AccountDTO acc = new AccountDTO(0, this.txtUser.Text, this.txtPass.Text);
            string tmp = accBUS.forgotPassword(acc);
            if (tmp != "")
            {
                MessageBox.Show("Don't forget your password anymore: \n=> Your pass: " + tmp, "Account usename", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
            else if (tmp == "" || this.txtUser.Text == "")
            {
                MessageBox.Show("Account not exist", "Account usename", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }    
        }
    }
}
