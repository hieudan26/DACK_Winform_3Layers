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
    public class doanhThuParkingBUS
    {
        //doanhThuParkingDTO doanhThuDTO = new doanhThuParkingDTO();
        doanhThuParkingDAL doanhthuDAL = new doanhThuParkingDAL();

        //tính tổng
        public int sumDoanhThu_InDay()
        {
            return this.doanhthuDAL.sumDoanhThu_InDay();
        }

        //lưu ngày lấy xe ra
        public bool insert_doanhThuParking(doanhThuParkingDTO doanhThuDTO)
        {
            return this.doanhthuDAL.insert_doanhThuParking(doanhThuDTO);
        }

        public DataTable getdoanhThuParking_InDay()
        {
            return this.doanhthuDAL.getDoanhThuParking_InDay();
        }
    }
}
