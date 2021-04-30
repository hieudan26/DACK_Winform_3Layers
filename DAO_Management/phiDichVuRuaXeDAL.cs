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
    public class phiDichVuRuaXeDAL : MyDB
    {
        public DataTable GetPrice(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get price by type
        public DataTable getPriceByType(int type)
        {
            SqlCommand cmd = new SqlCommand("select * from SERVICE_VEHICLE_WASH where type = @type");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            DataTable table = this.GetPrice(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //update
        public bool updatePrice(int type, int price)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update SERVICE_VEHICLE_WASH set wash_fee = @price where type = @type", this.getConnection);
                cmd.Parameters.Add("@price", SqlDbType.Int).Value = price;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;

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
    }
}
