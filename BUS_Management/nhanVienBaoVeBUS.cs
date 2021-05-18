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
    public class nhanVienBaoVeBUS
    {
        nhanVienBaoVeDAL nhanVienBaoVeDAL = new nhanVienBaoVeDAL();

        //updateAccount Bao Ve
        public bool UpdateAccountBaoVe(string id, string username, string password, int status)
        {
            return this.nhanVienBaoVeDAL.UpdateAccountBaoVe(id, username, password, status);
        }

        //get thông tin bằng id
        public DataTable getInfo_byID(string IDBaoVe)
        {
            return this.nhanVienBaoVeDAL.getInfo_byID(IDBaoVe);
        }

        //Get thông tin leader
        public DataTable getInfoLeader()
        {
            return this.nhanVienBaoVeDAL.getInfoLeader();
        }

        //Del nhân viên
        public bool RemoveBAOVE(string IDBaoVe)
        {
            return this.nhanVienBaoVeDAL.RemoveBAOVE(IDBaoVe);
        }

        //ktra có leader chưa
        public bool leaderExist()
        {
            return this.nhanVienBaoVeDAL.leaderExist();
        }

        public bool insertnhanVienBaoVe(nhanVienBaoVeDTO nhanVienBaoVeDTO)
        {
            return this.nhanVienBaoVeDAL.insertnhanVienBaoVe(nhanVienBaoVeDTO);
        }
    }
}
