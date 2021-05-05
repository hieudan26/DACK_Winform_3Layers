using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class shift_NhanVienDTO
    {
        private string sid_NV;
        private int iThu2;
        private int iThu3;
        private int iThu4;
        private int iThu5;
        private int iThu6;
        private int iThu7;
        private int iChuNhat;

        public string id_NV { get => sid_NV; set => sid_NV = value; }
        public int Thu2 { get => iThu2; set => iThu2 = value; }
        public int Thu3 { get => iThu3; set => iThu3 = value; }
        public int Thu4 { get => iThu4; set => iThu4 = value; }
        public int Thu5 { get => iThu5; set => iThu5 = value; }
        public int Thu6 { get => iThu6; set => iThu6 = value; }
        public int Thu7 { get => iThu7; set => iThu7 = value; }
        public int ChuNhat { get => iChuNhat; set => iChuNhat = value; }

        public shift_NhanVienDTO()
        {

        }

        public shift_NhanVienDTO(string id_NV, int thu2, int thu3, int thu4, int thu5, int thu6, int thu7, int chunhat)
        {
            this.sid_NV = id_NV;
            this.iThu2 = thu2;
            this.iThu3 = thu3;
            this.iThu4 = thu4;
            this.iThu5 = thu5;
            this.iThu6 = thu6;
            this.iThu7 = thu7;
            this.iChuNhat = chunhat;
        }

        ~shift_NhanVienDTO() { }
    }
}
