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
    public class nhanVienRuaXeDAL : MyDB
    {
        private DataTable getNhanVienRuaXe(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //updateAccount Bao Ve
        public bool UpdateAccountNVRuaXe(string id, string username, string password, int status)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update THORUAXE set username = @username, password = @password, status = @status where id = @id", this.getConnection);
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
        public DataTable getInfo_byID(string IDNVRuaXe)
        {
            SqlCommand cmd = new SqlCommand("select * from THORUAXE where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDNVRuaXe;

            DataTable table = this.getNhanVienRuaXe(cmd);

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
            SqlCommand cmd = new SqlCommand("select * from THORUAXE where status = 1");
            DataTable table = this.getNhanVienRuaXe(cmd);

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
        public bool RemoveNhanVienRuaXe(string IDRuaXe)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from THORUAXE where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDRuaXe;
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
            SqlCommand cmd = new SqlCommand("select * from THORUAXE where status = @status");
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = 1;

            DataTable table = this.getNhanVienRuaXe(cmd);

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
        public bool insertnhanVienRuaXe(nhanVienRuaXeDTO nhanVienRuaXeDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO THORUAXE(id, username, password, status)" +
            "VALUES (@id, @username, @password, @status)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVienRuaXeDTO.id;
                cmd.Parameters.Add("@username", SqlDbType.NChar).Value = nhanVienRuaXeDTO.username;
                cmd.Parameters.Add("@password", SqlDbType.NChar).Value = nhanVienRuaXeDTO.password;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = nhanVienRuaXeDTO.status;

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
