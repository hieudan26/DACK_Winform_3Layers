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
    public class doanhThuContract_ThueBUS
    {
        doanhThuContract_ThuDAL doanhThuContract_ThuDAL = new doanhThuContract_ThuDAL();

        //get số hợp đồng thuê xe và tổng thu
        public DataTable CountContract_SumTotal(string idEmployee)
        {
            return this.doanhThuContract_ThuDAL.CountContract_SumTotal(idEmployee);
        }

        //Remove
        public bool RemovedoanhThuContract_Thu(string idContract)
        {
            return this.doanhThuContract_ThuDAL.RemovedoanhThuContract_Thu(idContract);
        }

        //insert
        public bool insertdoanhThuContract_Thue(doanhThuContract_ThueDTO doanhThuContract_ThueDTO)
        {
            return this.doanhThuContract_ThuDAL.insertdoanhThuContract_Thue(doanhThuContract_ThueDTO);
        }
    }
}
