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
    public class phongBanDAL : MyDB
    {
        public DataTable getDepartment(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //tìm kiếm theo id có phải leader ko?
        public bool ktraLeader(string idleader)
        {
            SqlCommand cmd = new SqlCommand("select * from DEPARTMENT where leaderId = @leaderId");
            cmd.Parameters.Add("@leaderId", SqlDbType.NVarChar).Value = idleader;
            DataTable table = this.getDepartment(cmd);
            if (table.Rows.Count > 0)
                return true;
            else
                return false;
        }

        //trả về ID phòng ban của loại thợ
        public DataTable getPhongBan_byName(string nameDept)
        {
            SqlCommand cmd = new SqlCommand("select * from DEPARTMENT where name = @nameDept");
            cmd.Parameters.Add("@nameDept", SqlDbType.NVarChar).Value = nameDept;
            DataTable table = this.getDepartment(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }   
            else
            {
                return null;
            }    
        }    

        //check phòng đã có trưởng phòng chưa
        public bool ktraTruongPhong(string idDepartment)
        {
            SqlCommand cmd = new SqlCommand("select * from DEPARTMENT where leaderId is not null and id = @dep_id");
            cmd.Parameters.Add("@dep_id", SqlDbType.NVarChar).Value = idDepartment;
            DataTable table = this.getDepartment(cmd);
            if (table.Rows.Count > 0)
            {
                return false;           //đã tồn tại trưởng phòng
            }
            else
            {
                return true;            //chưa tồn tại trưởng phòng
            } 
                
        }

        //reset idleader theo phòng
        public bool reset_leaderId_Department(string idDepartment)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update DEPARTMENT set leaderId = NULL where id = @idDepartment", this.getConnection);
                cmd.Parameters.Add("@idDepartment", SqlDbType.NVarChar).Value = idDepartment;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
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

        //update leader
        public bool update_leaderId_Department(string idDepartment, string leaderId)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update DEPARTMENT set leaderId = @leaderID where id = @idDepartment", this.getConnection);
                cmd.Parameters.Add("@leaderID", SqlDbType.NVarChar).Value = leaderId;
                cmd.Parameters.Add("@idDepartment", SqlDbType.NVarChar).Value = idDepartment;

                if (cmd.ExecuteNonQuery() == 1)
                {
                    return true;
                }
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
