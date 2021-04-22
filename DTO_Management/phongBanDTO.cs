using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class phongBanDTO
    {
        private string sid;
        private string sname;
        private string sleaderId;

        public string id { get => sid; set => sid = value; }
        public string name { get => sname; set => sname = value; }
        public string leaderId { get => sleaderId; set => sleaderId = value; }

        public phongBanDTO() { }

        public phongBanDTO(string id, string name, string leaderId)
        {
            this.sid = id;
            this.sname = name;
            this.sleaderId = leaderId;
        }

        ~phongBanDTO() { }
    }
}
