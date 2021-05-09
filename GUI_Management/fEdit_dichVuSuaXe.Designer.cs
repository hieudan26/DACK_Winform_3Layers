
namespace GUI_Management
{
    partial class fEdit_dichVuSuaXe
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
            this.lBoxDichVu = new System.Windows.Forms.ListBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbTypeXe = new Guna.UI.WinForms.GunaComboBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnFirst = new System.Windows.Forms.Button();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnLast = new System.Windows.Forms.Button();
            this.txtGiaDichVu = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtTenDichVu = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel6 = new Guna.UI.WinForms.GunaLabel();
            this.btnADD = new Guna.UI.WinForms.GunaGradientButton();
            this.btnEDIT = new Guna.UI.WinForms.GunaGradientButton();
            this.btnREMOVE = new Guna.UI.WinForms.GunaGradientButton();
            this.cbTxtType = new Guna.UI.WinForms.GunaComboBox();
            this.lbCount = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(305, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(655, 67);
            this.label1.TabIndex = 66;
            this.label1.Text = "XÓA SỬA PHÍ SỬA XE";
            // 
            // lBoxDichVu
            // 
            this.lBoxDichVu.FormattingEnabled = true;
            this.lBoxDichVu.ItemHeight = 16;
            this.lBoxDichVu.Location = new System.Drawing.Point(807, 132);
            this.lBoxDichVu.Name = "lBoxDichVu";
            this.lBoxDichVu.Size = new System.Drawing.Size(441, 356);
            this.lBoxDichVu.TabIndex = 67;
            this.lBoxDichVu.Click += new System.EventHandler(this.lBoxDichVu_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(802, 86);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(199, 28);
            this.gunaLabel1.TabIndex = 68;
            this.gunaLabel1.Text = "Các Dịch Vụ Sửa Xe: ";
            // 
            // cbTypeXe
            // 
            this.cbTypeXe.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeXe.BaseColor = System.Drawing.Color.Transparent;
            this.cbTypeXe.BorderColor = System.Drawing.Color.Silver;
            this.cbTypeXe.BorderSize = 0;
            this.cbTypeXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeXe.FocusedColor = System.Drawing.Color.Empty;
            this.cbTypeXe.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbTypeXe.ForeColor = System.Drawing.Color.Black;
            this.cbTypeXe.FormattingEnabled = true;
            this.cbTypeXe.Items.AddRange(new object[] {
            "Xe Đạp",
            "Xe Máy",
            "Xe Hơi",
            "Tất Cả"});
            this.cbTypeXe.Location = new System.Drawing.Point(1030, 83);
            this.cbTypeXe.Name = "cbTypeXe";
            this.cbTypeXe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeXe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeXe.Size = new System.Drawing.Size(190, 35);
            this.cbTypeXe.TabIndex = 69;
            this.cbTypeXe.SelectedIndexChanged += new System.EventHandler(this.cbTypeXe_SelectedIndexChanged);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(904, 531);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(56, 37);
            this.btnNext.TabIndex = 70;
            this.btnNext.Text = "<";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnFirst
            // 
            this.btnFirst.Location = new System.Drawing.Point(807, 531);
            this.btnFirst.Name = "btnFirst";
            this.btnFirst.Size = new System.Drawing.Size(56, 37);
            this.btnFirst.TabIndex = 71;
            this.btnFirst.Text = "< <";
            this.btnFirst.UseVisualStyleBackColor = true;
            this.btnFirst.Click += new System.EventHandler(this.btnFirst_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(1095, 531);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 37);
            this.btnPrevious.TabIndex = 72;
            this.btnPrevious.Text = ">";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnLast
            // 
            this.btnLast.Location = new System.Drawing.Point(1192, 531);
            this.btnLast.Name = "btnLast";
            this.btnLast.Size = new System.Drawing.Size(56, 37);
            this.btnLast.TabIndex = 73;
            this.btnLast.Text = ">>";
            this.btnLast.UseVisualStyleBackColor = true;
            this.btnLast.Click += new System.EventHandler(this.btnLast_Click);
            // 
            // txtGiaDichVu
            // 
            this.txtGiaDichVu.BackColor = System.Drawing.Color.White;
            this.txtGiaDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaDichVu.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaDichVu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaDichVu.LineColor = System.Drawing.Color.LimeGreen;
            this.txtGiaDichVu.Location = new System.Drawing.Point(282, 339);
            this.txtGiaDichVu.Name = "txtGiaDichVu";
            this.txtGiaDichVu.PasswordChar = '\0';
            this.txtGiaDichVu.SelectedText = "";
            this.txtGiaDichVu.Size = new System.Drawing.Size(197, 34);
            this.txtGiaDichVu.TabIndex = 81;
            this.txtGiaDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTenDichVu
            // 
            this.txtTenDichVu.BackColor = System.Drawing.Color.White;
            this.txtTenDichVu.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenDichVu.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenDichVu.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTenDichVu.LineColor = System.Drawing.Color.LimeGreen;
            this.txtTenDichVu.Location = new System.Drawing.Point(282, 236);
            this.txtTenDichVu.Name = "txtTenDichVu";
            this.txtTenDichVu.PasswordChar = '\0';
            this.txtTenDichVu.SelectedText = "";
            this.txtTenDichVu.Size = new System.Drawing.Size(197, 34);
            this.txtTenDichVu.TabIndex = 80;
            this.txtTenDichVu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(64, 341);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(129, 28);
            this.gunaLabel3.TabIndex = 76;
            this.gunaLabel3.Text = "Giá Dịch Vụ: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(64, 236);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(94, 28);
            this.gunaLabel2.TabIndex = 75;
            this.gunaLabel2.Text = "Dịch Vụ: ";
            // 
            // gunaLabel6
            // 
            this.gunaLabel6.AutoSize = true;
            this.gunaLabel6.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel6.Location = new System.Drawing.Point(64, 135);
            this.gunaLabel6.Name = "gunaLabel6";
            this.gunaLabel6.Size = new System.Drawing.Size(89, 28);
            this.gunaLabel6.TabIndex = 74;
            this.gunaLabel6.Text = "Loại Xe: ";
            // 
            // btnADD
            // 
            this.btnADD.AnimationHoverSpeed = 0.07F;
            this.btnADD.AnimationSpeed = 0.03F;
            this.btnADD.BackColor = System.Drawing.Color.Transparent;
            this.btnADD.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnADD.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnADD.BorderColor = System.Drawing.Color.Black;
            this.btnADD.BorderSize = 1;
            this.btnADD.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnADD.FocusedColor = System.Drawing.Color.Empty;
            this.btnADD.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnADD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnADD.Image = null;
            this.btnADD.ImageSize = new System.Drawing.Size(20, 20);
            this.btnADD.Location = new System.Drawing.Point(42, 451);
            this.btnADD.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnADD.Name = "btnADD";
            this.btnADD.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnADD.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnADD.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnADD.OnHoverForeColor = System.Drawing.Color.White;
            this.btnADD.OnHoverImage = null;
            this.btnADD.OnPressedColor = System.Drawing.Color.Black;
            this.btnADD.Radius = 3;
            this.btnADD.Size = new System.Drawing.Size(170, 37);
            this.btnADD.TabIndex = 82;
            this.btnADD.Text = "ADD";
            this.btnADD.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnADD.Click += new System.EventHandler(this.btnADD_Click);
            // 
            // btnEDIT
            // 
            this.btnEDIT.AnimationHoverSpeed = 0.07F;
            this.btnEDIT.AnimationSpeed = 0.03F;
            this.btnEDIT.BackColor = System.Drawing.Color.Transparent;
            this.btnEDIT.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnEDIT.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnEDIT.BorderColor = System.Drawing.Color.Black;
            this.btnEDIT.BorderSize = 1;
            this.btnEDIT.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnEDIT.FocusedColor = System.Drawing.Color.Empty;
            this.btnEDIT.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEDIT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnEDIT.Image = null;
            this.btnEDIT.ImageSize = new System.Drawing.Size(20, 20);
            this.btnEDIT.Location = new System.Drawing.Point(342, 451);
            this.btnEDIT.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnEDIT.Name = "btnEDIT";
            this.btnEDIT.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnEDIT.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnEDIT.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnEDIT.OnHoverForeColor = System.Drawing.Color.White;
            this.btnEDIT.OnHoverImage = null;
            this.btnEDIT.OnPressedColor = System.Drawing.Color.Black;
            this.btnEDIT.Radius = 3;
            this.btnEDIT.Size = new System.Drawing.Size(170, 37);
            this.btnEDIT.TabIndex = 83;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // btnREMOVE
            // 
            this.btnREMOVE.AnimationHoverSpeed = 0.07F;
            this.btnREMOVE.AnimationSpeed = 0.03F;
            this.btnREMOVE.BackColor = System.Drawing.Color.Transparent;
            this.btnREMOVE.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREMOVE.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnREMOVE.BorderColor = System.Drawing.Color.Black;
            this.btnREMOVE.BorderSize = 1;
            this.btnREMOVE.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnREMOVE.FocusedColor = System.Drawing.Color.Empty;
            this.btnREMOVE.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnREMOVE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnREMOVE.Image = null;
            this.btnREMOVE.ImageSize = new System.Drawing.Size(20, 20);
            this.btnREMOVE.Location = new System.Drawing.Point(181, 531);
            this.btnREMOVE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnREMOVE.Name = "btnREMOVE";
            this.btnREMOVE.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnREMOVE.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnREMOVE.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnREMOVE.OnHoverForeColor = System.Drawing.Color.White;
            this.btnREMOVE.OnHoverImage = null;
            this.btnREMOVE.OnPressedColor = System.Drawing.Color.Black;
            this.btnREMOVE.Radius = 3;
            this.btnREMOVE.Size = new System.Drawing.Size(170, 37);
            this.btnREMOVE.TabIndex = 84;
            this.btnREMOVE.Text = "REMOVE";
            this.btnREMOVE.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnREMOVE.Click += new System.EventHandler(this.btnREMOVE_Click);
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
            "Xe Đạp",
            "Xe Máy",
            "Xe Hơi"});
            this.cbTxtType.Location = new System.Drawing.Point(282, 132);
            this.cbTxtType.Name = "cbTxtType";
            this.cbTxtType.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTxtType.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTxtType.Size = new System.Drawing.Size(197, 32);
            this.cbTxtType.TabIndex = 85;
            // 
            // lbCount
            // 
            this.lbCount.AutoSize = true;
            this.lbCount.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCount.Location = new System.Drawing.Point(900, 491);
            this.lbCount.Name = "lbCount";
            this.lbCount.Size = new System.Drawing.Size(238, 23);
            this.lbCount.TabIndex = 86;
            this.lbCount.Text = "Số Lượng Dịch Vụ: 0";
            // 
            // fEdit_dichVuSuaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1302, 602);
            this.Controls.Add(this.lbCount);
            this.Controls.Add(this.cbTxtType);
            this.Controls.Add(this.btnREMOVE);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.btnADD);
            this.Controls.Add(this.txtGiaDichVu);
            this.Controls.Add(this.txtTenDichVu);
            this.Controls.Add(this.gunaLabel3);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel6);
            this.Controls.Add(this.btnLast);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.btnFirst);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.cbTypeXe);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.lBoxDichVu);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEdit_dichVuSuaXe";
            this.Text = "fEdit_dichVuSuaXe";
            this.Load += new System.EventHandler(this.fEdit_dichVuSuaXe_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lBoxDichVu;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbTypeXe;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnFirst;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnLast;
        private Guna.UI.WinForms.GunaLineTextBox txtGiaDichVu;
        private Guna.UI.WinForms.GunaLineTextBox txtTenDichVu;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel6;
        private Guna.UI.WinForms.GunaGradientButton btnADD;
        private Guna.UI.WinForms.GunaGradientButton btnEDIT;
        private Guna.UI.WinForms.GunaGradientButton btnREMOVE;
        private Guna.UI.WinForms.GunaComboBox cbTxtType;
        private Guna.UI.WinForms.GunaLabel lbCount;
    }
}