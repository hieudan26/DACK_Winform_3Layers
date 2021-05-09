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

namespace GUI_Management
{
    public partial class flamHopDongChoThue : Form
    {
        customerBUS customerBUS = new customerBUS();
        customer_VehicleBUS customer_VehicleBUS = new customer_VehicleBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();

        public flamHopDongChoThue()
        {
            InitializeComponent();
        }

        private void flamHopDongChoThue_Load(object sender, EventArgs e)
        {
            this.LoadComboBoxCMND_Customer();
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

        private void LoadLabelVehicleOfCustomer(string id_cus)
        {
            DataTable table = this.customer_VehicleBUS.getAllVehicle_IdCus(id_cus); //Ở đây ko cần dùng distinct vì bên liên kết đã xóa đi những xe đã sở hữu nên ko bị trùng ez
            //foreach (DataRow item in table.Rows)
            //{
            //    Label lbIdXe = new Label();
            //    lbIdXe.Text = item["id_Veh"].ToString();
            //    this.flpLabelIDVeh.Controls.Add(lbIdXe);
            //}

            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow item = table.Rows[i];
                Label lbIdXe = new Label();
                lbIdXe.Text = item["id_Veh"].ToString();
                this.flpLabelIDVeh.Controls.Add(lbIdXe);
                Label lbTypeXe = new Label();
                string type = this.vehicleBUS.getVehicleByID(lbIdXe.Text).Rows[0]["type"].ToString();
                lbTypeXe.Text = this.typeXe(type);
                this.flpTypeXe.Controls.Add(lbTypeXe);
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
    }
}
