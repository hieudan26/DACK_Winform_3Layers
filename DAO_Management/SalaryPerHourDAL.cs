using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;
using DTO_Management;

namespace DAO_Management
{
    public class SalaryPerHourDAL :MyDB
    {
        public DataTable getSalary(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertSalaryPerHour(string type, int Ca,float Luongperhour)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("insert into SALARYPERHOUR (type,Ca,Luongperhour) values (@type,@Ca,@Luongperhour)", this.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.NChar).Value = type;
                cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("@Luongperhour", SqlDbType.Float).Value = Luongperhour;
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
        public bool UpdateSalaryPerHour(string type, int Ca, float Luongperhour)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("update SALARYPERHOUR set Luongperhour=@Luongperhour where type = @type and Ca =@Ca", this.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.NChar).Value = type;
                cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("@Luongperhour", SqlDbType.Float).Value = Luongperhour;
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
        public bool DeleteAll()
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("Delete from SALARYPERHOUR ", this.getConnection);
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
        public float getLuongPerHour(string type, int Ca)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("select Luongperhour from SALARYPERHOUR where  type = @type and Ca =@Ca",this.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.NChar).Value = type;
                cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    return float.Parse(table.Rows[0][0].ToString());
                else
                    return 0;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return 0;
        }
    }
}
