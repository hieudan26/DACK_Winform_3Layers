using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class phongBanBUS
    {
        phongBanDAL PhongBanDAL = new phongBanDAL();

        //reset leaderid theo phòng
        public bool reset_leaderId_Department(string idDepartment)
        {
            return this.PhongBanDAL.reset_leaderId_Department(idDepartment);
        }

        //tìm kiếm theo id có phải leader ko?
        public bool ktraLeader(string idleader)
        {
            return this.PhongBanDAL.ktraLeader(idleader);
        }

        //trả về table phòng ban theo name
        public DataTable getPhongBan_byName(string nameDept)
        {
            return this.PhongBanDAL.getPhongBan_byName(nameDept);
        }    

        //checkPhong đã có trưởng phòng chưa
        public bool ktraTruongPhong(string idDepartment)
        {
            return this.PhongBanDAL.ktraTruongPhong(idDepartment);
        }

        ////update leader
        public bool update_leaderId_Department(string idDepartment, string leaderId)
        {
            return this.PhongBanDAL.update_leaderId_Department(idDepartment, leaderId);
        }
    }
}
