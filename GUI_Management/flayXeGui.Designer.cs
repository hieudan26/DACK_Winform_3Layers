
namespace GUI_Management
{
    partial class flayXeGui
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.lb_Content = new System.Windows.Forms.Label();
            this.dgvXe = new Guna.UI.WinForms.GunaDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTypeFilter = new Guna.UI.WinForms.GunaComboBox();
            this.btnThanhToan = new Guna.UI.WinForms.GunaGradientButton();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnSearch = new Guna.UI.WinForms.GunaGradientButton();
            this.lbCount = new Guna.UI.WinForms.GunaLabel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.rbYes = new Guna.UI.WinForms.GunaRadioButton();
            this.rbNo = new Guna.UI.WinForms.GunaRadioButton();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtP2 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.dtP1 = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaGradient2Panel2 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1083, 33);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // lb_Content
            // 
            this.lb_Content.AutoSize = true;
            this.lb_Content.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.lb_Content.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Content.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.lb_Content.Location = new System.Drawing.Point(430, 35);
            this.lb_Content.Name = "lb_Content";
            this.lb_Content.Size = new System.Drawing.Size(237, 67);
            this.lb_Content.TabIndex = 5;
            this.lb_Content.Text = "LẤY XE";
            // 
            // dgvXe
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXe.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.Color.Honeydew;
            this.dgvXe.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvXe.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXe.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvXe.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvXe.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvXe.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvXe.EnableHeadersVisualStyles = false;
            this.dgvXe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXe.Location = new System.Drawing.Point(40, 223);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvXe.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.RowTemplate.Height = 24;
            this.dgvXe.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvXe.Size = new System.Drawing.Size(1006, 306);
            this.dgvXe.TabIndex = 24;
            this.dgvXe.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Teal;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(179)))), ((int)(((byte)(223)))), ((int)(((byte)(219)))));
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvXe.ThemeStyle.BackColor = System.Drawing.Color.Honeydew;
            this.dgvXe.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(177)))), ((int)(((byte)(222)))), ((int)(((byte)(218)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.dgvXe.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvXe.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvXe.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvXe.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvXe.ThemeStyle.ReadOnly = false;
            this.dgvXe.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(233)))), ((int)(((byte)(231)))));
            this.dgvXe.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvXe.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvXe.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvXe.ThemeStyle.RowsStyle.Height = 24;
            this.dgvXe.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(185)))), ((int)(((byte)(175)))));
            this.dgvXe.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvXe.DoubleClick += new System.EventHandler(this.dgvXe_DoubleClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(36, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(96, 23);
            this.label2.TabIndex = 25;
            this.label2.Text = "Filter By: ";
            // 
            // cbTypeFilter
            // 
            this.cbTypeFilter.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeFilter.BaseColor = System.Drawing.Color.White;
            this.cbTypeFilter.BorderColor = System.Drawing.Color.Silver;
            this.cbTypeFilter.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeFilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeFilter.FocusedColor = System.Drawing.Color.Empty;
            this.cbTypeFilter.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeFilter.ForeColor = System.Drawing.Color.Black;
            this.cbTypeFilter.FormattingEnabled = true;
            this.cbTypeFilter.Items.AddRange(new object[] {
            "Xe Đạp",
            "Xe Máy",
            "Xe Hơi",
            "Xe Hết Hạn",
            "Xe Còn Hạn",
            "Tất Cả"});
            this.cbTypeFilter.Location = new System.Drawing.Point(149, 188);
            this.cbTypeFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbTypeFilter.Name = "cbTypeFilter";
            this.cbTypeFilter.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeFilter.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeFilter.Size = new System.Drawing.Size(170, 31);
            this.cbTypeFilter.TabIndex = 26;
            this.cbTypeFilter.SelectedIndexChanged += new System.EventHandler(this.cbTypeFilter_SelectedIndexChanged);
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.AnimationHoverSpeed = 0.07F;
            this.btnThanhToan.AnimationSpeed = 0.03F;
            this.btnThanhToan.BackColor = System.Drawing.Color.Transparent;
            this.btnThanhToan.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnThanhToan.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnThanhToan.BorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.BorderSize = 1;
            this.btnThanhToan.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThanhToan.FocusedColor = System.Drawing.Color.Empty;
            this.btnThanhToan.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnThanhToan.Image = null;
            this.btnThanhToan.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThanhToan.Location = new System.Drawing.Point(886, 542);
            this.btnThanhToan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnThanhToan.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnThanhToan.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThanhToan.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThanhToan.OnHoverImage = null;
            this.btnThanhToan.OnPressedColor = System.Drawing.Color.Black;
            this.btnThanhToan.Radius = 3;
            this.btnThanhToan.Size = new System.Drawing.Size(129, 37);
            this.btnThanhToan.TabIndex = 29;
            this.btnThanhToan.Text = "Thanh Toán";
            this.btnThanhToan.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(392, 193);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(156, 23);
            this.label3.TabIndex = 30;
            this.label3.Text = "Searching by ID: ";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.White;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearch.LineColor = System.Drawing.Color.LimeGreen;
            this.txtSearch.Location = new System.Drawing.Point(566, 189);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(131, 30);
            this.txtSearch.TabIndex = 31;
            // 
            // btnSearch
            // 
            this.btnSearch.AnimationHoverSpeed = 0.07F;
            this.btnSearch.AnimationSpeed = 0.03F;
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSearch.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSearch.BorderColor = System.Drawing.Color.Black;
            this.btnSearch.BorderSize = 1;
            this.btnSearch.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnSearch.FocusedColor = System.Drawing.Color.Empty;
            this.btnSearch.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnSearch.Image = null;
            this.btnSearch.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSearch.Location = new System.Drawing.Point(717, 182);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnSearch.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnSearch.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSearch.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSearch.OnHoverImage = null;
            this.btnSearch.OnPressedColor = System.Drawing.Color.Black;
            this.btnSearch.Radius = 3;
            this.btnSearch.Size = new System.Drawing.Size(116, 37);
            this.btnSearch.TabIndex = 32;
            this.btnSearch.Text = "Search";
            this.btnSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.lbCount.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.ForeColor = System.Drawing.Color.Firebrick;
            this.lbCount.Location = new System.Drawing.Point(881, 193);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(150, 28);
            this.lbCount.TabIndex = 33;
            this.lbCount.Text = "Số Lượng Xe: 0";
            this.lbCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // rbYes
            // 
            this.rbYes.BaseColor = System.Drawing.SystemColors.Control;
            this.rbYes.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbYes.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbYes.FillColor = System.Drawing.Color.Black;
            this.rbYes.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(32, 29);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(60, 28);
            this.rbYes.TabIndex = 0;
            this.rbYes.Text = "YES";
            this.rbYes.CheckedChanged += new System.EventHandler(this.rbYes_CheckedChanged);
            // 
            // rbNo
            // 
            this.rbNo.BaseColor = System.Drawing.SystemColors.Control;
            this.rbNo.CheckedOffColor = System.Drawing.Color.Gray;
            this.rbNo.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.rbNo.FillColor = System.Drawing.Color.Black;
            this.rbNo.Font = new System.Drawing.Font("Segoe UI Semilight", 10.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(247, 29);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(59, 28);
            this.rbNo.TabIndex = 1;
            this.rbNo.Text = "NO";
            this.rbNo.CheckedChanged += new System.EventHandler(this.rbNo_CheckedChanged);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.WhiteSmoke;
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(168, 9);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(3, 60);
            this.gunaGradient2Panel1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtP2);
            this.panel1.Controls.Add(this.gunaLabel1);
            this.panel1.Controls.Add(this.dtP1);
            this.panel1.Controls.Add(this.gunaGradient2Panel2);
            this.panel1.Controls.Add(this.gunaGradient2Panel1);
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Location = new System.Drawing.Point(40, 105);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1006, 78);
            this.panel1.TabIndex = 34;
            // 
            // dtP2
            // 
            this.dtP2.BackColor = System.Drawing.Color.Transparent;
            this.dtP2.BaseColor = System.Drawing.Color.White;
            this.dtP2.BorderColor = System.Drawing.Color.Silver;
            this.dtP2.CustomFormat = null;
            this.dtP2.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtP2.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtP2.ForeColor = System.Drawing.Color.Black;
            this.dtP2.Location = new System.Drawing.Point(725, 27);
            this.dtP2.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtP2.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtP2.Name = "dtP2";
            this.dtP2.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtP2.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP2.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP2.OnPressedColor = System.Drawing.Color.Black;
            this.dtP2.Radius = 8;
            this.dtP2.Size = new System.Drawing.Size(250, 30);
            this.dtP2.TabIndex = 5;
            this.dtP2.Text = "Friday, April 30, 2021";
            this.dtP2.Value = new System.DateTime(2021, 4, 30, 23, 14, 47, 882);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(673, 29);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(46, 23);
            this.gunaLabel1.TabIndex = 4;
            this.gunaLabel1.Text = "AND";
            // 
            // dtP1
            // 
            this.dtP1.BackColor = System.Drawing.Color.Transparent;
            this.dtP1.BaseColor = System.Drawing.Color.White;
            this.dtP1.BorderColor = System.Drawing.Color.Silver;
            this.dtP1.CustomFormat = null;
            this.dtP1.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtP1.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.dtP1.ForeColor = System.Drawing.Color.Black;
            this.dtP1.Location = new System.Drawing.Point(407, 27);
            this.dtP1.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtP1.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtP1.Name = "dtP1";
            this.dtP1.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtP1.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP1.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtP1.OnPressedColor = System.Drawing.Color.Black;
            this.dtP1.Radius = 8;
            this.dtP1.Size = new System.Drawing.Size(250, 30);
            this.dtP1.TabIndex = 0;
            this.dtP1.Text = "Friday, April 30, 2021";
            this.dtP1.Value = new System.DateTime(2021, 4, 30, 23, 14, 47, 882);
            // 
            // gunaGradient2Panel2
            // 
            this.gunaGradient2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel2.GradientColor1 = System.Drawing.Color.Black;
            this.gunaGradient2Panel2.GradientColor2 = System.Drawing.Color.WhiteSmoke;
            this.gunaGradient2Panel2.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradient2Panel2.Location = new System.Drawing.Point(381, 9);
            this.gunaGradient2Panel2.Name = "gunaGradient2Panel2";
            this.gunaGradient2Panel2.Size = new System.Drawing.Size(3, 60);
            this.gunaGradient2Panel2.TabIndex = 3;
            // 
            // flayXeGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1083, 605);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.cbTypeFilter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.lb_Content);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "flayXeGui";
            this.Text = "flayXe";
            this.Load += new System.EventHandler(this.flayXe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lb_Content;
        private Guna.UI.WinForms.GunaDataGridView dgvXe;
        public System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbTypeFilter;
        private Guna.UI.WinForms.GunaGradientButton btnThanhToan;
        public System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaLineTextBox txtSearch;
        private Guna.UI.WinForms.GunaGradientButton btnSearch;
        private Guna.UI.WinForms.GunaLabel lbCount;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI.WinForms.GunaRadioButton rbYes;
        private Guna.UI.WinForms.GunaRadioButton rbNo;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtP2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaDateTimePicker dtP1;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel2;
    }
}