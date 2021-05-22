
namespace GUI_Management
{
    partial class fShift
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.llb_BaoVe = new Guna.UI.WinForms.GunaLinkLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbCa3 = new Guna.UI.WinForms.GunaRadioButton();
            this.rbCa2 = new Guna.UI.WinForms.GunaRadioButton();
            this.rbCa1 = new Guna.UI.WinForms.GunaRadioButton();
            this.llb_SuaXe = new Guna.UI.WinForms.GunaLinkLabel();
            this.llb_RuaXe = new Guna.UI.WinForms.GunaLinkLabel();
            this.llb_NhanVien = new Guna.UI.WinForms.GunaLinkLabel();
            this.listB_BV = new System.Windows.Forms.ListBox();
            this.listB_SX = new System.Windows.Forms.ListBox();
            this.listB_RX = new System.Windows.Forms.ListBox();
            this.listB_NV = new System.Windows.Forms.ListBox();
            this.dtPicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnSche = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(318, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(558, 106);
            this.label1.TabIndex = 7;
            this.label1.Text = "LỊCH LÀM VIỆC";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label2.Location = new System.Drawing.Point(125, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 106);
            this.label2.TabIndex = 8;
            this.label2.Text = "_";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI Light", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label3.Location = new System.Drawing.Point(978, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 106);
            this.label3.TabIndex = 9;
            this.label3.Text = "_";
            // 
            // llb_BaoVe
            // 
            this.llb_BaoVe.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.llb_BaoVe.AutoSize = true;
            this.llb_BaoVe.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_BaoVe.LinkColor = System.Drawing.Color.Black;
            this.llb_BaoVe.Location = new System.Drawing.Point(79, 251);
            this.llb_BaoVe.Name = "llb_BaoVe";
            this.llb_BaoVe.Size = new System.Drawing.Size(133, 28);
            this.llb_BaoVe.TabIndex = 10;
            this.llb_BaoVe.TabStop = true;
            this.llb_BaoVe.Text = "Phòng Bảo Vệ";
            this.llb_BaoVe.VisitedLinkColor = System.Drawing.Color.Black;
            this.llb_BaoVe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_BaoVe_LinkClicked);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbCa3);
            this.panel1.Controls.Add(this.rbCa2);
            this.panel1.Controls.Add(this.rbCa1);
            this.panel1.Location = new System.Drawing.Point(503, 178);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(517, 37);
            this.panel1.TabIndex = 11;
            // 
            // rbCa3
            // 
            this.rbCa3.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCa3.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCa3.CheckedOnColor = System.Drawing.Color.White;
            this.rbCa3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbCa3.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCa3.ForeColor = System.Drawing.Color.Black;
            this.rbCa3.Location = new System.Drawing.Point(431, 3);
            this.rbCa3.Name = "rbCa3";
            this.rbCa3.Size = new System.Drawing.Size(83, 28);
            this.rbCa3.TabIndex = 14;
            this.rbCa3.Text = "CA 3";
            // 
            // rbCa2
            // 
            this.rbCa2.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCa2.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCa2.CheckedOnColor = System.Drawing.Color.White;
            this.rbCa2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbCa2.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCa2.ForeColor = System.Drawing.Color.Black;
            this.rbCa2.Location = new System.Drawing.Point(234, 3);
            this.rbCa2.Name = "rbCa2";
            this.rbCa2.Size = new System.Drawing.Size(83, 28);
            this.rbCa2.TabIndex = 13;
            this.rbCa2.Text = "CA 2";
            // 
            // rbCa1
            // 
            this.rbCa1.BaseColor = System.Drawing.SystemColors.Control;
            this.rbCa1.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbCa1.CheckedOnColor = System.Drawing.Color.White;
            this.rbCa1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbCa1.Font = new System.Drawing.Font("Microsoft Yi Baiti", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbCa1.ForeColor = System.Drawing.Color.Black;
            this.rbCa1.Location = new System.Drawing.Point(3, 3);
            this.rbCa1.Name = "rbCa1";
            this.rbCa1.Size = new System.Drawing.Size(83, 28);
            this.rbCa1.TabIndex = 12;
            this.rbCa1.Text = "CA 1";
            // 
            // llb_SuaXe
            // 
            this.llb_SuaXe.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.llb_SuaXe.AutoSize = true;
            this.llb_SuaXe.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_SuaXe.LinkColor = System.Drawing.Color.Black;
            this.llb_SuaXe.Location = new System.Drawing.Point(373, 251);
            this.llb_SuaXe.Name = "llb_SuaXe";
            this.llb_SuaXe.Size = new System.Drawing.Size(131, 28);
            this.llb_SuaXe.TabIndex = 56;
            this.llb_SuaXe.TabStop = true;
            this.llb_SuaXe.Text = "Phòng Sửa Xe";
            this.llb_SuaXe.VisitedLinkColor = System.Drawing.Color.Black;
            this.llb_SuaXe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_SuaXe_LinkClicked);
            // 
            // llb_RuaXe
            // 
            this.llb_RuaXe.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.llb_RuaXe.AutoSize = true;
            this.llb_RuaXe.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_RuaXe.LinkColor = System.Drawing.Color.Black;
            this.llb_RuaXe.Location = new System.Drawing.Point(679, 251);
            this.llb_RuaXe.Name = "llb_RuaXe";
            this.llb_RuaXe.Size = new System.Drawing.Size(132, 28);
            this.llb_RuaXe.TabIndex = 57;
            this.llb_RuaXe.TabStop = true;
            this.llb_RuaXe.Text = "Phòng Rửa Xe";
            this.llb_RuaXe.VisitedLinkColor = System.Drawing.Color.Black;
            this.llb_RuaXe.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_RuaXe_LinkClicked);
            // 
            // llb_NhanVien
            // 
            this.llb_NhanVien.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.llb_NhanVien.AutoSize = true;
            this.llb_NhanVien.Font = new System.Drawing.Font("Segoe UI Semilight", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.llb_NhanVien.LinkColor = System.Drawing.Color.Black;
            this.llb_NhanVien.Location = new System.Drawing.Point(949, 251);
            this.llb_NhanVien.Name = "llb_NhanVien";
            this.llb_NhanVien.Size = new System.Drawing.Size(164, 28);
            this.llb_NhanVien.TabIndex = 58;
            this.llb_NhanVien.TabStop = true;
            this.llb_NhanVien.Text = "Phòng Nhân Viên";
            this.llb_NhanVien.VisitedLinkColor = System.Drawing.Color.Black;
            this.llb_NhanVien.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llb_NhanVien_LinkClicked);
            // 
            // listB_BV
            // 
            this.listB_BV.FormattingEnabled = true;
            this.listB_BV.ItemHeight = 16;
            this.listB_BV.Location = new System.Drawing.Point(12, 303);
            this.listB_BV.Name = "listB_BV";
            this.listB_BV.Size = new System.Drawing.Size(258, 308);
            this.listB_BV.TabIndex = 59;
            // 
            // listB_SX
            // 
            this.listB_SX.FormattingEnabled = true;
            this.listB_SX.ItemHeight = 16;
            this.listB_SX.Location = new System.Drawing.Point(314, 303);
            this.listB_SX.Name = "listB_SX";
            this.listB_SX.Size = new System.Drawing.Size(258, 308);
            this.listB_SX.TabIndex = 60;
            this.listB_SX.Visible = false;
            // 
            // listB_RX
            // 
            this.listB_RX.FormattingEnabled = true;
            this.listB_RX.ItemHeight = 16;
            this.listB_RX.Location = new System.Drawing.Point(618, 303);
            this.listB_RX.Name = "listB_RX";
            this.listB_RX.Size = new System.Drawing.Size(258, 308);
            this.listB_RX.TabIndex = 61;
            this.listB_RX.Visible = false;
            // 
            // listB_NV
            // 
            this.listB_NV.FormattingEnabled = true;
            this.listB_NV.ItemHeight = 16;
            this.listB_NV.Location = new System.Drawing.Point(915, 303);
            this.listB_NV.Name = "listB_NV";
            this.listB_NV.Size = new System.Drawing.Size(258, 308);
            this.listB_NV.TabIndex = 62;
            this.listB_NV.Visible = false;
            // 
            // dtPicker
            // 
            this.dtPicker.BackColor = System.Drawing.Color.Transparent;
            this.dtPicker.BaseColor = System.Drawing.Color.LavenderBlush;
            this.dtPicker.BorderColor = System.Drawing.Color.Crimson;
            this.dtPicker.BorderSize = 3;
            this.dtPicker.CustomFormat = "dddd";
            this.dtPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtPicker.ForeColor = System.Drawing.Color.Black;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(175, 181);
            this.dtPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.OnPressedColor = System.Drawing.Color.Black;
            this.dtPicker.Radius = 5;
            this.dtPicker.Size = new System.Drawing.Size(223, 37);
            this.dtPicker.TabIndex = 63;
            this.dtPicker.Text = "Wednesday";
            this.dtPicker.Value = new System.DateTime(2021, 5, 5, 16, 34, 40, 642);
            // 
            // btnSche
            // 
            this.btnSche.AnimationHoverSpeed = 0.07F;
            this.btnSche.AnimationSpeed = 0.03F;
            this.btnSche.BackColor = System.Drawing.Color.Transparent;
            this.btnSche.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSche.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSche.BorderColor = System.Drawing.Color.Black;
            this.btnSche.BorderSize = 1;
            this.btnSche.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSche.FocusedColor = System.Drawing.Color.Empty;
            this.btnSche.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSche.ForeColor = System.Drawing.Color.Black;
            this.btnSche.Image = null;
            this.btnSche.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSche.Location = new System.Drawing.Point(446, 653);
            this.btnSche.Name = "btnSche";
            this.btnSche.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSche.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnSche.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSche.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnSche.OnHoverImage = null;
            this.btnSche.OnPressedColor = System.Drawing.Color.Black;
            this.btnSche.Radius = 6;
            this.btnSche.Size = new System.Drawing.Size(267, 42);
            this.btnSche.TabIndex = 64;
            this.btnSche.Text = "*   SCHEDULE   *";
            this.btnSche.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSche.Click += new System.EventHandler(this.btnSche_Click);
            // 
            // fShift
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1185, 707);
            this.Controls.Add(this.btnSche);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.listB_NV);
            this.Controls.Add(this.listB_RX);
            this.Controls.Add(this.listB_SX);
            this.Controls.Add(this.listB_BV);
            this.Controls.Add(this.llb_NhanVien);
            this.Controls.Add(this.llb_RuaXe);
            this.Controls.Add(this.llb_SuaXe);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.llb_BaoVe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fShift";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fShift";
            this.Load += new System.EventHandler(this.fShift_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLinkLabel llb_BaoVe;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaRadioButton rbCa3;
        private Guna.UI.WinForms.GunaRadioButton rbCa2;
        private Guna.UI.WinForms.GunaRadioButton rbCa1;
        private Guna.UI.WinForms.GunaLinkLabel llb_SuaXe;
        private Guna.UI.WinForms.GunaLinkLabel llb_RuaXe;
        private Guna.UI.WinForms.GunaLinkLabel llb_NhanVien;
        private System.Windows.Forms.ListBox listB_BV;
        private System.Windows.Forms.ListBox listB_SX;
        private System.Windows.Forms.ListBox listB_RX;
        private System.Windows.Forms.ListBox listB_NV;
        private Guna.UI.WinForms.GunaDateTimePicker dtPicker;
        private Guna.UI.WinForms.GunaGradientButton btnSche;
    }
}