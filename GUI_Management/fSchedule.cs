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
    public partial class fSchedule : Form
    {
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();

        public fSchedule()
        {
            InitializeComponent();
        }

        private void btnpBV_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadDataPhong_BaoVe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadLaiFlow(DataTable table, FlowLayoutPanel fl)
        {
            if(table != null)
            {
                this.LoadFlowLayoutPanel(table, fl);
                table.Clear();
            }
            
        }
        private void LoadDataPhong_BaoVe()
        {
            try
            {
                DataTable table;
                //load Ca1_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
                //for (int j = 1; j < 4; j++)
                //{
                //    for (int i = 2; i < 9; i++)
                //    {
                //        string nameFlowLayoutPanel = "flpCa";
                //        FlowLayoutPanel fl = new FlowLayoutPanel();
                //        fl.Name = nameFlowLayoutPanel + j.ToString() + "_" + i.ToString();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        /*private string Thu(int i)
        {
            if (i == 0)
            {
                return "Thu2";
            }    
            else if (i == 1)
            {
                return "Thu3";
            }    
            else if (i == 2)
            {
                return "Thu4";
            }    
            else if (i == 3)
            {
                return "Thu5";
            }    
            else if (i == 4)
            {
                return "Thu6";
            }    
            else if (i == 5)
            {
                return "Thu7";
            }
            else
            {
                return "ChuNhat";
            }
        }*/

        private string XuLyTen(string label)
        {
            int ViTriSpaceCuoiCung = label.LastIndexOf(" ");
            if (ViTriSpaceCuoiCung != -1)
            {
                label = label.Remove(0, ViTriSpaceCuoiCung + 1);
                return label;
            }
            else
                return label;
        }

        private void LoadFlowLayoutPanel(DataTable table, FlowLayoutPanel fl)
        {
            if (table != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Label lbSp = new Label(); lbSp.Text = "--------------------";
                    fl.Controls.Add(lbSp);
                    Label lbName = new Label();
                    lbName.Text = XuLyTen(table.Rows[i][1].ToString().Trim());
                    lbName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
                    fl.Controls.Add(lbName);
                }
                Label lbSp2 = new Label(); lbSp2.Text = "--------------------";
                fl.Controls.Add(lbSp2);
            }
        }

        private void btnpSX_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadDataPhong_SuaXe();
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataPhong_SuaXe()
        {
            try
            {
                DataTable table;
                //load Ca1_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu2");
                if(table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_2);
                    table.Clear();
                }
                //load Ca2_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu2");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_2);
                    table.Clear();
                }
                //load Ca3_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu2");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_2);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_7);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_7);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_7);
                    table.Clear();
                }
                    
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "ChuNhat");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_CN);
                    table.Clear();
                }    
                    
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "ChuNhat");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_CN);
                    table.Clear();
                }    
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpRS_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadDataPhong_RuaXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void LoadDataPhong_RuaXe()
        {
            try
            {
                DataTable table;
                //load Ca1_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpNS_Click(object sender, EventArgs e)
        {
            try
            {
                this.LoadDataPhong_NhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataPhong_NhanVien()
        {
            try
            {
                DataTable table;
                //load Ca1_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ", e.Message);
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.shift_ThoSuaXeBUS.InsertIntoOld_FormNew();
            this.btnpSX_Click(sender, e);
        }
    }
}
