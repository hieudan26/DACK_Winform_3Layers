using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using DTO_Management;

namespace GUI_Management
{
    public partial class faddKhach : Form
    {
        customerBUS customerBUS = new customerBUS();
        private int status;

        public faddKhach(int status)
        {
            InitializeComponent();
            this.status = status;
        }

        private bool checkGender()
        {
            if (this.rbFemale.Checked == true || this.rbMale.Checked == true)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool verify()
        {
            if (this.txtCCCD.Text == "" || this.txtFname.Text == "" || this.txtLname.Text == "" ||
                this.txtPhone.Text == "" || this.rtxtAddress.Text == "" || !this.checkGender())
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!this.verify())
            {
                try
                {
                    string cccd = this.txtCCCD.Text;
                    string fname = this.txtFname.Text ;
                    string lname = this.txtLname.Text;
                    string gender = "";
                    if (this.rbMale.Checked == true)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nữ";
                    }
                    string address = this.rtxtAddress.Text;
                    int phone = int.Parse(this.txtPhone.Text);

                    customerDTO customerDTO = new customerDTO(cccd, fname, lname, gender, address, phone, this.status);

                    if (this.customerBUS.insertCustomer(customerDTO))
                    {
                        MessageBox.Show("Thêm thông tin khách hàng thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thêm thông tin khách hàng không thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (this.txtCCCD.Text != "")
            {
                string id = this.txtCCCD.Text;
                DataTable table = this.customerBUS.getData_byId(id);
                if (table != null)
                {
                    //this.txtCCCD.Text = table.Rows[0]["id"].ToString();
                    this.txtFname.Text = table.Rows[0]["fname"].ToString();
                    this.txtLname.Text = table.Rows[0]["lname"].ToString();
                    this.txtPhone.Text = table.Rows[0]["phone"].ToString();
                    this.rtxtAddress.Text = table.Rows[0]["address"].ToString();
                    if (table.Rows[0]["gender"].ToString() == "Nam")
                    {
                        this.rbMale.Checked = true;
                    }    
                    else
                    {
                        this.rbFemale.Checked = true;
                    }    
                }    
                else
                {
                    MessageBox.Show("Không tồn tại ID", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }    
            else
            {
                MessageBox.Show("Empty Fields", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (!this.verify())
            {
                try
                {
                    string cccd = this.txtCCCD.Text;
                    string fname = this.txtFname.Text;
                    string lname = this.txtLname.Text;
                    string gender = "";
                    if (this.rbMale.Checked == true)
                    {
                        gender = "Nam";
                    }
                    else
                    {
                        gender = "Nữ";
                    }
                    string address = this.rtxtAddress.Text;
                    int phone = int.Parse(this.txtPhone.Text);

                    customerDTO customerDTO = new customerDTO(cccd, fname, lname, gender, address, phone, this.status);

                    if (this.customerBUS.UpdateCustomer(customerDTO))
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin khách hàng không thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            if (!this.verify())
            {
                try
                {
                    string cccd = this.txtCCCD.Text;

                    if (this.customerBUS.DelCustomer(cccd))
                    {
                        MessageBox.Show("Xóa khách hàng thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtCCCD.Text = "";
                        this.txtFname.Text = "";
                        this.txtLname.Text = "";
                        this.rbFemale.Checked = false;
                        this.rbMale.Checked = false;
                        this.rtxtAddress.Text = "";
                        this.txtPhone.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Xóa khách hàng không thành công", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Khách Thuê", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
