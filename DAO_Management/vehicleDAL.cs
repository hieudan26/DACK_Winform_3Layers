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

        //Lay ra tien theo dayWeek
        public int layTienTheoThu(int dayWeek, string loaiGui)
        {
            int temp = -1;
            SqlCommand cmd = new SqlCommand("select * from FEE_PARKING where dayWeek = @dayWeek",this.getConnection);
            cmd.Parameters.Add("@dayWeek", SqlDbType.Int).Value = dayWeek;

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);

            if (table.Rows.Count == 1)
            {
                temp = (int)table.Rows[0][loaiGui];
                return temp;
            }
            else
                return temp;

        }

        //lay ra loai gui --0: gio -- 1: ngay -- 2: tuan -- 3: thang
        public int getLoaiGuiXe(int id)
        {
            int type = -1;
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE_PARKING where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable table = this.getVehicle(cmd);
            if (table.Rows.Count == 1)
            {
                type = (int)table.Rows[0]["typePark"];
                return type;
            }
            else
            {
                return type;
            } 
                
        }    

        //lay vehicle bang id
        public DataTable getVehicleByID(int id)
        {
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE_PARKING where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

            DataTable table = this.getVehicle(cmd);
            return table;
        }

        //Lay hinh 1 ra ?? de lam gi ? =)) 
        public MemoryStream getImage1(int id, string imgx)
        {
            //this.openConnection();
            SqlCommand cmd = new SqlCommand("Select " + imgx + " from VEHICLE_PARKING where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.Int).Value = id;

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

                SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE_PARKING (type, img1, img2,typePark,timeIn)" +
            "VALUES (@type, @img1,@img2,@typePark,@timeIn)", this.getConnection);

                cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.type;
                cmd.Parameters.Add("@img1", SqlDbType.Image).Value = vel.Img1.ToArray();
                cmd.Parameters.Add("@img2", SqlDbType.Image).Value = vel.Img2.ToArray();
                cmd.Parameters.Add("@typePark", SqlDbType.Int).Value = vel.typeGui;
                cmd.Parameters.Add("@timeIn", SqlDbType.DateTime).Value = vel.ngayGui;
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

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from VEHICLE_PARKING where type = " + type, this.getConnection);

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

        //List vehicle theo id
        public List<int> danhSachID(int type)
        {
            List<int> lID = new List<int>();
            try
            {
                int soLuong = this.countVehicleType(type);

                if (type != -1 || type != 0)
                {
                    this.openConnection();

                    SqlCommand cmd = new SqlCommand("select id from VEHICLE_PARKING where type = " + type, this.getConnection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    for (int i = 0; i < soLuong; i++)
                    {
                        lID.Add((int)(table.Rows[i]["id"]));
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

                SqlCommand cmd = new SqlCommand("select count(*) as Total from VEHICLE_PARKING", this.getConnection);

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
