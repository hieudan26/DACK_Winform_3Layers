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
    public class phiDichVuSuaXeDAL : MyDB
    {
        public DataTable GetPrice(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Remove
        public bool DeleteService(string service)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from SERVICE_VEHICLE_FIX where service = @service", this.getConnection);
                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = service;

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

        //Edit
        public bool UpdateService_fee(string service, int service_fee)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update SERVICE_VEHICLE_FIX set service_fee = @service_fee where service = @service", this.getConnection);

                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = service;
                cmd.Parameters.Add("@service_fee", SqlDbType.Int).Value = service_fee;

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

        //add 
        public bool insertService(int type, string service, int fee)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO SERVICE_VEHICLE_FIX(type, service, service_fee)" +
            "VALUES (@type, @service, @service_fee)", this.getConnection);
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = service;
                cmd.Parameters.Add("@service_fee", SqlDbType.Int).Value = fee;

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

        public string getFee_byService(string service)
        {
            string temp = "";
            SqlCommand cmd = new SqlCommand("select service_fee from SERVICE_VEHICLE_FIX where service = @ser");
            cmd.Parameters.Add("@ser", SqlDbType.NVarChar).Value = service;
            DataTable table = this.GetPrice(cmd);
            if (table.Rows.Count > 0)
                temp = table.Rows[0]["service_fee"].ToString();
            return temp;
        }

        public DataTable getDichVu_ByType(int type)
        {
            SqlCommand cmd = new SqlCommand("select * from SERVICE_VEHICLE_FIX where type = @type", this.getConnection);
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;

            DataTable table = this.GetPrice(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                MessageBox.Show("Can't get price");
                return null;
            }
        }
    }
}
