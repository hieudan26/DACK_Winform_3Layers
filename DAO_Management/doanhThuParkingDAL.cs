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
    public class doanhThuParkingDAL : MyDB
    {
        public DataTable getDoanhThuParking(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public bool insert_doanhThuParking(doanhThuParkingDTO doanhThu)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO REVENUE_PARKING (id, timeOut, totalFee)" +
            "VALUES (@id, @timeOut, @totalFee)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = doanhThu.id;
                cmd.Parameters.Add("@timeOut", SqlDbType.DateTime).Value = doanhThu.timeOut;
                cmd.Parameters.Add("@totalFee", SqlDbType.Int).Value = doanhThu.totalFee;
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
