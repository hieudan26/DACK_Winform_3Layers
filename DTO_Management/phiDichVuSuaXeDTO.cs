using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    static public class phiDichVuSuaXeDTO
    {
        static public int type;
        static public string service;
        static public int service_fee;

        static public void Update(int type, string service, int ser_fee)
        {
            phiDichVuSuaXeDTO.type = type;
            phiDichVuSuaXeDTO.service = service;
            phiDichVuSuaXeDTO.service_fee = ser_fee;
        }
    }
}
