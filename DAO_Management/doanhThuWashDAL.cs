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
    public class doanhThuWashDAL : MyDB
    {
        public DataTable getDoanhThuWash(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Tong thu nhap trong ngày
        public int sumDoanhThu_InDay()
        {
            int sum = 0;
            DateTime curr = DateTime.Now;
            string start = " 00:00:00";
            string end = " 23:59:59";
            string tmp = curr.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select sum(totalFee) as sum from REVENUE_WASH " +
                "where timeOut between '" + tmp + start + "' and '" + tmp + end + "'", this.getConnection);

            DataTable table = this.getDoanhThuWash(cmd);
            if (table.Rows[0]["sum"].ToString() != "")
                sum = (int)table.Rows[0]["sum"];
            return sum;
        }

        //get doanh thu trong ngay
        public DataTable getDoanhThuWash_InDay()
        {
            //this.openConnection();
            DateTime curr = DateTime.Now;
            string start = " 00:00:00";
            string end = " 23:59:59";
            string tmp = curr.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select * from REVENUE_WASH " +
                "where timeOut between '" + tmp + start + "' and '" + tmp + end + "'", this.getConnection);

            DataTable table = this.getDoanhThuWash(cmd);
            return table;
        }

        public bool insert_doanhThuWash(doanhThuWashDTO doanhThu)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO REVENUE_WASH (id, timeOut, totalFee)" +
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
