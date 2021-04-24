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
    public partial class UC_Signin : UserControl
    {
        AccountBUS accBUS = new AccountBUS();
        Form1 f;
        public UC_Signin()
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

        private void ImgBtn1_Click(object sender, EventArgs e)
        {
            if (this.txtPass.UseSystemPasswordChar == true)
            {
                this.ImgBtn1.BackColor = Color.Empty;
                this.txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                this.ImgBtn1.BackColor = Color.Black;
                this.txtPass.UseSystemPasswordChar = true;
            }
        }

        private void ImgBtn2_Click(object sender, EventArgs e)
        {
            if (this.txtConfirmPass.UseSystemPasswordChar == true)
            {
                this.ImgBtn2.BackColor = Color.Empty;
                this.txtConfirmPass.UseSystemPasswordChar = false;
            }
            else
            {
                this.ImgBtn2.BackColor = Color.Black;
                this.txtConfirmPass.UseSystemPasswordChar = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            f.btnSignIn.BaseColor1 = Color.LightPink;
            f.btnSignIn.BaseColor2 = Color.LightBlue;
            f.btnSignIn.BorderColor = Color.White;
            f.btnSignIn.ForeColor = Color.White;
            this.txtUser.Text = "";
            this.txtPass.Text = "";
            this.txtConfirmPass.Text = "";
            this.Captcha.Checked = false;
        }

        private void born_captcha()
        {
            Random rd = new Random();
            int num = rd.Next(6, 8);
            string capt = "";
            int totl = 0;
            do
            {
                int chr = rd.Next(48, 123);
                if ((chr >= 48 && chr <= 57) || (chr >= 65 && chr <= 90) || (chr >= 97 && chr <= 122))
                {
                    capt = capt + (char)chr;
                    totl++;
                    if (totl == num)
                        break;
                }
            } while (true);
            this.lbCaptcha.Text = capt; 
        }

        private void btnSign_Click(object sender, EventArgs e)
        {
            AccountDTO acc = new AccountDTO(0, this.txtUser.Text, this.txtPass.Text);
            try
            {
                if (!accBUS.verifyAccount(acc))
                {
                    throw new Exception("Account already exists !! please try again");
                }    
                else
                {
                    if (this.Captcha.Checked == false)
                    {
                        MessageBox.Show("Robot ", "Register", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        this.txtUser.Text = "";
                        this.txtPass.Text = "";
                        this.txtConfirmPass.Text = "";
                        this.txtUser.Focus();
                    }
                    else
                    {
                        if (this.lbCaptcha.Text == this.txtCaptcha.Text)
                        {
                            if (!accBUS.insertAccount(acc))
                            {
                                this.txtUser.Text = "";
                                this.txtPass.Text = "";
                                this.txtConfirmPass.Text = "";
                                this.txtUser.Focus();
                                MessageBox.Show("Wrong format Password!!");
                            }
                            else
                            {
                                MessageBox.Show("Successfully!!");
                            }
                        }    
                        else
                        {
                            MessageBox.Show("Captcha is incorrect !!", "SIGN UP", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }    
                    }    
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtUser.Text = "";
                this.txtPass.Text = "";
                this.txtConfirmPass.Text = "";
                this.txtUser.Focus();
            }
        }

        public void SetParent(Form1 F)
        {
            this.f = F;
        }

        private void UC_Signup_Load(object sender, EventArgs e)
        {
            this.born_captcha();
        }

        private void btnLoadCapt_Click(object sender, EventArgs e)
        {
            this.born_captcha();
        }
    }
}
