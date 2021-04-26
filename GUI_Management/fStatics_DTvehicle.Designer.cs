
namespace GUI_Management
{
    partial class fStatics_DTvehicle
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fStatics_DTvehicle));
            this.BD = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnBack = new Guna.UI.WinForms.GunaButton();
            this.gunaGradientPanel2 = new Guna.UI.WinForms.GunaGradientPanel();
            this.btnChange = new Guna.UI.WinForms.GunaGradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.BD)).BeginInit();
            this.SuspendLayout();
            // 
            // BD
            // 
            chartArea1.Name = "ChartArea1";
            this.BD.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.BD.Legends.Add(legend1);
            this.BD.Location = new System.Drawing.Point(220, 135);
            this.BD.Name = "BD";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Members";
            this.BD.Series.Add(series1);
            this.BD.Size = new System.Drawing.Size(629, 300);
            this.BD.TabIndex = 0;
            this.BD.Text = "chart1";
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
            this.btnBack.TabIndex = 24;
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
            this.gunaGradientPanel2.TabIndex = 25;
            this.gunaGradientPanel2.Text = "gunaGradientPanel2";
            // 
            // btnChange
            // 
            this.btnChange.Animated = true;
            this.btnChange.AnimationHoverSpeed = 0.07F;
            this.btnChange.AnimationSpeed = 0.03F;
            this.btnChange.BackColor = System.Drawing.Color.Transparent;
            this.btnChange.BaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnChange.BaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnChange.BorderColor = System.Drawing.Color.Black;
            this.btnChange.BorderSize = 1;
            this.btnChange.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnChange.FocusedColor = System.Drawing.Color.Empty;
            this.btnChange.Font = new System.Drawing.Font("Segoe UI Black", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChange.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(42)))), ((int)(((byte)(86)))));
            this.btnChange.Image = null;
            this.btnChange.ImageSize = new System.Drawing.Size(20, 20);
            this.btnChange.Location = new System.Drawing.Point(482, 519);
            this.btnChange.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnChange.Name = "btnChange";
            this.btnChange.OnHoverBaseColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(221)))), ((int)(((byte)(225)))));
            this.btnChange.OnHoverBaseColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(168)))), ((int)(((byte)(255)))));
            this.btnChange.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnChange.OnHoverForeColor = System.Drawing.Color.White;
            this.btnChange.OnHoverImage = null;
            this.btnChange.OnPressedColor = System.Drawing.Color.Black;
            this.btnChange.Radius = 3;
            this.btnChange.Size = new System.Drawing.Size(129, 37);
            this.btnChange.TabIndex = 30;
            this.btnChange.Text = "CHANGE";
            this.btnChange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // fStatics_DTvehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(239)))), ((int)(((byte)(196)))));
            this.ClientSize = new System.Drawing.Size(1083, 605);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.gunaGradientPanel2);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.BD);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "fStatics_DTvehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "fStatics_DTvehicle";
            this.Load += new System.EventHandler(this.fStatics_DTvehicle_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart BD;
        private Guna.UI.WinForms.GunaButton btnBack;
        private Guna.UI.WinForms.GunaGradientPanel gunaGradientPanel2;
        private Guna.UI.WinForms.GunaGradientButton btnChange;
    }
}