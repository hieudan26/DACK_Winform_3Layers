using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;

namespace GUI_Management
{
    public partial class finfoXeSua : Form
    {
        vehicleFixBUS vehFixBUS = new vehicleFixBUS();
        phiDichVuSuaXeBUS phiSuaBUS = new phiDichVuSuaXeBUS();
        fQuanLyXe formQuanLyXeGui;
        doanhThuFixBUS dtFixBUS = new doanhThuFixBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();
        fProgressBar fLoad = new fProgressBar();

        public finfoXeSua(fQuanLyXe fQuanLy)
        {
            InitializeComponent();
            this.formQuanLyXeGui = fQuanLy;
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Load Progress bar
            this.timer1.Start();
            fLoad.ShowDialog();
            //end
            int index = this.cbTypeFilter.SelectedIndex;
            if (index < 3 && index >=0)
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehFixBUS.getVehicleFix_info_byType(index);
                if (table != null)
                {
                    this.designDataGridView(table, 3, 4);
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                }
                else
                {
                    this.dgvFix.DataSource = null;
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                }    
            }    
            else
            {
                DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                if (table != null)
                {
                    this.designDataGridView(table, 3, 4);
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                }
                else
                {
                    this.dgvFix.DataSource = null;
                    this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                }
            }    
        }

        private void designDataGridView(DataTable table, int i1, int i2)
        {
            this.dgvFix.RowTemplate.Height = 80;
            this.dgvFix.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            this.dgvFix.DataSource = table;
            picCol = (DataGridViewImageColumn)this.dgvFix.Columns[i1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)this.dgvFix.Columns[i2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dgvFix.AllowUserToAddRows = false;
        }

        private void dgvFix_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (this.dgvFix.DataSource != null)
            {
                this.txtTienSua.Text = "";
                //this.txtDichVuSua.Text = this.dgvFix.CurrentRow.Cells[1].Value.ToString();
                if (this.phiSuaBUS.getDichVu_ByType(Convert.ToInt32(this.dgvFix.CurrentRow.Cells[2].Value)) != null)
                {
                    this.cbDichVu.DataSource = this.phiSuaBUS.getDichVu_ByType(Convert.ToInt32(this.dgvFix.CurrentRow.Cells[2].Value));
                    this.cbDichVu.DisplayMember = "service";
                    this.cbDichVu.ValueMember = "service";
                }
                else
                {
                    MessageBox.Show("Can't Load DataSource");
                }
            }    

            //this.txtTienSua.Text = this.phiSuaBUS.getFee_byService(this.cbDichVu.Text);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtSearch.Text != "")
                {
                    this.cbTypeFilter.SelectedIndex = -1;
                    string id = this.txtSearch.Text;
                    if (this.vehFixBUS.getVehicleByID_GanDung(this.txtSearch.Text) != null)
                    {
                        DataTable table = this.vehFixBUS.getVehicleByID_GanDung(this.txtSearch.Text);
                        this.designDataGridView(table, 3, 4);
                        this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                    }
                }    
            }
            catch { }
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(this.cbDichVu.Text);
            if (this.cbDichVu.SelectedIndex != -1)
                this.txtTienSua.Text = this.phiSuaBUS.getFee_byService(this.cbDichVu.Text);
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
            this.formQuanLyXeGui.pnlMove.Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbDichVu.SelectedIndex != -1)
                {
                    string id = this.dgvFix.CurrentRow.Cells[0].Value.ToString();
                    string service = this.cbDichVu.Text;
                    vehicleFixDTO vehFixDTO = new vehicleFixDTO(id, service);
                    if (this.vehFixBUS.VerifyIDandService_Existed(id, service) == false)
                    {
                        if (this.vehFixBUS.insertVehicle_FIX(vehFixDTO))
                        {
                            MessageBox.Show("Thêm dịch vụ sửa thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.cbTypeFilter.SelectedIndex = 3;
                            DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                            if (table != null)
                            {
                                this.designDataGridView(table, 3, 4);
                                this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                            }
                            else
                            {
                                this.dgvFix.DataSource = null;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Thêm dịch vụ sửa không thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            this.dgvFix.DataSource = null;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Xe đã và đang sử dụng dịch vụ này.\nVui lòng chọn lại", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch { }
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
                string id = this.dgvFix.CurrentRow.Cells[0].Value.ToString();
                string service = this.dgvFix.CurrentRow.Cells[1].Value.ToString();
                if (this.vehFixBUS.DeleteVehicleFix(id, service) && this.vehicleBUS.UpdateStatusVehicle(id, "FIX", 0))
                {
                    MessageBox.Show("Xóa dịch vụ sửa thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                    if (table != null)
                    {
                        this.designDataGridView(table, 3, 4);
                        this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                    }
                    else
                    {
                        this.dgvFix.DataSource = null;
                    }
                }
                else
                {
                    MessageBox.Show("Xóa dịch vụ sửa không thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.dgvFix.DataSource = null;
                }
            }
            catch { }
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvFix.CurrentRow.Cells[0].Value.ToString();
                string service = this.dgvFix.CurrentRow.Cells[1].Value.ToString();
                int totalFee = Convert.ToInt32(this.phiSuaBUS.getFee_byService(service));
                doanhThuFixDTO doanhThuFixDTO = new doanhThuFixDTO(id, DateTime.Now, totalFee);
                if (this.dtFixBUS.insert_doanhThuFix(doanhThuFixDTO) && this.vehFixBUS.DeleteVehicleFix(id, service) && this.vehicleBUS.UpdateStatusVehicle(id, "FIX", 0))
                {
                    MessageBox.Show("Thanh toán thành công dịch vụ: " + service + " trị giá: " + totalFee + " VND", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                    if (table != null)
                    {
                       this.designDataGridView(table, 3, 4);
                       this.lbCount.Text = "Số Lượng Xe: " + this.dgvFix.Rows.Count;
                    }
                    else
                    {
                        //this.dgvFix.DataSource = null;
                        this.lbCount.Text = "" + this.dgvFix.Rows.Count;
                    }
                }
                else
                {
                    MessageBox.Show("Thanh toán không thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch { }
        }

        private void finfoXeSua_Load(object sender, EventArgs e)
        {
            //this.cbDichVu.DataSource = null;
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

        private string type(int loaiXe)
        {
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

        private DataTable table_DichVuChuaDung(string idXe, DataTable tableBu)
        {
            try
            {
                for (int i = tableBu.Rows.Count - 1; i >= 0; i--)
                {
                    DataRow row = tableBu.Rows[i];
                    string service = row["service"].ToString();
                    if (this.vehFixBUS.VerifyIDandService_Existed(idXe, service))
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

        private void dgvFix_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                //type 2
                int loaiXe = int.Parse(this.dgvFix.CurrentRow.Cells[2].Value.ToString());
                string id = this.dgvFix.CurrentRow.Cells[0].Value.ToString();
                faddDichVuSua form = new faddDichVuSua(this.table_DichVuChuaDung(id, this.phiSuaBUS.getDichVu_ByType(loaiXe)), loaiXe, this.formQuanLyXeGui);
                form.txtIDXe.Text = id;
                form.txtTypeXe.Text = this.type(loaiXe);
                form.dgvServices.RowTemplate.Height = 30;
                form.dgvServices.ReadOnly = true;
                //form.dgvServices.DataSource = ;
                form.dgvServices.AllowUserToAddRows = false;
                form.loadLabelSum();
                this.formQuanLyXeGui.openChildForm(form);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
