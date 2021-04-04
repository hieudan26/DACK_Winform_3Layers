using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using DTO_Management;

namespace GUI_Management
{
    public partial class fGuiXe : Form
    {
        vehicleBUS vehBUS = new vehicleBUS();
        fQuanLyXeGui formQuanLyXeGui;
        public fGuiXe(fQuanLyXeGui Form)
        {
            InitializeComponent();
            this.formQuanLyXeGui = Form;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formQuanLyXeGui.pnlMove.Visible = false;
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

        public void openForm(vehicleDTO vel)
        {
            this.formQuanLyXeGui.openChildForm(new fphiGui(vel));
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (this.picBox1.Image == null || this.picBox2.Image == null)
            {
                MessageBox.Show("Can't insert new vehicle if you don't upload your image", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                int type = this.cbLoaiXe.SelectedIndex;
                
                MemoryStream pic1 = new MemoryStream();
                this.picBox1.Image.Save(pic1, this.picBox1.Image.RawFormat);

                MemoryStream pic2 = new MemoryStream();
                this.picBox2.Image.Save(pic2, this.picBox2.Image.RawFormat);
                vehicleDTO vehDTO = new vehicleDTO(0, type, pic1, pic2);
                MessageBox.Show("Successfully~~");
                //thu phi
                openForm(vehDTO);
                //end
                
            }
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.DarkGray;
            this.btnExit.ForeColor = Color.Black;
        }
    }
}
