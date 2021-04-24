using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;

namespace GUI_Management
{
    public partial class finfoXeGui : Form
    {
        vehicleParkingDTO vehicleDTO = new vehicleParkingDTO();
        vehicleParkingBUS vehicleParkingBUS = new vehicleParkingBUS();
        vehicleBUS vehicleBUS = new vehicleBUS();
        fQuanLyXe formQuanLyXeGui;
        string type;
        public finfoXeGui(fQuanLyXe formQuanLyXeGui, string type)
        {
            InitializeComponent();
            //this.vehicleDTO = vel;
            //this.vehicleDTO.ID = id;
            this.formQuanLyXeGui = formQuanLyXeGui;
            this.type = type;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            switch (type)
            {
                case "BaiXe": { this.BacktoBaiXe(); break; }
                case "LayXeGui": { this.BacktoLayXeGui(); break; }
                case "Other": { this.BacktoOther(); break; }
            }
        }

        public void BacktoOther()
        {
            fotherServices_Park f = new fotherServices_Park(this.formQuanLyXeGui);
            this.formQuanLyXeGui.openChildForm(f);
        }

        public void BacktoBaiXe()
        {
            fbaiXe f = new fbaiXe(this.formQuanLyXeGui);
            this.formQuanLyXeGui.openChildForm(f);
        }

        public void BacktoLayXeGui()
        {
            flayXeGui f = new flayXeGui(this.formQuanLyXeGui);
            this.formQuanLyXeGui.openChildForm(f);
        }

        private bool verify()
        {
            if (this.txtID.Text == "" || this.txtLoaiGui.Text == "" || this.txtLoaiXe.Text == ""
                || this.txtDTGui.Text == "" || this.pBHinh1.Image == null || this.pBHinh2.Image == null)
            {
                return false;
            }    
            else
            {
                return true;
            }    
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = this.txtID.Text;
            int loaiGui;
            if (this.txtLoaiGui.Text == "hourFee")
            {
                loaiGui = 0;
            }    
            else if (this.txtLoaiGui.Text == "dateFee")
            {
                loaiGui = 1;
            }    
            else if (this.txtLoaiGui.Text == "weekFee")
            { 
                loaiGui = 2;
            }
            else
            {
                loaiGui = 3;
            } 
                

            DateTime timeIn = Convert.ToDateTime(this.txtDTGui.Text);

            if (this.verify())
            {
                try
                {
                    if (this.vehicleParkingBUS.UpdateInfoVehicle(id, loaiGui, timeIn))
                    {
                        MessageBox.Show("Vehicle Information Updated", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    } 
                    else
                    {
                        MessageBox.Show("Error", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            else
            {
                MessageBox.Show("Empty Fields", "Edit Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private bool checkOtherService(string idxe)
        {
            DataTable table = this.vehicleBUS.getVehicleByID(idxe);
            int park = int.Parse(table.Rows[0]["park"].ToString());
            int fix = int.Parse(table.Rows[0]["fix"].ToString());
            int wash = int.Parse(table.Rows[0]["wash"].ToString());
            if (park != 0 || fix != 0 || wash != 0)
            {
                return true;          //đang sài dịch vụ khác không xóa c=khỏi vehicle
            }
            else
            {
                return false;        //không còn dịch vụ nào xóa đc
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                string id = this.txtID.Text;
                if (MessageBox.Show("Are You Sure ?!?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (this.vehicleParkingBUS.DelVehicle(id) && this.vehicleBUS.UpdateStatusVehicle(id, "PARK", 0))
                    {
                        MessageBox.Show("Vehicle Deleted", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        if (!this.checkOtherService(id))
                        {
                            if (this.vehicleBUS.DelVehicle(id))
                            {
                                MessageBox.Show("Xóa Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show("Xóa Không Thành Công Trong Bảng VEHICLE", "Info Wash", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                            }
                        }
                        this.txtID.Text = "";
                        this.txtLoaiGui.Text = "";
                        this.txtLoaiXe.Text = "";
                        this.txtTongTien.Text = "";
                        this.txtDTGui.Text = DateTime.Now.ToString();
                        this.pBHinh2.Image = null;
                        this.pBHinh1.Image = null;
                    }
                    else
                        MessageBox.Show("Vehicle Not Deleted", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch
            {
                MessageBox.Show("Please Enter A Valid ID", "Delete Vehicle", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
