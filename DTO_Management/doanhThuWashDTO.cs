using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class doanhThuWashDTO
    {
        private string sid;
        private DateTime dttimeOut;
        private int itotalFee;

        public DateTime timeOut
        {
            get { return this.dttimeOut; }
            set { this.dttimeOut = value; }
        }

        public int totalFee
        {
            get { return this.itotalFee; }
            set { this.itotalFee = value; }
        }

        public string id { get => sid; set => sid = value; }

        public doanhThuWashDTO()
        {

        }

        public doanhThuWashDTO(string id, DateTime timeOut, int totalFee)
        {
            this.sid = id;
            this.itotalFee = totalFee;
            this.dttimeOut = timeOut;
        }

        ~doanhThuWashDTO() { }
    }
}
