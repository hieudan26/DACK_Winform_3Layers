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


        //Update status
        public bool UpdateStatusVehicle(string id, string type_status, int status)
        {
            SqlCommand cmd;
            if (type_status == "FIX")
                cmd = new SqlCommand("update VEHICLE set fix = @status where id = @id", this.getConnection);
            else if (type_status == "WASH")
                cmd = new SqlCommand("update VEHICLE set wash = @status where id = @id", this.getConnection);
            else
                cmd = new SqlCommand("update VEHICLE set park = @status where id = @id", this.getConnection);

            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = status;

            this.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }

        //Ktra ID tồn tại
        public bool CheckID_Exited(string id)
        {
            DataTable table = this.getVehicleByID(id);
            if (table.Rows.Count > 0)
                return true;
            return false;
        }

        //Del vehicle
        public bool DeleteVehicle(string id)
        {
            SqlCommand cmd = new SqlCommand("Delete from VEHICLE where id = @id", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            this.openConnection();
            if (cmd.ExecuteNonQuery() == 1)
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }    

        //Edit_Update thông tin xe gửi
        public bool UpdateInfoVehicle(string id, int loaiXe, MemoryStream img1, MemoryStream img2)
        {
            SqlCommand cmd = new SqlCommand("update VEHICLE set type = @loaiXe, img1 = @img1, img2 = @img2 where id = @id", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@loaiXe", SqlDbType.Int).Value = loaiXe;
            cmd.Parameters.Add("@img1", SqlDbType.Image).Value = img1.ToArray();
            cmd.Parameters.Add("@img2", SqlDbType.Image).Value = img2.ToArray();
            this.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                this.closeConnection();
                return true;
            }
            else
            {
                this.closeConnection();
                return false;
            }
        }
        //lay vehicle bang id
        public DataTable getVehicleByID(string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

            DataTable table = this.getVehicle(cmd);
            return table;
        }

        //them object xe
        public bool insertVehicle(vehicleDTO vel)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE(id,type, img1, img2, park, fix, wash)" +
            "VALUES (@id,@type, @img1,@img2, @park, @fix, @wash)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = vel.id;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.type;
                cmd.Parameters.Add("@img1", SqlDbType.Image).Value = vel.Img1.ToArray();
                cmd.Parameters.Add("@img2", SqlDbType.Image).Value = vel.Img2.ToArray();
                cmd.Parameters.Add("@park", SqlDbType.Int).Value = vel.park;
                cmd.Parameters.Add("@fix", SqlDbType.Int).Value = vel.fix;
                cmd.Parameters.Add("@wash", SqlDbType.Int).Value = vel.wash;
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

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from VEHICLE where type = " + type, this.getConnection);

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

                    SqlCommand cmd = new SqlCommand("select id from VEHICLE where type = " + type, this.getConnection);

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

                SqlCommand cmd = new SqlCommand("select count(*) as Total from VEHICLE", this.getConnection);

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
        public bool checkFullVehicle(int type)
        {
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE where type = @type");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;

            DataTable table = this.getVehicle(cmd);
            if (table.Rows.Count < 100)
                return false;
            else
                return true;
        }


        //list id xe gửi trong ngày
        /*
        public List<int> danhSachID_InDay(int type)
        {
            List<int> lID = new List<int>();
            try
            {
                //int soLuong = this.countVehicleType(type);

                this.openConnection();

                DateTime curr = DateTime.Now;
                string start = " 00:00:00";
                string end = " 23:59:59";
                string tmp = curr.ToString("yyyy-MM-dd");

                SqlCommand cmd = new SqlCommand("select id from VEHICLE_PARKING where timeIn between '" + tmp + start + "' and '" + tmp + end + "'and type = " + type, this.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    lID.Add((int)(table.Rows[i]["id"]));
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
        */
        //lấy ra số lượng xe TRONG NGÀY theo LOẠI
        /*
        public int countVehicle_byType_InDay(int type)
        {
            try
            {
                this.openConnection();

                DateTime curr = DateTime.Now;
                string start = " 00:00:00";
                string end = " 23:59:59";
                string tmp = curr.ToString("yyyy-MM-dd");

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from VEHICLE_PARKING where timeIn between '" + tmp + start + "' and '" + tmp + end + "' and type = " + type, this.getConnection);

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

        //lấy ra danh sách các xe gửi quá hạn
        public DataTable getVehicleExpired()
        {
            SqlCommand cmd = new SqlCommand("select * from VEHICLE_PARKING");
            DataTable table = this.getVehicle(cmd);
            table.AcceptChanges();

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow item = table.Rows[i];
                if (this.compareDateTime_theoTypeGui((int)item["type"], (DateTime)item["timeIn"]) == 1)
                    table.Rows.Remove(item);
            }
            
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
                return null;       
        }

        //trả về 1 => quá tgian
        private int compareDateTime_theoTypeGui(int typeGui, DateTime timeIn)
        {
            DateTime cur = DateTime.Now;
            if (typeGui == 0) //Gửi theo giờ
            {
                cur = cur.AddHours(-1); // Lấy datetime hiện tại -1 giờ
                //so sánh datetime vào vs datetime hiện tại -1 giờ nếu datetime hiện tại -1 giờ <= datetime vào thì chưa quá giờ
                return this.compareDatetime(timeIn, cur);
                
            }    
            else if (typeGui == 1) //Gửi theo ngày
            {
                cur = cur.AddDays(-1); // lấy datetime hiện tại -1 ngày
                return this.compareDatetime(timeIn, cur);
            }
            else if (typeGui == 2) //Gửi theo tuần
            {
                cur = cur.AddDays(-7);
                return this.compareDatetime(timeIn, cur);
            }    
            else //Gửi theo tháng
            {
                cur = cur.AddMonths(-1);
                return this.compareDatetime(timeIn, cur);
            }    
        }

        //private hàm con so sánh trả về 1 khi quá tgian, 0 khi vẫn còn tgian
        private int compareDatetime(DateTime timeIn, DateTime cur)
        {
            if (timeIn.CompareTo(cur) == -1 || timeIn.Equals(cur) == true)
            {
                return 0;
            }    
            else
            {
                return 1;
            }    
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
        public int getLoaiGuiXe(string id)
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
        */

    }
}
