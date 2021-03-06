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

        //update status veh
        public bool UpdateStatusVehicle(string id, string type_status, int status)
        {
            return this.Vehicle.UpdateStatusVehicle(id, type_status, status);
        }

        //Check Id đã tồn tại chưa?
        public bool CheckID_Exited(string id)
        {
            return this.Vehicle.CheckID_Exited(id);
        }

        public DataTable getVehicleByID(string id)
        {
            return this.Vehicle.getVehicleByID(id);
        }
        
        public bool insertVehicle(vehicleDTO vel)
        {
            return this.Vehicle.insertVehicle(vel);
        }

        public int countVehicleType(int type)
        {
            return this.Vehicle.countVehicleType(type);
        }

        public int countVehicleTotal()
        {
            return this.Vehicle.countVehicleTotal();
        }

        public List<int> danhSachID(int type)
        {
            return this.Vehicle.danhSachID(type);
        }
        //delete vehicle
        public bool DelVehicle(string id)
        {
            return this.Vehicle.DeleteVehicle(id);
        }
        // check full
        public bool checkFullVehicle(int type)
        {
            return this.Vehicle.checkFullVehicle(type);
        }
        /*
        //Lay ra phi gui xe theo thu
        public int layTienTheoThu(int thu, string loaiGui)
        {
            return this.Vehicle.layTienTheoThu(thu, loaiGui);
        }

        //Lay ra loai gui xe
        public int getTypeGuiXe(int id)
        {
            return this.Vehicle.getLoaiGuiXe(id);
        }

        //Lấy ra danh sách xe gửi quá hạn
        public DataTable getVehicleExpired()
        {
            return this.Vehicle.getVehicleExpired();
        }

        //Đếm số lượng xe theo loại vào bãi trong ngày
        public int countVehicle_byType_InDay(int type)
        {
            return this.Vehicle.countVehicle_byType_InDay(type);
        }

        //list id xe gửi trong ngày
        public List<int> listID_InDay(int type)
        {
            return this.Vehicle.danhSachID_InDay(type);
        }

        //update info vehicle
        public bool UpdateInfoVehicle(int id, int loaiXe, int loaiGui, MemoryStream img1, MemoryStream img2, DateTime timeIn)
        {
            return this.Vehicle.UpdateInfoVehicle(id, loaiXe, loaiGui, img1, img2, timeIn);
        }
         */

    }
}
