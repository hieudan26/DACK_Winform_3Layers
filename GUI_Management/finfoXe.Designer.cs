
namespace GUI_Management
{
    partial class finfoXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(finfoXe));
            this.label1 = new System.Windows.Forms.Label();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.lbHinh1 = new System.Windows.Forms.Label();
            this.lbHinh2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtID = new Guna.UI.WinForms.GunaTextBox();
            this.txtLoaiXe = new Guna.UI.WinForms.GunaTextBox();
            this.txtTongTien = new Guna.UI.WinForms.GunaTextBox();
            this.pBHinh1 = new System.Windows.Forms.PictureBox();
            this.pBHinh2 = new System.Windows.Forms.PictureBox();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.pBHinh1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHinh2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(85, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(607, 95);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thông Tin Chi Tiết Xe";
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(800, 14);
            this.gunaGradientPanel1.TabIndex = 6;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            this.gunaGradientPanel1.Click += new System.EventHandler(this.gunaGradientPanel1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(12, 179);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 23);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID Xe:";
            // 
            // lbHinh1
            // 
            this.lbHinh1.AutoSize = true;
            this.lbHinh1.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinh1.ForeColor = System.Drawing.Color.Black;
            this.lbHinh1.Location = new System.Drawing.Point(383, 167);
            this.lbHinh1.Name = "lbHinh1";
            this.lbHinh1.Size = new System.Drawing.Size(73, 23);
            this.lbHinh1.TabIndex = 8;
            this.lbHinh1.Text = "Hình 1:";
            this.lbHinh1.Click += new System.EventHandler(this.label3_Click);
            // 
            // lbHinh2
            // 
            this.lbHinh2.AutoSize = true;
            this.lbHinh2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbHinh2.ForeColor = System.Drawing.Color.Black;
            this.lbHinh2.Location = new System.Drawing.Point(383, 320);
            this.lbHinh2.Name = "lbHinh2";
            this.lbHinh2.Size = new System.Drawing.Size(73, 23);
            this.lbHinh2.TabIndex = 9;
            this.lbHinh2.Text = "Hình 2:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(12, 397);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(175, 23);
            this.label5.TabIndex = 10;
            this.label5.Text = "Tổng Tiền Dịch Vụ:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(12, 289);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 23);
            this.label6.TabIndex = 11;
            this.label6.Text = "Loại Xe:";
            // 
            // txtID
            // 
            this.txtID.BaseColor = System.Drawing.Color.White;
            this.txtID.BorderColor = System.Drawing.Color.Silver;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedBaseColor = System.Drawing.Color.White;
            this.txtID.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtID.Location = new System.Drawing.Point(141, 179);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(101, 32);
            this.txtID.TabIndex = 12;
            // 
            // txtLoaiXe
            // 
            this.txtLoaiXe.BaseColor = System.Drawing.Color.White;
            this.txtLoaiXe.BorderColor = System.Drawing.Color.Silver;
            this.txtLoaiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoaiXe.FocusedBaseColor = System.Drawing.Color.White;
            this.txtLoaiXe.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLoaiXe.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtLoaiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtLoaiXe.Location = new System.Drawing.Point(141, 289);
            this.txtLoaiXe.Name = "txtLoaiXe";
            this.txtLoaiXe.PasswordChar = '\0';
            this.txtLoaiXe.SelectedText = "";
            this.txtLoaiXe.Size = new System.Drawing.Size(101, 32);
            this.txtLoaiXe.TabIndex = 13;
            // 
            // txtTongTien
            // 
            this.txtTongTien.BaseColor = System.Drawing.Color.White;
            this.txtTongTien.BorderColor = System.Drawing.Color.Silver;
            this.txtTongTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongTien.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTongTien.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTongTien.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTongTien.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongTien.Location = new System.Drawing.Point(208, 397);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.PasswordChar = '\0';
            this.txtTongTien.SelectedText = "";
            this.txtTongTien.Size = new System.Drawing.Size(101, 32);
            this.txtTongTien.TabIndex = 14;
            // 
            // pBHinh1
            // 
            this.pBHinh1.Location = new System.Drawing.Point(565, 131);
            this.pBHinh1.Name = "pBHinh1";
            this.pBHinh1.Size = new System.Drawing.Size(159, 91);
            this.pBHinh1.TabIndex = 15;
            this.pBHinh1.TabStop = false;
            // 
            // pBHinh2
            // 
            this.pBHinh2.Location = new System.Drawing.Point(565, 272);
            this.pBHinh2.Name = "pBHinh2";
            this.pBHinh2.Size = new System.Drawing.Size(159, 113);
            this.pBHinh2.TabIndex = 16;
            this.pBHinh2.TabStop = false;
            // 
            // btnBack
            // 
            this.btnBack.AnimationHoverSpeed = 0.07F;
            this.btnBack.AnimationSpeed = 0.03F;
            this.btnBack.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btnBack.BorderColor = System.Drawing.Color.Black;
            this.btnBack.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnBack.FocusedColor = System.Drawing.Color.Empty;
            this.btnBack.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.ForeColor = System.Drawing.Color.Black;
            this.btnBack.Image = null;
            this.btnBack.ImageSize = new System.Drawing.Size(20, 20);
            this.btnBack.Location = new System.Drawing.Point(668, 418);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Black;
            this.btnBack.Size = new System.Drawing.Size(56, 20);
            this.btnBack.TabIndex = 21;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // finfoXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.pBHinh2);
            this.Controls.Add(this.pBHinh1);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtLoaiXe);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbHinh2);
            this.Controls.Add(this.lbHinh1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "finfoXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "finfoXe";
            this.Load += new System.EventHandler(this.finfoXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pBHinh1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pBHinh2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label lbHinh1;
        public System.Windows.Forms.Label lbHinh2;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public Guna.UI.WinForms.GunaTextBox txtID;
        public Guna.UI.WinForms.GunaTextBox txtLoaiXe;
        public Guna.UI.WinForms.GunaTextBox txtTongTien;
        public System.Windows.Forms.PictureBox pBHinh1;
        public System.Windows.Forms.PictureBox pBHinh2;
        private Guna.UI.WinForms.GunaButton btnBack;
    }
}