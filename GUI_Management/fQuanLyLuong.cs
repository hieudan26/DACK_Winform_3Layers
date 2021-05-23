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
    public partial class fQuanLyLuong : Form
    {
        SalaryBUS salaryBUS = new SalaryBUS();
        public fQuanLyLuong()
        {
            InitializeComponent();
        }

        private void fQuanLyLuong_Load(object sender, EventArgs e)
        {
                DataTable table = this.salaryBUS.getKetToanLuongAll();
                if(table != null)
                    this.LoadDGV(table);
                else
                    this.ResetDGV();
        }
        private void LoadDGV(DataTable table)
        {
            this.DGVLuongperhour.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            this.DGVLuongperhour.RowTemplate.Height = 80;
            this.DGVLuongperhour.DataSource =table;
            this.DGVLuongperhour.AllowUserToAddRows = false;
            this.DGVLuongperhour.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DGVLuongperhour.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            this.DGVLuongperhour.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            picCol = (DataGridViewImageColumn)this.DGVLuongperhour.Columns[2];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.DGVLuongperhour.AllowUserToAddRows = false;
        }

        private void cbTypeNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTypeNV.SelectedItem.ToString().Trim() != null)
            {
                string text = this.cbTypeNV.SelectedItem.ToString().Trim();
                DataTable table = this.salaryBUS.getKetToanLuongType(text);
                if (table != null)
                {
                    this.LoadDGV(table);
                }    
                else
                    this.ResetDGV();
            }
        }
        private void ResetDGV()
        {
            DataTable table = new DataTable();
            this.DGVLuongperhour.DataSource = table;
        }
        private void FIllForm(DataTable table)
        {
            this.txtID.Text = table.Rows[0][0].ToString();
            this.txtName.Text = table.Rows[0][1].ToString();
            this.cbTxtType.SelectedItem = table.Rows[0][2].ToString().Trim();
            this.txtLuong.Text = table.Rows[0][4].ToString();
            byte[] pic = (byte[])table.Rows[0][3];
            MemoryStream picture = new MemoryStream(pic);
            this.picBox.Image = Image.FromStream(picture);

        }

        private void DGVLuongperhour_Click(object sender, EventArgs e)
        {
            if (this.DGVLuongperhour.CurrentRow != null)
            {
                string ID = this.DGVLuongperhour.CurrentRow.Cells[0].Value.ToString().Trim();
                DataTable table = this.salaryBUS.getKetToanLuongID(ID);
                if (table != null)
                {
                    this.FIllForm(table);
                    /*float x = this.salaryBUS.getLuongHourPerCa(table.Rows[0][2].ToString().Trim(), 3);
                    MessageBox.Show(x.ToString());
                    this.salaryBUS.UpdateLuong(table.Rows[0][0].ToString().Trim(), x);
                    */
                }
            }
        }

        private void btnKetToan_Click(object sender, EventArgs e)
        {
            string IDNV = txtID.Text;
            if(IDNV == "")
            {
                MessageBox.Show("ID trống");
            }
            else
            {
                //Làm gì đó ở đây
                //
                if(this.salaryBUS.ResetNV(IDNV))
                {
                    MessageBox.Show("Kết toán lương thành công");
                }
                else
                {
                    MessageBox.Show("Kết toán lương thất bại");
                }    
            }    
        }

        private void DGVLuongperhour_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
