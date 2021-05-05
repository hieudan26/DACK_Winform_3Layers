
namespace GUI_Management
{
    partial class finfoNhanVien
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDoB = new Guna.UI.WinForms.GunaDateTimePicker();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.btnEdit = new Guna.UI.WinForms.GunaGradientButton();
            this.cbTypeTho = new Guna.UI.WinForms.GunaComboBox();
            this.cbSex = new Guna.UI.WinForms.GunaComboBox();
            this.txtId_CMND = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTenNV = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnUpImg = new Guna.UI.WinForms.GunaButton();
            this.label9 = new System.Windows.Forms.Label();
            this.pbNhanVien = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFind = new Guna.UI.WinForms.GunaGradientButton();
            this.btnRemove = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Arial", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(83, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(936, 89);
            this.label1.TabIndex = 7;
            this.label1.Text = "THÔNG TIN NHÂN VIÊN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rbNo);
            this.panel1.Controls.Add(this.rbYes);
            this.panel1.Location = new System.Drawing.Point(219, 223);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(235, 73);
            this.panel1.TabIndex = 49;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(175, 28);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(51, 21);
            this.rbNo.TabIndex = 1;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "NO";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbYes.Location = new System.Drawing.Point(3, 29);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(57, 21);
            this.rbYes.TabIndex = 0;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "YES";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 247);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 25);
            this.label5.TabIndex = 48;
            this.label5.Text = "Nhóm Trưởng: ";
            // 
            // dtpDoB
            // 
            this.dtpDoB.BackColor = System.Drawing.Color.Transparent;
            this.dtpDoB.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.dtpDoB.BorderColor = System.Drawing.Color.LimeGreen;
            this.dtpDoB.CustomFormat = "dd/ MM/ yyyy";
            this.dtpDoB.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtpDoB.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDoB.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpDoB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dtpDoB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDoB.Location = new System.Drawing.Point(219, 318);
            this.dtpDoB.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpDoB.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpDoB.Name = "dtpDoB";
            this.dtpDoB.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtpDoB.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDoB.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtpDoB.OnPressedColor = System.Drawing.Color.Black;
            this.dtpDoB.Radius = 3;
            this.dtpDoB.Size = new System.Drawing.Size(235, 30);
            this.dtpDoB.TabIndex = 47;
            this.dtpDoB.Text = "22/ 04/ 2021";
            this.dtpDoB.Value = new System.DateTime(2021, 4, 22, 11, 41, 41, 819);
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.DarkTurquoise;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(562, 163);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(5, 340);
            this.gunaGradient2Panel1.TabIndex = 46;
            // 
            // btnEdit
            // 
            this.btnEdit.AnimationHoverSpeed = 0.07F;
            this.btnEdit.AnimationSpeed = 0.03F;
            this.btnEdit.BackColor = System.Drawing.Color.Transparent;
            this.btnEdit.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.BorderColor = System.Drawing.Color.Black;
            this.btnEdit.BorderSize = 1;
            this.btnEdit.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEdit.FocusedColor = System.Drawing.Color.Empty;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.ForeColor = System.Drawing.Color.Black;
            this.btnEdit.Image = null;
            this.btnEdit.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEdit.Location = new System.Drawing.Point(599, 566);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnEdit.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnEdit.OnHoverImage = null;
            this.btnEdit.OnPressedColor = System.Drawing.Color.Black;
            this.btnEdit.Radius = 3;
            this.btnEdit.Size = new System.Drawing.Size(160, 42);
            this.btnEdit.TabIndex = 45;
            this.btnEdit.Text = "EDIT";
            this.btnEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // cbTypeTho
            // 
            this.cbTypeTho.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeTho.BaseColor = System.Drawing.Color.White;
            this.cbTypeTho.BorderColor = System.Drawing.Color.Silver;
            this.cbTypeTho.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeTho.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeTho.FocusedColor = System.Drawing.Color.Empty;
            this.cbTypeTho.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeTho.ForeColor = System.Drawing.Color.Black;
            this.cbTypeTho.FormattingEnabled = true;
            this.cbTypeTho.Items.AddRange(new object[] {
            "Bảo Vệ",
            "Thợ Sửa",
            "Thợ Rửa",
            "Nhân Viên"});
            this.cbTypeTho.Location = new System.Drawing.Point(219, 479);
            this.cbTypeTho.Name = "cbTypeTho";
            this.cbTypeTho.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeTho.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeTho.Size = new System.Drawing.Size(235, 31);
            this.cbTypeTho.TabIndex = 44;
            // 
            // cbSex
            // 
            this.cbSex.BackColor = System.Drawing.Color.Transparent;
            this.cbSex.BaseColor = System.Drawing.Color.White;
            this.cbSex.BorderColor = System.Drawing.Color.Silver;
            this.cbSex.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FocusedColor = System.Drawing.Color.Empty;
            this.cbSex.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbSex.ForeColor = System.Drawing.Color.Black;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "Nam",
            "Nữ",
            "Khác"});
            this.cbSex.Location = new System.Drawing.Point(219, 401);
            this.cbSex.Name = "cbSex";
            this.cbSex.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbSex.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbSex.Size = new System.Drawing.Size(235, 31);
            this.cbSex.TabIndex = 43;
            // 
            // txtId_CMND
            // 
            this.txtId_CMND.BackColor = System.Drawing.Color.White;
            this.txtId_CMND.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtId_CMND.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtId_CMND.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtId_CMND.LineColor = System.Drawing.Color.LimeGreen;
            this.txtId_CMND.Location = new System.Drawing.Point(716, 162);
            this.txtId_CMND.Name = "txtId_CMND";
            this.txtId_CMND.PasswordChar = '\0';
            this.txtId_CMND.SelectedText = "";
            this.txtId_CMND.Size = new System.Drawing.Size(235, 30);
            this.txtId_CMND.TabIndex = 42;
            // 
            // txtTenNV
            // 
            this.txtTenNV.BackColor = System.Drawing.Color.White;
            this.txtTenNV.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenNV.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenNV.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenNV.LineColor = System.Drawing.Color.LimeGreen;
            this.txtTenNV.Location = new System.Drawing.Point(219, 163);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.PasswordChar = '\0';
            this.txtTenNV.SelectedText = "";
            this.txtTenNV.Size = new System.Drawing.Size(235, 30);
            this.txtTenNV.TabIndex = 41;
            // 
            // btnUpImg
            // 
            this.btnUpImg.AnimationHoverSpeed = 0.07F;
            this.btnUpImg.AnimationSpeed = 0.03F;
            this.btnUpImg.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpImg.BorderColor = System.Drawing.Color.Black;
            this.btnUpImg.BorderSize = 1;
            this.btnUpImg.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpImg.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpImg.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImg.ForeColor = System.Drawing.Color.Black;
            this.btnUpImg.Image = null;
            this.btnUpImg.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpImg.Location = new System.Drawing.Point(715, 468);
            this.btnUpImg.Name = "btnUpImg";
            this.btnUpImg.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnUpImg.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpImg.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpImg.OnHoverImage = null;
            this.btnUpImg.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpImg.Size = new System.Drawing.Size(333, 24);
            this.btnUpImg.TabIndex = 40;
            this.btnUpImg.Text = "UP IMAGE";
            this.btnUpImg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpImg.Click += new System.EventHandler(this.btnUpImg_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(710, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(323, 25);
            this.label9.TabIndex = 39;
            this.label9.Text = "Mặt Trước CMND / Ảnh Chân Dung";
            // 
            // pbNhanVien
            // 
            this.pbNhanVien.Location = new System.Drawing.Point(716, 307);
            this.pbNhanVien.Name = "pbNhanVien";
            this.pbNhanVien.Size = new System.Drawing.Size(332, 155);
            this.pbNhanVien.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbNhanVien.TabIndex = 38;
            this.pbNhanVien.TabStop = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(42, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 25);
            this.label7.TabIndex = 37;
            this.label7.Text = "Loại Thợ: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(614, 167);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 25);
            this.label6.TabIndex = 36;
            this.label6.Text = "CMND: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(41, 407);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 25);
            this.label4.TabIndex = 35;
            this.label4.Text = "Giới Tính: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(42, 305);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 34;
            this.label3.Text = "DoB:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(42, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 25);
            this.label2.TabIndex = 33;
            this.label2.Text = "Tên Nhân Viên:";
            // 
            // btnFind
            // 
            this.btnFind.AnimationHoverSpeed = 0.07F;
            this.btnFind.AnimationSpeed = 0.03F;
            this.btnFind.BackColor = System.Drawing.Color.Transparent;
            this.btnFind.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFind.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFind.BorderColor = System.Drawing.Color.Black;
            this.btnFind.BorderSize = 1;
            this.btnFind.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFind.FocusedColor = System.Drawing.Color.Empty;
            this.btnFind.Font = new System.Drawing.Font("Segoe UI Semibold", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFind.ForeColor = System.Drawing.Color.Black;
            this.btnFind.Image = null;
            this.btnFind.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFind.Location = new System.Drawing.Point(972, 162);
            this.btnFind.Name = "btnFind";
            this.btnFind.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFind.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnFind.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnFind.OnHoverImage = null;
            this.btnFind.OnPressedColor = System.Drawing.Color.Black;
            this.btnFind.Radius = 3;
            this.btnFind.Size = new System.Drawing.Size(92, 30);
            this.btnFind.TabIndex = 50;
            this.btnFind.Text = "FIND";
            this.btnFind.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.AnimationHoverSpeed = 0.07F;
            this.btnRemove.AnimationSpeed = 0.03F;
            this.btnRemove.BackColor = System.Drawing.Color.Transparent;
            this.btnRemove.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.BorderColor = System.Drawing.Color.Black;
            this.btnRemove.BorderSize = 1;
            this.btnRemove.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnRemove.FocusedColor = System.Drawing.Color.Empty;
            this.btnRemove.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemove.ForeColor = System.Drawing.Color.Black;
            this.btnRemove.Image = null;
            this.btnRemove.ImageSize = new System.Drawing.Size(20, 20);
            this.btnRemove.Location = new System.Drawing.Point(859, 566);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnRemove.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnRemove.OnHoverImage = null;
            this.btnRemove.OnPressedColor = System.Drawing.Color.Black;
            this.btnRemove.Radius = 3;
            this.btnRemove.Size = new System.Drawing.Size(160, 42);
            this.btnRemove.TabIndex = 51;
            this.btnRemove.Text = "REMOVE";
            this.btnRemove.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // finfoNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1112, 635);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpDoB);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.cbTypeTho);
            this.Controls.Add(this.cbSex);
            this.Controls.Add(this.txtId_CMND);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.btnUpImg);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.pbNhanVien);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "finfoNhanVien";
            this.Text = "finfoNhanVien";
            this.Load += new System.EventHandler(this.finfoNhanVien_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbNhanVien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaGradientButton btnEdit;
        private Guna.UI.WinForms.GunaButton btnUpImg;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaGradientButton btnFind;
        private Guna.UI.WinForms.GunaGradientButton btnRemove;
        public System.Windows.Forms.RadioButton rbNo;
        public System.Windows.Forms.RadioButton rbYes;
        public Guna.UI.WinForms.GunaDateTimePicker dtpDoB;
        public Guna.UI.WinForms.GunaComboBox cbTypeTho;
        public Guna.UI.WinForms.GunaComboBox cbSex;
        public Guna.UI.WinForms.GunaLineTextBox txtId_CMND;
        public Guna.UI.WinForms.GunaLineTextBox txtTenNV;
        public System.Windows.Forms.PictureBox pbNhanVien;
    }
}