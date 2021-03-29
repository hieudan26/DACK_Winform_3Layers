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
    public partial class fGuiXe : Form
    {
        public fGuiXe()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void fGuiXe_Load(object sender, EventArgs e)
        {

        }

        private void cbLoaiXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbLoaiXe.SelectedIndex == 0)
            {
                this.btnText1.Text = "Hình Xe";
                this.btnText2.Text = "Người Gửi";
            }    
            else if(this.cbLoaiXe.SelectedIndex == 1)
            {
                this.btnText1.Text = "Bảng Số";
                this.btnText2.Text = "Người Gửi";
            }    
            else
            {
                this.btnText1.Text = "Bảng Số";
                this.btnText2.Text = "Hiệu Xe";
            }    
        }

        private void btnUpImg1_Click(object sender, EventArgs e)
        {
            if (this.cbLoaiXe.SelectedIndex == 0 || this.cbLoaiXe.SelectedIndex == 1 || this.cbLoaiXe.SelectedIndex == 2)
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    this.picBox1.Image = Image.FromFile(opf.FileName);
                }
            }    
            else
            {
                MessageBox.Show("Can't add image, pls select type of vehicle", "Upload Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnUpImg2_Click(object sender, EventArgs e)
        {
            if (this.cbLoaiXe.SelectedIndex == 0 || this.cbLoaiXe.SelectedIndex == 1 || this.cbLoaiXe.SelectedIndex == 2)
            {
                OpenFileDialog opf = new OpenFileDialog();
                opf.Filter = "Select Image(*.jpg; *.png; *gif)|*.jpg; *.png; *.gif";
                if (opf.ShowDialog() == DialogResult.OK)
                {
                    this.picBox2.Image = Image.FromFile(opf.FileName);
                }
            }
            else
            {
                MessageBox.Show("Can't add image, pls select type of vehicle", "Upload Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
