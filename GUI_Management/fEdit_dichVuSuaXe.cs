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

        void reloadListBoxData(int index)
        {
            this.lBoxDichVu.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lBoxDichVu.DataSource = this.phiDichVuSuaXeBUS.getDichVu_ByType(index);
            this.lBoxDichVu.ValueMember = "service_fee";
            this.lBoxDichVu.DisplayMember = "service";
            this.lBoxDichVu.SelectedItem = null;
            //this.btnTotal.Text = ("Total Courses: " + course.totalCourses());
        }

        private void cbTypeXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeXe.SelectedIndex;
            if (index != -1)
            {
                this.reloadListBoxData(index);
            }     
        }

        private void lBoxDichVu_Click(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)this.lBoxDichVu.SelectedItem;
            this.pos = this.lBoxDichVu.SelectedIndex;
            this.showData(pos);
        }

        void showData(int index)
        {
            DataRow dr = this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows[index];
            this.lBoxDichVu.SelectedIndex = index;
            this.cbTxtType.SelectedIndex = this.cbTypeXe.SelectedIndex;   
            this.txtTenDichVu.Text = dr.ItemArray[1].ToString();
            this.txtGiaDichVu.Text = dr.ItemArray[2].ToString();
        }

        private void btnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                pos = 0;
                showData(pos);
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
                if (pos > 0)
                {
                    pos = pos - 1;
                    showData(pos);
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
                if (pos < (this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows.Count - 1))
                {
                    pos = pos + 1;
                    showData(pos);
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
                pos = this.phiDichVuSuaXeBUS.getDichVu_ByType(this.cbTypeXe.SelectedIndex).Rows.Count - 1;
                showData(pos);
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
                int type = this.cbTxtType.SelectedIndex;
                string service = this.txtTenDichVu.Text;
                int service_fee = int.Parse(this.txtGiaDichVu.Text);
                if (this.phiDichVuSuaXeBUS.insertService(type, service, service_fee))
                {
                    MessageBox.Show("Thêm Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.reloadListBoxData(type);
                }    
                else
                {
                    MessageBox.Show("Thêm Dịch Vụ Không Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int type = this.cbTxtType.SelectedIndex;
                string service = this.txtTenDichVu.Text;
                int service_fee = int.Parse(this.txtGiaDichVu.Text);
                if (this.phiDichVuSuaXeBUS.UpdateService_fee(service, service_fee))
                {
                    MessageBox.Show("Chỉnh Sửa Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                string service = this.txtTenDichVu.Text;
                if (this.phiDichVuSuaXeBUS.DeleteService(service))
                {
                    MessageBox.Show("Xóa Dịch Vụ Thành Công", "Edit Dịch Vụ Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.reloadListBoxData(this.cbTypeXe.SelectedIndex);
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
