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
            SqlCommand cmd = new SqlCommand("SELECT * FROM TienGui where thu = " + thu, this.getConnection);
           
            DataTable table = this.GetPrice(cmd);
            
            if(table.Rows.Count > 0)
            {
                //DataRow Row = table.Rows[thu];
                int gio = int.Parse(table.Rows[0]["gio"].ToString());
                int ngay = int.Parse(table.Rows[0]["ngay"].ToString());
                int tuan = int.Parse(table.Rows[0]["tuan"].ToString());
                int thang = int.Parse(table.Rows[0]["thang"].ToString());
                phiGuiDTO.Update(gio, ngay, tuan, thang);
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
