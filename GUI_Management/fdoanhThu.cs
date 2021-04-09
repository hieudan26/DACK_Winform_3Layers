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
                lbContent.Text = "";
            }

            else
            {

                lbContent.Text = txt.Substring(0, counter);

                if (lbContent.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54))))))
                    lbContent.ForeColor = Color.LightPink;
                else
                    lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            }
        }

        private bool LoadDataGridView()
        {
            if (this.vehicleBUS.getVehicleExpired() != null)
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
                return true;
            }
            else
            {
                //MessageBox.Show("Empty");
                return false;
            }  
        }

        private void LoadSoLuongVehicle()
        {
            if ((int)this.vehicleBUS.countVehicle_byType_InDay(0) == -1 || (int)this.vehicleBUS.countVehicle_byType_InDay(1) == -1
                || (int)this.vehicleBUS.countVehicle_byType_InDay(2) == -1) //ko load đc
            {
                this.txtSLXeDap.Text = "";
                this.txtSLXeMay.Text = "";
                this.txtSLXeHoi.Text = "";
            }
            else
            {
                this.txtSLXeDap.Text = this.vehicleBUS.countVehicle_byType_InDay(0).ToString();
                this.txtSLXeMay.Text = this.vehicleBUS.countVehicle_byType_InDay(1).ToString();
                this.txtSLXeHoi.Text = this.vehicleBUS.countVehicle_byType_InDay(2).ToString();
            }
        }

        public int doanhThuTheoLoai(int type)
        {
            int thu = 0;
            if (this.vehicleBUS.listID_InDay(type).Count != 0)
            {
                foreach (var item in this.vehicleBUS.listID_InDay(type))
                {
                    thu += this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(item));
                }
            }  
            return thu;
        }

        private int tienPhat()
        {
            int phat = 0;
            if (this.LoadDataGridView())
            {
                DataTable table = this.vehicleBUS.getVehicleExpired();
                for (int i = 0; i < table.Rows.Count; i++)
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
            }    
            return phat;
        }

        private void fdoanhThu_Load(object sender, EventArgs e)
        {
            txt = lbContent.Text;
            len = txt.Length;
            lbContent.Text = "";
            timer1.Start();

            //Load datagridview
            //this.dgvExpired.head
            this.LoadDataGridView();

            //Load Số lượng 
            this.LoadSoLuongVehicle();
            //end

            //Doanh thu xe đạp
            this.txtDTXeDap.Text = this.doanhThuTheoLoai(0).ToString();
            //end

            //Doanh thu xe máy
            this.txtDTXeMay.Text = this.doanhThuTheoLoai(1).ToString();
            //end

            //Doanh thu xe máy
            this.txtDTXeHoi.Text = this.doanhThuTheoLoai(2).ToString();
            //end

            //phạt
            int phat = this.tienPhat();
            //end

            this.txtTong.Text = (this.doanhThuTheoLoai(0) + this.doanhThuTheoLoai(1) + this.doanhThuTheoLoai(2) + phat).ToString() + " VND"; 
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

        private MemoryStream picture(int i)
        {
            byte[] pic;
            pic = (byte[])this.dgvExpired.CurrentRow.Cells[i].Value;
            MemoryStream picture = new MemoryStream(pic);
            return picture;
        }

        private void dgvExpired_DoubleClick(object sender, EventArgs e)
        {
            finfoXe form = new finfoXe(this.fQuanLyXeGui, "DoanhThu");

            int id = Convert.ToInt32(this.dgvExpired.CurrentRow.Cells[0].Value);

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
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;
            form.pBHinh1.Image = Image.FromStream(this.picture(2));

            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;
            form.pBHinh2.Image = Image.FromStream(this.picture(3));

            form.txtLoaiGui.Text = this.LoaiGui(id);

            form.txtDTGui.Text = this.dgvExpired.CurrentRow.Cells[5].Value.ToString();

            form.txtTongTien.Text = this.loadDoanhThuPhat(id).ToString();

            this.fQuanLyXeGui.openChildForm(form);
        }

        private int loadDoanhThuPhat(int id)
        {
            int doanhThuPhat = 0;
            if (this.LoadDataGridView())
            {
                DataTable table = this.vehicleBUS.getVehicleExpired();
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (id == (int)table.Rows[i]["id"])
                    {
                        if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 0) //giờ
                        {
                            doanhThuPhat = (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(0))) * 2;
                        }
                        else if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 1) //ngày
                        {
                            doanhThuPhat = (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(1))) * 2;
                        }
                        else if (this.vehicleBUS.getTypeGuiXe((int)table.Rows[i]["id"]) == 2) //tuần
                        {
                            doanhThuPhat = (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(3)));
                        }
                        else
                        {
                            doanhThuPhat = (this.vehicleBUS.layTienTheoThu(this.xacDinhThu(), this.LoaiGui(3))) * 2;
                        }
                    }    
                }
            }
            return doanhThuPhat;
        }
    }
}
