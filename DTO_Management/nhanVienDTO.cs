using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class nhanVienDTO
    {
        private string iid;
        private string sname;
        private DateTime dtbirthdate;
        private string sgender;
        private string stypeTho;
        private MemoryStream msImg;

        public string id { get => iid; set => iid = value; }
        public string name { get => sname; set => sname = value; }
        public DateTime birthdate { get => dtbirthdate; set => dtbirthdate = value; }
        public string gender { get => sgender; set => sgender = value; }
        public MemoryStream Img { get => msImg; set => msImg = value; }
        public string typeTho { get => stypeTho; set => stypeTho = value; }

        public nhanVienDTO()
        {

        }

        public nhanVienDTO(string id, string name, DateTime birthDate, string gender, MemoryStream Img, string typeTho)
        {
            this.iid = id;
            this.sname = name;
            this.dtbirthdate = birthDate;
            this.sgender = gender;
            this.msImg = Img;
            this.stypeTho = typeTho;
        }

        ~nhanVienDTO() { }
    }
}
