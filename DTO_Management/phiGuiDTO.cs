using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    static public class phiGuiDTO
    {
        static public int PhiGio;
        
        static public int PhiNgay;
        
        static public int PhiTuan;
        
        static public int PhiThang;
        
        static public void Update(int gio,int ngay,int tuan,int thang)
        {
            phiGuiDTO.PhiGio = gio;
            phiGuiDTO.PhiNgay = ngay;
            phiGuiDTO.PhiTuan = tuan;
            phiGuiDTO.PhiThang = thang;
        }
    }
}
