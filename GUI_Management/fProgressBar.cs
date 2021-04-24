using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management
{
    public partial class fProgressBar : Form
    {
        public fProgressBar()
        {
            InitializeComponent();
        }

        private void timer_Theme_Tick(object sender, EventArgs e)
        {
            //223, 249, 251
            if (this.pnlTheme.GradientColor1 == Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251))))))
            {
                //45, 152, 218  223, 249, 251
                this.pnlTheme.GradientColor1 = Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(152)))), ((int)(((byte)(218)))));
                this.pnlTheme.GradientColor2 = Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
            }    
            else
            {
                //224, 86, 253
                this.pnlTheme.GradientColor1 = Color.FromArgb(((int)(((byte)(223)))), ((int)(((byte)(249)))), ((int)(((byte)(251)))));
                this.pnlTheme.GradientColor2 = Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(86)))), ((int)(((byte)(253)))));
            }
        }

        private void fProgressBar_Load(object sender, EventArgs e)
        {
            this.gunaCircleProgressBar1.Value = 0;
            this.timer1_Prog.Start();
        }

        private void timer1_Prog_Tick(object sender, EventArgs e)
        {
            this.gunaCircleProgressBar1.Increment(3);
        }
    }
}
