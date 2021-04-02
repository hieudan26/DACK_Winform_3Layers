using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;
using DAO_Management;

namespace BUS_Management
{
    static public class phiGuiBUS
    {
        static public void UpdatePhi()
        {
            phiGuiDAL Phi = new phiGuiDAL();
            bool a = Phi.UpdatePrice(0);
            if (a == false)
                MessageBox.Show("Update that bai");
        }
    }
}
