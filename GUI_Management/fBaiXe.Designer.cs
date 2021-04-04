
namespace GUI_Management
{
    partial class fBaiXe
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.flpKhuA = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKhuB = new System.Windows.Forms.FlowLayoutPanel();
            this.flpKhuC = new System.Windows.Forms.FlowLayoutPanel();
            this.lbA = new System.Windows.Forms.Label();
            this.lbB = new System.Windows.Forms.Label();
            this.lbC = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.gunaVScrollBar1 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaVScrollBar2 = new Guna.UI.WinForms.GunaVScrollBar();
            this.gunaVScrollBar3 = new Guna.UI.WinForms.GunaVScrollBar();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.btnExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(765, 33);
            this.flowLayoutPanel1.TabIndex = 2;
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label1.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label1.Location = new System.Drawing.Point(250, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 95);
            this.label1.TabIndex = 4;
            this.label1.Text = "BÃI XE";
            // 
            // flpKhuA
            // 
            this.flpKhuA.Location = new System.Drawing.Point(28, 184);
            this.flpKhuA.Name = "flpKhuA";
            this.flpKhuA.Size = new System.Drawing.Size(212, 201);
            this.flpKhuA.TabIndex = 5;
            // 
            // flpKhuB
            // 
            this.flpKhuB.Location = new System.Drawing.Point(272, 184);
            this.flpKhuB.Name = "flpKhuB";
            this.flpKhuB.Size = new System.Drawing.Size(212, 201);
            this.flpKhuB.TabIndex = 6;
            // 
            // flpKhuC
            // 
            this.flpKhuC.Location = new System.Drawing.Point(520, 184);
            this.flpKhuC.Name = "flpKhuC";
            this.flpKhuC.Size = new System.Drawing.Size(212, 201);
            this.flpKhuC.TabIndex = 7;
            // 
            // lbA
            // 
            this.lbA.AutoSize = true;
            this.lbA.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbA.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbA.Location = new System.Drawing.Point(49, 149);
            this.lbA.Name = "lbA";
            this.lbA.Size = new System.Drawing.Size(123, 24);
            this.lbA.TabIndex = 8;
            this.lbA.Text = "Bãi Xe Khu A";
            // 
            // lbB
            // 
            this.lbB.AutoSize = true;
            this.lbB.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbB.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbB.Location = new System.Drawing.Point(296, 149);
            this.lbB.Name = "lbB";
            this.lbB.Size = new System.Drawing.Size(124, 24);
            this.lbB.TabIndex = 9;
            this.lbB.Text = "Bãi Xe Khu B";
            // 
            // lbC
            // 
            this.lbC.AutoSize = true;
            this.lbC.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbC.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.lbC.Location = new System.Drawing.Point(542, 149);
            this.lbC.Name = "lbC";
            this.lbC.Size = new System.Drawing.Size(125, 24);
            this.lbC.TabIndex = 10;
            this.lbC.Text = "Bãi Xe Khu C";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label5.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label5.Location = new System.Drawing.Point(134, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 95);
            this.label5.TabIndex = 11;
            this.label5.Text = "~";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.label6.Font = new System.Drawing.Font("Mistral", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            this.label6.Location = new System.Drawing.Point(495, 36);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 95);
            this.label6.TabIndex = 12;
            this.label6.Text = "~";
            // 
            // gunaVScrollBar1
            // 
            this.gunaVScrollBar1.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar1.LargeChange = 10;
            this.gunaVScrollBar1.Location = new System.Drawing.Point(246, 184);
            this.gunaVScrollBar1.Maximum = 100;
            this.gunaVScrollBar1.Name = "gunaVScrollBar1";
            this.gunaVScrollBar1.Radius = 2;
            this.gunaVScrollBar1.ScrollIdleColor = System.Drawing.Color.LavenderBlush;
            this.gunaVScrollBar1.Size = new System.Drawing.Size(6, 201);
            this.gunaVScrollBar1.TabIndex = 13;
            this.gunaVScrollBar1.ThumbColor = System.Drawing.Color.Crimson;
            this.gunaVScrollBar1.ThumbHoverColor = System.Drawing.Color.LightCoral;
            this.gunaVScrollBar1.ThumbPressedColor = System.Drawing.Color.MistyRose;
            // 
            // gunaVScrollBar2
            // 
            this.gunaVScrollBar2.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar2.LargeChange = 10;
            this.gunaVScrollBar2.Location = new System.Drawing.Point(490, 184);
            this.gunaVScrollBar2.Maximum = 100;
            this.gunaVScrollBar2.Name = "gunaVScrollBar2";
            this.gunaVScrollBar2.Radius = 2;
            this.gunaVScrollBar2.ScrollIdleColor = System.Drawing.Color.GhostWhite;
            this.gunaVScrollBar2.Size = new System.Drawing.Size(6, 201);
            this.gunaVScrollBar2.TabIndex = 14;
            this.gunaVScrollBar2.ThumbColor = System.Drawing.Color.SandyBrown;
            this.gunaVScrollBar2.ThumbHoverColor = System.Drawing.Color.LightCoral;
            this.gunaVScrollBar2.ThumbPressedColor = System.Drawing.Color.MistyRose;
            // 
            // gunaVScrollBar3
            // 
            this.gunaVScrollBar3.BackColor = System.Drawing.Color.Transparent;
            this.gunaVScrollBar3.LargeChange = 10;
            this.gunaVScrollBar3.Location = new System.Drawing.Point(738, 184);
            this.gunaVScrollBar3.Maximum = 100;
            this.gunaVScrollBar3.Name = "gunaVScrollBar3";
            this.gunaVScrollBar3.Radius = 2;
            this.gunaVScrollBar3.ScrollIdleColor = System.Drawing.Color.LightCyan;
            this.gunaVScrollBar3.Size = new System.Drawing.Size(6, 201);
            this.gunaVScrollBar3.TabIndex = 15;
            this.gunaVScrollBar3.ThumbColor = System.Drawing.Color.RoyalBlue;
            this.gunaVScrollBar3.ThumbHoverColor = System.Drawing.Color.LightCoral;
            this.gunaVScrollBar3.ThumbPressedColor = System.Drawing.Color.MistyRose;
            // 
            // fBaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(765, 411);
            this.Controls.Add(this.gunaVScrollBar3);
            this.Controls.Add(this.gunaVScrollBar2);
            this.Controls.Add(this.gunaVScrollBar1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbC);
            this.Controls.Add(this.lbB);
            this.Controls.Add(this.lbA);
            this.Controls.Add(this.flpKhuC);
            this.Controls.Add(this.flpKhuB);
            this.Controls.Add(this.flpKhuA);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fBaiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fBaiXe";
            this.Load += new System.EventHandler(this.fBaiXe_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flpKhuA;
        private System.Windows.Forms.FlowLayoutPanel flpKhuB;
        private System.Windows.Forms.FlowLayoutPanel flpKhuC;
        private System.Windows.Forms.Label lbA;
        private System.Windows.Forms.Label lbB;
        private System.Windows.Forms.Label lbC;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar1;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar2;
        private Guna.UI.WinForms.GunaVScrollBar gunaVScrollBar3;
    }
}