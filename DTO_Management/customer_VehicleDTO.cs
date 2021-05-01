using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class customer_VehicleDTO
    {
        private string sid_Cus;
        private string sid_Veh;

        public string id_Cus { get => sid_Cus; set => sid_Cus = value; }
        public string id_Veh { get => sid_Veh; set => sid_Veh = value; }

        public customer_VehicleDTO()
        {

        }

        public customer_VehicleDTO(string id_Cus, string id_Veh)
        {
            this.sid_Cus = id_Cus;
            this.sid_Veh = id_Veh;
        }
         
        ~customer_VehicleDTO() { }
    }
}
