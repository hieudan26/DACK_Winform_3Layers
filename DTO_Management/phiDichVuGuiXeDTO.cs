using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    static public class phiDichVuGuiXeDTO
    {
        static public int PhiGio;
        
        static public int PhiNgay;
        
        static public int PhiTuan;
        
        static public int PhiThang;
        
        static public void Update(int gio,int ngay,int tuan,int thang)
        {
            phiDichVuGuiXeDTO.PhiGio = gio;
            phiDichVuGuiXeDTO.PhiNgay = ngay;
            phiDichVuGuiXeDTO.PhiTuan = tuan;
            phiDichVuGuiXeDTO.PhiThang = thang;
        }
    }
}
