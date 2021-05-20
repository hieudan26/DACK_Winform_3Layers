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
    public class nhanVienHopDongBUS
    {
        nhanVienHopDongDAL nhanVienHopDongDAL = new nhanVienHopDongDAL();

        //username exist
        public DataTable UsernameExist(string username)
        {
            return this.nhanVienHopDongDAL.UsernameExist(username);
        }

        //Xác minh login
        public DataTable VerifyLogin(string username, string password)
        {
            return this.nhanVienHopDongDAL.VerifyLogin(username, password);
        }

        //updateAccount Bao Ve
        public bool UpdateAccountNVHopDong(string id, string username, string password, int status)
        {
            return this.nhanVienHopDongDAL.UpdateAccountNVHopDong(id, username, password, status);
        }

        //get thông tin bằng id
        public DataTable getInfo_byID(string IDNVHopDong)
        {
            return this.nhanVienHopDongDAL.getInfo_byID(IDNVHopDong);
        }

        //Get thông tin leader
        public DataTable getInfoLeader()
        {
            return this.nhanVienHopDongDAL.getInfoLeader();
        }

        //Del nhân viên
        public bool RemoveNhanVienHopDong(string IDNhanVienHopDong)
        {
            return this.nhanVienHopDongDAL.RemoveNhanVienHopDong(IDNhanVienHopDong);
        }

        //ktra có leader chưa
        public bool leaderExist()
        {
            return this.nhanVienHopDongDAL.leaderExist();
        }

        public bool insertnhanVienHopDong(nhanVienHopDongDTO nhanVienHopDongDTO)
        {
            return this.nhanVienHopDongDAL.insertnhanVienHopDong(nhanVienHopDongDTO);
        }
    }
}
