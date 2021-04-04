
namespace GUI_Management
{
    partial class fphiGui
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fphiGui));
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiGui = new Guna.UI.WinForms.GunaComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnOK = new Guna.UI.WinForms.GunaGradientCircleButton();
            this.labelGio = new System.Windows.Forms.Label();
            this.labelTuan = new System.Windows.Forms.Label();
            this.labelThang = new System.Windows.Forms.Label();
            this.labelNgay = new System.Windows.Forms.Label();
            this.gunaGradientPanel1 = new Guna.UI.WinForms.GunaGradientPanel();
            this.dTpickerThu = new System.Windows.Forms.DateTimePicker();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 33);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(229, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 95);
            this.label1.TabIndex = 3;
            this.label1.Text = "PHÍ GỬI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 232);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 23);
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
            this.cbLoaiGui.Location = new System.Drawing.Point(161, 228);
            this.cbLoaiGui.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbLoaiGui.Name = "cbLoaiGui";
            this.cbLoaiGui.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLoaiGui.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLoaiGui.Radius = 5;
            this.cbLoaiGui.Size = new System.Drawing.Size(143, 31);
            this.cbLoaiGui.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(501, 176);
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
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(480, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 23);
            this.label5.TabIndex = 9;
            this.label5.Text = "Bảng Giá:";
            // 
            // btnOK
            // 
            this.btnOK.AnimationHoverSpeed = 0.07F;
            this.btnOK.AnimationSpeed = 0.03F;
            this.btnOK.BaseColor1 = System.Drawing.Color.Magenta;
            this.btnOK.BaseColor2 = System.Drawing.Color.DeepSkyBlue;
            this.btnOK.BorderColor = System.Drawing.Color.Black;
            this.btnOK.BorderSize = 2;
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnOK.FocusedColor = System.Drawing.Color.Empty;
            this.btnOK.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.ForeColor = System.Drawing.Color.White;
            this.btnOK.Image = null;
            this.btnOK.ImageSize = new System.Drawing.Size(52, 52);
            this.btnOK.Location = new System.Drawing.Point(148, 296);
            this.btnOK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnOK.Name = "btnOK";
            this.btnOK.OnHoverBaseColor1 = System.Drawing.Color.DeepSkyBlue;
            this.btnOK.OnHoverBaseColor2 = System.Drawing.Color.Magenta;
            this.btnOK.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnOK.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnOK.OnHoverImage = null;
            this.btnOK.OnPressedColor = System.Drawing.Color.Black;
            this.btnOK.Size = new System.Drawing.Size(60, 50);
            this.btnOK.TabIndex = 13;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // labelGio
            // 
            this.labelGio.AutoSize = true;
            this.labelGio.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGio.ForeColor = System.Drawing.Color.Black;
            this.labelGio.Location = new System.Drawing.Point(402, 217);
            this.labelGio.Name = "labelGio";
            this.labelGio.Size = new System.Drawing.Size(211, 23);
            this.labelGio.TabIndex = 14;
            this.labelGio.Text = "Giá theo giờ:       ...........";
            this.labelGio.Click += new System.EventHandler(this.label6_Click);
            // 
            // labelTuan
            // 
            this.labelTuan.AutoSize = true;
            this.labelTuan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTuan.ForeColor = System.Drawing.Color.Black;
            this.labelTuan.Location = new System.Drawing.Point(402, 309);
            this.labelTuan.Name = "labelTuan";
            this.labelTuan.Size = new System.Drawing.Size(212, 23);
            this.labelTuan.TabIndex = 15;
            this.labelTuan.Text = "Giá theo tuần:     ...........";
            // 
            // labelThang
            // 
            this.labelThang.AutoSize = true;
            this.labelThang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelThang.ForeColor = System.Drawing.Color.Black;
            this.labelThang.Location = new System.Drawing.Point(402, 355);
            this.labelThang.Name = "labelThang";
            this.labelThang.Size = new System.Drawing.Size(212, 23);
            this.labelThang.TabIndex = 16;
            this.labelThang.Text = "Giá theo tháng:   ...........";
            // 
            // labelNgay
            // 
            this.labelNgay.AutoSize = true;
            this.labelNgay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgay.ForeColor = System.Drawing.Color.Black;
            this.labelNgay.Location = new System.Drawing.Point(402, 263);
            this.labelNgay.Name = "labelNgay";
            this.labelNgay.Size = new System.Drawing.Size(210, 23);
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
            this.gunaGradientPanel1.Location = new System.Drawing.Point(353, 165);
            this.gunaGradientPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gunaGradientPanel1.Name = "gunaGradientPanel1";
            this.gunaGradientPanel1.Size = new System.Drawing.Size(5, 222);
            this.gunaGradientPanel1.TabIndex = 10;
            this.gunaGradientPanel1.Text = "gunaGradientPanel1";
            // 
            // dTpickerThu
            // 
            this.dTpickerThu.CustomFormat = "dddd";
            this.dTpickerThu.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dTpickerThu.Location = new System.Drawing.Point(596, 176);
            this.dTpickerThu.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dTpickerThu.Name = "dTpickerThu";
            this.dTpickerThu.Size = new System.Drawing.Size(125, 22);
            this.dTpickerThu.TabIndex = 11;
            // 
            // fphiGui
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(765, 411);
            this.Controls.Add(this.labelNgay);
            this.Controls.Add(this.labelThang);
            this.Controls.Add(this.labelTuan);
            this.Controls.Add(this.labelGio);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.dTpickerThu);
            this.Controls.Add(this.gunaGradientPanel1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cbLoaiGui);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "fphiGui";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fphiGui";
            this.Load += new System.EventHandler(this.fphiGui_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbLoaiGui;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel1;
        private Guna.UI.WinForms.GunaGradientCircleButton btnOK;
        private System.Windows.Forms.Label labelGio;
        private System.Windows.Forms.Label labelTuan;
        private System.Windows.Forms.Label labelThang;
        private System.Windows.Forms.Label labelNgay;
        private System.Windows.Forms.DateTimePicker dTpickerThu;
    }
}