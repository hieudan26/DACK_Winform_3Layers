using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;

namespace BUS_Management
{
   public class phiDichVuGuiXeBUS
   {
        phiGuiDAL PhiGuiDAL = new phiGuiDAL();

        public bool editPrice(int thu, int gio, int ngay, int tuan, int thang)
        {
            return this.PhiGuiDAL.editPrice(thu, gio, ngay, tuan, thang);
        }

        public DataTable getAllPrice()
        {
            return this.PhiGuiDAL.getAllPrice();
        }
       
        public void UpdatePhi(int IThu)
        {
            IThu += 1;
            if (IThu == 1)
                IThu = 8;
            
            bool a = this.PhiGuiDAL.UpdatePrice(IThu);
            
            if (a == false)
                MessageBox.Show("Update that bai");
        }
    }
}
