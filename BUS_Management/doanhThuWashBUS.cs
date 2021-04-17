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
    public class doanhThuWashBUS
    {
        doanhThuWashDAL dtWashDAl = new doanhThuWashDAL();

        //get datatable
        public DataTable getDoanhThuWash_InDay()
        {
            return this.dtWashDAl.getDoanhThuWash_InDay();
        }

        //sum in day
        public int sumDoanhThu_InDay()
        {
            return this.dtWashDAl.sumDoanhThu_InDay();
        }

        //insert
        public bool insert_doanhThuWash(doanhThuWashDTO washDTO)
        {
            return this.dtWashDAl.insert_doanhThuWash(washDTO);
        }
    }
}
