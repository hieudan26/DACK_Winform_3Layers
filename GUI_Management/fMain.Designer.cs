
namespace GUI_Management
{
    partial class fMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.vehicleManagemenyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addVehicleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jobsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.techniqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contractToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnl = new Guna.UI.WinForms.GunaGradient2Panel();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.menuStrip1.SuspendLayout();
            this.pnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vehicleManagemenyToolStripMenuItem,
            this.jobsToolStripMenuItem,
            this.employToolStripMenuItem,
            this.techniqueToolStripMenuItem,
            this.contractToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(791, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // vehicleManagemenyToolStripMenuItem
            // 
            this.vehicleManagemenyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addVehicleToolStripMenuItem});
            this.vehicleManagemenyToolStripMenuItem.Name = "vehicleManagemenyToolStripMenuItem";
            this.vehicleManagemenyToolStripMenuItem.Size = new System.Drawing.Size(162, 26);
            this.vehicleManagemenyToolStripMenuItem.Text = "Vehicle Management";
            // 
            // addVehicleToolStripMenuItem
            // 
            this.addVehicleToolStripMenuItem.Name = "addVehicleToolStripMenuItem";
            this.addVehicleToolStripMenuItem.Size = new System.Drawing.Size(192, 26);
            this.addVehicleToolStripMenuItem.Text = "Quản Lý Xe Gửi";
            this.addVehicleToolStripMenuItem.Click += new System.EventHandler(this.addVehicleToolStripMenuItem_Click);
            // 
            // jobsToolStripMenuItem
            // 
            this.jobsToolStripMenuItem.Name = "jobsToolStripMenuItem";
            this.jobsToolStripMenuItem.Size = new System.Drawing.Size(52, 26);
            this.jobsToolStripMenuItem.Text = "Jobs";
            // 
            // employToolStripMenuItem
            // 
            this.employToolStripMenuItem.Name = "employToolStripMenuItem";
            this.employToolStripMenuItem.Size = new System.Drawing.Size(95, 26);
            this.employToolStripMenuItem.Text = "Employees";
            // 
            // techniqueToolStripMenuItem
            // 
            this.techniqueToolStripMenuItem.Name = "techniqueToolStripMenuItem";
            this.techniqueToolStripMenuItem.Size = new System.Drawing.Size(90, 26);
            this.techniqueToolStripMenuItem.Text = "Technique";
            // 
            // contractToolStripMenuItem
            // 
            this.contractToolStripMenuItem.Name = "contractToolStripMenuItem";
            this.contractToolStripMenuItem.Size = new System.Drawing.Size(79, 26);
            this.contractToolStripMenuItem.Text = "Contract";
            // 
            // pnl
            // 
            this.pnl.BackColor = System.Drawing.Color.Transparent;
            this.pnl.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnl.Controls.Add(this.axWindowsMediaPlayer1);
            this.pnl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl.GradientColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.pnl.GradientColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnl.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.ForwardDiagonal;
            this.pnl.Location = new System.Drawing.Point(0, 30);
            this.pnl.Name = "pnl";
            this.pnl.Size = new System.Drawing.Size(791, 466);
            this.pnl.TabIndex = 1;
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(40, 41);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(514, 305);
            this.axWindowsMediaPlayer1.TabIndex = 0;
            // 
            // fMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 496);
            this.Controls.Add(this.pnl);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "fMain";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main System";
            this.Load += new System.EventHandler(this.fMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem vehicleManagemenyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jobsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addVehicleToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem techniqueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contractToolStripMenuItem;
        private Guna.UI.WinForms.GunaGradient2Panel pnl;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
    }
}