using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;
using DTO_Management;

namespace GUI_Management
{
    public class vehicleParkingDAL : MyDB
    {
        vehicleDAL velDAL = new vehicleDAL();
        public DataTable getVehicle(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get status
        public DataTable getStatus(string id)
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, park, fix, wash from VEHICLE_PARKING, VEHICLE where VEHICLE_PARKING.id = VEHICLE.id and VEHICLE.id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicle(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //Del vehicle
        public bool DeleteVehicle(string id)
        {
            SqlCommand cmd = new SqlCommand("Delete from VEHICLE_PARKING where id = @id", this.getConnection);
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
        public bool UpdateInfoVehicle(string id,  int loaiGui, DateTime timeIn)
        {
            SqlCommand cmd = new SqlCommand("update VEHICLE_PARKING set typePark = @loaiGui, timeIn = @tI where id = @id", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@loaiGui", SqlDbType.Int).Value = loaiGui;
            cmd.Parameters.Add("@tI", SqlDbType.DateTime).Value = timeIn;

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

        //list id xe gửi trong ngày
        public List<string> danhSachID_InDay(int type)
        {
            List<string> lID = new List<string>();
            try
            {

                this.openConnection();

                DateTime curr = DateTime.Now;
                string start = " 00:00:00";
                string end = " 23:59:59";
                string tmp = curr.ToString("yyyy-MM-dd");

                SqlCommand cmd = new SqlCommand("select VEHICLE.id from VEHICLE_PARKING inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id " +
                    "where VEHICLE_PARKING.timeIn between '" + tmp + start + "' and '" + tmp + end + "'and VEHICLE.type = " + type, this.getConnection);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    lID.Add((string)(table.Rows[i]["id"]));
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
        

        //lấy ra số lượng xe TRONG NGÀY theo LOẠI
        public int countVehicle_byType_InDay(int type)
        {
            try
            {
                this.openConnection();

                DateTime curr = DateTime.Now;
                string start = " 00:00:00";
                string end = " 23:59:59";
                string tmp = curr.ToString("yyyy-MM-dd");

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from VEHICLE_PARKING inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id " +
                    "where timeIn between '" + tmp + start + "' and '" + tmp + end + "' and type = " + type, this.getConnection);

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
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE inner join VEHICLE_PARKING on VEHICLE_PARKING.id = VEHICLE.id");
            DataTable table = this.getVehicle(cmd);
            table.AcceptChanges();

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow item = table.Rows[i];
                if (this.compareDateTime_theoTypeGui((int)item["typePark"], (DateTime)item["timeIn"]) == 1)
                    table.Rows.Remove(item);
            }

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
                return null;
        }

        //Xe khoong heet han
        public DataTable getVehicleNotExpired()
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE inner join VEHICLE_PARKING on VEHICLE_PARKING.id = VEHICLE.id");
            DataTable table = this.getVehicle(cmd);
            table.AcceptChanges();

            for (int i = table.Rows.Count - 1; i >= 0; i--)
            {
                DataRow item = table.Rows[i];
                if (this.compareDateTime_theoTypeGui((int)item["typePark"], (DateTime)item["timeIn"]) == 0)
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
            SqlCommand cmd = new SqlCommand("select * from FEE_PARKING where dayWeek = @dayWeek", this.getConnection);
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
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;

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

        //lay vehicle bang id gần đúng
        public DataTable getVehicleByID_GanDung(string id)
        {
            SqlCommand cmd = new SqlCommand("Select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE_PARKING inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id " +
                "where VEHICLE.id like N'%" + id + "%'");
            //cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicle(cmd);
            return table;
        }

        //lay vehicle bang id
        public DataTable getVehicleByID(string id)
        {
            SqlCommand cmd = new SqlCommand("Select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE_PARKING inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id " +
                "where VEHICLE.id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicle(cmd);
            return table;
        }

        //lay toan bo xe
        public DataTable getAllVehicle()
        {
            SqlCommand cmd = new SqlCommand("Select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE_PARKING inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id ", this.con);
            DataTable table = this.getVehicle(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //them object xe
        public bool insertVehicle(vehicleParkingDTO vel)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE_PARKING (id, typePark, timeIn)" +
            "VALUES (@id, @type, @timeIn)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = vel.id;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.typeGui;
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

                SqlCommand cmd = new SqlCommand("select count(*) as SoLuong from VEHICLE_PARKING " +
                    "inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id " +
                    "where type = " + type, this.getConnection);

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
        public List<string> danhSachID(int type)
        {
            List<string> lID = new List<string>();
            try
            {
                int soLuong = this.countVehicleType(type);

                if (type != -1 || type != 0)
                {
                    this.openConnection();

                    SqlCommand cmd = new SqlCommand("select VEHICLE.id from VEHICLE_PARKING " +
                        "inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id" +
                        " where type = " + type, this.getConnection);

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    for (int i = 0; i < soLuong; i++)
                    {
                        lID.Add((string)(table.Rows[i]["id"]));
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

        public DataTable danhSachXetheoLoai(int type)
        {
            this.openConnection();
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, VEHICLE.type, img1, img2, VEHICLE_PARKING.typePark, VEHICLE_PARKING.timeIn from VEHICLE_PARKING " +
                "inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id" +
                " where type = " + type, this.getConnection);
            return this.getVehicle(cmd);
                   
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

        public bool checkFullVehicle(int type)
        {
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE_PARKING " +
                "inner join VEHICLE on VEHICLE_PARKING.id = VEHICLE.id" +
                " where type = @type");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;

            DataTable table = this.getVehicle(cmd);
            if (table.Rows.Count < 100)
                return false;
            else
                return true;
        }
    }
}
