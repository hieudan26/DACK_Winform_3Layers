using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class vehicleFixDTO
    {
        private string sid;
        private string sservice;

        public string id { get => sid; set => sid = value; }
        public string service { get => sservice; set => sservice = value; }

        public vehicleFixDTO()
        {

        }

        public vehicleFixDTO(string id, string service)
        {
            this.sid = id;
            this.sservice = service;
        }

        ~vehicleFixDTO() { }
    }
}
