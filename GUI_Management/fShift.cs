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
            this.dtPicker.Value = Convert.ToDateTime(day);
            if (day.DayOfWeek == DayOfWeek.Saturday)
            {
                try
                {
                    ///////Reset bảo vệ --> đẩy dữ liệu vào table//////
                    this.shift_BaoVeBUS.ResetShift_BaoVe();
                    this.shift_BaoVeBUS.InsertIntoOld_FormNew();
                    //////Reset thợ sửa --> đẩy dữ liệu vào table//////
                    this.shift_ThoSuaXeBUS.ResetShift_ThoSuaXe();
                    this.shift_ThoSuaXeBUS.InsertIntoOld_FormNew();
                    //////Reset thợ rửa --> đẩy dữ liệu vào table//////
                    this.shift_ThoRuaXeBUS.ResetShift_ThoRuaXe();
                    this.shift_ThoRuaXeBUS.InsertIntoOld_FormNew();
                    //////Reset nhân viên --> đẩy dữ liệu vào table/////
                    this.shift_NhanVienBUS.ResetShift_NhanVien();
                    this.shift_NhanVienBUS.InsertIntoOld_FormNew();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message, "Reset New Shift", MessageBoxButtons.AbortRetryIgnore, MessageBoxIcon.Error);
                }
            }    
        }

        private DataTable showName_ID_byDoW(DataTable tableBu, int Ca)
        {
            try
            {
                if (tableBu != null)
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
                    for (int i = tableBu.Rows.Count - 1; i >= 0; i--)
                    {
                        DataRow item = tableBu.Rows[i];
                        if (int.Parse(item[2].ToString()) != Ca)
                        {
                            tableBu.Rows.Remove(item);
                        }
                    }
                    return tableBu;
                }
                else
                    return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            return null;
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
                    try
                    {
                        this.listB_BV.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        DataTable temp = this.showName_ID_byDoW(this.shift_BaoVeBUS.getALLShift_BaoVe(), ca);
                        if(temp != null)
                        {
                            this.listB_BV.DataSource = temp;
                            this.listB_BV.ValueMember = "id";
                            this.listB_BV.DisplayMember = "name";
                            this.listB_BV.SelectedItem = null;
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
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
                    try
                    {
                        this.listB_SX.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        DataTable temp = this.showName_ID_byDoW(this.shift_ThoSuaXeBUS.getALLShift_ThoSuaXe(), this.Ca());
                        if(temp != null)
                        {
                            this.listB_SX.DataSource = temp;
                            this.listB_SX.ValueMember = "id";
                            this.listB_SX.DisplayMember = "name";
                            this.listB_SX.SelectedItem = null;
                        }
                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
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
                    try
                    {
                        this.listB_RX.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        DataTable temp = this.showName_ID_byDoW(this.shift_ThoRuaXeBUS.getALLShift_ThoRuaXe(), this.Ca());
                        if(temp != null)
                        {
                            this.listB_RX.DataSource = temp;
                            this.listB_RX.ValueMember = "id";
                            this.listB_RX.DisplayMember = "name";
                            this.listB_RX.SelectedItem = null;
                        }
                            
                    }    
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: ", ex.Message);
                    }
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
                    try
                    {
                        this.listB_NV.Font = new System.Drawing.Font("Segoe UI", 11.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                        DataTable temp = this.showName_ID_byDoW(this.shift_NhanVienBUS.getALLShift_NhanVien(), this.Ca());
                        if (temp != null)
                        {
                            this.listB_NV.DataSource = temp;
                            this.listB_NV.ValueMember = "id";
                            this.listB_NV.DisplayMember = "name";
                            this.listB_NV.SelectedItem = null;
                        }
                           
                    }   
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: ", ex.Message);
                    }
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

        private void btnSche_Click(object sender, EventArgs e)
        {
            fSchedule form = new fSchedule();
            this.Hide();
            form.ShowDialog();
            this.Show();
        }
    }
}
