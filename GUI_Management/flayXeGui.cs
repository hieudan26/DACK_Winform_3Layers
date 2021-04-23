using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using DTO_Management;

namespace GUI_Management
{
    public partial class flayXeGui : Form
    {
        doanhThuParkingBUS doanhThuBUS = new doanhThuParkingBUS();
        vehicleParkingBUS vehParkingBUS = new vehicleParkingBUS();
        vehicleBUS vehBUS = new vehicleBUS();
        fQuanLyXe formQuanLyXeGui;

        public flayXeGui(fQuanLyXe quanLyXe)
        {
            InitializeComponent();
            this.formQuanLyXeGui = quanLyXe;
        }

        private void btnExit_MouseHover(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnExit.ForeColor = Color.White;
        }

        private void btnExit_MouseLeave(object sender, EventArgs e)
        {
            this.btnExit.BackColor = Color.DarkGray;
            this.btnExit.ForeColor = Color.Black;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            this.formQuanLyXeGui.pnlMove.Visible = false;
        }

        private void designDataGridView(int i1, int i2)
        {
            this.dgvXe.ReadOnly = true;
            DataGridViewImageColumn picCol = new DataGridViewImageColumn();
            DataGridViewImageColumn picCol2 = new DataGridViewImageColumn();
            
            picCol = (DataGridViewImageColumn)this.dgvXe.Columns[i1];
            picCol.ImageLayout = DataGridViewImageCellLayout.Stretch;
            picCol2 = (DataGridViewImageColumn)this.dgvXe.Columns[i2];
            picCol2.ImageLayout = DataGridViewImageCellLayout.Stretch;
            this.dgvXe.AllowUserToAddRows = false;
        }

        private void cbTypeFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = this.cbTypeFilter.SelectedIndex;
            this.dgvXe.RowTemplate.Height = 80;
            if (this.cbTypeFilter.SelectedIndex == 3) // Lọc xe hết hạn
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehParkingBUS.getVehicleExpired();
                if (table != null)
                {
                    this.dgvXe.DataSource = table;
                    this.designDataGridView(2, 3);
                }    
                else
                {
                    this.dgvXe.DataSource = null;
                }
            }   
            else if (this.cbTypeFilter.SelectedIndex < 3 && this.cbTypeFilter.SelectedIndex >= 0)  // Lọc xe đạp, máy, hơi
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehParkingBUS.danhSachXetheoLoai(index);
                if (table != null)
                {
                    this.dgvXe.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvXe.DataSource = null;
                }
            }
            else if (this.cbTypeFilter.SelectedIndex == 4 )  // Lọc xe còn hạn
            {
                this.txtSearch.Text = "";
                DataTable table = this.vehParkingBUS.getVehicleNotExpired();
                if (table != null)
                {
                    this.dgvXe.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvXe.DataSource = null;
                }
            }
            else
            {
                DataTable table = this.vehParkingBUS.getAllVehicle();
                if (table != null)
                {
                    this.dgvXe.DataSource = table;
                    this.designDataGridView(2, 3);
                }
                else
                {
                    this.dgvXe.DataSource = null;
                }
            }
        }

        private bool checkHetHan(string id)
        {
            DataTable table = this.vehParkingBUS.getVehicleExpired();
            if (table == null)
                return false;
            else
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    if (table.Rows[i]["id"].ToString() == id)
                    {
                        return true;
                    }
                }
                return false;
            }
        }

        private int totalfee(string id)
        {
            int totalFee;
            int thu = this.xacDinhThu();
            string loaiGui = this.LoaiGui((int)this.dgvXe.CurrentRow.Cells["typePark"].Value);
            if (!checkHetHan(id))
            {
                totalFee = this.vehParkingBUS.layTienTheoThu(thu, loaiGui);
            }    
            else
            {
                if ((int)this.dgvXe.CurrentRow.Cells["typePark"].Value == 0)
                {
                    totalFee = this.vehParkingBUS.layTienTheoThu(thu, "dateFee");
                }    
                else if ((int)this.dgvXe.CurrentRow.Cells["typePark"].Value == 1)
                {
                    totalFee = this.vehParkingBUS.layTienTheoThu(thu, "weekFee");
                }    
                else if ((int)this.dgvXe.CurrentRow.Cells["typePark"].Value == 2)
                {
                    totalFee = this.vehParkingBUS.layTienTheoThu(thu, "monthFee");
                }    
                else
                {
                    totalFee = this.vehParkingBUS.layTienTheoThu(thu, "monthFee")*2;
                }    
            }
            return totalFee;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            try
            {
                string IDxe = this.dgvXe.CurrentRow.Cells[0].Value.ToString();
                if (MessageBox.Show("Do you want to take out : " + IDxe, "Take Out vehicle", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    if (checkHetHan(IDxe))
                    {
                        MessageBox.Show("Xe đã quá hạn chi phí thanh toán: " + this.totalfee(IDxe), "Lấy Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Thanh toán: " + this.totalfee(IDxe), "Lấy Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    doanhThuParkingDTO doanhthuDTO = new doanhThuParkingDTO(IDxe, DateTime.Now, this.totalfee(IDxe));
                    this.doanhThuBUS.insert_doanhThuParking(doanhthuDTO);

                    if (this.vehParkingBUS.DelVehicle(IDxe) && this.vehBUS.DelVehicle(IDxe))
                    {
                        MessageBox.Show("Vehicle is taken out", "Lấy Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }    
                    else
                        MessageBox.Show("Vehicle is taken out Error", "Lấy Xe", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.cbTypeFilter.SelectedIndex = 5;
                    DataTable table = this.vehParkingBUS.getAllVehicle();
                    if (table != null)
                    {
                        this.dgvXe.DataSource = table;
                        this.designDataGridView(5, 6);
                    }
                    else
                    {
                        this.dgvXe.DataSource = null;
                    }
                }
                else
                {
                    //Nothing
                }    
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message,"Lấy Xe");
            }
        }

        private int xacDinhThu()
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
                thu = 8;

            return thu;
        }

        private string LoaiGui(int type)
        {
            string LoaiGui = "";

            if (type == 0)
            {
                LoaiGui = "hourFee";
            }
            else if (type == 1)
            {
                LoaiGui = "dateFee";
            }
            else if (type == 2)
            {
                LoaiGui = "weekFee";
            }
            else
            {
                LoaiGui = "monthFee";
            }
            return LoaiGui;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                this.cbTypeFilter.SelectedIndex = -1;
                string id = this.txtSearch.Text;
                if (this.vehParkingBUS.getVehicleByID(id) != null)
                {
                    this.dgvXe.RowTemplate.Height = 80;
                    this.dgvXe.DataSource = this.vehParkingBUS.getVehicleByID_GanDung(id);
                    this.designDataGridView(5, 6);
                }
            }
            catch { }
        }

        private void flayXe_Load(object sender, EventArgs e)
        {
        }

        private MemoryStream picture(DataTable table, string img)
        {
            Byte[] pic = new Byte[0];
            pic = (Byte[])(table.Rows[0][img]);
            MemoryStream ms = new MemoryStream(pic);
            return ms;
        }

        private void dgvXe_DoubleClick(object sender, EventArgs e)
        {
            finfoXeGui form = new finfoXeGui(formQuanLyXeGui, "LayXeGui");
            string id = this.dgvXe.CurrentRow.Cells[0].Value.ToString();
            DataTable table = this.vehParkingBUS.getVehicleByID(id);
            form.pBHinh1.Image = Image.FromStream(this.picture(table, "img1"));
            form.pBHinh1.SizeMode = PictureBoxSizeMode.StretchImage;

            form.pBHinh2.Image = Image.FromStream(this.picture(table, "img2"));
            form.pBHinh2.SizeMode = PictureBoxSizeMode.StretchImage;

            form.txtID.Text = id.ToString();

            if (int.Parse(table.Rows[0]["type"].ToString()) == 0)
            { 
                form.txtLoaiXe.Text = "Xe Đạp";
                form.lbHinh1.Text = "Hình Xe";
                form.lbHinh2.Text = "Người Gửi";
            }    
            else if (int.Parse(table.Rows[0]["type"].ToString()) == 1)
            {
                form.txtLoaiXe.Text = "Xe Máy";
                form.lbHinh1.Text = "Bảng Số";
                form.lbHinh2.Text = "Người Gửi";
            }    
            else
            { 
                form.txtLoaiXe.Text = "Xe Hơi";
                form.lbHinh1.Text = "Bảng Số";
                form.lbHinh2.Text = "Hiệu Xe";
            }    


            //Xác định thứ trong tuần
            int thu = this.xacDinhThu();

            String loaiGui = this.LoaiGui(int.Parse(table.Rows[0]["typePark"].ToString()));

            form.txtLoaiGui.Text = loaiGui;

            int phi_theo_thu = 0;
            if (loaiGui != "")
            {
                phi_theo_thu = this.vehParkingBUS.layTienTheoThu(thu, loaiGui);
            }

            form.txtDTGui.Text = table.Rows[0]["timeIn"].ToString();

            form.txtTongTien.Text = phi_theo_thu.ToString();

            this.formQuanLyXeGui.openChildForm(form);
        }
    }
}
