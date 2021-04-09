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

        //delete vehicle
        public bool DelVehicle(int id)
        {
            return this.Vehicle.DeleteVehicle(id);
        }
    }
}
