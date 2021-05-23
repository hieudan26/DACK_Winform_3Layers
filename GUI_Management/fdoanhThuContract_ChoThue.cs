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
    public partial class fdoanhThuContract_ChoThue : Form
    {
        contract_ChoThueBUS contract_ChoThueBUS = new contract_ChoThueBUS();
        nhanVienBUS nhanVienBUS = new nhanVienBUS();
        customerBUS customerBUS = new customerBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();
        doanhThuContract_ChoThueBUS doanhThuContract_ChoThueBUS = new doanhThuContract_ChoThueBUS();

        public fdoanhThuContract_ChoThue()
        {
            InitializeComponent();
        }

        private void fdoanhThuContract_ChoThue_Load(object sender, EventArgs e)
        {
            try
            {
                this.LoadDataGridView();
                this.LoadTenNhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadTenNhanVien()
        {
            string idEmployee = Global.GlobalEmployeeId;
            DataTable table = this.nhanVienBUS.getEmployee_byID(idEmployee);
            this.lbNameEmpl.Text = table.Rows[0][1].ToString().Trim();
            this.lbID.Text = "ID: " + idEmployee.Trim();
        }

        private void LoadDataGridView()
        {
            try
            {
                DataTable table = this.contract_ChoThueBUS.getAllVehicle_ContractChoThueByIDEmployee(Global.GlobalEmployeeId);
                this.DGV.ReadOnly = true;
                this.DGV.RowTemplate.Height = 30;
                this.DGV.DataSource = table;
                this.DGV.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void rbALL_CheckedChanged(object sender, EventArgs e)
        {
            if (this.rbALL.Checked == true)
            {
                try
                {
                    DataTable table = this.contract_ChoThueBUS.getAllVehicle_ContractChoThueByIDEmployee(Global.GlobalEmployeeId);
                    this.DGV.ReadOnly = true;
                    this.DGV.RowTemplate.Height = 30;
                    this.DGV.DataSource = table;
                    this.DGV.AllowUserToAddRows = false;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void rbHetHan_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable table = this.contract_ChoThueBUS.getAllContractChoThue_Expired(Global.GlobalEmployeeId);
                this.DGV.ReadOnly = true;
                this.DGV.RowTemplate.Height = 30;
                this.DGV.DataSource = table;
                this.DGV.AllowUserToAddRows = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DGV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.txtIdContract.Text = this.DGV.CurrentRow.Cells[0].Value.ToString().Trim();
                string IDCustomer = this.DGV.CurrentRow.Cells[1].Value.ToString().Trim();
                string IDVehicle = this.DGV.CurrentRow.Cells[2].Value.ToString().Trim();
                DataTable table = this.customerBUS.getData_byId(IDCustomer);
                DataTable table2 = this.vehicleBUS.getVehicleByID(IDVehicle);
                this.txtIDCus.Text = IDCustomer;
                this.txtHoTenCustomer.Text = table.Rows[0][1].ToString().Trim() + " " + table.Rows[0][2].ToString().Trim();
                this.lbIDVeh.Text = "Biển Số Xe: " + IDVehicle;
                this.txtTien.Text = this.DGV.CurrentRow.Cells[4].Value.ToString().Trim();
                int type = int.Parse(table2.Rows[0][1].ToString().Trim());
                if (type == 0)
                {
                    this.lbTypeXe.Text = "Xe Đạp";
                    this.lbImg1.Text = "Hình Xe";
                    this.lbIMG2.Text = "Người Gửi";
                }
                else if (type == 1)
                {
                    this.lbTypeXe.Text = "Xe Máy";
                    this.lbImg1.Text = "Bảng Số";
                    this.lbIMG2.Text = "Người Gửi";
                }
                else
                {
                    this.lbTypeXe.Text = "Xe Hơi";
                    this.lbImg1.Text = "Bảng Số";
                    this.lbIMG2.Text = "Hiệu Xe";
                }
                Byte[] pic = new Byte[0];
                pic = (Byte[])(table2.Rows[0][2]);
                MemoryStream ms = new MemoryStream(pic);
                this.pb1.Image = Image.FromStream(ms);

                Byte[] pic1 = new Byte[0];
                pic1 = (Byte[])(table2.Rows[0][3]);
                MemoryStream ms1 = new MemoryStream(pic1);
                this.pb2.Image = Image.FromStream(ms1);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void ResetForm()
        {
            this.txtIdContract.Text = "";
            this.txtIDCus.Text = "";
            this.txtHoTenCustomer.Text = "";
            this.txtTien.Text = "";
            this.lbIDVeh.Text = "Biển Số Xe: ";
            this.lbTypeXe.Text = "Loại Xe";
            this.lbImg1.Text = "IMG1";
            this.lbIMG2.Text = "IMG2";
            this.pb1.Image = null;
            this.pb2.Image = null;
            this.rbALL.Checked = false;
            this.rbHetHan.Checked = false;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string idContract = this.txtIdContract.Text.Trim();
                    float totalCost = float.Parse(this.txtTien.Text.Trim());
                    string idEmployee = Global.GlobalEmployeeId.Trim();
                    doanhThuContract_ChoThueDTO doanhThuContract_ChoThueDTO = new doanhThuContract_ChoThueDTO(idContract, totalCost, idEmployee);
                    if (this.doanhThuContract_ChoThueBUS.insertdoanhThuContract_ChoThue(doanhThuContract_ChoThueDTO))
                    {
                        MessageBox.Show("Thêm vào danh sách thanh toán thành công", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (this.contract_ChoThueBUS.RemoveContract(idContract))
                        {
                            MessageBox.Show("Đã thanh toán thành công!", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.fdoanhThuContract_ChoThue_Load(sender, e);
                            this.ResetForm();
                        }
                        else
                        {
                            MessageBox.Show("Thanh toán thất bại vui lòng thử lại sau", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.doanhThuContract_ChoThueBUS.RemovedoanhThuContract_ChoThue(idContract);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Thêm vào danh sách thanh toán không thành công", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Hủy thao tác", "Thanh Toán", MessageBoxButtons.OK, MessageBoxIcon.None);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
