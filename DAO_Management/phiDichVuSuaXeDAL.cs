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

        public string getFee_byService(string service)
        {
            SqlCommand cmd = new SqlCommand("select service_fee from SERVICE_VEHICLE_FIX where service = @ser");
            cmd.Parameters.Add("@ser", SqlDbType.NVarChar).Value = service;
            DataTable table = this.GetPrice(cmd);
            return table.Rows[0]["service_fee"].ToString();
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
