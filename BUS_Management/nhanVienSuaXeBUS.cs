 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Management;
using DAL_Management;
using System.Data;

namespace BUS_Management
{
    public class nhanVienSuaXeBUS
    {
        nhanVienSuaXeDAL nhanVienSuaXeDAL = new nhanVienSuaXeDAL();

        //updateAccount Bao Ve
        public bool UpdateAccountNVSuaXe(string id, string username, string password, int status)
        {
            return this.nhanVienSuaXeDAL.UpdateAccountNVSuaXe(id, username, password, status);
        }

        //get thông tin bằng id
        public DataTable getInfo_byID(string IDNVSuaXe)
        {
            return this.nhanVienSuaXeDAL.getInfo_byID(IDNVSuaXe);
        }

        //Get thông tin leader
        public DataTable getInfoLeader()
        {
            return this.nhanVienSuaXeDAL.getInfoLeader();
        }

        //Del nhân viên
        public bool RemoveNhanVienSuaXe(string IDSuaXe)
        {
            return this.nhanVienSuaXeDAL.RemoveNhanVienSuaXe(IDSuaXe);
        }

        //ktra có leader chưa
        public bool leaderExist()
        {
            return this.nhanVienSuaXeDAL.leaderExist();
        }

        public bool insertnhanVienSuaXe(nhanVienSuaXeDTO nhanVienSuaXeDTO)
        {
            return this.nhanVienSuaXeDAL.insertnhanVienSuaXe(nhanVienSuaXeDTO);
        }
    }
}
