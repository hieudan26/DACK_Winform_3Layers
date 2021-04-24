
namespace GUI_Management
{
    partial class UC_Login
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lLForgotPass = new System.Windows.Forms.LinkLabel();
            this.btnLog = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ImaBtnShowPass = new Guna.UI.WinForms.GunaImageButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.txtPass = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.ImgBtn2 = new Guna.UI.WinForms.GunaImageButton();
            this.ImgBtn1 = new Guna.UI.WinForms.GunaImageButton();
            this.txtPassNew = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtUserNew = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPassCurr = new System.Windows.Forms.TextBox();
            this.txtUserCurr = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(3, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(592, 504);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.tabPage1.Controls.Add(this.panel2);
            this.tabPage1.Controls.Add(this.panel1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(584, 475);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Log In";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnCancel);
            this.panel2.Controls.Add(this.lLForgotPass);
            this.panel2.Controls.Add(this.btnLog);
            this.panel2.Location = new System.Drawing.Point(76, 351);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(435, 91);
            this.panel2.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnCancel.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(29, 18);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(165, 49);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "CANCEL";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lLForgotPass
            // 
            this.lLForgotPass.AutoSize = true;
            this.lLForgotPass.Font = new System.Drawing.Font("Times New Roman", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lLForgotPass.Location = new System.Drawing.Point(156, 71);
            this.lLForgotPass.Name = "lLForgotPass";
            this.lLForgotPass.Size = new System.Drawing.Size(137, 16);
            this.lLForgotPass.TabIndex = 9;
            this.lLForgotPass.TabStop = true;
            this.lLForgotPass.Text = "Forgot your password?";
            this.lLForgotPass.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lLForgotPass_LinkClicked);
            // 
            // btnLog
            // 
            this.btnLog.BackColor = System.Drawing.Color.Honeydew;
            this.btnLog.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLog.Location = new System.Drawing.Point(247, 18);
            this.btnLog.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLog.Name = "btnLog";
            this.btnLog.Size = new System.Drawing.Size(165, 49);
            this.btnLog.TabIndex = 3;
            this.btnLog.Text = "LOG IN";
            this.btnLog.UseVisualStyleBackColor = false;
            this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ImaBtnShowPass);
            this.panel1.Controls.Add(this.radioButton2);
            this.panel1.Controls.Add(this.txtPass);
            this.panel1.Controls.Add(this.radioButton1);
            this.panel1.Controls.Add(this.txtUser);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(6, 93);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(572, 239);
            this.panel1.TabIndex = 13;
            // 
            // ImaBtnShowPass
            // 
            this.ImaBtnShowPass.BackColor = System.Drawing.Color.Black;
            this.ImaBtnShowPass.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImaBtnShowPass.Image = global::GUI_Management.Properties.Resources.eye_real;
            this.ImaBtnShowPass.ImageSize = new System.Drawing.Size(64, 64);
            this.ImaBtnShowPass.Location = new System.Drawing.Point(497, 112);
            this.ImaBtnShowPass.Name = "ImaBtnShowPass";
            this.ImaBtnShowPass.OnHoverImage = null;
            this.ImaBtnShowPass.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImaBtnShowPass.Size = new System.Drawing.Size(52, 22);
            this.ImaBtnShowPass.TabIndex = 12;
            this.ImaBtnShowPass.Click += new System.EventHandler(this.ImaBtnShowPass_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(355, 176);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(68, 21);
            this.radioButton2.TabIndex = 12;
            this.radioButton2.Text = "Admin";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // txtPass
            // 
            this.txtPass.Location = new System.Drawing.Point(219, 114);
            this.txtPass.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPass.Name = "txtPass";
            this.txtPass.Size = new System.Drawing.Size(249, 22);
            this.txtPass.TabIndex = 2;
            this.txtPass.UseSystemPasswordChar = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(131, 176);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 21);
            this.radioButton1.TabIndex = 13;
            this.radioButton1.Text = "User";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // txtUser
            // 
            this.txtUser.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUser.ForeColor = System.Drawing.Color.Silver;
            this.txtUser.Location = new System.Drawing.Point(219, 52);
            this.txtUser.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(249, 22);
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
            this.label3.Location = new System.Drawing.Point(40, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 23);
            this.label3.TabIndex = 1;
            this.label3.Text = "Password: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(40, 49);
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
            this.label1.Location = new System.Drawing.Point(215, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 56);
            this.label1.TabIndex = 12;
            this.label1.Text = "LOG IN";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.tabPage2.Controls.Add(this.panel3);
            this.tabPage2.Controls.Add(this.panel4);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(584, 475);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Change Info";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnConfirm);
            this.panel3.Location = new System.Drawing.Point(81, 350);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(435, 91);
            this.panel3.TabIndex = 19;
            // 
            // btnConfirm
            // 
            this.btnConfirm.BackColor = System.Drawing.Color.Honeydew;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(127, 21);
            this.btnConfirm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(165, 49);
            this.btnConfirm.TabIndex = 3;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.UseVisualStyleBackColor = false;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.ImgBtn2);
            this.panel4.Controls.Add(this.ImgBtn1);
            this.panel4.Controls.Add(this.txtPassNew);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.txtUserNew);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.txtPassCurr);
            this.panel4.Controls.Add(this.txtUserCurr);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Location = new System.Drawing.Point(6, 86);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(572, 242);
            this.panel4.TabIndex = 18;
            // 
            // ImgBtn2
            // 
            this.ImgBtn2.BackColor = System.Drawing.Color.Black;
            this.ImgBtn2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImgBtn2.Image = global::GUI_Management.Properties.Resources.eye_real;
            this.ImgBtn2.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtn2.Location = new System.Drawing.Point(475, 186);
            this.ImgBtn2.Name = "ImgBtn2";
            this.ImgBtn2.OnHoverImage = null;
            this.ImgBtn2.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtn2.Size = new System.Drawing.Size(53, 22);
            this.ImgBtn2.TabIndex = 14;
            this.ImgBtn2.Click += new System.EventHandler(this.ImgBtn2_Click);
            // 
            // ImgBtn1
            // 
            this.ImgBtn1.BackColor = System.Drawing.Color.Black;
            this.ImgBtn1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.ImgBtn1.Image = global::GUI_Management.Properties.Resources.eye_real;
            this.ImgBtn1.ImageSize = new System.Drawing.Size(64, 64);
            this.ImgBtn1.Location = new System.Drawing.Point(475, 141);
            this.ImgBtn1.Name = "ImgBtn1";
            this.ImgBtn1.OnHoverImage = null;
            this.ImgBtn1.OnHoverImageOffset = new System.Drawing.Point(0, 0);
            this.ImgBtn1.Size = new System.Drawing.Size(53, 22);
            this.ImgBtn1.TabIndex = 13;
            this.ImgBtn1.Click += new System.EventHandler(this.ImgBtn1_Click);
            // 
            // txtPassNew
            // 
            this.txtPassNew.Location = new System.Drawing.Point(202, 187);
            this.txtPassNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassNew.Name = "txtPassNew";
            this.txtPassNew.Size = new System.Drawing.Size(219, 22);
            this.txtPassNew.TabIndex = 6;
            this.txtPassNew.UseSystemPasswordChar = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(37, 186);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 23);
            this.label8.TabIndex = 5;
            this.label8.Text = "Password new: ";
            // 
            // txtUserNew
            // 
            this.txtUserNew.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserNew.ForeColor = System.Drawing.Color.Silver;
            this.txtUserNew.Location = new System.Drawing.Point(202, 96);
            this.txtUserNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserNew.Name = "txtUserNew";
            this.txtUserNew.Size = new System.Drawing.Size(219, 22);
            this.txtUserNew.TabIndex = 4;
            this.txtUserNew.Text = "Write your username";
            this.txtUserNew.TextChanged += new System.EventHandler(this.txtUserNew_TextChanged);
            this.txtUserNew.Enter += new System.EventHandler(this.txtUserNew_Enter);
            this.txtUserNew.Leave += new System.EventHandler(this.txtUserNew_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(37, 93);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 23);
            this.label7.TabIndex = 3;
            this.label7.Text = "Username new: ";
            // 
            // txtPassCurr
            // 
            this.txtPassCurr.Location = new System.Drawing.Point(202, 141);
            this.txtPassCurr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPassCurr.Name = "txtPassCurr";
            this.txtPassCurr.Size = new System.Drawing.Size(219, 22);
            this.txtPassCurr.TabIndex = 2;
            this.txtPassCurr.UseSystemPasswordChar = true;
            // 
            // txtUserCurr
            // 
            this.txtUserCurr.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserCurr.ForeColor = System.Drawing.Color.Silver;
            this.txtUserCurr.Location = new System.Drawing.Point(202, 46);
            this.txtUserCurr.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtUserCurr.Name = "txtUserCurr";
            this.txtUserCurr.Size = new System.Drawing.Size(219, 22);
            this.txtUserCurr.TabIndex = 1;
            this.txtUserCurr.Text = "Write your username";
            this.txtUserCurr.TextChanged += new System.EventHandler(this.txtUserCurr_TextChanged);
            this.txtUserCurr.Enter += new System.EventHandler(this.txtUserCurr_Enter);
            this.txtUserCurr.Leave += new System.EventHandler(this.txtUserCurr_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(142, 23);
            this.label4.TabIndex = 1;
            this.label4.Text = "Password curr: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(37, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(147, 23);
            this.label5.TabIndex = 0;
            this.label5.Text = "Username curr: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tempus Sans ITC", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Crimson;
            this.label6.Location = new System.Drawing.Point(123, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(330, 56);
            this.label6.TabIndex = 17;
            this.label6.Text = "CHANGE INFO";
            // 
            // UC_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.Controls.Add(this.tabControl1);
            this.Name = "UC_Login";
            this.Size = new System.Drawing.Size(598, 520);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lLForgotPass;
        private System.Windows.Forms.Button btnLog;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaImageButton ImaBtnShowPass;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.TextBox txtPass;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.Panel panel4;
        private Guna.UI.WinForms.GunaImageButton ImgBtn2;
        private Guna.UI.WinForms.GunaImageButton ImgBtn1;
        private System.Windows.Forms.TextBox txtPassNew;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtUserNew;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPassCurr;
        private System.Windows.Forms.TextBox txtUserCurr;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}
