using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI_Management
{
    public partial class fStatics_DTvehicle : Form
    {
        int sumGuixe;
        int sumSuaxe;
        int sumRuaxe;
        fQuanLyXe fQuanLyXe = new fQuanLyXe();

        public fStatics_DTvehicle(fQuanLyXe f, int gui, int sua, int rua)
        {
            InitializeComponent();
            this.sumGuixe = gui;
            this.sumSuaxe = sua;
            this.sumRuaxe = rua;
            this.fQuanLyXe = f;
        }

        private void fStatics_DTvehicle_Load(object sender, EventArgs e)
        {
            this.BD.Series["Members"].Points.AddXY("Doanh Thu Gửi Xe", this.sumGuixe);
            this.BD.Series["Members"].Points.AddXY("Doanh Thu Sửa Xe", this.sumSuaxe);
            this.BD.Series["Members"].Points.AddXY("Doanh Thu Rửa Xe", this.sumRuaxe);
            this.BD.Titles.Add("BIỂU ĐỒ THỂ HIỆN DOANH THU HIỆN TẠI");
            this.BD.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fdoanhThu f = new fdoanhThu(this.fQuanLyXe);
            this.fQuanLyXe.openChildForm(f);
        }

        private void btnChange_Click(object sender, EventArgs e)
        {
            //this.BD.Series["Members"].Points.AddXY("Doanh Thu Gửi Xe", this.sumGuixe);
            //this.BD.Series["Members"].Points.AddXY("Doanh Thu Sửa Xe", this.sumSuaxe);
            //this.BD.Series["Members"].Points.AddXY("Doanh Thu Rửa Xe", this.sumRuaxe);
            //this.BD.Titles.Add("BIỂU ĐỒ THỂ HIỆN DOANH THU HIỆN TẠI");
            if (this.BD.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie)
            {
                this.BD.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;
            }  
            else if (this.BD.Series[0].ChartType == System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column)
            {
                this.BD.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            }
            else
            {
                this.BD.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            }    
        }
    }
}
