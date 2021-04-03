
namespace GUI_Management
{
    partial class UC_Signin
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Captcha = new Guna.UI.WinForms.GunaCheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImgBtn1 = new Guna.UI.WinForms.GunaImageButton();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ImgBtn2 = new Guna.UI.WinForms.GunaImageButton();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Captcha
            // 
            this.Captcha.BaseColor = System.Drawing.Color.White;
            this.Captcha.CheckedOffColor = System.Drawing.Color.Gray;
            this.Captcha.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.Captcha.FillColor = System.Drawing.Color.White;
            this.Captcha.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Captcha.Location = new System.Drawing.Point(183, 317);
            this.Captcha.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Captcha.Name = "Captcha";
            this.Captcha.Size = new System.Drawing.Size(145, 23);
            this.Captcha.TabIndex = 16;
            this.Captcha.Text = "I\'m not a robot";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnSign);
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Location = new System.Drawing.Point(17, 346);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(451, 91);
            this.panel2.TabIndex = 15;
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.Honeydew;
            this.btnSign.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSign.Location = new System.Drawing.Point(273, 18);
            this.btnSign.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(165, 49);
            this.btnSign.TabIndex = 3;
            this.btnSign.Text = "SIGN IN";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(29, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 49);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImgBtn2);
            this.panel1.Controls.Add(this.ImgBtn1);
            this.panel1.Controls.Add(this.txtConfirmPass);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(17, 105);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(451, 196);
            this.panel1.TabIndex = 14;
            // 
            // ImgBtn1
            // 
            this.ImgBtn1.BackColor = System.Drawing.Color.Black;
            this.ImgBtn1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImgBtn1.Image = global::GUI_Management.Properties.Resources.eye_real;
            this.ImgBtn1.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtn1.Location = new System.Drawing.Point(398, 90);
            this.ImgBtn1.Name = "ImgBtn1";
            this.ImgBtn1.OnHoverImage = null;
            this.ImgBtn1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtn1.Size = new System.Drawing.Size(50, 23);
            this.ImgBtn1.TabIndex = 15;
            this.ImgBtn1.Click += new System.EventHandler(this.ImgBtn1_Click);
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Location = new System.Drawing.Point(187, 153);
            this.txtConfirmPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(206, 22);
            this.txtConfirmPass.TabIndex = 4;
            this.txtConfirmPass.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "Confirm Password: ";
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(187, 91);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(206, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(187, 32);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(206, 22);
            this.txtUser.TabIndex = 1;
            this.txtUser.Text = "Write your username";
            this.txtUser.TextChanged += new System.EventHandler(this.txtUser_TextChanged);
            this.txtUser.Enter += new System.EventHandler(this.txtUser_Enter);
            this.txtUser.Leave += new System.EventHandler(this.txtUser_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "Username: ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(165, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 56);
            this.label1.TabIndex = 13;
            this.label1.Text = "SIGN IN";
            // 
            // ImgBtn2
            // 
            this.ImgBtn2.BackColor = System.Drawing.Color.Black;
            this.ImgBtn2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImgBtn2.Image = global::GUI_Management.Properties.Resources.eye_real;
            this.ImgBtn2.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtn2.Location = new System.Drawing.Point(398, 153);
            this.ImgBtn2.Name = "ImgBtn2";
            this.ImgBtn2.OnHoverImage = null;
            this.ImgBtn2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtn2.Size = new System.Drawing.Size(50, 23);
            this.ImgBtn2.TabIndex = 16;
            this.ImgBtn2.Click += new System.EventHandler(this.ImgBtn2_Click);
            // 
            // UC_Signin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.Controls.Add(this.Captcha);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Name = "UC_Signin";
            this.Size = new System.Drawing.Size(485, 459);
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox Captcha;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSign;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton ImgBtn2;
        private Guna.UI.WinForms.GunaImageButton ImgBtn1;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
