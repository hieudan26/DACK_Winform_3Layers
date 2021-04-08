
namespace GUI_Management
{
    partial class fdoanhThu
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
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.gunaGradient2Panel1 = new Guna.UI.WinForms.GunaGradient2Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtSLXeDap = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDTXeDap = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSLXeMay = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDTXeMay = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtSLXeHoi = new Guna.UI.WinForms.GunaLineTextBox();
            this.txtDTXeHoi = new Guna.UI.WinForms.GunaLineTextBox();
            this.dgvExpired = new Guna.UI.WinForms.GunaDataGridView();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTong = new Guna.UI.WinForms.GunaLineTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 46.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(-12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(737, 93);
            this.label1.TabIndex = 4;
            this.label1.Text = "DOANH THU TRONG NGÀY";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(15, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 8;
            this.label2.Text = "Số Lượng Xe Đạp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(15, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(138, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "Số Lượng Xe Máy:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(15, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 19);
            this.label4.TabIndex = 10;
            this.label4.Text = "Số Lượng Xe Hơi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(15, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 19);
            this.label5.TabIndex = 11;
            this.label5.Text = "Doanh Thu Xe Đạp:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(15, 280);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 19);
            this.label6.TabIndex = 12;
            this.label6.Text = "Doanh Thu Xe Máy:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(15, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 19);
            this.label7.TabIndex = 13;
            this.label7.Text = "Doanh Thu Xe Hơi:";
            // 
            // gunaGradient2Panel1
            // 
            this.gunaGradient2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.gunaGradient2Panel1.GradientColor1 = System.Drawing.Color.MediumSeaGreen;
            this.gunaGradient2Panel1.GradientColor2 = System.Drawing.Color.Snow;
            this.gunaGradient2Panel1.Location = new System.Drawing.Point(172, 105);
            this.gunaGradient2Panel1.Name = "gunaGradient2Panel1";
            this.gunaGradient2Panel1.Radius = 5;
            this.gunaGradient2Panel1.Size = new System.Drawing.Size(413, 4);
            this.gunaGradient2Panel1.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(192, 149);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 22);
            this.textBox1.TabIndex = 15;
            // 
            // txtSLXeDap
            // 
            this.txtSLXeDap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSLXeDap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLXeDap.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSLXeDap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSLXeDap.LineColor = System.Drawing.Color.ForestGreen;
            this.txtSLXeDap.Location = new System.Drawing.Point(192, 141);
            this.txtSLXeDap.Name = "txtSLXeDap";
            this.txtSLXeDap.PasswordChar = '\0';
            this.txtSLXeDap.SelectedText = "";
            this.txtSLXeDap.Size = new System.Drawing.Size(81, 30);
            this.txtSLXeDap.TabIndex = 17;
            // 
            // txtDTXeDap
            // 
            this.txtDTXeDap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDTXeDap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDTXeDap.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDTXeDap.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDTXeDap.LineColor = System.Drawing.Color.ForestGreen;
            this.txtDTXeDap.Location = new System.Drawing.Point(192, 182);
            this.txtDTXeDap.Name = "txtDTXeDap";
            this.txtDTXeDap.PasswordChar = '\0';
            this.txtDTXeDap.SelectedText = "";
            this.txtDTXeDap.Size = new System.Drawing.Size(81, 30);
            this.txtDTXeDap.TabIndex = 18;
            // 
            // txtSLXeMay
            // 
            this.txtSLXeMay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSLXeMay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLXeMay.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSLXeMay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSLXeMay.LineColor = System.Drawing.Color.ForestGreen;
            this.txtSLXeMay.Location = new System.Drawing.Point(192, 226);
            this.txtSLXeMay.Name = "txtSLXeMay";
            this.txtSLXeMay.PasswordChar = '\0';
            this.txtSLXeMay.SelectedText = "";
            this.txtSLXeMay.Size = new System.Drawing.Size(81, 30);
            this.txtSLXeMay.TabIndex = 19;
            // 
            // txtDTXeMay
            // 
            this.txtDTXeMay.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDTXeMay.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDTXeMay.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDTXeMay.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDTXeMay.LineColor = System.Drawing.Color.ForestGreen;
            this.txtDTXeMay.Location = new System.Drawing.Point(192, 269);
            this.txtDTXeMay.Name = "txtDTXeMay";
            this.txtDTXeMay.PasswordChar = '\0';
            this.txtDTXeMay.SelectedText = "";
            this.txtDTXeMay.Size = new System.Drawing.Size(81, 30);
            this.txtDTXeMay.TabIndex = 20;
            // 
            // txtSLXeHoi
            // 
            this.txtSLXeHoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSLXeHoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSLXeHoi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSLXeHoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSLXeHoi.LineColor = System.Drawing.Color.ForestGreen;
            this.txtSLXeHoi.Location = new System.Drawing.Point(192, 314);
            this.txtSLXeHoi.Name = "txtSLXeHoi";
            this.txtSLXeHoi.PasswordChar = '\0';
            this.txtSLXeHoi.SelectedText = "";
            this.txtSLXeHoi.Size = new System.Drawing.Size(81, 30);
            this.txtSLXeHoi.TabIndex = 21;
            // 
            // txtDTXeHoi
            // 
            this.txtDTXeHoi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDTXeHoi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDTXeHoi.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDTXeHoi.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDTXeHoi.LineColor = System.Drawing.Color.ForestGreen;
            this.txtDTXeHoi.Location = new System.Drawing.Point(192, 357);
            this.txtDTXeHoi.Name = "txtDTXeHoi";
            this.txtDTXeHoi.PasswordChar = '\0';
            this.txtDTXeHoi.SelectedText = "";
            this.txtDTXeHoi.Size = new System.Drawing.Size(81, 30);
            this.txtDTXeHoi.TabIndex = 22;
            // 
            // dgvExpired
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvExpired.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvExpired.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpired.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvExpired.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvExpired.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpired.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpired.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvExpired.ColumnHeadersHeight = 25;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvExpired.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvExpired.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnKeystroke;
            this.dgvExpired.EnableHeadersVisualStyles = false;
            this.dgvExpired.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvExpired.Location = new System.Drawing.Point(307, 172);
            this.dgvExpired.Name = "dgvExpired";
            this.dgvExpired.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvExpired.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvExpired.RowHeadersWidth = 51;
            this.dgvExpired.RowTemplate.Height = 24;
            this.dgvExpired.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvExpired.Size = new System.Drawing.Size(454, 215);
            this.dgvExpired.TabIndex = 23;
            this.dgvExpired.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Green;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(201)))), ((int)(((byte)(231)))), ((int)(((byte)(203)))));
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvExpired.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvExpired.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(231)))), ((int)(((byte)(201)))));
            this.dgvExpired.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.dgvExpired.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            this.dgvExpired.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpired.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvExpired.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvExpired.ThemeStyle.HeaderStyle.Height = 25;
            this.dgvExpired.ThemeStyle.ReadOnly = false;
            this.dgvExpired.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(219)))), ((int)(((byte)(239)))), ((int)(((byte)(220)))));
            this.dgvExpired.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvExpired.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvExpired.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvExpired.ThemeStyle.RowsStyle.Height = 24;
            this.dgvExpired.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(135)))), ((int)(((byte)(201)))), ((int)(((byte)(138)))));
            this.dgvExpired.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            this.dgvExpired.DoubleClick += new System.EventHandler(this.dgvExpired_DoubleClick);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Times New Roman", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Tomato;
            this.label8.Location = new System.Drawing.Point(351, 141);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 19);
            this.label8.TabIndex = 24;
            this.label8.Text = "Danh Sách Xe Quá Hạn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(188, 419);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 19);
            this.label9.TabIndex = 25;
            this.label9.Text = "Tổng:";
            // 
            // txtTong
            // 
            this.txtTong.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTong.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTong.FocusedLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTong.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTong.LineColor = System.Drawing.Color.ForestGreen;
            this.txtTong.Location = new System.Drawing.Point(271, 408);
            this.txtTong.Name = "txtTong";
            this.txtTong.PasswordChar = '\0';
            this.txtTong.SelectedText = "";
            this.txtTong.Size = new System.Drawing.Size(127, 30);
            this.txtTong.TabIndex = 26;
            // 
            // fdoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(765, 460);
            this.Controls.Add(this.txtTong);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.dgvExpired);
            this.Controls.Add(this.txtDTXeHoi);
            this.Controls.Add(this.txtSLXeHoi);
            this.Controls.Add(this.txtDTXeMay);
            this.Controls.Add(this.txtSLXeMay);
            this.Controls.Add(this.txtDTXeDap);
            this.Controls.Add(this.txtSLXeDap);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.gunaGradient2Panel1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fdoanhThu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fdoanhThu";
            this.Load += new System.EventHandler(this.fdoanhThu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpired)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.Label label7;
        private Guna.UI.WinForms.GunaGradient2Panel gunaGradient2Panel1;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI.WinForms.GunaLineTextBox txtSLXeDap;
        private Guna.UI.WinForms.GunaLineTextBox txtDTXeDap;
        private Guna.UI.WinForms.GunaLineTextBox txtSLXeMay;
        private Guna.UI.WinForms.GunaLineTextBox txtDTXeMay;
        private Guna.UI.WinForms.GunaLineTextBox txtSLXeHoi;
        private Guna.UI.WinForms.GunaLineTextBox txtDTXeHoi;
        private Guna.UI.WinForms.GunaDataGridView dgvExpired;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        private Guna.UI.WinForms.GunaLineTextBox txtTong;
    }
}