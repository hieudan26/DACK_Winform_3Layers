using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class phiDichVuRuaXeDTO
    {
        private int itype;
        private int iwash_fee;

        public int type { get => itype; set => itype = value; }
        public int wash_fee { get => iwash_fee; set => iwash_fee = value; }

        public phiDichVuRuaXeDTO(int type, int wash_fee)
        {
            this.itype = type;
            this.iwash_fee = wash_fee;
        }

        public phiDichVuRuaXeDTO()
        {

        }

        ~phiDichVuRuaXeDTO() { }
    }
}
