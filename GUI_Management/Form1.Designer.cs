
namespace GUI_Management
{
    partial class Form1
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSignIn = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLogIn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.btnExit = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.uC_Intro1 = new GUI_Management.UC_Intro();
            this.uC_Login1 = new GUI_Management.UC_Login();
            this.uC_Signin1 = new GUI_Management.UC_Signin();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(0, 521);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.gunaLinkLabel1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.gunaPictureBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 521);
            this.panel1.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSignIn);
            this.panel3.Controls.Add(this.btnLogIn);
            this.panel3.Location = new System.Drawing.Point(151, 294);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 16;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignIn.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnSignIn.BorderColor = System.Drawing.Color.Black;
            this.btnSignIn.BorderSize = 1;
            this.btnSignIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSignIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnSignIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignIn.ForeColor = System.Drawing.Color.White;
            this.btnSignIn.Image = global::GUI_Management.Properties.Resources.iconkeyreal;
            this.btnSignIn.ImageSize = new System.Drawing.Size(45, 22);
            this.btnSignIn.Location = new System.Drawing.Point(21, 121);
            this.btnSignIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSignIn.Name = "btnSignIn";
            this.btnSignIn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnSignIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSignIn.OnHoverImage = null;
            this.btnSignIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnSignIn.Radius = 25;
            this.btnSignIn.Size = new System.Drawing.Size(233, 62);
            this.btnSignIn.TabIndex = 5;
            this.btnSignIn.Text = "SIGN IN";
            this.btnSignIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSignIn.Click += new System.EventHandler(this.btnSignIn_Click);
            // 
            // btnLogIn
            // 
            this.btnLogIn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnLogIn.AnimationHoverSpeed = 0.07F;
            this.btnLogIn.AnimationSpeed = 0.03F;
            this.btnLogIn.BackColor = System.Drawing.Color.Transparent;
            this.btnLogIn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnLogIn.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.BorderColor = System.Drawing.Color.Black;
            this.btnLogIn.BorderSize = 1;
            this.btnLogIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnLogIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnLogIn.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogIn.ForeColor = System.Drawing.Color.White;
            this.btnLogIn.Image = global::GUI_Management.Properties.Resources.iconlogin;
            this.btnLogIn.ImageOffsetX = 10;
            this.btnLogIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnLogIn.Location = new System.Drawing.Point(21, 21);
            this.btnLogIn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnLogIn.Name = "btnLogIn";
            this.btnLogIn.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnLogIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnLogIn.OnHoverImage = null;
            this.btnLogIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnLogIn.Radius = 25;
            this.btnLogIn.Size = new System.Drawing.Size(233, 62);
            this.btnLogIn.TabIndex = 4;
            this.btnLogIn.Text = "LOG IN";
            this.btnLogIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnLogIn.Click += new System.EventHandler(this.btnLogIn_Click);
            // 
            // gunaLinkLabel1
            // 
            this.gunaLinkLabel1.AutoSize = true;
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(13, 460);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(46, 17);
            this.gunaLinkLabel1.TabIndex = 15;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Help?";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.btnExit.BaseColor2 = System.Drawing.Color.Gray;
            this.btnExit.BorderColor = System.Drawing.Color.Black;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.White;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(-18, 363);
            this.btnExit.Margin = new System.Windows.Forms.Padding(0);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.btnExit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Radius = 20;
            this.btnExit.Size = new System.Drawing.Size(121, 50);
            this.btnExit.TabIndex = 14;
            this.btnExit.Text = "EXIT";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::GUI_Management.Properties.Resources.car;
            this.gunaPictureBox1.Location = new System.Drawing.Point(47, 21);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(235, 158);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 13;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 34.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 204);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(322, 76);
            this.label1.TabIndex = 12;
            this.label1.Text = "WELCOME";
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.PeachPuff;
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Silver;
            this.gunaDateTimePicker1.CustomFormat = null;
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(511, 11);
            this.gunaDateTimePicker1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.White;
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 10;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(156, 30);
            this.gunaDateTimePicker1.TabIndex = 3;
            this.gunaDateTimePicker1.Text = "8:27:56 AM";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 3, 16, 8, 27, 56, 351);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.uC_Intro1);
            this.panel2.Controls.Add(this.uC_Login1);
            this.panel2.Controls.Add(this.uC_Signin1);
            this.panel2.Location = new System.Drawing.Point(366, 59);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(441, 419);
            this.panel2.TabIndex = 4;
            // 
            // uC_Intro1
            // 
            this.uC_Intro1.Location = new System.Drawing.Point(-27, -13);
            this.uC_Intro1.Name = "uC_Intro1";
            this.uC_Intro1.Size = new System.Drawing.Size(544, 452);
            this.uC_Intro1.TabIndex = 2;
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.PeachPuff;
            this.uC_Login1.Location = new System.Drawing.Point(-9, 0);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(450, 432);
            this.uC_Login1.TabIndex = 1;
            this.uC_Login1.Load += new System.EventHandler(this.uC_Login1_Load);
            // 
            // uC_Signin1
            // 
            this.uC_Signin1.BackColor = System.Drawing.Color.LavenderBlush;
            this.uC_Signin1.Location = new System.Drawing.Point(-27, -13);
            this.uC_Signin1.Name = "uC_Signin1";
            this.uC_Signin1.Size = new System.Drawing.Size(485, 463);
            this.uC_Signin1.TabIndex = 0;
            this.uC_Signin1.Load += new System.EventHandler(this.uC_Signin1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(836, 521);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.gunaDateTimePicker1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        public Guna.UI.WinForms.GunaGradientButton btnSignIn;
        public Guna.UI.WinForms.GunaGradientButton btnLogIn;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaGradientButton btnExit;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private System.Windows.Forms.Panel panel2;
        private UC_Signin uC_Signin1;
        private UC_Intro uC_Intro1;
        private UC_Login uC_Login1;
    }
}

