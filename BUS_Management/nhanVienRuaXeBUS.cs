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
    public class nhanVienRuaXeBUS
    {
        nhanVienRuaXeDAL nhanVienRuaXeDAL = new nhanVienRuaXeDAL();

        //username exist
        public DataTable UsernameExist(string username)
        {
            return this.nhanVienRuaXeDAL.UsernameExist(username);
        }

        //Xác minh login
        public DataTable VerifyLogin(string username, string password)
        {
            return this.nhanVienRuaXeDAL.VerifyLogin(username, password);
        }

        //updateAccount Bao Ve
        public bool UpdateAccountNVRuaXe(string id, string username, string password, int status)
        {
            return this.nhanVienRuaXeDAL.UpdateAccountNVRuaXe(id, username, password, status);
        }

        //get thông tin bằng id
        public DataTable getInfo_byID(string IDNVRuaXe)
        {
            return this.nhanVienRuaXeDAL.getInfo_byID(IDNVRuaXe);
        }

        //Get thông tin leader
        public DataTable getInfoLeader()
        {
            return this.nhanVienRuaXeDAL.getInfoLeader();
        }

        //Del nhân viên
        public bool RemoveNhanVienRuaXe(string IDRuaXe)
        {
            return this.nhanVienRuaXeDAL.RemoveNhanVienRuaXe(IDRuaXe);
        }

        //ktra có leader chưa
        public bool leaderExist()
        {
            return this.nhanVienRuaXeDAL.leaderExist();
        }

        public bool insertnhanVienRuaXe(nhanVienRuaXeDTO nhanVienRuaXeDTO)
        {
            return this.nhanVienRuaXeDAL.insertnhanVienRuaXe(nhanVienRuaXeDTO);
        }
    }
}
