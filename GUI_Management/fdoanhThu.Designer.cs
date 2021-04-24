
namespace GUI_Management
{
    partial class fdoanhThu
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lbContent = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.dgvExpired = new Guna.UI.WinForms.GunaDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSave = new Guna.UI.WinForms.GunaGradientButton();
            this.btnPrint = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.txtGuiXe = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSuaXe = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtRuaXe = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.txtTongCong = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel4 = new Guna.UI.WinForms.GunaLabel();
            this.cbThanhToan = new Guna.UI.WinForms.GunaComboBox();
            this.btnSaveAll = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).BeginInit();
            this.SuspendLayout();
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lbContent.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lbContent.Location = new System.Drawing.Point(114, 9);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(806, 67);
            this.lbContent.TabIndex = 4;
            this.lbContent.Text = "DOANH THU TRONG NGÀY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.MediumSeaGreen;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Snow;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(328, 104);
            this.gunaGradient2Panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 5;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(413, 4);
            this.gunaGradient2Panel1.TabIndex = 14;
            // 
            // dgvExpired
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvExpired.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpired.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvExpired.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpired.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpired.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpired.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpired.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpired.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvExpired.EnableHeadersVisualStyles = false;
            this.dgvExpired.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvExpired.Location = new System.Drawing.Point(454, 186);
            this.dgvExpired.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvExpired.Name = "dgvExpired";
            this.dgvExpired.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpired.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpired.RowHeadersVisible = false;
            this.dgvExpired.RowHeadersWidth = 51;
            this.dgvExpired.RowTemplate.Height = 24;
            this.dgvExpired.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvExpired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpired.Size = new System.Drawing.Size(595, 332);
            this.dgvExpired.TabIndex = 23;
            this.dgvExpired.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvExpired.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvExpired.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvExpired.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExpired.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpired.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExpired.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExpired.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvExpired.ThemeStyle.ReadOnly = false;
            this.dgvExpired.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvExpired.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpired.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpired.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvExpired.ThemeStyle.RowsStyle.Height = 24;
            this.dgvExpired.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvExpired.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpired.DoubleClick += new System.EventHandler(this.dgvExpired_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.label8.Location = new System.Drawing.Point(449, 136);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(332, 26);
            this.label8.TabIndex = 24;
            this.label8.Text = "Danh Sách Xe Đã Thanh Toán: ";
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSave.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.BorderSize = 1;
            this.btnSave.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnSave.Image = null;
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(547, 544);
            this.btnSave.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSave.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 3;
            this.btnSave.Size = new System.Drawing.Size(91, 37);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "SAVE";
            this.btnSave.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnPrint.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.BorderSize = 1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(920, 544);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnPrint.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 3;
            this.btnPrint.Size = new System.Drawing.Size(129, 37);
            this.btnPrint.TabIndex = 28;
            this.btnPrint.Text = "PRINT";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(43, 240);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(139, 17);
            this.gunaLabel1.TabIndex = 29;
            this.gunaLabel1.Text = "Doanh Thu Gửi Xe: ";
            // 
            // txtGuiXe
            // 
            this.txtGuiXe.BackColor = System.Drawing.Color.White;
            this.txtGuiXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGuiXe.Enabled = false;
            this.txtGuiXe.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGuiXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtGuiXe.LineColor = System.Drawing.Color.LimeGreen;
            this.txtGuiXe.Location = new System.Drawing.Point(243, 227);
            this.txtGuiXe.Name = "txtGuiXe";
            this.txtGuiXe.PasswordChar = '\0';
            this.txtGuiXe.SelectedText = "";
            this.txtGuiXe.Size = new System.Drawing.Size(165, 30);
            this.txtGuiXe.TabIndex = 30;
            // 
            // txtSuaXe
            // 
            this.txtSuaXe.BackColor = System.Drawing.Color.White;
            this.txtSuaXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSuaXe.Enabled = false;
            this.txtSuaXe.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSuaXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSuaXe.LineColor = System.Drawing.Color.LimeGreen;
            this.txtSuaXe.Location = new System.Drawing.Point(243, 314);
            this.txtSuaXe.Name = "txtSuaXe";
            this.txtSuaXe.PasswordChar = '\0';
            this.txtSuaXe.SelectedText = "";
            this.txtSuaXe.Size = new System.Drawing.Size(165, 30);
            this.txtSuaXe.TabIndex = 32;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(43, 327);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(139, 17);
            this.gunaLabel2.TabIndex = 31;
            this.gunaLabel2.Text = "Doanh Thu Sửa Xe: ";
            // 
            // txtRuaXe
            // 
            this.txtRuaXe.BackColor = System.Drawing.Color.White;
            this.txtRuaXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtRuaXe.Enabled = false;
            this.txtRuaXe.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtRuaXe.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtRuaXe.LineColor = System.Drawing.Color.LimeGreen;
            this.txtRuaXe.Location = new System.Drawing.Point(243, 399);
            this.txtRuaXe.Name = "txtRuaXe";
            this.txtRuaXe.PasswordChar = '\0';
            this.txtRuaXe.SelectedText = "";
            this.txtRuaXe.Size = new System.Drawing.Size(165, 30);
            this.txtRuaXe.TabIndex = 34;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(43, 412);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(142, 17);
            this.gunaLabel3.TabIndex = 33;
            this.gunaLabel3.Text = "Doanh Thu Rửa Xe: ";
            // 
            // txtTongCong
            // 
            this.txtTongCong.BackColor = System.Drawing.Color.White;
            this.txtTongCong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTongCong.Enabled = false;
            this.txtTongCong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTongCong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTongCong.LineColor = System.Drawing.Color.LimeGreen;
            this.txtTongCong.Location = new System.Drawing.Point(243, 478);
            this.txtTongCong.Name = "txtTongCong";
            this.txtTongCong.PasswordChar = '\0';
            this.txtTongCong.SelectedText = "";
            this.txtTongCong.Size = new System.Drawing.Size(165, 30);
            this.txtTongCong.TabIndex = 36;
            // 
            // gunaLabel4
            // 
            this.gunaLabel4.AutoSize = true;
            this.gunaLabel4.Font = new System.Drawing.Font("Times New Roman", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel4.Location = new System.Drawing.Point(43, 491);
            this.gunaLabel4.Name = "gunaLabel4";
            this.gunaLabel4.Size = new System.Drawing.Size(90, 17);
            this.gunaLabel4.TabIndex = 35;
            this.gunaLabel4.Text = "Tổng Cộng: ";
            // 
            // cbThanhToan
            // 
            this.cbThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.cbThanhToan.BaseColor = System.Drawing.Color.Transparent;
            this.cbThanhToan.BorderColor = System.Drawing.Color.Transparent;
            this.cbThanhToan.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbThanhToan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbThanhToan.FocusedColor = System.Drawing.Color.Empty;
            this.cbThanhToan.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbThanhToan.ForeColor = System.Drawing.Color.Black;
            this.cbThanhToan.FormattingEnabled = true;
            this.cbThanhToan.Items.AddRange(new object[] {
            "Gửi Xe",
            "Sửa Xe",
            "Rửa Xe"});
            this.cbThanhToan.Location = new System.Drawing.Point(807, 135);
            this.cbThanhToan.Name = "cbThanhToan";
            this.cbThanhToan.OnHoverItemBaseColor = System.Drawing.Color.White;
            this.cbThanhToan.OnHoverItemForeColor = System.Drawing.Color.MistyRose;
            this.cbThanhToan.Size = new System.Drawing.Size(219, 28);
            this.cbThanhToan.TabIndex = 37;
            this.cbThanhToan.SelectedIndexChanged += new System.EventHandler(this.cbThanhToan_SelectedIndexChanged);
            // 
            // btnSaveAll
            // 
            this.btnSaveAll.AnimationHoverSpeed = 0.07F;
            this.btnSaveAll.AnimationSpeed = 0.03F;
            this.btnSaveAll.BackColor = System.Drawing.Color.Transparent;
            this.btnSaveAll.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSaveAll.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSaveAll.BorderColor = System.Drawing.Color.Black;
            this.btnSaveAll.BorderSize = 1;
            this.btnSaveAll.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSaveAll.FocusedColor = System.Drawing.Color.Empty;
            this.btnSaveAll.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnSaveAll.Image = null;
            this.btnSaveAll.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSaveAll.Location = new System.Drawing.Point(687, 544);
            this.btnSaveAll.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSaveAll.Name = "btnSaveAll";
            this.btnSaveAll.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSaveAll.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSaveAll.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSaveAll.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSaveAll.OnHoverImage = null;
            this.btnSaveAll.OnPressedColor = System.Drawing.Color.Black;
            this.btnSaveAll.Radius = 3;
            this.btnSaveAll.Size = new System.Drawing.Size(135, 37);
            this.btnSaveAll.TabIndex = 38;
            this.btnSaveAll.Text = "SAVE ALL";
            this.btnSaveAll.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSaveAll.Click += new System.EventHandler(this.btnSaveAll_Click);
            // 
            // fdoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1083, 605);
            this.Controls.Add(this.btnSaveAll);
            this.Controls.Add(this.cbThanhToan);
            this.Controls.Add(this.txtTongCong);
            this.Controls.Add(this.gunaLabel4);
            this.Controls.Add(this.txtRuaXe);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.txtSuaXe);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.txtGuiXe);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvExpired);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.lbContent);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fdoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fdoanhThu";
            this.Load += new System.EventHandler(this.fdoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaDataGridView dgvExpired;
        public System.Windows.Forms.Label label8;
        private Guna.UI.WinForms.GunaGradientButton btnSave;
        private Guna.UI.WinForms.GunaGradientButton btnPrint;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtGuiXe;
        private Guna.UI.WinForms.GunaLineTextBox txtSuaXe;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtRuaXe;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox txtTongCong;
        private Guna.UI.WinForms.GunaLabel gunaLabel4;
        private Guna.UI.WinForms.GunaComboBox cbThanhToan;
        private Guna.UI.WinForms.GunaGradientButton btnSaveAll;
    }
}