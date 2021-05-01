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
    public partial class faddDichVuSua : Form
    {
        vehicleFixBUS vehicleFixBUS = new vehicleFixBUS();
        phiDichVuSuaXeBUS phiSuaBUS = new phiDichVuSuaXeBUS();

        private int typeXe;
        private DataTable table = new DataTable();

        public faddDichVuSua(int type)
        {
            InitializeComponent();
            this.typeXe = type;
            this.table.Columns.Add("service", typeof(string));
            this.table.Columns.Add("service_fee", typeof(int));
        }

        private bool checkDGV(string service)
        {
            for (int i = 0; i < this.table.Rows.Count; i++)
            {
                if (this.table.Rows[i][0].ToString() == service)
                {
                    return false;
                }    
            }
            return true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string service = this.dgvServices.CurrentRow.Cells[0].Value.ToString();
            string service_fee = this.dgvServices.CurrentRow.Cells[1].Value.ToString();

            if (this.checkDGV(service))
            {
                DataRow row = this.table.NewRow();
                row["service"] = service;
                row["service_fee"] = service_fee;
                this.table.Rows.Add(row);
                this.dgvSer_Of_ID.DataSource = this.table;
                this.dgvSer_Of_ID.ReadOnly = true;
                this.dgvSer_Of_ID.AllowUserToAddRows = false;
            }    
        }

        private DataTable table_DichVuChuaDung(string idXe, DataTable tableBu)
        {
            try
            {
                for (int i = tableBu.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = tableBu.Rows[i];
                    string service = row["service"].ToString();
                    if (this.vehicleFixBUS.VerifyIDandService_Existed(idXe, service))
                    {
                        tableBu.Rows.Remove(row);
                    }
                }
                DataColumn col = tableBu.Columns[0];
                tableBu.Columns.Remove(col);
                return tableBu;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
            return null;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure ?!?", "Dịch Vụ Sửa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {
                    DataTable table_tmp = (DataTable)this.dgvSer_Of_ID.DataSource;
                    for (int i = 0; i < this.dgvSer_Of_ID.RowCount; i++)
                    {
                        vehicleFixDTO vehicleFixDTO = new vehicleFixDTO(this.txtIDXe.Text, table_tmp.Rows[i]["service"].ToString());
                        if (this.vehicleFixBUS.insertVehicle_FIX(vehicleFixDTO))
                        {
                            continue;
                        }
                        else
                        {
                            MessageBox.Show("Thêm dịch vụ không thành công", "Dịch Vụ Sửa", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.dgvServices.DataSource = this.table_DichVuChuaDung(this.txtIDXe.Text, this.phiSuaBUS.getDichVu_ByType(this.typeXe));
                            break;
                        }
                    }
                    this.dgvServices.DataSource = this.table_DichVuChuaDung(this.txtIDXe.Text, this.phiSuaBUS.getDichVu_ByType(this.typeXe));
                    this.dgvSer_Of_ID.DataSource = null;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }    
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            //MyTypedDataRow row = (MyTypedDataRow)((DataRowView)DataGridViewRow.DataBoundItem).Row
            this.table.Rows.RemoveAt(this.dgvSer_Of_ID.SelectedRows[0].Index);
        }
    }
}
