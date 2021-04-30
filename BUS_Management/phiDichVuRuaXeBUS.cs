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
    public class phiDichVuRuaXeBUS
    {
        phiDichVuRuaXeDAL phiDichVuRuaXeDAL = new phiDichVuRuaXeDAL();

        //get price by type
        public DataTable getPriceByType(int type)
        {
            return this.phiDichVuRuaXeDAL.getPriceByType(type);
        }

        //update
        public bool updatePrice(int type, int price)
        {
            return this.phiDichVuRuaXeDAL.updatePrice(type, price);
        }
    }
}
