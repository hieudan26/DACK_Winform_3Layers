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

namespace GUI_Management
{
    public partial class finfoXe : Form
    {
        vehicleDTO vehicleDTO = new vehicleDTO();
        fQuanLyXeGui formQuanLyXeGui;
        public finfoXe(fQuanLyXeGui formQuanLyXeGui)
        {
            InitializeComponent();
            //this.vehicleDTO = vel;
            //this.vehicleDTO.ID = id;
            this.formQuanLyXeGui = formQuanLyXeGui;
        }

        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void finfoXe_Load(object sender, EventArgs e)
        {

        }

        private void gunaGradientPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            fBaiXe f = new fBaiXe(formQuanLyXeGui);
            formQuanLyXeGui.openChildForm(f);
        }
    }
}
