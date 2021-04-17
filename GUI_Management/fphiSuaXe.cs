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
    public partial class fphiSuaXe : Form
    {
        vehicleFixDTO vehFixDTO = new vehicleFixDTO();
        vehicleFixBUS vehFixBUS = new vehicleFixBUS();
        vehicleDTO vehDTO = new vehicleDTO();
        phiDichVuSuaXeBUS phiSuaBUS = new phiDichVuSuaXeBUS();
        public List<string> list_Service = new List<string>();
        fQuanLyXe formQuanLyXeGui;

        public fphiSuaXe(string id, fQuanLyXe fQuanLy, int type)
        {
            InitializeComponent();
            this.vehFixDTO.id = id;
            this.formQuanLyXeGui = fQuanLy;
            this.vehDTO.type = type;
            //this.ve
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fVehicle f = new fVehicle(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }

        private void btnFix_Click(object sender, EventArgs e)
        {
            int choice = this.cbDichVu.SelectedIndex;
            this.vehFixDTO.service = this.list_Service[choice];
            if (this.vehFixBUS.insertVehicle_FIX(this.vehFixDTO))
            {
                MessageBox.Show("Đã thêm thành công vào danh sách sửa", "Sửa Xe", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Đã thêm không thành công vào danh sách sửa", "Sửa Xe", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void SaveList(DataTable table)
        {
            if (this.list_Service.Count != 0)
                this.list_Service.Clear();

            foreach(DataRow item in table.Rows)
            {
                this.list_Service.Add(item["service"].ToString());
            }    
        }

        private void loadComboBox()
        {
            if (this.phiSuaBUS.getDichVu_ByType(this.vehDTO.type) != null)
            {
                this.cbDichVu.DataSource = this.phiSuaBUS.getDichVu_ByType(this.vehDTO.type);
                this.cbDichVu.DisplayMember = "service";
                this.cbDichVu.ValueMember = "service_fee";
                this.SaveList(this.phiSuaBUS.getDichVu_ByType(this.vehDTO.type));
            }    
            else
            {
                MessageBox.Show("Can't Load DataSource");
            }    
        }

        private void AddBinding()
        {
            this.txtGiaTien.DataBindings.Add(new Binding("Text", this.cbDichVu.DataSource, "service_fee"));
        }

        private void fphiSuaXe_Load(object sender, EventArgs e)
        {
            this.loadComboBox();
            this.AddBinding();
        }

        private void cbDichVu_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
