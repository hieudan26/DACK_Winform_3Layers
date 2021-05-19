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

namespace GUI_Management
{
    public partial class fEdit_phiRuaXe : Form
    {
        phiDichVuRuaXeBUS phiDichVuRuaXeBUS = new phiDichVuRuaXeBUS();

        public fEdit_phiRuaXe()
        {
            InitializeComponent();
        }

        private void LoadTxt(int type)
        {
            DataTable table = this.phiDichVuRuaXeBUS.getPriceByType(type);
            if (table != null)
            {
                this.txtFee.Text = table.Rows[0]["Wash Fee"].ToString();
            }    
        }

        private void cbTypeXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbTypeXe.SelectedIndex == 0)
            {
                this.picBox.Image = Properties.Resources.bike_gif;
            }    
            else if (this.cbTypeXe.SelectedIndex == 1)
            {
                this.picBox.Image = Properties.Resources.motor_gif;
            }    
            else
            {
                this.picBox.Image = Properties.Resources.car_gif;
            }
            this.LoadTxt(this.cbTypeXe.SelectedIndex);
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                if (this.txtFee.Text != "")
                {
                    int type = this.cbTypeXe.SelectedIndex;
                    int wash_fee = int.Parse(this.txtFee.Text);
                    if (this.phiDichVuRuaXeBUS.updatePrice(type, wash_fee))
                    {
                        MessageBox.Show("Update thành công phí tiền rửa xe", "Edit Phí Rửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                    {
                        MessageBox.Show("Update không thành công phí tiền rửa xe", "Edit Phí Rửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }    
                else
                {
                    MessageBox.Show("Empty Fields", "Edit Phí Rửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }    
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
