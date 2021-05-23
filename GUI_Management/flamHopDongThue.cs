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
    public partial class flamHopDongThue : Form
    {
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        customerBUS customerBUS = new customerBUS();
        customer_VehicleBUS customer_VehicleBUS = new customer_VehicleBUS();
        contract_ThueBUS contract_ThueBUS = new contract_ThueBUS();

        public flamHopDongThue()
        {
            InitializeComponent();
        }

        private void gunaGradient2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void flamHopDongThue_Load(object sender, EventArgs e)
        {
            this.txtIDNV.Text = Global.GlobalEmployeeId.Trim();
            this.txtTenNhanVien.Text = this.nhanVienBUS.getEmployee_byID(Global.GlobalEmployeeId).Rows[0][1].ToString().Trim();
            this.LoadCustomerThue_DGV();
            this.LoadVehicleChoThue_DGV();
        }

        private void LoadCustomerThue_DGV()
        {
            try
            {
                DataTable table = this.customerBUS.getAllCustomer_Thue();
                this.dgv_CusThue.ReadOnly = true;
                this.dgv_CusThue.RowTemplate.Height = 50;
                this.dgv_CusThue.DataSource = table;
                this.dgv_CusThue.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private DataTable XoaVehicleDaDuocThue(DataTable tableBu)
        {
            DataTable table = this.contract_ThueBUS.getAllVehicle_ContractThue();
            if (table != null)
            {
                for (int i = table.Rows.Count - 1; i >= 0; i--)
                {
                    for (int j = tableBu.Rows.Count - 1; j >= 0; j--)
                    {
                        if (table.Rows[i][2].ToString().Trim() == tableBu.Rows[j][0].ToString().Trim())
                        {
                            tableBu.Rows.RemoveAt(i);
                        }
                    }
                }
                return tableBu;
            }   
            else
            {
                return tableBu;
            }    
        }

        private void LoadVehicleChoThue_DGV()
        {
            try
            {
                DataTable table = this.customer_VehicleBUS.getFullInfoVehicle_Thue();
                this.dgvXeChoThue.ReadOnly = true;
                this.dgvXeChoThue.RowTemplate.Height = 60;
                this.dgvXeChoThue.DataSource = this.XoaVehicleDaDuocThue(table);

                DataGridViewImageColumn picCol = new DataGridViewImageColumn();

                picCol = (DataGridViewImageColumn)this.dgvXeChoThue.Columns[2];
                picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;

                DataGridViewImageColumn picCol1 = new DataGridViewImageColumn();

                picCol1 = (DataGridViewImageColumn)this.dgvXeChoThue.Columns[3];
                picCol1.ImageLayout = DataGridViewImageCellLayout.Stretch;

                this.dgvXeChoThue.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void dgv_CusThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtHoTenCustomer.Text = this.dgv_CusThue.CurrentRow.Cells[1].Value.ToString().Trim() + " " + this.dgv_CusThue.CurrentRow.Cells[2].Value.ToString().Trim();
            string gender = this.dgv_CusThue.CurrentRow.Cells[3].Value.ToString().Trim();
            if (gender == "Nam")
            {
                this.rbNam.Checked = true;
            }
            else
            {
                this.rbNu.Checked = true;
            }
            this.txtAddress.Text = this.dgv_CusThue.CurrentRow.Cells[4].Value.ToString().Trim();
            this.txtSDT.Text = this.dgv_CusThue.CurrentRow.Cells[5].Value.ToString().Trim();
        }

        private void dgvXeChoThue_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.lbBienSo.Text = this.dgvXeChoThue.CurrentRow.Cells[0].Value.ToString().Trim();
            int type = int.Parse(this.dgvXeChoThue.CurrentRow.Cells[1].Value.ToString().Trim());
            if (type == 0)
            {
                this.lbTypeXe.Text = "Xe Đạp";
                this.lbIMG1.Text = "Hình Xe";
                this.lbIMG2.Text = "Người Gửi";
            }    
            else if (type == 1)
            {
                this.lbTypeXe.Text = "Xe Máy";
                this.lbIMG1.Text = "Bảng Số";
                this.lbIMG2.Text = "Người Gửi";
            }    
            else
            {
                this.lbTypeXe.Text = "Xe Hơi";
                this.lbIMG1.Text = "Bảng Số";
                this.lbIMG2.Text = "Hiệu Xe";
            }

            Byte[] pic = new Byte[0];
            pic = (Byte[])(this.dgvXeChoThue.CurrentRow.Cells[2].Value);
            MemoryStream ms = new MemoryStream(pic);
            this.pb1.Image = Image.FromStream(ms);

            Byte[] pic1 = new Byte[0];
            pic1 = (Byte[])(this.dgvXeChoThue.CurrentRow.Cells[3].Value);
            MemoryStream ms1 = new MemoryStream(pic1);
            this.pb2.Image = Image.FromStream(ms1);
        }

        private void btnCamKet_Click(object sender, EventArgs e)
        {
            try
            {
                string idContract = this.txtIDContract.Text.Trim();
                string idCustomer = this.dgv_CusThue.CurrentRow.Cells[0].Value.ToString().Trim();
                string idVehicle = this.lbBienSo.Text.Trim();
                DateTime dateSign = this.dtPicker1.Value;
                float totalCost = float.Parse(this.txtCost.Text.Trim());
                string idEmployee = Global.GlobalEmployeeId;
                contract_ThueDTO contract_ThueDTO = new contract_ThueDTO(idContract, idCustomer, idVehicle, dateSign, totalCost, idEmployee);

                if (this.contract_ThueBUS.insertContract_Thue(contract_ThueDTO))
                {
                    MessageBox.Show("Thêm hợp đồng thành công", "Contract Thuê", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadVehicleChoThue_DGV();
                }
                else
                {
                    MessageBox.Show("Thêm hợp đồng không thành công", "Contract Thuê", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
