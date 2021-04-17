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
    public class phiDichVuSuaXeBUS
    {
        phiDichVuSuaXeDAL phiDAL = new phiDichVuSuaXeDAL();

        public string getFee_byService(string service)
        {
            return this.phiDAL.getFee_byService(service);
        }

        //trả về datatable để load datasource của cbbox
        public DataTable getDichVu_ByType(int type)
        {
            return this.phiDAL.getDichVu_ByType(type);
        }
    }
}
