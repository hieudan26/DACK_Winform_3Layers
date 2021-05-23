
namespace GUI_Management
{
    partial class fQuanLyLuong
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
            this.DGVLuongperhour = new System.Windows.Forms.DataGridView();
            this.cbTxtType = new Guna.UI.WinForms.GunaComboBox();
            this.btnKetToan = new Guna.UI.WinForms.GunaGradientButton();
            this.txtLuong = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.LoaiNVLabel = new Guna.UI.WinForms.GunaLabel();
            this.cbTypeNV = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtID = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtName = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.picBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLuongperhour)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DGVLuongperhour
            // 
            this.DGVLuongperhour.BackgroundColor = System.Drawing.Color.LavenderBlush;
            this.DGVLuongperhour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLuongperhour.Location = new System.Drawing.Point(140, 65);
            this.DGVLuongperhour.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DGVLuongperhour.Name = "DGVLuongperhour";
            this.DGVLuongperhour.RowHeadersWidth = 51;
            this.DGVLuongperhour.Size = new System.Drawing.Size(912, 347);
            this.DGVLuongperhour.TabIndex = 117;
            this.DGVLuongperhour.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVLuongperhour_CellContentClick);
            this.DGVLuongperhour.Click += new System.EventHandler(this.DGVLuongperhour_Click);
            // 
            // cbTxtType
            // 
            this.cbTxtType.BackColor = System.Drawing.Color.White;
            this.cbTxtType.BaseColor = System.Drawing.Color.Transparent;
            this.cbTxtType.BorderColor = System.Drawing.Color.Silver;
            this.cbTxtType.BorderSize = 0;
            this.cbTxtType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTxtType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTxtType.FocusedColor = System.Drawing.Color.Empty;
            this.cbTxtType.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTxtType.ForeColor = System.Drawing.Color.Black;
            this.cbTxtType.FormattingEnabled = true;
            this.cbTxtType.Items.AddRange(new object[] {
            "Bảo Vệ",
            "Thợ Sửa",
            "Thợ Rửa",
            "Nhân Viên"});
            this.cbTxtType.Location = new System.Drawing.Point(936, 475);
            this.cbTxtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTxtType.Name = "cbTxtType";
            this.cbTxtType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTxtType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTxtType.Size = new System.Drawing.Size(237, 32);
            this.cbTxtType.TabIndex = 115;
            // 
            // btnKetToan
            // 
            this.btnKetToan.AnimationHoverSpeed = 0.07F;
            this.btnKetToan.AnimationSpeed = 0.03F;
            this.btnKetToan.BackColor = System.Drawing.Color.Transparent;
            this.btnKetToan.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKetToan.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnKetToan.BorderColor = System.Drawing.Color.Black;
            this.btnKetToan.BorderSize = 1;
            this.btnKetToan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnKetToan.FocusedColor = System.Drawing.Color.Empty;
            this.btnKetToan.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKetToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnKetToan.Image = null;
            this.btnKetToan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnKetToan.Location = new System.Drawing.Point(494, 648);
            this.btnKetToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnKetToan.Name = "btnKetToan";
            this.btnKetToan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnKetToan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnKetToan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnKetToan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnKetToan.OnHoverImage = null;
            this.btnKetToan.OnPressedColor = System.Drawing.Color.Black;
            this.btnKetToan.Radius = 3;
            this.btnKetToan.Size = new System.Drawing.Size(171, 48);
            this.btnKetToan.TabIndex = 114;
            this.btnKetToan.Text = "KÊT TOÁN";
            this.btnKetToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnKetToan.Click += new System.EventHandler(this.btnKetToan_Click);
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.White;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.LineColor = System.Drawing.Color.LimeGreen;
            this.txtLuong.Location = new System.Drawing.Point(936, 569);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(237, 42);
            this.txtLuong.TabIndex = 113;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(822, 583);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(75, 28);
            this.gunaLabel3.TabIndex = 112;
            this.gunaLabel3.Text = "Lương:";
            // 
            // LoaiNVLabel
            // 
            this.LoaiNVLabel.AutoSize = true;
            this.LoaiNVLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiNVLabel.Location = new System.Drawing.Point(735, 479);
            this.LoaiNVLabel.Name = "LoaiNVLabel";
            this.LoaiNVLabel.Size = new System.Drawing.Size(162, 28);
            this.LoaiNVLabel.TabIndex = 110;
            this.LoaiNVLabel.Text = "Loại Nhân Viên: ";
            // 
            // cbTypeNV
            // 
            this.cbTypeNV.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeNV.BaseColor = System.Drawing.Color.Transparent;
            this.cbTypeNV.BorderColor = System.Drawing.Color.Silver;
            this.cbTypeNV.BorderSize = 0;
            this.cbTypeNV.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeNV.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeNV.FocusedColor = System.Drawing.Color.Empty;
            this.cbTypeNV.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeNV.ForeColor = System.Drawing.Color.Black;
            this.cbTypeNV.FormattingEnabled = true;
            this.cbTypeNV.Items.AddRange(new object[] {
            "Bảo Vệ",
            "Thợ Sửa",
            "Thợ Rửa",
            "Nhân Viên"});
            this.cbTypeNV.Location = new System.Drawing.Point(616, 11);
            this.cbTypeNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypeNV.Name = "cbTypeNV";
            this.cbTypeNV.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeNV.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeNV.Size = new System.Drawing.Size(191, 35);
            this.cbTypeNV.TabIndex = 109;
            this.cbTypeNV.SelectedIndexChanged += new System.EventHandler(this.cbTypeNV_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(372, 18);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(185, 28);
            this.gunaLabel1.TabIndex = 108;
            this.gunaLabel1.Text = "Các Loại Nhân viên";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.White;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtID.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.LineColor = System.Drawing.Color.LimeGreen;
            this.txtID.Location = new System.Drawing.Point(194, 479);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtID.Name = "txtID";
            this.txtID.PasswordChar = '\0';
            this.txtID.SelectedText = "";
            this.txtID.Size = new System.Drawing.Size(264, 42);
            this.txtID.TabIndex = 119;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(6, 493);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(134, 28);
            this.gunaLabel2.TabIndex = 118;
            this.gunaLabel2.Text = "ID Nhân Viên";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.LineColor = System.Drawing.Color.LimeGreen;
            this.txtName.Location = new System.Drawing.Point(194, 561);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.PasswordChar = '\0';
            this.txtName.SelectedText = "";
            this.txtName.Size = new System.Drawing.Size(264, 42);
            this.txtName.TabIndex = 121;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(6, 575);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(146, 28);
            this.gunaLabel4.TabIndex = 120;
            this.gunaLabel4.Text = "Tên Nhân Viên";
            // 
            // picBox
            // 
            this.picBox.Location = new System.Drawing.Point(494, 449);
            this.picBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(224, 154);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 122;
            this.picBox.TabStop = false;
            // 
            // fQuanLyLuong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1185, 707);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.DGVLuongperhour);
            this.Controls.Add(this.cbTxtType);
            this.Controls.Add(this.btnKetToan);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.LoaiNVLabel);
            this.Controls.Add(this.cbTypeNV);
            this.Controls.Add(this.gunaLabel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "fQuanLyLuong";
            this.Text = "fQuanLyLuong";
            this.Load += new System.EventHandler(this.fQuanLyLuong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVLuongperhour)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DGVLuongperhour;
        private Guna.UI.WinForms.GunaComboBox cbTxtType;
        private Guna.UI.WinForms.GunaGradientButton btnKetToan;
        private Guna.UI.WinForms.GunaLineTextBox txtLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel LoaiNVLabel;
        private Guna.UI.WinForms.GunaComboBox cbTypeNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtID;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtName;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private System.Windows.Forms.PictureBox picBox;
    }
}