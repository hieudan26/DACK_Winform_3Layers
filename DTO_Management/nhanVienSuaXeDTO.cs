using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class nhanVienSuaXeDTO
    {
        private string sid;
        private string susername;
        private string spassword;
        private int istatus;

        public string id { get => sid; set => sid = value; }
        public string username { get => susername; set => susername = value; }
        public string password { get => spassword; set => spassword = value; }
        public int status { get => istatus; set => istatus = value; }

        public nhanVienSuaXeDTO(string id, string username, string password, int status)
        {
            this.sid = id;
            this.susername = username;
            this.spassword = password;
            this.istatus = status;
        }

        public nhanVienSuaXeDTO()
        {

        }

        ~nhanVienSuaXeDTO() { }
    }
}
