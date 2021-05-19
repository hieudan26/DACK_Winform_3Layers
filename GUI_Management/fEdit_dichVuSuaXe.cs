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
    public partial class fEdit_dichVuSuaXe : Form
    {
        phiDichVuSuaXeBUS phiDichVuSuaXeBUS = new phiDichVuSuaXeBUS();
        int pos;

        public fEdit_dichVuSuaXe()
        {
            InitializeComponent();
        }

        private void fEdit_dichVuSuaXe_Load(object sender, EventArgs e)
        {

        }

        void reloadListBoxData(DataTable table)
        {
            this.lBoxDichVu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxDichVu.DataSource = table;
            this.lBoxDichVu.ValueMember = "service_fee";
            this.lBoxDichVu.DisplayMember = "service";
            this.lBoxDichVu.SelectedItem = null;
            //this.btnTotal.Text = ("Total Courses: " + course.totalCourses());
            this.lbCount.Text = "Số Lượng Dịch Vụ: " + this.lBoxDichVu.Items.Count.ToString();
        }

        private void cbTypeXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeXe.SelectedIndex;
            if (index != -1 && index != 3)
            {
                DataTable table = this.phiDichVuSuaXeBUS.getDichVu_ByType(index);
                this.reloadListBoxData(table);
            }     
            else if (index == 3)
            {
                DataTable table = this.phiDichVuSuaXeBUS.getDichVu_All();
                this.reloadListBoxData(table);
            }    
        }

        private void lBoxDichVu_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.lBoxDichVu.SelectedItem;
            this.pos = this.lBoxDichVu.SelectedIndex;
            int flag = this.cbTypeXe.SelectedIndex;
            this.showData(pos, flag);
        }

        void showData(int index, int flag)
        {
            DataRow dr;
            if (flag < 3)
            {
                dr = this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows[index];
            }
            else
            {
                dr = this.phiDichVuSuaXeBUS.getDichVu_All().Rows[index];
            }
            this.lBoxDichVu.SelectedIndex = index;
            this.cbTxtType.SelectedIndex = int.Parse(dr["Type"].ToString());
            this.txtTenDichVu.Text = dr.ItemArray[1].ToString().Trim();
            this.txtGiaDichVu.Text = dr.ItemArray[2].ToString().Trim();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTypeXe.SelectedIndex != 3)
                {
                    pos = 0;
                    showData(pos, this.cbTypeXe.SelectedIndex);
                }
                else
                {
                    pos = 0;
                    showData(pos, 3);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTypeXe.SelectedIndex != 3)
                {
                    if (pos > 0)
                    {
                        pos = pos - 1;
                        showData(pos, 1);
                    }
                }    
                else
                {
                    if (pos > 0)
                    {
                        pos = pos - 1;
                        showData(pos, 3);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTypeXe.SelectedIndex != 3)
                {
                    if (pos < (this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows.Count - 1))
                    {
                        pos = pos + 1;
                        showData(pos, 1);
                    }
                }    
                else
                {
                    if (pos < (this.phiDichVuSuaXeBUS.getDichVu_All().Rows.Count - 1))
                    {
                        pos = pos + 1;
                        showData(pos, 3);
                    }
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTypeXe.SelectedIndex != 3)
                {
                    pos = this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows.Count - 1;
                    showData(pos, 1);
                }    
                else
                {
                    pos = this.phiDichVuSuaXeBUS.getDichVu_All().Rows.Count - 1;
                    showData(pos, 3);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnADD_Click(object sender, EventArgs e)
        {
            try
            {
                int Type = this.cbTxtType.SelectedIndex;
                string service = this.txtTenDichVu.Text.Trim();
                int service_fee = int.Parse(this.txtGiaDichVu.Text.Trim());
                if (!this.phiDichVuSuaXeBUS.Service_Exist(service))
                {
                    if (this.phiDichVuSuaXeBUS.insertService(Type, service, service_fee))
                    {
                        MessageBox.Show("Thêm Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DataTable table = this.phiDichVuSuaXeBUS.getDichVu_ByType(Type);
                        this.cbTypeXe.SelectedIndex = Type;
                        this.reloadListBoxData(table);
                    }
                    else
                    {
                        MessageBox.Show("Thêm Dịch Vụ Không Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Dịch Vụ Này Đã Tồn Tại", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.pos = 0;
            }
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                int Type = this.cbTxtType.SelectedIndex;
                string service = this.txtTenDichVu.Text;
                int service_fee = int.Parse(this.txtGiaDichVu.Text);
                if (this.phiDichVuSuaXeBUS.UpdateService_fee(service, service_fee))
                {
                    MessageBox.Show("Chỉnh Sửa Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable table = this.phiDichVuSuaXeBUS.getDichVu_ByType(Type);
                    this.cbTypeXe.SelectedIndex = Type;
                    this.reloadListBoxData(table);
                }
                else
                {
                    MessageBox.Show("Chỉnh Sửa Dịch Vụ Không Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.pos = 0;
            }
        }

        private void btnREMOVE_Click(object sender, EventArgs e)
        {
            try
            {
                string service = this.txtTenDichVu.Text.Trim();
                if (this.phiDichVuSuaXeBUS.DeleteService(service))
                {
                    MessageBox.Show("Xóa Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    DataTable table = this.phiDichVuSuaXeBUS.getDichVu_All();
                    this.cbTypeXe.SelectedIndex = 3;
                    this.reloadListBoxData(table);
                }   
                else
                {
                    MessageBox.Show("Xóa Dịch Vụ Không Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.pos = 0;
            }
        }
    }
}
