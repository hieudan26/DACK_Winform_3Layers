using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DAO_Management;
using DTO_Management;

namespace BUS_Management
{
    public class vehicleParkingBUS
    {
        vehicleParkingDAL Vehicle = new vehicleParkingDAL();

        //get status
        public DataTable getStatus(string id)
        {
            return this.Vehicle.getStatus(id);
        }

        public DataTable getVehicleByID(string id)
        {
            return this.Vehicle.getVehicleByID(id);
        }

        public DataTable getVehicleByID_GanDung(string id)
        {
            return this.Vehicle.getVehicleByID_GanDung(id);
        }

        public bool insertVehicle(vehicleParkingDTO vel)
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

        public List<string> danhSachID(int type)
        {
            return this.Vehicle.danhSachID(type);
        }

        //Lay ra phi gui xe theo thu
        public int layTienTheoThu(int thu, string loaiGui)
        {
            return this.Vehicle.layTienTheoThu(thu, loaiGui);
        }

        //Lay ra loai gui xe
        public int getTypeGuiXe(string id)
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
        public List<string> listID_InDay(int type)
        {
            return this.Vehicle.danhSachID_InDay(type);
        }

        //update info vehicle
        public bool UpdateInfoVehicle(string id, int loaiGui, DateTime timeIn)
        {
            return this.Vehicle.UpdateInfoVehicle(id, loaiGui, timeIn);
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
       
        //get all vehicle
        public DataTable getAllVehicle()
        {
            return this.Vehicle.getAllVehicle();
        }
        public DataTable danhSachXetheoLoai(int type)
        {
            return this.Vehicle.danhSachXetheoLoai(type);
        }
        public DataTable getVehicleNotExpired()
        {
            return this.Vehicle.getVehicleNotExpired();
        }
    }
}
