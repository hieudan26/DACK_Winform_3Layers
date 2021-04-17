
namespace GUI_Management
{
    partial class fphiSuaXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fphiSuaXe));
            this.label1 = new System.Windows.Forms.Label();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.cbDichVu = new Guna.UI.WinForms.GunaComboBox();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.txtGiaTien = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnFix = new Guna.UI.WinForms.GunaGradientButton();
            this.gunaTransfarantPictureBox1 = new Guna.UI.WinForms.GunaTransfarantPictureBox();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Arial", 64.8F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(206, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(503, 122);
            this.label1.TabIndex = 4;
            this.label1.Text = "PHÍ SỬA";
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
            this.btnBack.Location = new System.Drawing.Point(794, 21);
            this.btnBack.Name = "btnBack";
            this.btnBack.OnHoverBaseColor = System.Drawing.Color.Transparent;
            this.btnBack.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnBack.OnHoverForeColor = System.Drawing.Color.White;
            this.btnBack.OnHoverImage = null;
            this.btnBack.OnPressedColor = System.Drawing.Color.Transparent;
            this.btnBack.Size = new System.Drawing.Size(56, 20);
            this.btnBack.TabIndex = 23;
            this.btnBack.Text = "Back";
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(35, 383);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(162, 27);
            this.gunaLabel1.TabIndex = 24;
            this.gunaLabel1.Text = "Dịch Vụ Sửa: ";
            // 
            // cbDichVu
            // 
            this.cbDichVu.BackColor = System.Drawing.Color.Transparent;
            this.cbDichVu.BaseColor = System.Drawing.Color.White;
            this.cbDichVu.BorderColor = System.Drawing.Color.Silver;
            this.cbDichVu.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbDichVu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbDichVu.FocusedColor = System.Drawing.Color.Empty;
            this.cbDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDichVu.ForeColor = System.Drawing.Color.Black;
            this.cbDichVu.FormattingEnabled = true;
            this.cbDichVu.Items.AddRange(new object[] {
            "Dịch Vụ 1",
            "Dịch Vụ 2",
            "Dịch Vụ 3",
            "Dịch Vụ 4",
            "Dịch Vụ 5",
            "Dịch Vụ 6",
            "Dịch Vụ 7",
            "Dịch Vụ 8",
            "Dịch Vụ 9",
            "Dịch Vụ 10"});
            this.cbDichVu.Location = new System.Drawing.Point(203, 379);
            this.cbDichVu.Name = "cbDichVu";
            this.cbDichVu.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbDichVu.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbDichVu.Size = new System.Drawing.Size(223, 31);
            this.cbDichVu.TabIndex = 25;
            this.cbDichVu.SelectedIndexChanged += new System.EventHandler(this.cbDichVu_SelectedIndexChanged);
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(495, 383);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(147, 27);
            this.gunaLabel2.TabIndex = 26;
            this.gunaLabel2.Text = "Thành Tiền: ";
            // 
            // txtGiaTien
            // 
            this.txtGiaTien.BackColor = System.Drawing.Color.White;
            this.txtGiaTien.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaTien.Enabled = false;
            this.txtGiaTien.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtGiaTien.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaTien.LineColor = System.Drawing.Color.LimeGreen;
            this.txtGiaTien.Location = new System.Drawing.Point(663, 379);
            this.txtGiaTien.Name = "txtGiaTien";
            this.txtGiaTien.PasswordChar = '\0';
            this.txtGiaTien.SelectedText = "";
            this.txtGiaTien.Size = new System.Drawing.Size(154, 33);
            this.txtGiaTien.TabIndex = 31;
            // 
            // btnFix
            // 
            this.btnFix.AnimationHoverSpeed = 0.07F;
            this.btnFix.AnimationSpeed = 0.03F;
            this.btnFix.BackColor = System.Drawing.Color.Transparent;
            this.btnFix.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFix.BaseColor2 = System.Drawing.Color.White;
            this.btnFix.BorderColor = System.Drawing.Color.Black;
            this.btnFix.BorderSize = 1;
            this.btnFix.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnFix.FocusedColor = System.Drawing.Color.Empty;
            this.btnFix.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnFix.Image = null;
            this.btnFix.ImageSize = new System.Drawing.Size(20, 20);
            this.btnFix.Location = new System.Drawing.Point(348, 464);
            this.btnFix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnFix.Name = "btnFix";
            this.btnFix.OnHoverBaseColor1 = System.Drawing.Color.White;
            this.btnFix.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnFix.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnFix.OnHoverForeColor = System.Drawing.Color.White;
            this.btnFix.OnHoverImage = null;
            this.btnFix.OnPressedColor = System.Drawing.Color.Black;
            this.btnFix.Radius = 3;
            this.btnFix.Size = new System.Drawing.Size(149, 37);
            this.btnFix.TabIndex = 34;
            this.btnFix.Text = "FIX";
            this.btnFix.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnFix.Click += new System.EventHandler(this.btnFix_Click);
            // 
            // gunaTransfarantPictureBox1
            // 
            this.gunaTransfarantPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.gunaTransfarantPictureBox1.BaseColor = System.Drawing.Color.Black;
            this.gunaTransfarantPictureBox1.Image = global::GUI_Management.Properties.Resources.Castrol;
            this.gunaTransfarantPictureBox1.Location = new System.Drawing.Point(141, 127);
            this.gunaTransfarantPictureBox1.Name = "gunaTransfarantPictureBox1";
            this.gunaTransfarantPictureBox1.Size = new System.Drawing.Size(625, 203);
            this.gunaTransfarantPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.gunaTransfarantPictureBox1.TabIndex = 35;
            this.gunaTransfarantPictureBox1.TabStop = false;
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
            this.gunaGradientPanel2.Size = new System.Drawing.Size(862, 14);
            this.gunaGradientPanel2.TabIndex = 22;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // fphiSuaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(862, 536);
            this.Controls.Add(this.gunaTransfarantPictureBox1);
            this.Controls.Add(this.btnFix);
            this.Controls.Add(this.txtGiaTien);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.cbDichVu);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fphiSuaXe";
            this.Text = "x";
            this.Load += new System.EventHandler(this.fphiSuaXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gunaTransfarantPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaComboBox cbDichVu;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLineTextBox txtGiaTien;
        private Guna.UI.WinForms.GunaGradientButton btnFix;
        private Guna.UI.WinForms.GunaTransfarantPictureBox gunaTransfarantPictureBox1;
    }
}