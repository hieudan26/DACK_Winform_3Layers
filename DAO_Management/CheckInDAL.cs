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
    public class CheckInDAL : MyDB
    {
        public DataTable getCheckIn(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insertEmtyCa(string IDnv, int thu, int Ca, int attend) //Monday = 2,......
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("insert into CHECKIN (id,ngay,Ca,attend) values (@id,@ngay,@Ca,@attend)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
                cmd.Parameters.Add("@ngay", SqlDbType.Int).Value = thu;
                cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("@attend", SqlDbType.Int).Value = attend;
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
        public bool AttendCa(string IDnv, int thu, int Ca, int attend) 
        {
            try
            {
                this.openConnection();
                SqlCommand cmd = new SqlCommand("update CHECKIN set attend=@attend where id = @id and ngay = @ngay and Ca = @Ca", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDnv;
                cmd.Parameters.Add("@ngay", SqlDbType.Int).Value = thu;
                cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;
                cmd.Parameters.Add("@attend", SqlDbType.Int).Value = attend;
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
                SqlCommand cmd = new SqlCommand("Delete from CHECKIN", this.getConnection);
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
