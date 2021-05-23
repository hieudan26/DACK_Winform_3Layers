using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Management;
using DAL_Management;
using System.Data;

namespace BUS_Management
{
    public class danhSachLuongDaThanhToanBUS
    {
        danhSachLuongDaThanhToanDAL danhSachLuongDaThanhToanDAL = new danhSachLuongDaThanhToanDAL();

        //sum luong by type
        public DataTable sum(string typeTho)
        {
            return this.danhSachLuongDaThanhToanDAL.sum(typeTho);
        }

        //get full info nhan viên
        public DataTable getFullInfo()
        {
            return this.danhSachLuongDaThanhToanDAL.getFullInfo();
        }

        //insert
        public bool insert(danhSachLuongDaThanhToanDTO danhSachLuongDaThanhToanDTO)
        {
            return this.danhSachLuongDaThanhToanDAL.insert(danhSachLuongDaThanhToanDTO);
        }
    }
}
