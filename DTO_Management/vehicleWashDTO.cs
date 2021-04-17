using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class vehicleWashDTO
    {
        private string sid;
        private int itype;

        public string id { get => sid; set => sid = value; }
        public int type { get => itype; set => itype = value; }

        public vehicleWashDTO()
        {

        }

        public vehicleWashDTO(string id, int type)
        {
            this.sid = id;
            this.itype = type;
        }

        ~vehicleWashDTO() { }
    }
}
