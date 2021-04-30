
namespace GUI_Management
{
    partial class fEdit_phiRuaXe
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
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.cbTypeXe = new Guna.UI.WinForms.GunaComboBox();
            this.txtRuaXe = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtFee = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.btnEDIT = new Guna.UI.WinForms.GunaGradientButton();
            this.picBox = new Guna.UI.WinForms.GunaPictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(723, 67);
            this.label1.TabIndex = 66;
            this.label1.Text = "CHỈNH SỬA PHÍ RỬA XE";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.MintCream;
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(661, 117);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(5, 420);
            this.gunaGradient2Panel1.TabIndex = 68;
            // 
            // cbTypeXe
            // 
            this.cbTypeXe.BackColor = System.Drawing.Color.Transparent;
            this.cbTypeXe.BaseColor = System.Drawing.Color.White;
            this.cbTypeXe.BorderColor = System.Drawing.Color.Silver;
            this.cbTypeXe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbTypeXe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbTypeXe.FocusedColor = System.Drawing.Color.Empty;
            this.cbTypeXe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbTypeXe.ForeColor = System.Drawing.Color.Black;
            this.cbTypeXe.FormattingEnabled = true;
            this.cbTypeXe.Items.AddRange(new object[] {
            "Xe Đạp",
            "Xe Máy",
            "Xe Hơi"});
            this.cbTypeXe.Location = new System.Drawing.Point(965, 228);
            this.cbTypeXe.Name = "cbTypeXe";
            this.cbTypeXe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbTypeXe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbTypeXe.Size = new System.Drawing.Size(269, 31);
            this.cbTypeXe.TabIndex = 69;
            this.cbTypeXe.SelectedIndexChanged += new System.EventHandler(this.cbTypeXe_SelectedIndexChanged);
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
            // txtFee
            // 
            this.txtFee.BackColor = System.Drawing.Color.White;
            this.txtFee.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFee.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtFee.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFee.LineColor = System.Drawing.Color.LimeGreen;
            this.txtFee.Location = new System.Drawing.Point(1069, 362);
            this.txtFee.Name = "txtFee";
            this.txtFee.PasswordChar = '\0';
            this.txtFee.SelectedText = "";
            this.txtFee.Size = new System.Drawing.Size(165, 34);
            this.txtFee.TabIndex = 70;
            this.txtFee.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(768, 226);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(96, 28);
            this.gunaLabel1.TabIndex = 71;
            this.gunaLabel1.Text = "Loại Xe: ";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(768, 362);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(131, 28);
            this.gunaLabel2.TabIndex = 72;
            this.gunaLabel2.Text = "Phí Rửa Xe: ";
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
            this.btnEDIT.Location = new System.Drawing.Point(575, 554);
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
            this.btnEDIT.TabIndex = 73;
            this.btnEDIT.Text = "EDIT";
            this.btnEDIT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnEDIT.Click += new System.EventHandler(this.btnEDIT_Click);
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.BaseColor = System.Drawing.Color.Transparent;
            this.picBox.Location = new System.Drawing.Point(86, 164);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(421, 331);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBox.TabIndex = 67;
            this.picBox.TabStop = false;
            // 
            // fEdit_phiRuaXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1302, 602);
            this.Controls.Add(this.btnEDIT);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.txtFee);
            this.Controls.Add(this.cbTypeXe);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.picBox);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fEdit_phiRuaXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fEdit_phiRuaXe";
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaPictureBox picBox;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaComboBox cbTypeXe;
        private Guna.UI.WinForms.GunaLineTextBox txtRuaXe;
        private Guna.UI.WinForms.GunaLineTextBox txtFee;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaGradientButton btnEDIT;
    }
}