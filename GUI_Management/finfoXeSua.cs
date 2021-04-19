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

        public finfoXeSua(fQuanLyXe fQuanLy)
        {
            InitializeComponent();
            this.formQuanLyXeGui = fQuanLy;
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeFilter.SelectedIndex;
            this.dgvFix.RowTemplate.Height = 80;
            if (index < 3 && index >=0)
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehFixBUS.getVehicleFix_info_byType(index);
                if (table != null)
                {
                    this.dgvFix.DataSource = table;
                    this.designDataGridView(3, 4);
                }
                else
                {
                    this.dgvFix.DataSource = null;
                }    
            }    
            else
            {
                DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                if (table != null)
                {
                    this.dgvFix.DataSource = table;
                    this.designDataGridView(3, 4);
                }
                else
                {
                    this.dgvFix.DataSource = null;
                }
            }    
        }

        private void designDataGridView(int i1, int i2)
        {
            this.dgvFix.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();

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
                this.cbTypeFilter.SelectedIndex = -1;
                string id = this.txtSearch.Text;
                if (this.vehFixBUS.getVehicleByID_GanDung(this.txtSearch.Text) != null)
                {
                    this.dgvFix.RowTemplate.Height = 80;
                    this.dgvFix.DataSource = this.vehFixBUS.getVehicleByID_GanDung(this.txtSearch.Text);
                    this.designDataGridView(3, 4);
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
                                this.dgvFix.DataSource = table;
                                this.designDataGridView(3, 4);
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

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.dgvFix.CurrentRow.Cells[0].Value.ToString();
                string service = this.dgvFix.CurrentRow.Cells[1].Value.ToString();
                if (this.vehFixBUS.DeleteVehicleFix(id, service))
                {
                    MessageBox.Show("Xóa dịch vụ sửa thành công", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cbTypeFilter.SelectedIndex = 3;
                    DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                    if (table != null)
                    {
                        this.dgvFix.DataSource = table;
                        this.designDataGridView(3, 4);
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
                if (this.dtFixBUS.insert_doanhThuFix(doanhThuFixDTO) && this.vehFixBUS.DeleteVehicleFix(id, service))
                {
                    MessageBox.Show("Thanh toán thành công dịch vụ: " + service + " trị giá: " + totalFee + " VND", "Info Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.cbTypeFilter.SelectedIndex = 3;
                    DataTable table = this.vehFixBUS.getVehicleFix_info_all();
                    if (table != null)
                    {
                        this.dgvFix.DataSource = table;
                        this.designDataGridView(4, 5);
                    }
                    else
                    {
                        this.dgvFix.DataSource = null;
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
    }
}
