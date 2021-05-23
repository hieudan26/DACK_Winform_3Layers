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
    public partial class fQuanLySalaryPerHour : Form
    {
        SalaryBUS salaryBUS = new SalaryBUS();
        public fQuanLySalaryPerHour()
        {
            InitializeComponent();
        }

        private void fQuanLySalaryPerHour_Load(object sender, EventArgs e)
        {
            DataTable table = this.salaryBUS.getFullLuongPerHour();
            this.DGVLuongperhour.DataSource = table;
        }

        private void cbTypeNV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(this.cbTypeNV.SelectedItem.ToString().Trim() != null)
            {
                string text = this.cbTypeNV.SelectedItem.ToString().Trim();
                DataTable table = this.salaryBUS.getLuongTypePerHour(text);
                this.DGVLuongperhour.DataSource = table;
            }
        }

        private void DGVLuongperhour_Click(object sender, EventArgs e)
        {
            if (this.DGVLuongperhour.CurrentRow != null)
            {
                this.cbTxtType.SelectedItem = this.DGVLuongperhour.CurrentRow.Cells[0].Value.ToString().Trim();
                this.numerCa.Value = int.Parse(this.DGVLuongperhour.CurrentRow.Cells[1].Value.ToString());
                this.txtLuong.Text = this.DGVLuongperhour.CurrentRow.Cells[2].Value.ToString().Trim();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.cbTxtType.SelectedItem != null && txtLuong != null)
                {
                    string type = this.cbTxtType.SelectedItem.ToString().Trim();
                    float Luong = float.Parse(this.txtLuong.Text);
                    int Ca = int.Parse(this.numerCa.Value.ToString());
                    if (this.salaryBUS.UpdateLuongPerHour(type, Ca, Luong))
                        MessageBox.Show("Edit Successful");
                    else
                    {
                        
                    }    
                }
                else
                {
                    MessageBox.Show("Some field emty");
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
