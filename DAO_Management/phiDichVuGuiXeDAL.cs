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
