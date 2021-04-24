
namespace GUI_Management
{
    partial class fphiGuiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fphiGuiXe));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiGui = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.labelGio = new System.Windows.Forms.Label();
            this.labelTuan = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.dtPicker = new Guna.UI.WinForms.GunaDateTimePicker();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Arial", 64.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(323, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(472, 122);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHÍ GỬI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(42, 311);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(112, 26);
            this.label2.TabIndex = 4;
            this.label2.Text = "Loại Gửi:";
            // 
            // cbLoaiGui
            // 
            this.cbLoaiGui.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiGui.BaseColor = System.Drawing.Color.White;
            this.cbLoaiGui.BorderColor = System.Drawing.Color.Silver;
            this.cbLoaiGui.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiGui.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiGui.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoaiGui.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiGui.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiGui.FormattingEnabled = true;
            this.cbLoaiGui.Items.AddRange(new object[] {
            "Hour(s)",
            "Day(s)",
            "Week(s)",
            "Month(s)"});
            this.cbLoaiGui.Location = new System.Drawing.Point(185, 310);
            this.cbLoaiGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiGui.Name = "cbLoaiGui";
            this.cbLoaiGui.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLoaiGui.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLoaiGui.Radius = 5;
            this.cbLoaiGui.Size = new System.Drawing.Size(252, 31);
            this.cbLoaiGui.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(732, 285);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 17);
            this.label3.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(469, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 17);
            this.label4.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(612, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(145, 35);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bảng Giá:";
            // 
            // labelGio
            // 
            this.labelGio.AutoSize = true;
            this.labelGio.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGio.ForeColor = System.Drawing.Color.Black;
            this.labelGio.Location = new System.Drawing.Point(613, 315);
            this.labelGio.Name = "labelGio";
            this.labelGio.Size = new System.Drawing.Size(253, 26);
            this.labelGio.TabIndex = 14;
            this.labelGio.Text = "Giá theo giờ:       ...........";
            // 
            // labelTuan
            // 
            this.labelTuan.AutoSize = true;
            this.labelTuan.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuan.ForeColor = System.Drawing.Color.Black;
            this.labelTuan.Location = new System.Drawing.Point(613, 443);
            this.labelTuan.Name = "labelTuan";
            this.labelTuan.Size = new System.Drawing.Size(255, 26);
            this.labelTuan.TabIndex = 15;
            this.labelTuan.Text = "Giá theo tuần:     ...........";
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.ForeColor = System.Drawing.Color.Black;
            this.labelThang.Location = new System.Drawing.Point(613, 503);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(255, 26);
            this.labelThang.TabIndex = 16;
            this.labelThang.Text = "Giá theo tháng:   ...........";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgay.ForeColor = System.Drawing.Color.Black;
            this.labelNgay.Location = new System.Drawing.Point(613, 379);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(252, 26);
            this.labelNgay.TabIndex = 17;
            this.labelNgay.Text = "Giá theo ngày:    ...........";
            // 
            // gunaGradientPanel1
            // 
            this.gunaGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel1.BackgroundImage")));
            this.gunaGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(82)))), ((int)(((byte)(82)))));
            this.gunaGradientPanel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(111)))), ((int)(((byte)(211)))));
            this.gunaGradientPanel1.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(241)))), ((int)(((byte)(227)))));
            this.gunaGradientPanel1.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(217)))), ((int)(((byte)(178)))));
            this.gunaGradientPanel1.Location = new System.Drawing.Point(544, 180);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(2, 400);
            this.gunaGradientPanel1.TabIndex = 10;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // dtPicker
            // 
            this.dtPicker.BackColor = System.Drawing.Color.Transparent;
            this.dtPicker.BaseColor = System.Drawing.Color.MintCream;
            this.dtPicker.BorderColor = System.Drawing.Color.SeaGreen;
            this.dtPicker.CustomFormat = "dd/MM - dddd";
            this.dtPicker.DropDownAlign = System.Windows.Forms.LeftRightAlignment.Right;
            this.dtPicker.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtPicker.ForeColor = System.Drawing.Color.DeepPink;
            this.dtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtPicker.Location = new System.Drawing.Point(781, 225);
            this.dtPicker.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtPicker.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.OnHoverBaseColor = System.Drawing.Color.White;
            this.dtPicker.OnHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.OnHoverForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dtPicker.OnPressedColor = System.Drawing.Color.Black;
            this.dtPicker.Radius = 5;
            this.dtPicker.Size = new System.Drawing.Size(241, 44);
            this.dtPicker.TabIndex = 18;
            this.dtPicker.Text = "09/04 - Friday";
            this.dtPicker.Value = new System.DateTime(2021, 4, 9, 0, 0, 0, 0);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Location = new System.Drawing.Point(162, 414);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(165, 49);
            this.btnOK.TabIndex = 19;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
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
            this.btnBack.Location = new System.Drawing.Point(1015, 20);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnBack.Size = new System.Drawing.Size(56, 20);
            this.btnBack.TabIndex = 20;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gunaGradientPanel2
            // 
            this.gunaGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gunaGradientPanel2.BackgroundImage")));
            this.gunaGradientPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gunaGradientPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.gunaGradientPanel2.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel2.GradientColor2 = System.Drawing.Color.White;
            this.gunaGradientPanel2.GradientColor3 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel2.GradientColor4 = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.gunaGradientPanel2.Location = new System.Drawing.Point(0, 0);
            this.gunaGradientPanel2.Name = "gunaGradientPanel2";
            this.gunaGradientPanel2.Size = new System.Drawing.Size(1083, 14);
            this.gunaGradientPanel2.TabIndex = 21;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // fphiGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1083, 605);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dtPicker);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.labelTuan);
            this.Controls.Add(this.labelGio);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLoaiGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fphiGuiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fphiGui";
            this.Load += new System.EventHandler(this.fphiGui_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbLoaiGui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private System.Windows.Forms.Label labelGio;
        private System.Windows.Forms.Label labelTuan;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelNgay;
        private Guna.UI.WinForms.GunaDateTimePicker dtPicker;
        private System.Windows.Forms.Button btnOK;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
    }
}