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
    public partial class fVehicle : Form
    {
        vehicleBUS vehBUS = new vehicleBUS();
        fQuanLyXe formQuanLyXeGui;
        vehicleWashBUS vehWashBUS = new vehicleWashBUS();

        public fVehicle(fQuanLyXe Form)
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
                if(this.vehBUS.checkFullVehicle(0) == false)
                {
                    this.btnText1.Text = "Hình Xe";
                    this.btnText2.Text = "Người Gửi";
                }    
                else
                {
                    MessageBox.Show("Bãi Xe Đạp Đã Hết Chỗ", "Add Vehicle",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    this.cbLoaiXe.SelectedItem = null;
                    this.btnText1.Text = "";
                    this.btnText2.Text = "";
                }
            }    
            else if(this.cbLoaiXe.SelectedIndex == 1)
            {
                if (this.vehBUS.checkFullVehicle(1) == false)
                {
                    this.btnText1.Text = "Bảng Số";
                    this.btnText2.Text = "Người Gửi";
                }
                else
                {
                    MessageBox.Show("Bãi Xe Máy Đã Hết Chỗ", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbLoaiXe.SelectedItem = null;
                    this.btnText1.Text = "";
                    this.btnText2.Text = "";
                }
            }    
            else
            {
                if (this.vehBUS.checkFullVehicle(2) == false)
                {
                    this.btnText1.Text = "Bảng Số";
                    this.btnText2.Text = "Hiệu Xe";
                }
                else
                {
                    MessageBox.Show("Bãi Xe Hơi Đã Hết Chỗ", "Add Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.cbLoaiXe.SelectedItem = null;
                    this.btnText1.Text = "";
                    this.btnText2.Text = "";
                }
            }    
        }

        private void btnUpImg1_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text != "" || this.cbLoaiXe.SelectedIndex == 0 || this.cbLoaiXe.SelectedIndex == 1 || this.cbLoaiXe.SelectedIndex == 2)
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
                MessageBox.Show("Can't add image, pls select type of vehicle or txtbox", "Upload Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }    
        }

        private void btnUpImg2_Click(object sender, EventArgs e)
        {
            if (this.txtID.Text != "" || this.cbLoaiXe.SelectedIndex == 0 || this.cbLoaiXe.SelectedIndex == 1 || this.cbLoaiXe.SelectedIndex == 2)
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
                MessageBox.Show("Can't add image, pls select type of vehicle or txtbox", "Upload Image", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //open child form gửi
        public void openForm_Gui(vehicleDTO vel)
        {
            this.formQuanLyXeGui.openChildForm(new fphiGuiXe(vel.id, formQuanLyXeGui));
        }

        //open child form sửa
        public void openForm_Sua(vehicleDTO vel, int type)
        {
            this.formQuanLyXeGui.openChildForm(new fphiSuaXe(vel.id, formQuanLyXeGui, type));
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

        private void btnGuiXe_Click(object sender, EventArgs e)
        {
            if (this.vehBUS.CheckID_Exited(this.txtID.Text))
            {
                MessageBox.Show("ID xe đã tồn tại trong bãi xe", "Gửi Xe", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                this.txtID.Text = "";
            }   
            else
            {
                if (this.picBox1.Image == null || this.picBox2.Image == null)
                {
                    MessageBox.Show("Can't insert new vehicle if you don't upload your image", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtID.Text == "")
                {
                    MessageBox.Show("Can't insert new vehicle if you don't have id", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int type = this.cbLoaiXe.SelectedIndex;

                    MemoryStream pic1 = new MemoryStream();
                    this.picBox1.Image.Save(pic1, this.picBox1.Image.RawFormat);

                    MemoryStream pic2 = new MemoryStream();
                    this.picBox2.Image.Save(pic2, this.picBox2.Image.RawFormat);

                    vehicleDTO vehDTO = new vehicleDTO(this.txtID.Text, type, pic1, pic2, 1, 0, 0);
                    if (this.vehBUS.insertVehicle(vehDTO))
                    {
                        MessageBox.Show("Successfully~~");

                        //thu phi
                        this.openForm_Gui(vehDTO);
                        //end
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfully~~");
                    }
                }
            }    
        }

        private void btnSuaXe_Click(object sender, EventArgs e)
        {
            if (this.vehBUS.CheckID_Exited(this.txtID.Text))
            {
                MessageBox.Show("ID xe đã tồn tại trong bãi xe", "Gửi Xe", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                this.txtID.Text = "";
            }
            else
            {
                if (this.picBox1.Image == null || this.picBox2.Image == null)
                {
                    MessageBox.Show("Can't insert new vehicle if you don't upload your image", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtID.Text == "")
                {
                    MessageBox.Show("Can't insert new vehicle if you don't have id", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int type = this.cbLoaiXe.SelectedIndex;

                    MemoryStream pic1 = new MemoryStream();
                    this.picBox1.Image.Save(pic1, this.picBox1.Image.RawFormat);

                    MemoryStream pic2 = new MemoryStream();
                    this.picBox2.Image.Save(pic2, this.picBox2.Image.RawFormat);

                    vehicleDTO vehDTO = new vehicleDTO(this.txtID.Text, type, pic1, pic2, 0, 1, 0);

                    if (this.vehBUS.insertVehicle(vehDTO))
                    {
                        MessageBox.Show("Successfully~~");

                        //thu phi
                        this.openForm_Sua(vehDTO, type);
                        //end
                    }
                    else
                    {
                        MessageBox.Show("Unsuccessfully~~");
                    }    
                }
            }
        }

        private void btnRuaXe_Click(object sender, EventArgs e)
        {
            if (this.vehBUS.CheckID_Exited(this.txtID.Text))
            {
                MessageBox.Show("ID xe đã tồn tại trong bãi xe", "Gửi Xe", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Warning);
                this.txtID.Text = "";
            }
            else
            {
                if (this.picBox1.Image == null || this.picBox2.Image == null)
                {
                    MessageBox.Show("Can't insert new vehicle if you don't upload your image", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (this.txtID.Text == "")
                {
                    MessageBox.Show("Can't insert new vehicle if you don't have id", "Insert object", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    int type = this.cbLoaiXe.SelectedIndex;

                    MemoryStream pic1 = new MemoryStream();
                    this.picBox1.Image.Save(pic1, this.picBox1.Image.RawFormat);

                    MemoryStream pic2 = new MemoryStream();
                    this.picBox2.Image.Save(pic2, this.picBox2.Image.RawFormat);

                    vehicleDTO vehDTO = new vehicleDTO(this.txtID.Text, type, pic1, pic2, 0, 0, 1);
                    vehicleWashDTO vehWashDTO = new vehicleWashDTO(this.txtID.Text, type);
                    if (this.vehBUS.insertVehicle(vehDTO) && this.vehWashBUS.insertVehicleWash(vehWashDTO))
                        MessageBox.Show("Successfully~~");

                    //thu phi
                    //this.openForm_Sua(vehDTO, type);
                    //end
                }
            }
        }
    }
}
