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
    public partial class flienKetVehicle : Form
    {
        customerBUS customerBUS = new customerBUS();
        vehicleParkingBUS vehicleParkingBUS = new vehicleParkingBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();
        customer_VehicleBUS customer_VehicleBUS = new customer_VehicleBUS();

        public flienKetVehicle()
        {
            InitializeComponent();
        }

        private DataTable UpdateDanhSachVehID(DataTable tableBu)
        {
            DataTable table = this.customer_VehicleBUS.getAll();
            if (table != null)
            {
                for (int i = table.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow item = table.Rows[i];
                    for (int j = tableBu.Rows.Count - 1; j >= 0; j--)
                    {
                        DataRow itemBu = tableBu.Rows[j];
                        if (item["id_Veh"].ToString() == itemBu["id"].ToString())
                        {
                            tableBu.Rows.Remove(itemBu);
                        }    
                    }
                }
            }
            return tableBu;
        }

        private void flienKetVehicle_Load(object sender, EventArgs e)
        {
            this.Loadcb_Customer();
            this.Loadcb_Veh();
        }

        private void Loadcb_Veh()
        {
            try
            {
                this.cbIDxe.DataSource = this.UpdateDanhSachVehID(this.vehicleParkingBUS.getAllVehicle());
                this.cbIDxe.DisplayMember = "id";
                this.cbIDxe.ValueMember = "typePark";
            }    
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void Loadcb_Customer()
        {
            try
            {
                this.textBox1.Visible = false;
                this.textBox2.Visible = false;
                this.cbIDCustomer.DataSource = this.customerBUS.getAllCustomer_ChoThue();
                this.cbIDCustomer.DisplayMember = "id";
                this.cbIDCustomer.ValueMember = "fname";

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
                this.textBox1.DataBindings.Add(new Binding("Text", this.cbIDCustomer.DataSource, "fname"));
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
                this.textBox2.DataBindings.Add(new Binding("Text", this.cbIDCustomer.DataSource, "lname"));
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void cbIDCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.txt_FullName.Text = this.textBox1.Text.Trim() + " " + this.textBox2.Text.Trim();
        }

        private string LoaiXe(int type)
        {
            if (type == 0)
            {
                return "Xe Đạp";
            }    
            else if (type == 1)
            {
                return "Xe Máy";
            }    
            else
            {
                return "Xe Hơi";
            }    
        }

        private void cbIDxe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbIDxe.SelectedIndex != -1)
            {
                int type = int.Parse(this.vehicleBUS.getVehicleByID(this.cbIDxe.Text).Rows[0]["type"].ToString());
                string typeXe = this.LoaiXe(type);
                this.txtTypeVeh.Text = typeXe;
            }    
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string id_Cus = this.cbIDCustomer.Text;
            string id_Veh = this.cbIDxe.Text;
            customer_VehicleDTO customer_VehicleDTO = new customer_VehicleDTO(id_Cus, id_Veh);
            try
            {
                if (this.customer_VehicleBUS.insertcustomer_Vehicle(customer_VehicleDTO))
                {
                    MessageBox.Show("Sở hữu xe thành công", "liên kết xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Loadcb_Veh();
                }    
                else
                {
                    MessageBox.Show("Sở hữu xe không thành công", "liên kết xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }
    }
}
