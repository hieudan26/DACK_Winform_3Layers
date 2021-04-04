
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
            this.gunaShadowPanel1 = new Guna.UI.WinForms.GunaShadowPanel();
            this.btnExit = new Guna.UI.WinForms.GunaButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSignIn = new Guna.UI.WinForms.GunaGradientButton();
            this.btnLogIn = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLinkLabel1 = new Guna.UI.WinForms.GunaLinkLabel();
            this.gunaPictureBox1 = new Guna.UI.WinForms.GunaPictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaDateTimePicker1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.uC_Intro1 = new GUI_Management.UC_Intro();
            this.uC_Signin1 = new GUI_Management.UC_Signin();
            this.uC_Login1 = new GUI_Management.UC_Login();
            this.gunaShadowPanel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).BeginInit();
            this.gunaPanel1.SuspendLayout();
            this.gunaPanel2.SuspendLayout();
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
            // gunaShadowPanel1
            // 
            this.gunaShadowPanel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaShadowPanel1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaShadowPanel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.gunaShadowPanel1.Controls.Add(this.btnExit);
            this.gunaShadowPanel1.Controls.Add(this.panel3);
            this.gunaShadowPanel1.Controls.Add(this.gunaLinkLabel1);
            this.gunaShadowPanel1.Controls.Add(this.gunaPictureBox1);
            this.gunaShadowPanel1.Controls.Add(this.label1);
            this.gunaShadowPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.gunaShadowPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaShadowPanel1.Name = "gunaShadowPanel1";
            this.gunaShadowPanel1.Radius = 3;
            this.gunaShadowPanel1.ShadowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.gunaShadowPanel1.ShadowDepth = 50;
            this.gunaShadowPanel1.ShadowStyle = Guna.UI.WinForms.ShadowMode.Dropped;
            this.gunaShadowPanel1.Size = new System.Drawing.Size(333, 521);
            this.gunaShadowPanel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.AnimationHoverSpeed = 0.07F;
            this.btnExit.AnimationSpeed = 0.03F;
            this.btnExit.BaseColor = System.Drawing.Color.DarkGray;
            this.btnExit.BorderColor = System.Drawing.Color.White;
            this.btnExit.BorderSize = 1;
            this.btnExit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnExit.FocusedColor = System.Drawing.Color.Empty;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Black;
            this.btnExit.Image = null;
            this.btnExit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnExit.Location = new System.Drawing.Point(13, 387);
            this.btnExit.Name = "btnExit";
            this.btnExit.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnExit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnExit.OnHoverImage = null;
            this.btnExit.OnPressedColor = System.Drawing.Color.Black;
            this.btnExit.Size = new System.Drawing.Size(57, 31);
            this.btnExit.TabIndex = 22;
            this.btnExit.Text = "X";
            this.btnExit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.panel3.Controls.Add(this.btnSignIn);
            this.panel3.Controls.Add(this.btnLogIn);
            this.panel3.Location = new System.Drawing.Point(132, 298);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 197);
            this.panel3.TabIndex = 21;
            // 
            // btnSignIn
            // 
            this.btnSignIn.AccessibleRole = System.Windows.Forms.AccessibleRole.RadioButton;
            this.btnSignIn.AnimationHoverSpeed = 0.07F;
            this.btnSignIn.AnimationSpeed = 0.03F;
            this.btnSignIn.BackColor = System.Drawing.Color.Transparent;
            this.btnSignIn.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignIn.BaseColor2 = System.Drawing.Color.LightBlue;
            this.btnSignIn.BorderColor = System.Drawing.Color.White;
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
            this.btnSignIn.OnHoverBaseColor1 = System.Drawing.Color.LightBlue;
            this.btnSignIn.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSignIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSignIn.OnHoverForeColor = System.Drawing.Color.Black;
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
            this.btnLogIn.BaseColor1 = System.Drawing.Color.Magenta;
            this.btnLogIn.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.BorderColor = System.Drawing.Color.White;
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
            this.btnLogIn.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnLogIn.OnHoverBaseColor2 = System.Drawing.Color.Magenta;
            this.btnLogIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnLogIn.OnHoverForeColor = System.Drawing.Color.Black;
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
            this.gunaLinkLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaLinkLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(9)))), ((int)(((byte)(132)))), ((int)(((byte)(227)))));
            this.gunaLinkLabel1.Location = new System.Drawing.Point(19, 464);
            this.gunaLinkLabel1.Name = "gunaLinkLabel1";
            this.gunaLinkLabel1.Size = new System.Drawing.Size(47, 18);
            this.gunaLinkLabel1.TabIndex = 20;
            this.gunaLinkLabel1.TabStop = true;
            this.gunaLinkLabel1.Text = "Help?";
            this.gunaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.gunaLinkLabel1_LinkClicked);
            // 
            // gunaPictureBox1
            // 
            this.gunaPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaPictureBox1.BaseColor = System.Drawing.Color.White;
            this.gunaPictureBox1.Image = global::GUI_Management.Properties.Resources.car;
            this.gunaPictureBox1.Location = new System.Drawing.Point(51, 25);
            this.gunaPictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaPictureBox1.Name = "gunaPictureBox1";
            this.gunaPictureBox1.Size = new System.Drawing.Size(235, 158);
            this.gunaPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaPictureBox1.TabIndex = 18;
            this.gunaPictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Font = new System.Drawing.Font("Tempus Sans ITC", 33F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.label1.Location = new System.Drawing.Point(10, 202);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 72);
            this.label1.TabIndex = 17;
            this.label1.Text = "WELCOME";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.gunaPanel1.Controls.Add(this.gunaDateTimePicker1);
            this.gunaPanel1.Controls.Add(this.gunaPanel2);
            this.gunaPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaPanel1.Location = new System.Drawing.Point(333, 0);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(503, 521);
            this.gunaPanel1.TabIndex = 6;
            // 
            // gunaDateTimePicker1
            // 
            this.gunaDateTimePicker1.BackColor = System.Drawing.Color.Transparent;
            this.gunaDateTimePicker1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(218)))), ((int)(((byte)(226)))));
            this.gunaDateTimePicker1.BorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.CustomFormat = "hh:mm:ss";
            this.gunaDateTimePicker1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.gunaDateTimePicker1.FocusedColor = System.Drawing.Color.Gray;
            this.gunaDateTimePicker1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaDateTimePicker1.ForeColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.gunaDateTimePicker1.Location = new System.Drawing.Point(184, 21);
            this.gunaDateTimePicker1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.gunaDateTimePicker1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.gunaDateTimePicker1.Name = "gunaDateTimePicker1";
            this.gunaDateTimePicker1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaDateTimePicker1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaDateTimePicker1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaDateTimePicker1.Radius = 7;
            this.gunaDateTimePicker1.Size = new System.Drawing.Size(162, 30);
            this.gunaDateTimePicker1.TabIndex = 1;
            this.gunaDateTimePicker1.Text = "11:12:24 AM";
            this.gunaDateTimePicker1.Value = new System.DateTime(2021, 4, 3, 11, 12, 24, 0);
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.Controls.Add(this.uC_Intro1);
            this.gunaPanel2.Controls.Add(this.uC_Signin1);
            this.gunaPanel2.Controls.Add(this.uC_Login1);
            this.gunaPanel2.Location = new System.Drawing.Point(18, 57);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(462, 426);
            this.gunaPanel2.TabIndex = 0;
            // 
            // uC_Intro1
            // 
            this.uC_Intro1.Location = new System.Drawing.Point(-15, -4);
            this.uC_Intro1.Name = "uC_Intro1";
            this.uC_Intro1.Size = new System.Drawing.Size(519, 431);
            this.uC_Intro1.TabIndex = 2;
            // 
            // uC_Signin1
            // 
            this.uC_Signin1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(230)))), ((int)(((byte)(233)))));
            this.uC_Signin1.Location = new System.Drawing.Point(-18, 0);
            this.uC_Signin1.Name = "uC_Signin1";
            this.uC_Signin1.Size = new System.Drawing.Size(500, 437);
            this.uC_Signin1.TabIndex = 1;
            this.uC_Signin1.Load += new System.EventHandler(this.uC_Signin1_Load);
            // 
            // uC_Login1
            // 
            this.uC_Login1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(110)))), ((int)(((byte)(114)))));
            this.uC_Login1.Location = new System.Drawing.Point(-2, 0);
            this.uC_Login1.Name = "uC_Login1";
            this.uC_Login1.Size = new System.Drawing.Size(484, 450);
            this.uC_Login1.TabIndex = 0;
            this.uC_Login1.Load += new System.EventHandler(this.uC_Login1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(184)))), ((int)(((byte)(148)))));
            this.ClientSize = new System.Drawing.Size(836, 521);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaShadowPanel1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.gunaShadowPanel1.ResumeLayout(false);
            this.gunaShadowPanel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gunaPictureBox1)).EndInit();
            this.gunaPanel1.ResumeLayout(false);
            this.gunaPanel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI.WinForms.GunaShadowPanel gunaShadowPanel1;
        private System.Windows.Forms.Panel panel3;
        public Guna.UI.WinForms.GunaGradientButton btnSignIn;
        public Guna.UI.WinForms.GunaGradientButton btnLogIn;
        private Guna.UI.WinForms.GunaLinkLabel gunaLinkLabel1;
        private Guna.UI.WinForms.GunaPictureBox gunaPictureBox1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaButton btnExit;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaDateTimePicker gunaDateTimePicker1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private UC_Intro uC_Intro1;
        private UC_Signin uC_Signin1;
        private UC_Login uC_Login1;
    }
}

