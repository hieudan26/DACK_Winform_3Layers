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
    public partial class fStatics_DTThue_ChoThue : Form
    {
        doanhThuContract_ThueBUS doanhThuContract_ThueBUS = new doanhThuContract_ThueBUS();
        doanhThuContract_ChoThueBUS doanhThuContract_ChoThueBUS = new doanhThuContract_ChoThueBUS();
        contract_ThueBUS contract_ThueBUS = new contract_ThueBUS();
        contract_ChoThueBUS contract_ChoThueBUS = new contract_ChoThueBUS();
        private int i = 0;

        public fStatics_DTThue_ChoThue()
        {
            InitializeComponent();
        }

        private void fStatics_DTThue_ChoThue_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(i.ToString().Trim()());
            this.LoadPanel1();
            this.LoadPanel2();
            this.LoadPanel3();
            this.LoadChart1();
            this.LoadChart2();
            this.LoadChart3();
            this.timer1.Start();
        }

        private void LoadChart3()
        {
            this.chart3.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Đạp", int.Parse(this.lb2.Text.Trim()));
            this.chart3.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Máy", int.Parse(this.lb3.Text.Trim()));
            this.chart3.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Hơi", int.Parse(this.lb4.Text.Trim()));
            this.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
        }

        private void LoadChart2()
        {
            this.chart2.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Đạp", int.Parse(this.lbxedapThue.Text.Trim()));
            this.chart2.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Máy", int.Parse(this.lbXeMayThue.Text.Trim()));
            this.chart2.Series["Series1"].Points.AddXY("Số Hợp Đồng Xe Hơi", int.Parse(this.lbXeHoiThue.Text.Trim()));
            this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
        }

        private void LoadChart1()
        {
            this.chart1.Series["Series1"].Points.AddXY("Số Hợp Đồng Thuê", int.Parse(this.lbSoHDThue_DTT.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Số Hợp Đồng Cho Thuê", int.Parse(this.lbSoHDChoThue_DTT.Text.Trim()));
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }    

        private void LoadPanel1()
        {
            DataTable table = this.doanhThuContract_ThueBUS.CountContract_SumTotal(Global.GlobalEmployeeId);
            if (table != null)
            {
                this.lbSoHDThue_DTT.Text = table.Rows[0][0].ToString().Trim();
                this.txtTongThuThue_DTT.Text = table.Rows[0][1].ToString().Trim();
            }    
            else
            {
                this.lbSoHDThue_DTT.Text = i.ToString().Trim();
                this.txtTongThuThue_DTT.Text = i.ToString().Trim();
            }    

            DataTable table1 = this.doanhThuContract_ChoThueBUS.CountContract_SumTotal(Global.GlobalEmployeeId);
            if (table1 != null)
            {
                this.lbSoHDChoThue_DTT.Text = table.Rows[0][0].ToString().Trim();
                this.txtTongthuChoThue_DTT.Text = table.Rows[0][1].ToString().Trim();
            }    
            else
            {
                this.lbSoHDChoThue_DTT.Text = i.ToString().Trim();
                this.txtTongthuChoThue_DTT.Text = i.ToString().Trim();
            }    
        }

        private void LoadPanel2()
        {
            DataTable table = new DataTable();
            table = this.contract_ThueBUS.count(Global.GlobalEmployeeId);
            if (table != null)
            {
                this.lbSHDT_CTT.Text = table.Rows[0][0].ToString().Trim();
                this.txtTongChi2.Text = table.Rows[0][1].ToString().Trim();
            }    
            else
            {
                this.lbSHDT_CTT.Text = i.ToString().Trim();
                this.txtTongChi2.Text = i.ToString().Trim();
            }    

            //table.Clear();
            table = this.contract_ThueBUS.countTypeXe(Global.GlobalEmployeeId, 0);
            if (table != null)
            {
                this.lbxedapThue.Text = table.Rows[0][0].ToString().Trim();
            }    
            else
            {
                this.lbxedapThue.Text = i.ToString().Trim();
            }   

            //table.Clear();
            table = this.contract_ThueBUS.countTypeXe(Global.GlobalEmployeeId, 1);
            if (table != null)
            {
                this.lbXeMayThue.Text = table.Rows[0][0].ToString().Trim();
            }    
            else
            {
                this.lbXeMayThue.Text = i.ToString().Trim();
            }

            table = this.contract_ThueBUS.countTypeXe(Global.GlobalEmployeeId, 2);
            if (table != null)
            {
                this.lbXeHoiThue.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.lbXeHoiThue.Text = i.ToString().Trim();
            }
            //this.lbXeHoiThue.Text = (int.Parse(this.lbSHDT_CTT.Text.Trim()) - int.Parse(this.lbxedapThue.Text.Trim()) + int.Parse(this.lbXeMayThue.Text.Trim())).ToString();
        }

        private void LoadPanel3()
        {
            DataTable table = new DataTable();
            table = this.contract_ChoThueBUS.count(Global.GlobalEmployeeId);
            if (table != null)
            {
                this.lb1.Text = table.Rows[0][0].ToString().Trim();
                this.txt1.Text = table.Rows[0][1].ToString().Trim();
            }
            else
            {
                this.lb1.Text = i.ToString().Trim();
                this.txt1.Text = i.ToString().Trim();
            }

            //table.Clear();
            table = this.contract_ChoThueBUS.countTypeXe(Global.GlobalEmployeeId, 0);
            if (table != null)
            {
                this.lb2.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.lb2.Text = i.ToString().Trim();
            }

            //table.Clear();
            table = this.contract_ChoThueBUS.countTypeXe(Global.GlobalEmployeeId, 1);
            if (table != null)
            {
                this.lb3.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.lb3.Text = i.ToString().Trim();
            }

            table = this.contract_ChoThueBUS.countTypeXe(Global.GlobalEmployeeId, 2);
            if (table != null)
            {
                this.lb4.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.lb4.Text = i.ToString().Trim();
            }

            //this.lb4.Text = (int.Parse(this.lb1.Text.Trim()) - int.Parse(this.lb2.Text.Trim()) + int.Parse(this.lb3.Text.Trim())).ToString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (this.chart1.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
            {
                this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            }
            else
            {
                this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            } 

            if (this.chart2.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line)
            {
                this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }    
            else
            {
                this.chart2.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }    

            if (this.chart3.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble)
            {
                this.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            }    
            else
            {
                this.chart3.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bubble;
            }    
        }
    }
}

