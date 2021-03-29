
namespace GUI_Management
{
    partial class fGuiXe
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
            this.btnExit = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbLoaiXe = new Guna.UI.WinForms.GunaComboBox();
            this.picBox1 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.picBox2 = new Guna.UI.WinForms.GunaCirclePictureBox();
            this.btnText2 = new Guna.UI.WinForms.GunaButton();
            this.btnText1 = new Guna.UI.WinForms.GunaButton();
            this.btnUpImg1 = new System.Windows.Forms.Button();
            this.btnUpImg2 = new System.Windows.Forms.Button();
            this.gunaGradientButton1 = new Guna.UI.WinForms.GunaGradientButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(55, 28);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 33);
            this.flowLayoutPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Salmon;
            this.label1.Location = new System.Drawing.Point(281, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 67);
            this.label1.TabIndex = 2;
            this.label1.Text = "GỬI XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.label2.Location = new System.Drawing.Point(227, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Xe:";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiXe.BaseColor = System.Drawing.Color.LightGray;
            this.cbLoaiXe.BorderColor = System.Drawing.Color.Silver;
            this.cbLoaiXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbLoaiXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbLoaiXe.FocusedColor = System.Drawing.Color.Empty;
            this.cbLoaiXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbLoaiXe.ForeColor = System.Drawing.Color.Black;
            this.cbLoaiXe.FormattingEnabled = true;
            this.cbLoaiXe.Items.AddRange(new object[] {
            "Xe Đạp",
            "Xe Motor",
            "Xe Hơi/Oto"});
            this.cbLoaiXe.Location = new System.Drawing.Point(327, 105);
            this.cbLoaiXe.Name = "cbLoaiXe";
            this.cbLoaiXe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbLoaiXe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbLoaiXe.Radius = 5;
            this.cbLoaiXe.Size = new System.Drawing.Size(183, 31);
            this.cbLoaiXe.TabIndex = 4;
            this.cbLoaiXe.SelectedIndexChanged += new System.EventHandler(this.cbLoaiXe_SelectedIndexChanged);
            // 
            // picBox1
            // 
            this.picBox1.BaseColor = System.Drawing.Color.LightCyan;
            this.picBox1.Location = new System.Drawing.Point(28, 165);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(120, 101);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 6;
            this.picBox1.TabStop = false;
            this.picBox1.UseTransfarantBackground = false;
            // 
            // picBox2
            // 
            this.picBox2.BaseColor = System.Drawing.Color.LightCyan;
            this.picBox2.Location = new System.Drawing.Point(468, 165);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(120, 101);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 5;
            this.picBox2.TabStop = false;
            this.picBox2.UseTransfarantBackground = false;
            // 
            // btnText2
            // 
            this.btnText2.AnimationHoverSpeed = 0.07F;
            this.btnText2.AnimationSpeed = 0.03F;
            this.btnText2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnText2.BorderColor = System.Drawing.Color.Black;
            this.btnText2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnText2.FocusedColor = System.Drawing.Color.Empty;
            this.btnText2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText2.ForeColor = System.Drawing.Color.White;
            this.btnText2.Image = null;
            this.btnText2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnText2.Location = new System.Drawing.Point(468, 263);
            this.btnText2.Name = "btnText2";
            this.btnText2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnText2.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnText2.OnHoverForeColor = System.Drawing.Color.White;
            this.btnText2.OnHoverImage = null;
            this.btnText2.OnPressedColor = System.Drawing.Color.Black;
            this.btnText2.Size = new System.Drawing.Size(120, 42);
            this.btnText2.TabIndex = 7;
            this.btnText2.Text = "Text";
            this.btnText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnText1
            // 
            this.btnText1.AnimationHoverSpeed = 0.07F;
            this.btnText1.AnimationSpeed = 0.03F;
            this.btnText1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnText1.BorderColor = System.Drawing.Color.Black;
            this.btnText1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnText1.FocusedColor = System.Drawing.Color.Empty;
            this.btnText1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText1.ForeColor = System.Drawing.Color.White;
            this.btnText1.Image = null;
            this.btnText1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnText1.Location = new System.Drawing.Point(28, 263);
            this.btnText1.Name = "btnText1";
            this.btnText1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnText1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnText1.OnHoverForeColor = System.Drawing.Color.White;
            this.btnText1.OnHoverImage = null;
            this.btnText1.OnPressedColor = System.Drawing.Color.Black;
            this.btnText1.Size = new System.Drawing.Size(120, 42);
            this.btnText1.TabIndex = 8;
            this.btnText1.Text = "Text";
            this.btnText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpImg1
            // 
            this.btnUpImg1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpImg1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImg1.Location = new System.Drawing.Point(191, 193);
            this.btnUpImg1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpImg1.Name = "btnUpImg1";
            this.btnUpImg1.Size = new System.Drawing.Size(116, 49);
            this.btnUpImg1.TabIndex = 11;
            this.btnUpImg1.Text = "UP IMG";
            this.btnUpImg1.UseVisualStyleBackColor = false;
            this.btnUpImg1.Click += new System.EventHandler(this.btnUpImg1_Click);
            // 
            // btnUpImg2
            // 
            this.btnUpImg2.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnUpImg2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImg2.Location = new System.Drawing.Point(631, 194);
            this.btnUpImg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpImg2.Name = "btnUpImg2";
            this.btnUpImg2.Size = new System.Drawing.Size(116, 49);
            this.btnUpImg2.TabIndex = 12;
            this.btnUpImg2.Text = "UP IMG";
            this.btnUpImg2.UseVisualStyleBackColor = false;
            this.btnUpImg2.Click += new System.EventHandler(this.btnUpImg2_Click);
            // 
            // gunaGradientButton1
            // 
            this.gunaGradientButton1.AnimationHoverSpeed = 0.07F;
            this.gunaGradientButton1.AnimationSpeed = 0.03F;
            this.gunaGradientButton1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradientButton1.BaseColor1 = System.Drawing.Color.SlateBlue;
            this.gunaGradientButton1.BaseColor2 = System.Drawing.Color.Fuchsia;
            this.gunaGradientButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaGradientButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaGradientButton1.Font = new System.Drawing.Font("Times New Roman", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Strikeout))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaGradientButton1.ForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.Image = null;
            this.gunaGradientButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaGradientButton1.Location = new System.Drawing.Point(293, 357);
            this.gunaGradientButton1.Name = "gunaGradientButton1";
            this.gunaGradientButton1.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(155)))), ((int)(((byte)(145)))), ((int)(((byte)(221)))));
            this.gunaGradientButton1.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(85)))), ((int)(((byte)(255)))));
            this.gunaGradientButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaGradientButton1.OnHoverImage = null;
            this.gunaGradientButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaGradientButton1.Radius = 17;
            this.gunaGradientButton1.Size = new System.Drawing.Size(160, 42);
            this.gunaGradientButton1.TabIndex = 13;
            this.gunaGradientButton1.Text = "CONFIRM";
            this.gunaGradientButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // fGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LavenderBlush;
            this.ClientSize = new System.Drawing.Size(765, 411);
            this.Controls.Add(this.gunaGradientButton1);
            this.Controls.Add(this.btnUpImg2);
            this.Controls.Add(this.btnUpImg1);
            this.Controls.Add(this.btnText1);
            this.Controls.Add(this.btnText2);
            this.Controls.Add(this.picBox1);
            this.Controls.Add(this.picBox2);
            this.Controls.Add(this.cbLoaiXe);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fGuiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gửi Xe";
            this.Load += new System.EventHandler(this.fGuiXe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaComboBox cbLoaiXe;
        private Guna.UI.WinForms.GunaCirclePictureBox picBox2;
        private Guna.UI.WinForms.GunaCirclePictureBox picBox1;
        private Guna.UI.WinForms.GunaButton btnText2;
        private Guna.UI.WinForms.GunaButton btnText1;
        private System.Windows.Forms.Button btnUpImg1;
        private System.Windows.Forms.Button btnUpImg2;
        private Guna.UI.WinForms.GunaGradientButton gunaGradientButton1;
    }
}