
namespace GUI_Management
{
    partial class fEdit_SalaryPerHour
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.DGVLuongperhour = new Guna.UI.WinForms.GunaDataGridView();
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
            this.cbTxtType.Location = new System.Drawing.Point(301, 179);
            this.cbTxtType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTxtType.Name = "cbTxtType";
            this.cbTxtType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTxtType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTxtType.Size = new System.Drawing.Size(197, 32);
            this.cbTxtType.TabIndex = 103;
            // 
            // txtLuong
            // 
            this.txtLuong.BackColor = System.Drawing.Color.White;
            this.txtLuong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLuong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtLuong.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLuong.LineColor = System.Drawing.Color.LimeGreen;
            this.txtLuong.Location = new System.Drawing.Point(301, 386);
            this.txtLuong.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtLuong.Name = "txtLuong";
            this.txtLuong.PasswordChar = '\0';
            this.txtLuong.SelectedText = "";
            this.txtLuong.Size = new System.Drawing.Size(197, 42);
            this.txtLuong.TabIndex = 99;
            this.txtLuong.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(82, 388);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(116, 28);
            this.gunaLabel3.TabIndex = 97;
            this.gunaLabel3.Text = "Giá Lương: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(82, 283);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(45, 28);
            this.gunaLabel2.TabIndex = 96;
            this.gunaLabel2.Text = "Ca: ";
            // 
            // LoaiNVLabel
            // 
            this.LoaiNVLabel.AutoSize = true;
            this.LoaiNVLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoaiNVLabel.Location = new System.Drawing.Point(82, 182);
            this.LoaiNVLabel.Name = "LoaiNVLabel";
            this.LoaiNVLabel.Size = new System.Drawing.Size(162, 28);
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
            this.cbTypeNV.Location = new System.Drawing.Point(1045, 110);
            this.cbTypeNV.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypeNV.Name = "cbTypeNV";
            this.cbTypeNV.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeNV.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeNV.Size = new System.Drawing.Size(191, 35);
            this.cbTypeNV.TabIndex = 90;
            this.cbTypeNV.SelectedIndexChanged += new System.EventHandler(this.cbTypeNV_SelectedIndexChanged);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(819, 113);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(185, 28);
            this.gunaLabel1.TabIndex = 89;
            this.gunaLabel1.Text = "Các Loại Nhân viên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(72, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1094, 67);
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
            this.btnEdit.Location = new System.Drawing.Point(187, 512);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 3;
            this.btnEdit.Size = new System.Drawing.Size(171, 37);
            this.btnEdit.TabIndex = 102;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // numerCa
            // 
            this.numerCa.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerCa.Location = new System.Drawing.Point(299, 280);
            this.numerCa.Margin = new System.Windows.Forms.Padding(4);
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
            this.numerCa.Size = new System.Drawing.Size(199, 29);
            this.numerCa.TabIndex = 105;
            this.numerCa.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // DGVLuongperhour
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.DGVLuongperhour.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DGVLuongperhour.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGVLuongperhour.BackgroundColor = System.Drawing.Color.Honeydew;
            this.DGVLuongperhour.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DGVLuongperhour.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLuongperhour.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLuongperhour.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DGVLuongperhour.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGVLuongperhour.DefaultCellStyle = dataGridViewCellStyle3;
            this.DGVLuongperhour.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.DGVLuongperhour.EnableHeadersVisualStyles = false;
            this.DGVLuongperhour.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.DGVLuongperhour.Location = new System.Drawing.Point(761, 179);
            this.DGVLuongperhour.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DGVLuongperhour.Name = "DGVLuongperhour";
            this.DGVLuongperhour.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGVLuongperhour.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DGVLuongperhour.RowHeadersVisible = false;
            this.DGVLuongperhour.RowHeadersWidth = 51;
            this.DGVLuongperhour.RowTemplate.Height = 24;
            this.DGVLuongperhour.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGVLuongperhour.Size = new System.Drawing.Size(512, 370);
            this.DGVLuongperhour.TabIndex = 107;
            this.DGVLuongperhour.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.DGVLuongperhour.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.DGVLuongperhour.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.DGVLuongperhour.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.DGVLuongperhour.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.DGVLuongperhour.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.DGVLuongperhour.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.DGVLuongperhour.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.DGVLuongperhour.ThemeStyle.HeaderStyle.Height = 25;
            this.DGVLuongperhour.ThemeStyle.ReadOnly = false;
            this.DGVLuongperhour.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.DGVLuongperhour.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.DGVLuongperhour.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DGVLuongperhour.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.DGVLuongperhour.ThemeStyle.RowsStyle.Height = 24;
            this.DGVLuongperhour.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.DGVLuongperhour.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.DGVLuongperhour.Click += new System.EventHandler(this.DGVLuongperhour_Click_1);
            // 
            // fEdit_SalaryPerHour
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1302, 602);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "fEdit_SalaryPerHour";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private Guna.UI.WinForms.GunaDataGridView DGVLuongperhour;
    }
}