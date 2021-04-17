using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class vehicleDTO
    {
        private string iid;

        public string id { get => iid; set => iid = value; }
        
        private MemoryStream bImg1;

        public MemoryStream Img1 { get => bImg1; set => bImg1 = value; }

        private MemoryStream bImg2;

        public MemoryStream Img2 { get => bImg2; set => bImg2 = value; }
        

        private int itype;
        public int type { get => itype; set => itype = value; }
        public int park { get => ipark; set => ipark = value; }
        public int fix { get => ifix; set => ifix = value; }
        public int wash { get => iwash; set => iwash = value; }

        private int ipark;
        private int ifix;
        private int iwash;
        

        public vehicleDTO() { }

        public vehicleDTO(string id, int type, MemoryStream img1, MemoryStream img2, int park, int fix, int wash)
        {
            this.iid = id;
            this.itype = type;
            this.bImg1 = img1;
            this.bImg2 = img2;
            this.ipark = park;
            this.ifix = fix;
            this.iwash = wash;
        }

        ~vehicleDTO() { }
    }
}
