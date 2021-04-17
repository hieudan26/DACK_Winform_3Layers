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
    public partial class finfoXeRua : Form
    {
        vehicleWashBUS vehWashBUS = new vehicleWashBUS();
        fQuanLyXe fQuanLyXe = new fQuanLyXe();
        doanhThuWashBUS dtWashBUS = new doanhThuWashBUS();

        public finfoXeRua(fQuanLyXe quanly)
        {
            InitializeComponent();
            this.fQuanLyXe = quanly;
        }

        private void designDataGridView(int i1, int i2)
        {
            this.dgvWash.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

            picCol = (DataGridViewImageColumn)this.dgvWash.Columns[i1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)this.dgvWash.Columns[i2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dgvWash.AllowUserToAddRows = false;
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeFilter.SelectedIndex;
            this.dgvWash.RowTemplate.Height = 80;
            if (index < 3 && index >= 0)
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehWashBUS.getDataVehicleWash_ByType(index);
                if (table != null)
                {
                    this.dgvWash.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvWash.DataSource = null;
                }
            }
            else
            {
                DataTable table = this.vehWashBUS.getAllVehicleWash();
                if (table != null)
                {
                    this.dgvWash.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvWash.DataSource = null;
                }
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.fQuanLyXe.pnlMove.Visible = false;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            this.cbTypeFilter.SelectedIndex = -1;
            string id = this.txtSearch.Text;
            if (this.vehWashBUS.getVehicleByID_GanDung(this.txtSearch.Text) != null)
            {
                this.dgvWash.RowTemplate.Height = 80;
                this.dgvWash.DataSource = this.vehWashBUS.getVehicleByID_GanDung(this.txtSearch.Text);
                this.designDataGridView(2, 3);
            }
        }

        private void dgvWash_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = this.dgvWash.CurrentRow.Cells[0].Value.ToString();
            int fee = this.vehWashBUS.getWash_fee(id);
            if (fee != -1)
            {
                this.txtTienRua.Text = fee.ToString();
            }    
            else
            {
                this.txtTienRua.Text = "";
            }    
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            string id = this.dgvWash.CurrentRow.Cells[0].Value.ToString();
            if (MessageBox.Show("Are you sure?", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (this.vehWashBUS.DeleteVehicleWash(id))
                {
                    MessageBox.Show("Delete successful", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    this.cbTypeFilter.SelectedIndex = 3;
                    DataTable table = this.vehWashBUS.getAllVehicleWash();
                    if (table != null)
                    {
                        this.dgvWash.DataSource = table;
                        this.designDataGridView(2, 3);
                    }
                    else
                    {
                        this.dgvWash.DataSource = null;
                    }
                }    
                else
                {
                    MessageBox.Show("Delete unsuccessful", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    this.dgvWash.DataSource = null;
                }    
            }    
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            string id = this.dgvWash.CurrentRow.Cells[0].Value.ToString();
            int totalFee = this.vehWashBUS.getWash_fee(id);
            doanhThuWashDTO doanhThuWashDTO = new doanhThuWashDTO(id, DateTime.Now, totalFee);
            if (this.dtWashBUS.insert_doanhThuWash(doanhThuWashDTO) && this.vehWashBUS.DeleteVehicleWash(id))
            {
                MessageBox.Show("Thanh toán thành công dịch vụ", "Info Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.cbTypeFilter.SelectedIndex = 3;
                DataTable table = this.vehWashBUS.getAllVehicleWash();
                if (table != null)
                {
                    this.dgvWash.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvWash.DataSource = null;
                }
            }
            else
            {
                MessageBox.Show("Thanh toán không thành công", "Info Wash", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
