using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;

namespace DAL_Management
{
    public class nhanVienSuaXeDAL : MyDB
    {
        private DataTable getNhanVienSuaXe(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //updateAccount Bao Ve
        public bool UpdateAccountNVSuaXe(string id, string username, string password, int status)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update THOSUAXE set username = @username, password = @password, status = @status where id = @id", this.getConnection);
                cmd.Parameters.Add("@username", SqlDbType.NChar).Value = username;
                cmd.Parameters.Add("@password", SqlDbType.NChar).Value = password;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = id;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return false;
        }

        //get thông tin bằng id
        public DataTable getInfo_byID(string IDNVSuaXe)
        {
            SqlCommand cmd = new SqlCommand("select * from THOSUAXE where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDNVSuaXe;

            DataTable table = this.getNhanVienSuaXe(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //Get thông tin leader
        public DataTable getInfoLeader()
        {
            SqlCommand cmd = new SqlCommand("select * from THOSUAXE where status = 1");
            DataTable table = this.getNhanVienSuaXe(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //Del nhân viên
        public bool RemoveNhanVienSuaXe(string IDSuaXe)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from THOSUAXE where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDSuaXe;
                this.openConnection();
                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return false;
        }

        //ktra có leader chưa
        public bool leaderExist()
        {
            SqlCommand cmd = new SqlCommand("select * from THOSUAXE where status = @status");
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = 1;

            DataTable table = this.getNhanVienSuaXe(cmd);

            if (table.Rows.Count > 0)
            {
                return true;    //đã tồn tại
            }
            else
            {
                return false;
            }
        }

        //insert
        public bool insertnhanVienSuaXe(nhanVienSuaXeDTO nhanVienSuaXeDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO THOSUAXE(id, username, password, status)" +
            "VALUES (@id, @username, @password, @status)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVienSuaXeDTO.id;
                cmd.Parameters.Add("@username", SqlDbType.NChar).Value = nhanVienSuaXeDTO.username;
                cmd.Parameters.Add("@password", SqlDbType.NChar).Value = nhanVienSuaXeDTO.password;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = nhanVienSuaXeDTO.status;

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return false;
        }
    }
}
