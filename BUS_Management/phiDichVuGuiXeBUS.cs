using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;

namespace BUS_Management
{
    static public class phiDichVuGuiXeBUS
    { 
        static public void UpdatePhi(int IThu)
        {
            IThu += 1;
            if (IThu == 1)
                IThu = 8;

            phiGuiDAL Phi = new phiGuiDAL();
            
            bool a = Phi.UpdatePrice(IThu);
            
            if (a == false)
                MessageBox.Show("Update that bai");
        }
    }
}
