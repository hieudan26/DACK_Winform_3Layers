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
    public class phiGuiDAL : MyDB
    {
       
        public DataTable GetPrice(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool editPrice(int thu, int gio, int ngay, int tuan, int thang)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update FEE_PARKING set hourFee = @gio, dateFee = @ngay, weekFee = @tuan, monthFee = @thang where dayWeek = @thu", this.getConnection);
                cmd.Parameters.Add("@gio", SqlDbType.Int).Value = gio;
                cmd.Parameters.Add("@ngay", SqlDbType.Int).Value = ngay;
                cmd.Parameters.Add("@tuan", SqlDbType.Int).Value = tuan;
                cmd.Parameters.Add("@thang", SqlDbType.Int).Value = thang;
                cmd.Parameters.Add("@thu", SqlDbType.Int).Value = thu;

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

        public DataTable getAllPrice()
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Select dayWeek as Thu, hourFee as Gio, dateFee as Ngay, weekFee as Tuan, monthFee as Thang from FEE_PARKING");
                DataTable table = this.GetPrice(cmd);
                return table;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }

        public bool UpdatePrice(int thu)
        {
            SqlCommand cmd = new SqlCommand("SELECT * FROM FEE_PARKING where dayWeek = " + thu, this.getConnection);
           
            DataTable table = this.GetPrice(cmd);
            
            if(table.Rows.Count > 0)
            {
                //DataRow Row = table.Rows[thu];
                int gio = int.Parse(table.Rows[0]["hourFee"].ToString());
                int ngay = int.Parse(table.Rows[0]["dateFee"].ToString());
                int tuan = int.Parse(table.Rows[0]["weekFee"].ToString());
                int thang = int.Parse(table.Rows[0]["monthFee"].ToString());
                phiDichVuGuiXeDTO.Update(gio, ngay, tuan, thang);
                return true;
            }
            else
            {
                MessageBox.Show("Can't get price");
                return false;
            }    
        }
    }
}
