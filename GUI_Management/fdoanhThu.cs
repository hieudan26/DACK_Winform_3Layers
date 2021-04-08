using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;
using System.IO;

namespace GUI_Management
{
    public partial class fdoanhThu : Form
    {
        vehicleBUS vehicleBUS = new vehicleBUS();
        fQuanLyXeGui fQuanLyXeGui = new fQuanLyXeGui();
        public fdoanhThu(fQuanLyXeGui fQuanLy)
        {
            InitializeComponent();
            this.fQuanLyXeGui = fQuanLy;
        }

        int counter = 0;
        int len = 0;
        string txt;

        //Dòng chữ chạy nhấp nháy
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                label1.Text = "";
            }

            else
            {

                label1.Text = txt.Substring(0, counter);

                if (label1.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54))))))
                    label1.ForeColor = Color.LightPink;
                else
                    label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            }
        }

        private void fdoanhThu_Load(object sender, EventArgs e)
        {
            txt = label1.Text;
            len = txt.Length;
            label1.Text = "";
            timer1.Start();

            //Load datagridview
            //this.dgvExpired.head
            if (vehicleBUS.getVehicleExpired() != null)
            {
                this.dgvExpired.ReadOnly = true;
                DataGridViewImageColumn picCol = new DataGridViewImageColumn();
                DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
                this.dgvExpired.RowTemplate.Height = 60;
                //this.dgvExpired.Columns["type"].Width = 100;
                this.dgvExpired.AutoResizeRows();
                this.dgvExpired.AutoResizeColumns();
                this.dgvExpired.DataSource = vehicleBUS.getVehicleExpired();
                picCol = (DataGridViewImageColumn)this.dgvExpired.Columns[2];
                picCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                picCol2 = (DataGridViewImageColumn)this.dgvExpired.Columns[3];
                picCol2.ImageLayout = DataGridViewImageCellLayout.Zoom;
                this.dgvExpired.AllowUserToAddRows = false;
            }

            //Load Số lượng 
            this.txtSLXeDap.Text = this.vehicleBUS.countVehicle_byType_InDay(0).ToString();
            this.txtSLXeMay.Text = this.vehicleBUS.countVehicle_byType_InDay(1).ToString();
            this.txtSLXeHoi.Text = this.vehicleBUS.countVehicle_byType_InDay(2).ToString();
            //end

            //Doanh thu xe đạp
            int thuXeDap = 0;
            foreach (var item in this.vehicleBUS.listID_InDay(0))
            {
                thuXeDap += this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(item));
            }
            this.txtDTXeDap.Text = thuXeDap.ToString();
            //end

            //Doanh thu xe máy
            int thuXeMay = 0;
            foreach (var item in this.vehicleBUS.listID_InDay(1))
            {
                thuXeMay += this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(item));
            }
            this.txtDTXeMay.Text = thuXeMay.ToString();
            //end

            //Doanh thu xe máy
            int thuXeHoi = 0;
            foreach (var item in this.vehicleBUS.listID_InDay(2))
            {
                thuXeHoi += this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(item));
            }
            this.txtDTXeHoi.Text = thuXeHoi.ToString();
            //end

            //phạt
            int phat = 0;
            DataTable table = this.vehicleBUS.getVehicleExpired();
            for (int i = 0; i < table.Rows.Count - 1; i++)
            {
                if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 0) //giờ
                {
                    phat += (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(0))) * 2;
                }    
                else if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 1) //ngày
                {
                    phat += (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(1))) * 2;
                }    
                else if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 2) //tuần
                {
                    phat += (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(3)));
                }    
                else
                {
                    phat += (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(3))) * 2;
                }    
            }
            //end

            this.txtTong.Text = (thuXeDap + thuXeMay + thuXeHoi + phat).ToString() + " VND"; 
        }

        private int xacDinhThu()
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
                thu = 8;

            return thu;
        }

        private string LoaiGui(int id)
        {
            string LoaiGui = "";
            int lg = this.vehicleBUS.getTypeGuiXe(id);
            if (lg == 0)
            {
                LoaiGui = "hourFee";
            }
            else if (lg == 1)
            {
                LoaiGui = "dateFee";
            }
            else if (lg == 2)
            {
                LoaiGui = "weekFee";
            }
            else
            {
                LoaiGui = "monthFee";
            }
            return LoaiGui;
        }

        private void dgvExpired_DoubleClick(object sender, EventArgs e)
        {
            finfoXe form = new finfoXe(this.fQuanLyXeGui);
            form.txtID.Text = this.dgvExpired.CurrentRow.Cells[0].Value.ToString();
            if ((int)this.dgvExpired.CurrentRow.Cells[1].Value == 0)
            {
                form.txtLoaiXe.Text = "Xe Đạp";
            }    
            else if ((int)this.dgvExpired.CurrentRow.Cells[1].Value == 1)
            {
                form.txtLoaiXe.Text = "Xe Máy";
            }    
            else
            {
                form.txtLoaiXe.Text = "Xe Hơi";
            }
            byte[] pic;
            pic = (byte[])this.dgvExpired.CurrentRow.Cells[2].Value;
            MemoryStream picture = new MemoryStream(pic);
            form.pBHinh1.Image = Image.FromStream(picture);

            byte[] pic2;
            pic2 = (byte[])this.dgvExpired.CurrentRow.Cells[3].Value;
            MemoryStream picture2 = new MemoryStream(pic2);
            form.pBHinh2.Image = Image.FromStream(picture2);

            this.fQuanLyXeGui.openChildForm(form);
        }
    }
}
