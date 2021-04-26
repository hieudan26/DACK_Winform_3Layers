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

        //Remove
        public bool DeleteService(string service)
        {
            return this.phiDAL.DeleteService(service);
        }

        //Edit
        public bool UpdateService_fee(string service, int service_fee)
        {
            return this.phiDAL.UpdateService_fee(service, service_fee);
        }

        public bool insertService(int type, string service, int fee)
        {
            return this.phiDAL.insertService(type, service, fee);
        }

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
