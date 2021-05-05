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
    public partial class fShift : Form
    {
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();

        private int thu;
        public fShift()
        {
            InitializeComponent();
        }

        private void fShift_Load(object sender, EventArgs e)
        {
            DateTime day = DateTime.Now;
            //int thu = (int)day.DayOfWeek;
            this.dtPicker.Value = Convert.ToDateTime(day);
        }

        private DataTable showName_ID_byDoW(DataTable tableBu, int Ca)
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
            {
                thu = 8;
            }
            //id0, name1, t2 2  ---tableBu
            //xóa cột thứ ko sài
            for (int j = 8; j >= 2; j--)
            {
                if (j != thu)
                {
                    tableBu.Columns.RemoveAt(j);
                }
            }

            //lấy tên ca
            for (int i = tableBu.Rows.Count - 1; i >= 0 ; i--)
            {
                DataRow item = tableBu.Rows[i];
                if (int.Parse(item[2].ToString()) != Ca)
                {
                    tableBu.Rows.Remove(item);
                }    
            }
            return tableBu;
        }

        private int Ca()
        {
            if (this.rbCa1.Checked == true)
            {
                return 1;
            }
            else if (this.rbCa2.Checked == true)
            {
                return 2;
            }
            else
            {
                return 3;
            }    
        }

        private void llb_BaoVe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.listB_BV.Visible == false)
            {
                this.listB_BV.Visible = true;
                this.listB_NV.Visible = false;
                this.listB_RX.Visible = false;
                this.listB_SX.Visible = false;
                // ------------------------------------------------------------------//
                int ca = this.Ca();
                if (this.rbCa1.Checked == false && this.rbCa2.Checked == false && this.rbCa3.Checked == false)
                {
                    MessageBox.Show("Pls choose shift", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.listB_BV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.listB_BV.DataSource = this.showName_ID_byDoW(this.shift_BaoVeBUS.getALLShift_BaoVe(), ca);
                    this.listB_BV.ValueMember = "id";
                    this.listB_BV.DisplayMember = "name";
                    this.listB_BV.SelectedItem = null;
                }    
            }    
            else
            {
                this.listB_BV.Visible = false;
                this.listB_NV.Visible = true;
                this.listB_RX.Visible = true;
                this.listB_SX.Visible = true;
            }    
        }

        private void llb_SuaXe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.listB_SX.Visible == false)
            {
                this.listB_BV.Visible = false;
                this.listB_NV.Visible = false;
                this.listB_RX.Visible = false;
                this.listB_SX.Visible = true;
                if (this.rbCa1.Checked == false && this.rbCa2.Checked == false && this.rbCa3.Checked == false)
                {
                    MessageBox.Show("Pls choose shift", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.listB_SX.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.listB_SX.DataSource = this.showName_ID_byDoW(this.shift_ThoSuaXeBUS.getALLShift_ThoSuaXe(), this.Ca());
                    this.listB_SX.ValueMember = "id";
                    this.listB_SX.DisplayMember = "name";
                    this.listB_SX.SelectedItem = null;
                }
            }
            else
            {
                this.listB_BV.Visible = true;
                this.listB_NV.Visible = true;
                this.listB_RX.Visible = true;
                this.listB_SX.Visible = false;
            }
        }

        private void llb_RuaXe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.listB_RX.Visible == false)
            {
                this.listB_BV.Visible = false;
                this.listB_NV.Visible = false;
                this.listB_RX.Visible = true;
                this.listB_SX.Visible = false;
                if (this.rbCa1.Checked == false && this.rbCa2.Checked == false && this.rbCa3.Checked == false)
                {
                    MessageBox.Show("Pls choose shift", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.listB_RX.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.listB_RX.DataSource = this.showName_ID_byDoW(this.shift_ThoRuaXeBUS.getALLShift_ThoRuaXe(), this.Ca());
                    this.listB_RX.ValueMember = "id";
                    this.listB_RX.DisplayMember = "name";
                    this.listB_RX.SelectedItem = null;
                }
            }
            else
            {
                this.listB_BV.Visible = true;
                this.listB_NV.Visible = true;
                this.listB_RX.Visible = false;
                this.listB_SX.Visible = true;
            }
        }

        private void llb_NhanVien_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (this.listB_NV.Visible == false)
            {
                this.listB_BV.Visible = false;
                this.listB_NV.Visible = true;
                this.listB_RX.Visible = false;
                this.listB_SX.Visible = false;
                if (this.rbCa1.Checked == false && this.rbCa2.Checked == false && this.rbCa3.Checked == false)
                {
                    MessageBox.Show("Pls choose shift", "Schedule", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    this.listB_NV.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    this.listB_NV.DataSource = this.showName_ID_byDoW(this.shift_NhanVienBUS.getALLShift_NhanVien(), this.Ca());
                    this.listB_NV.ValueMember = "id";
                    this.listB_NV.DisplayMember = "name";
                    this.listB_NV.SelectedItem = null;
                }
            }
            else
            {
                this.listB_BV.Visible = true;
                this.listB_NV.Visible = false;
                this.listB_RX.Visible = true;
                this.listB_SX.Visible = true;
            }
        }
    }
}
