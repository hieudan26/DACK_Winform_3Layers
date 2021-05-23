using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class doanhThuContract_ChoThueDTO
    {
        private string sid;
        private float fTotalCost;
        private string sidEmployee;

        public doanhThuContract_ChoThueDTO(string sid, float fTotalCost, string sidEmployee)
        {
            this.sid = sid;
            this.fTotalCost = fTotalCost;
            this.sidEmployee = sidEmployee;
        }

        public string id { get => sid; set => sid = value; }
        public float TotalCost { get => fTotalCost; set => fTotalCost = value; }
        public string idEmployee { get => sidEmployee; set => sidEmployee = value; }

        public doanhThuContract_ChoThueDTO() { }

        ~doanhThuContract_ChoThueDTO() { }
    }
}
