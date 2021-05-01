using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class customerDTO
    {
        private string sid;
        private string sfname;
        private string slname;
        private string sgender;
        private string saddress;
        private int iphone;
        private int istatus;

        public string id { get => sid; set => sid = value; }
        public string fname { get => sfname; set => sfname = value; }
        public string lname { get => slname; set => slname = value; }
        public string gender { get => sgender; set => sgender = value; }
        public string address { get => saddress; set => saddress = value; }
        public int phone { get => iphone; set => iphone = value; }
        public int status { get => istatus; set => istatus = value; }

        public customerDTO() { }

        public customerDTO(string id, string fname, string lname, string gender, string address, int phone, int status)
        {
            this.sid = id;
            this.sfname = fname;
            this.slname = lname;
            this.sgender = gender;
            this.saddress = address;
            this.iphone = phone;
            this.istatus = status;
        }

        ~customerDTO() { }
    }
}
