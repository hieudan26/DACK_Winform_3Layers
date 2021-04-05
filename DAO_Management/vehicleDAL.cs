using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
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

        //lay vehicle bang id
        public DataTable getVehicleByID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from Vehicle where ID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable table = this.getVehicle(cmd);
            return table;
        }

        //Lay hinh 1 ra
        public MemoryStream getImage1(int ID, string imgx)
        {
            //this.openConnection();
            SqlCommand cmd = new SqlCommand("Select " + imgx + " from Vehicle where ID = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = ID;

            //SqlDataAdapter dataAdapter = new SqlDataAdapter(cmd);

            DataTable table = this.getVehicle(cmd);

            if (table.Rows.Count == 1)
            {
                Byte[] pic = new Byte[0];
                pic = (Byte[])(table.Rows[0][imgx]);
                MemoryStream ms = new MemoryStream(pic);
                return ms;
                this.closeConnection();
            }
            else
            {
                this.closeConnection();
                return null;
                
            }
        }

        //them object xe
        public bool insertVehicle(vehicleDTO vel)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO Vehicle (type, img1, img2,TypeGui,NgayGui)" +
            "VALUES (@type, @img1,@img2,@TypeGui,@NgayGui)", this.getConnection);

                cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.type;
                cmd.Parameters.Add("@img1", SqlDbType.Image).Value = vel.Img1.ToArray();
                cmd.Parameters.Add("@img2", SqlDbType.Image).Value = vel.Img2.ToArray();
                cmd.Parameters.Add("@TypeGui", SqlDbType.Int).Value = vel.typeGui;
                cmd.Parameters.Add("@NgayGui", SqlDbType.DateTime).Value = vel.ngayGui;
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
    }
}
