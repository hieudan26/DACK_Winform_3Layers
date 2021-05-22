using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class contract_ThueDTO
    {
        private string sid;
        private string sidCustomer;
        private string sidVehicle;
        private DateTime dtdateSign;
        private float fTotalCost;
        private string sidEmployee;

        public contract_ThueDTO(string sid, string sidCustomer, string sidVehicle, DateTime dtdateSign, float fTotalCost, string idEmployee)
        {
            this.sid = sid;
            this.sidCustomer = sidCustomer;
            this.sidVehicle = sidVehicle;
            this.dtdateSign = dtdateSign;
            this.fTotalCost = fTotalCost;
            this.sidEmployee = idEmployee;
        }

        public string id { get => sid; set => sid = value; }
        public string idCustomer { get => sidCustomer; set => sidCustomer = value; }
        public string idVehicle { get => sidVehicle; set => sidVehicle = value; }
        public DateTime dateSign { get => dtdateSign; set => dtdateSign = value; }
        public float TotalCost { get => fTotalCost; set => fTotalCost = value; }
        public string idEmployee { get => sidEmployee; set => sidEmployee = value; }

        public contract_ThueDTO() { }

        ~contract_ThueDTO() { }
    }
}
