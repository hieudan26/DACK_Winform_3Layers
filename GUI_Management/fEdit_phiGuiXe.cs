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
    public partial class fEdit_phiSuaXe : Form
    {
        phiDichVuGuiXeBUS phiDichVuGuiXeBUS = new phiDichVuGuiXeBUS();
        public fEdit_phiSuaXe()
        {
            InitializeComponent();
        }

        private void LoadDataGridView()
        {
            this.dgvPhiGui.RowTemplate.Height = 37;
            this.dgvPhiGui.ReadOnly = true;
            this.dgvPhiGui.DataSource = this.phiDichVuGuiXeBUS.getAllPrice();
            this.dgvPhiGui.AllowUserToAddRows = false;
        }

        private void fEdit_phiSuaXe_Load(object sender, EventArgs e)
        {
            this.LoadDataGridView();
        }

        private void dgvPhiGui_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.txtThu.Text = this.dgvPhiGui.CurrentRow.Cells[0].Value.ToString();
            this.txtGio.Text = this.dgvPhiGui.CurrentRow.Cells[1].Value.ToString();
            this.txtNgay.Text = this.dgvPhiGui.CurrentRow.Cells[2].Value.ToString();
            this.txtTuan.Text = this.dgvPhiGui.CurrentRow.Cells[3].Value.ToString();
            this.txtThang.Text = this.dgvPhiGui.CurrentRow.Cells[4].Value.ToString();
        }

        private void btnEDIT_Click(object sender, EventArgs e)
        {
            try
            {
                int thu = int.Parse(this.txtThu.Text);
                int gio = int.Parse(this.txtGio.Text);
                int ngay = int.Parse(this.txtNgay.Text);
                int tuan = int.Parse(this.txtTuan.Text);
                int thang = int.Parse(this.txtThang.Text);
                if (this.phiDichVuGuiXeBUS.editPrice(thu, gio, ngay, tuan, thang))
                {
                    MessageBox.Show("Update phí gửi thành công", "Edit phí gửi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.LoadDataGridView();
                }    
                else
                {
                    MessageBox.Show("Update phí gửi không thành công", "Edit phí gửi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }    
            }   
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
