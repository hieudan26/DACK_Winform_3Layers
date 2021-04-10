using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class vehicleParkingDTO
    {
        private string iid;

        public string id { get => iid; set => iid = value; }
        private int itypeGui;
        public int typeGui { get => itypeGui; set => itypeGui = value; }

        private DateTime dngayGui;
        public DateTime ngayGui { get => dngayGui; set => dngayGui = value; }
        public vehicleParkingDTO() { }

        public vehicleParkingDTO(string id, int typeGui, DateTime ngayGui)
        {
            this.iid = id;
            this.itypeGui = typeGui;
            this.dngayGui = ngayGui;
        }
    }
}
