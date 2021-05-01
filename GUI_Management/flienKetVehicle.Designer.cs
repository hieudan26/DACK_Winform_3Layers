
namespace GUI_Management
{
    partial class flienKetVehicle
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
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.cbIDCustomer = new Guna.UI.WinForms.GunaComboBox();
            this.txt_FullName = new Guna.UI.WinForms.GunaLineTextBox();
            this.gunaLabel3 = new Guna.UI.WinForms.GunaLabel();
            this.cbIDxe = new Guna.UI.WinForms.GunaComboBox();
            this.txtTypeVeh = new Guna.UI.WinForms.GunaLineTextBox();
            this.btnConfirm = new Guna.UI.WinForms.GunaGradientButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.gunaGradient2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.Controls.Add(this.textBox2);
            this.gunaGradient2Panel1.Controls.Add(this.textBox1);
            this.gunaGradient2Panel1.Controls.Add(this.panel1);
            this.gunaGradient2Panel1.Controls.Add(this.btnConfirm);
            this.gunaGradient2Panel1.Controls.Add(this.txtTypeVeh);
            this.gunaGradient2Panel1.Controls.Add(this.cbIDxe);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel3);
            this.gunaGradient2Panel1.Controls.Add(this.txt_FullName);
            this.gunaGradient2Panel1.Controls.Add(this.cbIDCustomer);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel2);
            this.gunaGradient2Panel1.Controls.Add(this.gunaLabel1);
            this.gunaGradient2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.gunaGradient2Panel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(0, 0);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(1017, 623);
            this.gunaGradient2Panel1.TabIndex = 0;
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(135, 22);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(765, 81);
            this.gunaLabel1.TabIndex = 0;
            this.gunaLabel1.Text = "XÁC MINH CHỦ QUYỀN XE";
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(132, 232);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(346, 32);
            this.gunaLabel2.TabIndex = 1;
            this.gunaLabel2.Text = "Danh Sách ID Người Sở Hữu Xe: ";
            // 
            // cbIDCustomer
            // 
            this.cbIDCustomer.BackColor = System.Drawing.Color.Transparent;
            this.cbIDCustomer.BaseColor = System.Drawing.Color.White;
            this.cbIDCustomer.BorderColor = System.Drawing.Color.Silver;
            this.cbIDCustomer.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDCustomer.FocusedColor = System.Drawing.Color.Empty;
            this.cbIDCustomer.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIDCustomer.ForeColor = System.Drawing.Color.Black;
            this.cbIDCustomer.FormattingEnabled = true;
            this.cbIDCustomer.Location = new System.Drawing.Point(533, 232);
            this.cbIDCustomer.Name = "cbIDCustomer";
            this.cbIDCustomer.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbIDCustomer.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbIDCustomer.Size = new System.Drawing.Size(302, 31);
            this.cbIDCustomer.TabIndex = 2;
            this.cbIDCustomer.SelectedIndexChanged += new System.EventHandler(this.cbIDCustomer_SelectedIndexChanged);
            // 
            // txt_FullName
            // 
            this.txt_FullName.BackColor = System.Drawing.Color.White;
            this.txt_FullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_FullName.Enabled = false;
            this.txt_FullName.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_FullName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_FullName.LineColor = System.Drawing.Color.LimeGreen;
            this.txt_FullName.Location = new System.Drawing.Point(293, 338);
            this.txt_FullName.Name = "txt_FullName";
            this.txt_FullName.PasswordChar = '\0';
            this.txt_FullName.SelectedText = "";
            this.txt_FullName.Size = new System.Drawing.Size(433, 34);
            this.txt_FullName.TabIndex = 101;
            this.txt_FullName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaLabel3
            // 
            this.gunaLabel3.AutoSize = true;
            this.gunaLabel3.Font = new System.Drawing.Font("Segoe UI Light", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel3.Location = new System.Drawing.Point(97, 447);
            this.gunaLabel3.Name = "gunaLabel3";
            this.gunaLabel3.Size = new System.Drawing.Size(257, 32);
            this.gunaLabel3.TabIndex = 102;
            this.gunaLabel3.Text = "Danh Sách Xe Trong Bãi";
            // 
            // cbIDxe
            // 
            this.cbIDxe.BackColor = System.Drawing.Color.Transparent;
            this.cbIDxe.BaseColor = System.Drawing.Color.White;
            this.cbIDxe.BorderColor = System.Drawing.Color.Silver;
            this.cbIDxe.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbIDxe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIDxe.FocusedColor = System.Drawing.Color.Empty;
            this.cbIDxe.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbIDxe.ForeColor = System.Drawing.Color.Black;
            this.cbIDxe.FormattingEnabled = true;
            this.cbIDxe.Location = new System.Drawing.Point(414, 448);
            this.cbIDxe.Name = "cbIDxe";
            this.cbIDxe.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbIDxe.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbIDxe.Size = new System.Drawing.Size(329, 31);
            this.cbIDxe.TabIndex = 103;
            this.cbIDxe.SelectedIndexChanged += new System.EventHandler(this.cbIDxe_SelectedIndexChanged);
            // 
            // txtTypeVeh
            // 
            this.txtTypeVeh.BackColor = System.Drawing.Color.White;
            this.txtTypeVeh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTypeVeh.Enabled = false;
            this.txtTypeVeh.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTypeVeh.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTypeVeh.LineColor = System.Drawing.Color.LimeGreen;
            this.txtTypeVeh.Location = new System.Drawing.Point(785, 448);
            this.txtTypeVeh.Name = "txtTypeVeh";
            this.txtTypeVeh.PasswordChar = '\0';
            this.txtTypeVeh.SelectedText = "";
            this.txtTypeVeh.Size = new System.Drawing.Size(126, 34);
            this.txtTypeVeh.TabIndex = 104;
            this.txtTypeVeh.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConfirm.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.ForeColor = System.Drawing.Color.Black;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(432, 541);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnConfirm.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 3;
            this.btnConfirm.Size = new System.Drawing.Size(160, 42);
            this.btnConfirm.TabIndex = 105;
            this.btnConfirm.Text = "= CONFIRM =";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(223, 152);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(565, 3);
            this.panel1.TabIndex = 106;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(49, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 107;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(49, 283);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 108;
            // 
            // flienKetVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 623);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "flienKetVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "flienKetVehicle";
            this.Load += new System.EventHandler(this.flienKetVehicle_Load);
            this.gunaGradient2Panel1.ResumeLayout(false);
            this.gunaGradient2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private Guna.UI.WinForms.GunaComboBox cbIDCustomer;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaLineTextBox txtTypeVeh;
        private Guna.UI.WinForms.GunaComboBox cbIDxe;
        private Guna.UI.WinForms.GunaLabel gunaLabel3;
        private Guna.UI.WinForms.GunaLineTextBox txt_FullName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI.WinForms.GunaGradientButton btnConfirm;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}