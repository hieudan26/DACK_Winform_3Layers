using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class danhSachLuongDaThanhToanDTO
    {
        private string sid;
        private DateTime dtngayThanhToan;
        private float fLuong;

        public danhSachLuongDaThanhToanDTO(string sid, DateTime dtngayThanhToan, float fLuong)
        {
            this.sid = sid;
            this.dtngayThanhToan = dtngayThanhToan;
            this.fLuong = fLuong;
        }

        public string id { get => sid; set => sid = value; }
        public DateTime ngayThanhToan { get => dtngayThanhToan; set => dtngayThanhToan = value; }
        public float Luong { get => fLuong; set => fLuong = value; }

        public danhSachLuongDaThanhToanDTO() { }

        ~danhSachLuongDaThanhToanDTO() { }
    }
}
