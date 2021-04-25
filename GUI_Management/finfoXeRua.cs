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
        vehicleBUS vehicleBUS = new vehicleBUS();
        fQuanLyXe fQuanLyXe = new fQuanLyXe();
        doanhThuWashBUS dtWashBUS = new doanhThuWashBUS();
        fProgressBar fLoad = new fProgressBar();

        public finfoXeRua(fQuanLyXe quanly)
        {
            InitializeComponent();
            this.fQuanLyXe = quanly;
        }

        private void designDataGridView(DataTable table, int i1, int i2)
        {
            this.dgvWash.RowTemplate.Height = 80;
            this.dgvWash.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            this.dgvWash.DataSource = table;
            picCol = (DataGridViewImageColumn)this.dgvWash.Columns[i1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)this.dgvWash.Columns[i2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dgvWash.AllowUserToAddRows = false;
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Progress bar
            this.timer1.Start();
            fLoad.ShowDialog();
            //end
            int index = this.cbTypeFilter.SelectedIndex;
            if (index < 3 && index >= 0)
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehWashBUS.getDataVehicleWash_ByType(index);
                if (table != null)
                {
                    //this.dgvWash.DataSource = table;
                    this.designDataGridView(table, 2, 3);
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                }
                else
                {
                    this.dgvWash.DataSource = null;
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                }
            }
            else
            {
                DataTable table = this.vehWashBUS.getAllVehicleWash();
                if (table != null)
                {
                    this.designDataGridView(table, 2, 3);
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                }
                else
                {
                    this.dgvWash.DataSource = null;
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
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
            try
            {
                if (this.txtSearch.Text != "")
                {
                    this.cbTypeFilter.SelectedIndex = -1;
                    string id = this.txtSearch.Text;
                    if (this.vehWashBUS.getVehicleByID_GanDung(this.txtSearch.Text) != null)
                    {
                        DataTable table = this.vehWashBUS.getVehicleByID_GanDung(this.txtSearch.Text);
                        this.designDataGridView(table, 2, 3);
                        this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                    }
                }    
            }
            catch { }
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

        private bool checkOtherService(string idxe)
        {
            DataTable table = this.vehicleBUS.getVehicleByID(idxe);
            int park = int.Parse(table.Rows[0]["park"].ToString());
            int fix = int.Parse(table.Rows[0]["fix"].ToString());
            int wash = int.Parse(table.Rows[0]["wash"].ToString());
            if (park != 0 || fix != 0 || wash != 0)
            {
                return true;          //đang sài dịch vụ khác không xóa c=khỏi vehicle
            }
            else
            {
                return false;        //không còn dịch vụ nào xóa đc
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvWash.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Are you sure?", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (this.vehWashBUS.DeleteVehicleWash(id) && this.vehicleBUS.UpdateStatusVehicle(id, "WASH", 0))
                    {
                        MessageBox.Show("Delete successful", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (!this.checkOtherService(id))
                        {
                            if (this.vehicleBUS.DelVehicle(id))
                            {
                                MessageBox.Show("Xóa Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Không Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }    
                        }    
                        this.cbTypeFilter.SelectedIndex = 3;
                        ////Load Progress bar
                        //this.timer1.Start();
                        //fLoad.ShowDialog();
                        ////end
                        DataTable table = this.vehWashBUS.getAllVehicleWash();
                        if (table != null)
                        {
                            this.designDataGridView(table, 2, 3);
                            this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                        }
                        else
                        {
                            this.dgvWash.DataSource = null;
                            this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Delete unsuccessful", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                        this.dgvWash.DataSource = null;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvWash.CurrentRow.Cells[0].Value.ToString();
                int totalFee = this.vehWashBUS.getWash_fee(id);
                doanhThuWashDTO doanhThuWashDTO = new doanhThuWashDTO(id, DateTime.Now, totalFee);
                if (this.dtWashBUS.insert_doanhThuWash(doanhThuWashDTO) && this.vehWashBUS.DeleteVehicleWash(id) && this.vehicleBUS.UpdateStatusVehicle(id, "WASH", 0))
                {
                    MessageBox.Show("Thanh toán thành công dịch vụ", "Info Wash", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (!this.checkOtherService(id))
                    {
                        if (this.vehicleBUS.DelVehicle(id))
                        {
                            MessageBox.Show("Xóa Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Xóa Không Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        }
                    }
                    this.cbTypeFilter.SelectedIndex = 3;
                    DataTable table = this.vehWashBUS.getAllVehicleWash();
                    if (table != null)
                    {
                        this.designDataGridView(table, 2, 3);
                        this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                    }
                    else
                    {
                        this.dgvWash.DataSource = null;
                        this.lbCount.Text = "Số Lượng Xe: " + this.dgvWash.Rows.Count;
                    }
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công", "Info Wash", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //fProgressBar form = new fProgressBar();
            fLoad.gunaCircleProgressBar1.Increment(25);

            if (fLoad.gunaCircleProgressBar1.Value >= fLoad.gunaCircleProgressBar1.Maximum)
            {
                timer1.Stop();
                fLoad.Close();
            }
        }
    }
}
