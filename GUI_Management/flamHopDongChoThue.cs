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
    public partial class flamHopDongChoThue : Form
    {
        customerBUS customerBUS = new customerBUS();
        customer_VehicleBUS customer_VehicleBUS = new customer_VehicleBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();
        contract_ChoThueBUS contract_ChoThueBUS = new contract_ChoThueBUS();
        nhanVienBUS nhanVienBUS = new nhanVienBUS();

        public flamHopDongChoThue()
        {
            InitializeComponent();
        }

        private void flamHopDongChoThue_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxCMND_Customer();
            this.txtTenNhanVien.Text = this.nhanVienBUS.getEmployee_byID(Global.GlobalEmployeeId).Rows[0][1].ToString();
        }

        private void LoadComboBoxCMND_Customer()
        {
            try
            {
                this.txtTen.Visible = false;
                this.txtHo.Visible = false;

                this.cbCustomer.DataSource = this.customerBUS.getAllCustomer_ChoThue();
                this.cbCustomer.DisplayMember = "id";
                this.cbCustomer.ValueMember = "fname";

                this.LoadTxt_FullName();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void LoadTxt_FullName()
        {
            this.AddBinding_Fname();
            this.AddBinding_Lname();
            //this.txt_FullName.Text = this.textBox1.Text + " " + this.textBox2.Text;
        }

        private void AddBinding_Fname()
        {
            try
            {
                this.txtHo.DataBindings.Add(new Binding("Text", this.cbCustomer.DataSource, "fname"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void AddBinding_Lname()
        {
            try
            {
                this.txtTen.DataBindings.Add(new Binding("Text", this.cbCustomer.DataSource, "lname"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void cbCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txtHoTen.Text = this.txtHo.Text.Trim() + " " + this.txtTen.Text.Trim();
            string id_cus = this.cbCustomer.Text;
            this.LoadLabelVehicleOfCustomer(id_cus);
        }

        private DataTable RemoveVehicleDaTrongHopDong(DataTable tableBu)
        {
            DataTable table = this.contract_ChoThueBUS.getAllVehicle_ContractChoThue();
            if (table != null)
            {
                for (int i = tableBu.Rows.Count - 1; i >= 0; i--)
                {
                    for (int j = table.Rows.Count - 1; j >= 0; j--)
                    {
                        if (tableBu.Rows[i][1].ToString() == table.Rows[j][2].ToString())
                        {
                            tableBu.Rows.RemoveAt(i);
                        }    
                    }
                }
            }
            return tableBu;
        }

        private void LoadLabelVehicleOfCustomer(string id_cus)
        {
            try
            {
                this.flpTypeXe.Controls.Clear();
                this.flpLabelIDVeh.Controls.Clear();

                DataTable table = this.RemoveVehicleDaTrongHopDong(this.customer_VehicleBUS.getAllVehicle_IdCus(id_cus)); //Ở đây ko cần dùng distinct vì bên liên kết đã xóa đi những xe đã sở hữu nên ko bị trùng ez

                if (table != null)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        DataRow item = table.Rows[i];
                        Label space = new Label();
                        Label lbIdXe = new Label();
                        lbIdXe.Text = item["id_Veh"].ToString();
                        lbIdXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.flpLabelIDVeh.Controls.Add(lbIdXe);
                        Label lbTypeXe = new Label();
                        string type = this.vehicleBUS.getVehicleByID(lbIdXe.Text).Rows[0]["type"].ToString();
                        lbTypeXe.Text = this.typeXe(type);
                        lbTypeXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        this.flpTypeXe.Controls.Add(lbTypeXe);
                        lbIdXe.Click += new System.EventHandler(lbIdXe_Click);
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void lbIdXe_Click(object sender, EventArgs e)
        {
            try
            {
                Label lbIdXe = sender as Label;
                string idXe = lbIdXe.Text.Trim();
                this.btnIDXe.Text = idXe;
                DataTable table = this.vehicleBUS.getVehicleByID(idXe);

                int typeXe = int.Parse(table.Rows[0][1].ToString());
                if (typeXe == 0)
                {
                    this.lbPic1.Text = "Hình Xe";
                    this.lbpic2.Text = "Người Gửi";
                }    
                else if (typeXe == 1)
                {
                    this.lbPic1.Text = "Bảng Số";
                    this.lbpic2.Text = "Người Gửi";
                }    
                else
                {
                    this.lbPic1.Text = "Bảng Số";
                    this.lbpic2.Text = "Hiệu Xe";
                }    

                Byte[] pic = new Byte[0];
                pic = (Byte[])(table.Rows[0][2]);
                MemoryStream ms = new MemoryStream(pic);
                this.pb1.Image = Image.FromStream(ms);

                Byte[] pic2 = new Byte[0];
                pic2 = (Byte[])(table.Rows[0][3]);
                MemoryStream ms2 = new MemoryStream(pic);
                this.pb2.Image = Image.FromStream(ms2);

                if (int.Parse(table.Rows[0][4].ToString()) == 1)
                {
                    this.checkbPark.Checked = true;
                }

                if (int.Parse(table.Rows[0][5].ToString()) == 1)
                {
                    this.checkBFix.Checked = true;
                }

                if (int.Parse(table.Rows[0][6].ToString()) == 1)
                {
                    this.checkBWash.Checked = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private string typeXe(string type)
        {
            int loaiXe = int.Parse(type);
            if (loaiXe == 0)
            {
                return "Xe Đạp";
            }    
            else if (loaiXe == 1)
            {
                return "Xe Máy";
            }    
            else
            {
                return "Xe Hơi";
            }    
        }

        private bool verify()
        {
            if (this.txtIDContract.Text == "" || this.txtHoTen.Text == "" || this.txtGia.Text == "")
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }

        private void btnCamKet_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.verify())
                {
                    string idContract = this.txtIDContract.Text.Trim();
                    string idCustomer = this.cbCustomer.Text.Trim();
                    string idVehicle = this.btnIDXe.Text.Trim();
                    DateTime dateSign = DateTime.Now;
                    float TotalCost = float.Parse(this.txtGia.Text.Trim()) + (1/10);
                    string idEmployee = Global.GlobalEmployeeId;
                    contract_ChoThueDTO contract_ChoThueDTO = new contract_ChoThueDTO(idContract, idCustomer, idVehicle, dateSign, TotalCost, idEmployee);

                    if (this.contract_ChoThueBUS.insertContract_ChoThue(contract_ChoThueDTO))
                    {
                        MessageBox.Show("Thêm hợp đồng thành công", "Thêm hợp đồng cho thuê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Thêm hợp đồng không thành công", "Thêm hợp đồng cho thuê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
