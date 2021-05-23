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
    public partial class fStaticLuong : Form
    {
        danhSachLuongDaThanhToanBUS danhSachLuongDaThanhToanBUS = new danhSachLuongDaThanhToanBUS();

        public fStaticLuong()
        {
            InitializeComponent();
        }

        private void fStaticLuong_Load(object sender, EventArgs e)
        {
            this.LoadDataGridView();
            this.LoadLabel();
            this.LoadChart();
        }

        private void LoadChart()
        {
            this.chart1.Series["Series1"].Points.AddXY("Bảo Vệ", int.Parse(this.txtBV.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Thợ Sửa", int.Parse(this.txtTS.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Thợ Rửa", int.Parse(this.txtTR.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Nhân Viên", int.Parse(this.txtNV.Text.Trim()));
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
        }

        private void LoadLabel()
        {
            DataTable table = new DataTable();
            table = this.danhSachLuongDaThanhToanBUS.sum("Bảo Vệ");
            if (table != null)
            { 
                this.txtBV.Text = table.Rows[0][0].ToString().Trim();
            }    
            else
            {
                this.txtBV.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Thợ Sửa");
            if (table != null)
            {
                this.txtTS.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtTS.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Thợ Rửa");
            if (table != null)
            {
                this.txtTR.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtTR.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Nhân Viên");
            if (table != null)
            {
                this.txtNV.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtNV.Text = "0";
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                this.dgv.ReadOnly = true;
                this.dgv.DataSource = this.danhSachLuongDaThanhToanBUS.getFullInfo();
                this.dgv.RowTemplate.Height = 50;
                this.dgv.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }
    }
}
