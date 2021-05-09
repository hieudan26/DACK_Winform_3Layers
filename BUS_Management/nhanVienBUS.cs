using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
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

        //update thông tin nhân viên theo id
        public bool UpdateInfoEmployee(string name, DateTime dob, string gender, string typeTho, MemoryStream img, string IdEmployee)
        {
            return this.nhanVienDAL.UpdateInfoEmployee(name, dob, gender, typeTho, img, IdEmployee);
        }

        //tìm kiếm hỗn hợp theo gender và gender giữa 2 ngày
        public DataTable getEmployee_ByIDandNameGenderGender_Giua2Ngay(string ID_name, string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getEmployee_ByIDandNameGenderGender_Giua2Ngay(ID_name, gender1, gender2, dt1, dt2);
        }

        //tìm kiếm hỗn hợp theo gender giữa 2 ngày
        public DataTable getEmployee_ByIDandNameGender_Giua2Ngay(string ID_name, string gender, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getEmployee_ByIDandNameGender_Giua2Ngay(ID_name, gender, dt1, dt2);
        }

        //tìm kiếm hỗn hợp giữa 2 ngày
        public DataTable getEmployee_ByIDandName_Giua2Ngay(string ID_name, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getEmployee_ByIDandName_Giua2Ngay(ID_name, dt1, dt2);
        }

        //tìm kiếm hỗn hợp theo gender và gender
        public DataTable getEmployee_ByIDandNameGenderGender(string ID_name, string gender1, string gender2)
        {
            return this.nhanVienDAL.getEmployee_ByIDandNameGenderGender(ID_name, gender1, gender2);
        }

        //tìm kiếm hỗn hợp theo gender
        public DataTable getEmployee_ByIDandNameGender(string ID_name, string gender)
        {
            return this.nhanVienDAL.getEmployee_ByIDandNameGender(ID_name, gender);
        }

        //tìm kiếm nhân viên theo id_cmnd
        public DataTable getEmployee_byID(string id)
        {
            return this.nhanVienDAL.getEmployee_byID(id);
        }

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

        //get tất cả nhân viên theo 2giới tính, giữa 2 ngày
        public DataTable getAllEmployeesGenderAndGender_Giua2Ngay(string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getAllEmployeesGenderAndGender_Giua2Ngay(gender1, gender2, dt1, dt2);
        }

        //get tất cả nhân viên theo 2giới tính
        public DataTable getAllEmployeesGenderAndGender(string gender1, string gender2)
        {
            return this.nhanVienDAL.getAllEmployeesGenderAndGender(gender1, gender2);
        }

        //get tất cả nhân viên theo giới tính giữa 2 ngày
        public DataTable getAllEmployeesGender_Giua2Ngay(string gender, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getAllEmployeesGender_Giua2Ngay(gender, dt1, dt2);
        }

        //get tất cả nhân viên theo giới tính
        public DataTable getAllEmployeesGender(string gender)
        {
            return this.nhanVienDAL.getAllEmployeesGender(gender);
        }

        //get tất cả nhân viên giữa 2 ngày
        public DataTable getAllEmployees_Giua2Ngay(DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getAllEmployees_Giua2Ngay(dt1, dt2);
        }

        //lấy tất cả nhân viên
        public DataTable getAllEmployees()
        {
            return this.nhanVienDAL.getAllEmployees();
        }

        //get nhân viên theo typeTho và giới tính và giới tính giữa 2 ngày
        public DataTable getNv_typeThoGenderAndGender_Giua2Ngay(string typeTho, string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getNv_typeThoGenderAndGender_Giua2Ngay(typeTho, gender1, gender2, dt1, dt2);
        }

        //get nhân viên theo typeTho và giới tính và giới tính
        public DataTable getNv_typeThoGenderAndGender(string typeTho, string gender1, string gender2)
        {
            return this.nhanVienDAL.getNv_typeThoGenderAndGender(typeTho, gender1, gender2);
        }

        //get nhân viên theo typeTho và giới tính giữa 2 ngày
        public DataTable getNv_typeThoGender_Giua2Ngay(string typeTho, string gender, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getNv_typeThoGender_Giua2Ngay(typeTho, gender, dt1, dt2);
        }

        //lấy nhân viên theo phfong và theo giới tính
        public DataTable getNv_typeThoGender(string typeTho, string gender)
        {
            return this.nhanVienDAL.getNv_typeThoGender(typeTho, gender);
        }

        //get nhân viên theo typeTho giữa 2 ngày
        public DataTable getNv_typeTho_Giua2Ngay(string typeTho, DateTime dt1, DateTime dt2)
        {
            return this.nhanVienDAL.getNv_typeTho_Giua2Ngay(typeTho, dt1, dt2);
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
