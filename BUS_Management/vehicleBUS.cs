using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class vehicleBUS
    {
        vehicleDAL Vehicle = new vehicleDAL();

        public DataTable getVehicleByID(int id)
        {
            return Vehicle.getVehicleByID(id);
        }
        
        public bool insertVehicle(vehicleDTO vel)
        {
            return Vehicle.insertVehicle(vel);
        }

        public int countVehicleType(int type)
        {
            return Vehicle.countVehicleType(type);
        }

        public int countVehicleTotal()
        {
            return Vehicle.countVehicleTotal();
        }

        public List<int> danhSachID(int type)
        {
            return Vehicle.danhSachID(type);
        }

        public MemoryStream getImg1(int id, string imgx)
        {
            return Vehicle.getImage1(id, imgx);
        }

        //Lay ra phi gui xe theo thu
        public int layTienTheoThu(int thu, string loaiGui)
        {
            return Vehicle.layTienTheoThu(thu, loaiGui);
        }

        //Lay ra loai gui xe
        public int getTypeGuiXe(int id)
        {
            return Vehicle.getLoaiGuiXe(id);
        }
    }
}
