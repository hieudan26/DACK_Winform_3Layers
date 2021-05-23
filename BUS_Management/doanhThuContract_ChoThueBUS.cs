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
    public class doanhThuContract_ChoThueBUS
    {
        doanhThuContract_ChoThueDAL doanhThuContract_ChoThueDAL = new doanhThuContract_ChoThueDAL();

        //get số hợp đồng thuê xe và tổng thu
        public DataTable CountContract_SumTotal(string idEmployee)
        {
            return this.doanhThuContract_ChoThueDAL.CountContract_SumTotal(idEmployee);
        }

        //Remove
        public bool RemovedoanhThuContract_ChoThue(string idContract)
        {
            return this.doanhThuContract_ChoThueDAL.RemovedoanhThuContract_ChoThue(idContract);
        }

        //insert
        public bool insertdoanhThuContract_ChoThue(doanhThuContract_ChoThueDTO doanhThuContract_ChoThueDTO)
        {
            return this.doanhThuContract_ChoThueDAL.insertdoanhThuContract_ChoThue(doanhThuContract_ChoThueDTO);
        }
    }
}
