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
            DataTable table = new DataTable();
            try
            {
                cmd.Connection = this.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
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
            try
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
        public DataTable getKetToanLuongAll()
        {
            SqlCommand cmd = new SqlCommand("Select EMPLOYEES.ID as[ID],name as Name, EMPLOYEES.img as [Picture], SALARY.Luong from  EMPLOYEES inner join SALARY on EMPLOYEES.id = SALARY.ID");
            //SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            //DataTable table = new DataTable();
            //adapter.Fill(table);
            DataTable table = this.getSalary(cmd);

            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }
        public DataTable getKetToanLuongType(string type)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select EMPLOYEES.ID as[ID],name as Name, EMPLOYEES.img as [Picture], SALARY.Luong from  EMPLOYEES inner join SALARY on EMPLOYEES.id = SALARY.ID where EMPLOYEES.typeTho =@type ", this.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.NChar).Value = type;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    return table;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return null;
        }
        public DataTable getKetToanLuongID(string IDnv)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select EMPLOYEES.ID,name as Name ,typeTho, EMPLOYEES.img, SALARY.Luong from  EMPLOYEES inner join SALARY on EMPLOYEES.id = SALARY.ID where SALARY.ID = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                if (table.Rows.Count > 0)
                    return table;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return null;
        }
    }
}
