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
    public class nhanVienBUS
    {
        nhanVienDAL nhanVienDAL = new nhanVienDAL();

        //del nhân viên
        public bool DelEmployee(string IDEmployee)
        {
            return this.nhanVienDAL.DelEmployee(IDEmployee);
        }

        //Search nhân viên hỗn hợp
        public DataTable getEmployee_ByIDandName(string ID_name)
        {
            return this.nhanVienDAL.getEmployee_ByIDandName(ID_name);
        }

        //lấy tất cả nhân viên
        public DataTable getAllEmployees()
        {
            return this.nhanVienDAL.getAllEmployees();
        }

        //lấy nhân viên theo phòng (theo loại nhân viên)
        public DataTable getNv_typeTho(string typeTho)
        {
            return this.nhanVienDAL.getNv_typeTho(typeTho);
        }


        public bool insertEmployee(nhanVienDTO nhanVienDTO)
        {
            return this.nhanVienDAL.insertEmployee(nhanVienDTO);
        }
    }
}
