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
    public class SalaryDAL : MyDB
    {
        public DataTable getSalary(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertSalaryNV(string IDnv, float Luong)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("insert into SALARY (id,Luong) values (@id,@Luong)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = Luong;
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

        public bool UpdateLuong(string IDnv, float Luong)
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("update SALARY set Luong=@Luong where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = Luong;
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
                SqlCommand cmd = new SqlCommand("Delete from SALARY ", this.getConnection);
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

        public float getLuongNV(string IDnv)
        {
            SqlCommand cmd = new SqlCommand("select Luong from SALARY where id = @id", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            if (table.Rows.Count > 0)
                return float.Parse(table.Rows[0][0].ToString());
            else
                return 0;
        }

        public DataTable getLuongAll()
        {
            SqlCommand cmd = new SqlCommand("select * from SALARY");
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            DataTable table = this.getSalary(cmd);

            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }
    }
}
