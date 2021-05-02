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
        fQuanLyXe fQuanLyXe = new fQuanLyXe();

        private int typeXe;
        private DataTable table = new DataTable();
        private DataTable table_services = new DataTable();

        public faddDichVuSua(DataTable table_service, int type, fQuanLyXe fQuanLyXe)
        {
            InitializeComponent();
            //this.loadLabelSum();
            this.typeXe = type;
            this.table.Columns.Add("service", typeof(string));
            this.table.Columns.Add("service_fee", typeof(int));
            this.table_services = table_service;
            this.dgvServices.DataSource = table_service;
            this.fQuanLyXe = fQuanLyXe;
        }

        private bool checkDGV(string service, DataTable tab)
        {
            for (int i = 0; i < tab.Rows.Count; i++)
            {
                if (tab.Rows[i][0].ToString() == service)
                {
                    return false;
                }    
            }
            return true;
        }

        private void AddRow(DataGridView dgv1, DataGridView dgv, DataTable tab)
        {
            string service = dgv1.CurrentRow.Cells[0].Value.ToString();
            string service_fee = dgv1.CurrentRow.Cells[1].Value.ToString();
            DataRow row = tab.NewRow();
            row["service"] = service;
            row["service_fee"] = service_fee;
            tab.Rows.Add(row);
            dgv.DataSource = tab;
            dgv.ReadOnly = true;
            dgv.AllowUserToAddRows = false;
        }

        public void loadLabelSum()
        {
            int sum1 = 0;
            if (this.dgvServices.DataSource != null)
            {
                for (int i = 0; i < this.dgvServices.RowCount; i++)
                {
                    sum1 += int.Parse(this.dgvServices[1, i].Value.ToString());
                }    
            }
            this.lbSum1.Text = "SUM: " + sum1.ToString();

            int sum2 = 0;
            if (this.dgvSer_Of_ID.DataSource != null)
            {
                for (int i = 0; i < this.dgvSer_Of_ID.RowCount; i++)
                {
                    sum2 += int.Parse(this.dgvSer_Of_ID[1, i].Value.ToString());
                }
            }
            this.lbSUM2.Text = "SUM: " + sum2.ToString();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvServices.DataSource != null)
                {
                    string service = this.dgvServices.CurrentRow.Cells[0].Value.ToString();

                    if (this.checkDGV(service, this.table))
                    {
                        this.AddRow(this.dgvServices, this.dgvSer_Of_ID, this.table);
                    }

                    this.XoaDichVuDGV_Services(this.table_services);
                    this.loadLabelSum();
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void XoaDichVuDGV_Services(DataTable tab)
        {
            try
            {
                tab.Rows.RemoveAt(this.dgvServices.SelectedRows[0].Index);
                this.dgvServices.DataSource = tab;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
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
                    this.loadLabelSum();
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
            try
            {
                string service = this.dgvSer_Of_ID.CurrentRow.Cells[0].Value.ToString();
                if (this.checkDGV(service, this.table_services))
                {
                   this.AddRow(this.dgvSer_Of_ID, this.dgvServices, this.table_services);
                }    
                
                this.table.Rows.RemoveAt(this.dgvSer_Of_ID.SelectedRows[0].Index);
                this.loadLabelSum();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            finfoXeSua f = new finfoXeSua(this.fQuanLyXe);
            this.fQuanLyXe.openChildForm(f);
        }
    }
}
