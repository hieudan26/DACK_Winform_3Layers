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
    public class nhanVienHopDongDAL : MyDB
    {
        private DataTable getNhanVienHopDong(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //username exist
        public DataTable UsernameExist(string username)
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIENHOPDONG where username = @username");
            cmd.Parameters.Add("@username", SqlDbType.NChar).Value = username;

            DataTable table = this.getNhanVienHopDong(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //Xác minh login
        public DataTable VerifyLogin(string username, string password)
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIENHOPDONG where username = @username and password = @password", this.getConnection);
            cmd.Parameters.Add("@username", SqlDbType.NChar).Value = username;
            cmd.Parameters.Add("@password", SqlDbType.NChar).Value = password;

            DataTable table = this.getNhanVienHopDong(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
                return null;
        }

        //updateAccount Bao Ve
        public bool UpdateAccountNVHopDong(string id, string username, string password, int status)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update NHANVIENHOPDONG set username = @username, password = @password, status = @status where id = @id", this.getConnection);
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
        public DataTable getInfo_byID(string IDNVHopDong)
        {
            SqlCommand cmd = new SqlCommand("select * from NHANVIENHOPDONG where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDNVHopDong;

            DataTable table = this.getNhanVienHopDong(cmd);

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
            SqlCommand cmd = new SqlCommand("select * from NHANVIENHOPDONG where status = 1");
            DataTable table = this.getNhanVienHopDong(cmd);

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
        public bool RemoveNhanVienHopDong(string IDNhanVienHopDong)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from NHANVIENHOPDONG where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDNhanVienHopDong;
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

            DataTable table = this.getNhanVienHopDong(cmd);

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
        public bool insertnhanVienHopDong(nhanVienHopDongDTO nhanVienHopDongDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO NHANVIENHOPDONG(id, username, password, status)" +
            "VALUES (@id, @username, @password, @status)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVienHopDongDTO.id;
                cmd.Parameters.Add("@username", SqlDbType.NChar).Value = nhanVienHopDongDTO.username;
                cmd.Parameters.Add("@password", SqlDbType.NChar).Value = nhanVienHopDongDTO.password;
                cmd.Parameters.Add("@status", SqlDbType.Bit).Value = nhanVienHopDongDTO.status;

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
