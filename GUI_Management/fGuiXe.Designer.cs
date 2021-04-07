
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
            this.btnConfirm = new Guna.UI.WinForms.GunaGradientButton();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.DarkGray;
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(3, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(33, 30);
            this.btnExit.TabIndex = 0;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.MouseLeave += new System.EventHandler(this.btnExit_MouseLeave);
            this.btnExit.MouseHover += new System.EventHandler(this.btnExit_MouseHover);
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
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(417, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(244, 95);
            this.label1.TabIndex = 2;
            this.label1.Text = "GỬI XE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(67, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 23);
            this.label2.TabIndex = 3;
            this.label2.Text = "Loại Xe:";
            // 
            // cbLoaiXe
            // 
            this.cbLoaiXe.BackColor = System.Drawing.Color.Transparent;
            this.cbLoaiXe.BaseColor = System.Drawing.Color.WhiteSmoke;
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
            this.cbLoaiXe.Location = new System.Drawing.Point(167, 83);
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
            this.picBox1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.picBox1.Location = new System.Drawing.Point(20, 173);
            this.picBox1.Name = "picBox1";
            this.picBox1.Size = new System.Drawing.Size(120, 108);
            this.picBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox1.TabIndex = 6;
            this.picBox1.TabStop = false;
            this.picBox1.UseTransfarantBackground = false;
            // 
            // picBox2
            // 
            this.picBox2.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.picBox2.Location = new System.Drawing.Point(460, 173);
            this.picBox2.Name = "picBox2";
            this.picBox2.Size = new System.Drawing.Size(120, 108);
            this.picBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox2.TabIndex = 5;
            this.picBox2.TabStop = false;
            this.picBox2.UseTransfarantBackground = false;
            // 
            // btnText2
            // 
            this.btnText2.AnimationHoverSpeed = 0.07F;
            this.btnText2.AnimationSpeed = 0.03F;
            this.btnText2.BackColor = System.Drawing.Color.Transparent;
            this.btnText2.BaseColor = System.Drawing.Color.LightGreen;
            this.btnText2.BorderColor = System.Drawing.Color.Black;
            this.btnText2.BorderSize = 1;
            this.btnText2.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnText2.FocusedColor = System.Drawing.Color.Empty;
            this.btnText2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText2.ForeColor = System.Drawing.Color.White;
            this.btnText2.Image = null;
            this.btnText2.ImageSize = new System.Drawing.Size(20, 20);
            this.btnText2.Location = new System.Drawing.Point(460, 278);
            this.btnText2.Name = "btnText2";
            this.btnText2.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btnText2.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnText2.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnText2.OnHoverImage = null;
            this.btnText2.OnPressedColor = System.Drawing.Color.Black;
            this.btnText2.Radius = 15;
            this.btnText2.Size = new System.Drawing.Size(120, 42);
            this.btnText2.TabIndex = 7;
            this.btnText2.Text = "Text";
            this.btnText2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnText1
            // 
            this.btnText1.AnimationHoverSpeed = 0.07F;
            this.btnText1.AnimationSpeed = 0.03F;
            this.btnText1.BackColor = System.Drawing.Color.Transparent;
            this.btnText1.BaseColor = System.Drawing.Color.LightGreen;
            this.btnText1.BorderColor = System.Drawing.Color.Black;
            this.btnText1.BorderSize = 1;
            this.btnText1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnText1.FocusedColor = System.Drawing.Color.Empty;
            this.btnText1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnText1.ForeColor = System.Drawing.Color.White;
            this.btnText1.Image = null;
            this.btnText1.ImageSize = new System.Drawing.Size(20, 20);
            this.btnText1.Location = new System.Drawing.Point(20, 278);
            this.btnText1.Name = "btnText1";
            this.btnText1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(126)))), ((int)(((byte)(214)))), ((int)(((byte)(223)))));
            this.btnText1.OnHoverBorderColor = System.Drawing.Color.White;
            this.btnText1.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnText1.OnHoverImage = null;
            this.btnText1.OnPressedColor = System.Drawing.Color.Black;
            this.btnText1.Radius = 15;
            this.btnText1.Size = new System.Drawing.Size(120, 42);
            this.btnText1.TabIndex = 8;
            this.btnText1.Text = "Text";
            this.btnText1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnUpImg1
            // 
            this.btnUpImg1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnUpImg1.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImg1.Location = new System.Drawing.Point(183, 208);
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
            this.btnUpImg2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(16)))), ((int)(((byte)(172)))), ((int)(((byte)(132)))));
            this.btnUpImg2.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpImg2.Location = new System.Drawing.Point(627, 208);
            this.btnUpImg2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnUpImg2.Name = "btnUpImg2";
            this.btnUpImg2.Size = new System.Drawing.Size(116, 49);
            this.btnUpImg2.TabIndex = 12;
            this.btnUpImg2.Text = "UP IMG";
            this.btnUpImg2.UseVisualStyleBackColor = false;
            this.btnUpImg2.Click += new System.EventHandler(this.btnUpImg2_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnConfirm.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(293, 356);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(1)))), ((int)(((byte)(163)))), ((int)(((byte)(164)))));
            this.btnConfirm.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(214)))), ((int)(((byte)(229)))));
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.WhiteSmoke;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.OnPressedDepth = 60;
            this.btnConfirm.Radius = 12;
            this.btnConfirm.Size = new System.Drawing.Size(160, 43);
            this.btnConfirm.TabIndex = 13;
            this.btnConfirm.Text = "CONFIRM";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // fGuiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(765, 411);
            this.Controls.Add(this.btnConfirm);
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
        private Guna.UI.WinForms.GunaGradientButton btnConfirm;
    }
}