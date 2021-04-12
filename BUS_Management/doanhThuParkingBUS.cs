using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Management;
using DAL_Management;

namespace BUS_Management
{
    public class doanhThuParkingBUS
    {
        //doanhThuParkingDTO doanhThuDTO = new doanhThuParkingDTO();
        doanhThuParkingDAL doanhthuDAL = new doanhThuParkingDAL();

        //lưu ngày lấy xe ra
        public bool insert_doanhThuParking(doanhThuParkingDTO doanhThuDTO)
        {
            return doanhthuDAL.insert_doanhThuParking(doanhThuDTO);
        }
    }
}
