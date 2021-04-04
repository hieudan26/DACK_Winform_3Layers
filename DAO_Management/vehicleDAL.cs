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

        //them object xe
        public bool insertVehicle(vehicleDTO vel)
        {
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
        }

        //dem loai xe
        public int countVehicleType(int type)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from Vehicle where type = " + type, this.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return (int)table.Rows[0]["SoLuong"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return -1;
        }

        //List vehicle theo ID
        public List<int> danhSachID(int type)
        {
            List<int> lID = new List<int>();
            try
            {
                int soLuong = this.countVehicleType(type);

                if (type != -1 || type != 0)
                {
                    this.openConnection();

                    SqlCommand cmd = new SqlCommand("select ID from Vehicle where type = " + type, this.getConnection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    for (int i = 0; i < soLuong; i++)
                    {
                        lID.Add((int)(table.Rows[i]["ID"]));
                    }
                }    
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return lID;
        }

        //dem tong cong
        public int countVehicleTotal()
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("select count(*) as Total from Vehicle", this.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return (int)table.Rows[0]["SoLuong"];
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return -1;
        }

        //can nhac
        public bool insertGuiXe(vehicleDTO vel,int type)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO GuiXe (IdXe, type, NgayGui)" +
         "VALUES (@IdXe, @type,@NgayGui)", this.getConnection);

                cmd.Parameters.Add("@IdXe", SqlDbType.Int).Value = vel.ID;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
                cmd.Parameters.Add("@NgayGui", SqlDbType.DateTime).Value = DateTime.Now;
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
