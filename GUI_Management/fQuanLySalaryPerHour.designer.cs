
namespace GUI_Management
{
    partial class fQuanLySalaryPerHour
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
            this.cbTxtType = new Guna.UI.WinForms.GunaComboBox();
            this.txtLuong = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.LoaiNVLabel = new Guna.UI.WinForms.GunaLabel();
            this.cbTypeNV = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientButton();
            this.numerCa = new System.Windows.Forms.NumericUpDown();
            this.DGVLuongperhour = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.numerCa)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLuongperhour)).BeginInit();
            this.SuspendLayout();
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
            this.cbTxtType.Location = new System.Drawing.Point(224, 129);
            this.cbTxtType.Margin = new System.Windows.Forms.Padding(2);
            this.cbTxtType.Name = "cbTxtType";
            this.cbTxtType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTxtType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTxtType.Size = new System.Drawing.Size(149, 28);
            this.cbTxtType.TabIndex = 103;
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.White;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.LineColor = System.Drawing.Color.LimeGreen;
            this.txtLuong.Location = new System.Drawing.Point(224, 297);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(148, 30);
            this.txtLuong.TabIndex = 99;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(60, 299);
            this.gunaLabel3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(92, 21);
            this.gunaLabel3.TabIndex = 97;
            this.gunaLabel3.Text = "Giá Lương: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(60, 214);
            this.gunaLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(36, 21);
            this.gunaLabel2.TabIndex = 96;
            this.gunaLabel2.Text = "Ca: ";
            // 
            // LoaiNVLabel
            // 
            this.LoaiNVLabel.AutoSize = true;
            this.LoaiNVLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiNVLabel.Location = new System.Drawing.Point(60, 132);
            this.LoaiNVLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LoaiNVLabel.Name = "LoaiNVLabel";
            this.LoaiNVLabel.Size = new System.Drawing.Size(126, 21);
            this.LoaiNVLabel.TabIndex = 95;
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
            this.cbTypeNV.Location = new System.Drawing.Point(784, 89);
            this.cbTypeNV.Margin = new System.Windows.Forms.Padding(2);
            this.cbTypeNV.Name = "cbTypeNV";
            this.cbTypeNV.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeNV.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeNV.Size = new System.Drawing.Size(144, 30);
            this.cbTypeNV.TabIndex = 90;
            this.cbTypeNV.SelectedIndexChanged += new System.EventHandler(this.cbTypeNV_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(614, 92);
            this.gunaLabel1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(146, 21);
            this.gunaLabel1.TabIndex = 89;
            this.gunaLabel1.Text = "Các Loại Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(54, 20);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(875, 55);
            this.label1.TabIndex = 87;
            this.label1.Text = "CHỈNH SỬA LƯƠNG NHÂN VIÊN/ GIỜ";
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(224, 389);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 3;
            this.btnEdit.Size = new System.Drawing.Size(128, 30);
            this.btnEdit.TabIndex = 102;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // numerCa
            // 
            this.numerCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerCa.Location = new System.Drawing.Point(223, 211);
            this.numerCa.Maximum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.numerCa.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numerCa.Name = "numerCa";
            this.numerCa.Size = new System.Drawing.Size(149, 24);
            this.numerCa.TabIndex = 105;
            this.numerCa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DGVLuongperhour
            // 
            this.DGVLuongperhour.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVLuongperhour.Location = new System.Drawing.Point(573, 128);
            this.DGVLuongperhour.Name = "DGVLuongperhour";
            this.DGVLuongperhour.Size = new System.Drawing.Size(384, 302);
            this.DGVLuongperhour.TabIndex = 106;
            this.DGVLuongperhour.Click += new System.EventHandler(this.DGVLuongperhour_Click);
            // 
            // fQuanLySalaryPerHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(989, 532);
            this.Controls.Add(this.DGVLuongperhour);
            this.Controls.Add(this.numerCa);
            this.Controls.Add(this.cbTxtType);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.txtLuong);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.LoaiNVLabel);
            this.Controls.Add(this.cbTypeNV);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "fQuanLySalaryPerHour";
            this.Text = "fQuanLySalaryPerHour";
            this.Load += new System.EventHandler(this.fQuanLySalaryPerHour_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numerCa)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVLuongperhour)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaComboBox cbTxtType;
        private Guna.UI.WinForms.GunaLineTextBox txtLuong;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel LoaiNVLabel;
        private Guna.UI.WinForms.GunaComboBox cbTypeNV;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientButton btnEdit;
        private System.Windows.Forms.NumericUpDown numerCa;
        private System.Windows.Forms.DataGridView DGVLuongperhour;
    }
}