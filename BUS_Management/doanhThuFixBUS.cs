using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class doanhThuFixBUS
    {
        doanhThuFixDAL doanhthuDAL = new doanhThuFixDAL();

        //tính tổng
        public int sumDoanhThu_InDay()
        {
            return this.doanhthuDAL.sumDoanhThu_InDay();
        }

        //lưu ngày lấy xe ra
        public bool insert_doanhThuFix(doanhThuFixDTO doanhThuDTO)
        {
            return this.doanhthuDAL.insert_doanhThuFix(doanhThuDTO);
        }

        public DataTable getDoanhThuFix_InDay()
        {
            return this.doanhthuDAL.getDoanhThuFix_InDay();
        }
    }
}
