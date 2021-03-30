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
    public class vehicleDAL : MyDB
    {
        public DataTable getVehicle(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public bool insertVehicle(vehicleDTO vel)
        {
            ////if (!vel.verifyPass(acc.Username, acc.Password))
            ////{
            ////    return false;
            ////}
            //else
            //{
                try
                {
                    this.openConnection();

                    SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle (type, img1, img2)" +
             "VALUES (@type, @img1,@img2)", this.getConnection);

                    cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.type;
                    cmd.Parameters.Add("@img1", SqlDbType.Image).Value = vel.Img1.ToArray();
                    cmd.Parameters.Add("@img2", SqlDbType.Image).Value = vel.Img2.ToArray();
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
           // }
        }
    }
}
