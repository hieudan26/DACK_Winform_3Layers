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
    public class nhanVienDAL : MyDB
    {
        phongBanDAL phongBanDAL = new phongBanDAL();

        public DataTable getEmployee(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //count nhân viên theo loại
        public int countEmployee_byType(string typeTho)
        {
            SqlCommand cmd = new SqlCommand("select count(*) as count from EMPLOYEES where typeTho = @tT");
            cmd.Parameters.Add("@tT", SqlDbType.NChar).Value = typeTho;

            DataTable table = this.getEmployee(cmd);

            return int.Parse(table.Rows[0]["count"].ToString());
        }

        //update thông tin nhân viên theo id
        public bool UpdateInfoEmployee(string name, DateTime dob, string gender, string typeTho, MemoryStream img,string IdEmployee)
        {
            try {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update EMPLOYEES set name = @name, birthdate = @dob, gender = @gender, typeTho = @typeTho, img = @img where id = @id", this.getConnection);
                cmd.Parameters.Add("@name", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@dob", SqlDbType.Date).Value = dob;
                cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;
                cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = img.ToArray();
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IdEmployee;

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

        //Del nhân viên
        public bool DelEmployee(string IDEmployee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from EMPLOYEES where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDEmployee;
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

        //tìm kiếm nhân viên theo id_cmnd
        public DataTable getEmployee_byID(string id)
        {
            SqlCommand cmd = new SqlCommand("select select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp theo gender và gender giữa 2 ngày
        public DataTable getEmployee_ByIDandNameGenderGender_Giua2Ngay(string ID_name, string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%' and (gender = @gender1 or gender = @gender2) and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@gender1", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gender2", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp theo gender và gender
        public DataTable getEmployee_ByIDandNameGenderGender(string ID_name, string gender1, string gender2)
        {
            SqlCommand cmd = new SqlCommand("select select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%' and (gender = @gender1 or gender = @gender2)");
            cmd.Parameters.Add("@gender1", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gender2", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp theo gender giữa 2 ngày
        public DataTable getEmployee_ByIDandNameGender_Giua2Ngay(string ID_name, string gender, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%' and gender = @gender and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp theo gender
        public DataTable getEmployee_ByIDandNameGender(string ID_name, string gender)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%' and gender = @gender");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp giữa 2 ngày
        public DataTable getEmployee_ByIDandName_Giua2Ngay(string ID_name, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%' and (birthdate between '" + date1 + "' and '" + date2 + "')");
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //tìm kiếm hỗn hợp 
        public DataTable getEmployee_ByIDandName(string ID_name)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%'");
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //get tất cả nhân viên theo 2giới tính, giữa 2 ngày
        public DataTable getAllEmployeesGenderAndGender_Giua2Ngay(string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where (gender = @gender or gender = @gen) and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gen", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get tất cả nhân viên theo 2giới tính
        public DataTable getAllEmployeesGenderAndGender(string gender1, string gender2)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where (gender = @gender or gender = @gen)");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gen", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get tất cả nhân viên theo giới tính giữa 2 ngày
        public DataTable getAllEmployeesGender_Giua2Ngay(string gender, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where gender = @gender and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get tất cả nhân viên theo giới tính
        public DataTable getAllEmployeesGender(string gender)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where gender = @gender");
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get tất cả nhân viên giữa 2 ngày
        public DataTable getAllEmployees_Giua2Ngay(DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where (birthdate between '" + date1 + "' and '" + date2 + "')");
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get tất cả nhân viên
        public DataTable getAllEmployees()
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES");
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho và giới tính và giới tính giữa 2 ngày
        public DataTable getNv_typeThoGenderAndGender_Giua2Ngay(string typeTho, string gender1, string gender2, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho and (gender = @gender or gender = @gen) and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gen", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho và giới tính và giới tính
        public DataTable getNv_typeThoGenderAndGender(string typeTho, string gender1, string gender2)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho and (gender = @gender or gender = @gen)");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender1;
            cmd.Parameters.Add("@gen", SqlDbType.NChar).Value = gender2;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho và giới tính giữa 2 ngày
        public DataTable getNv_typeThoGender_Giua2Ngay(string typeTho, string gender, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho and gender = @gender and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho và giới tính
        public DataTable getNv_typeThoGender(string typeTho, string gender)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho and gender = @gender");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = gender;

            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho giữa 2 ngày
        public DataTable getNv_typeTho_Giua2Ngay(string typeTho, DateTime dt1, DateTime dt2)
        {
            string date1 = dt1.ToString("yyyy-MM-dd");
            string date2 = dt2.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho and (birthdate between '" + date1 + "' and '" + date2 + "')");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get nhân viên theo typeTho
        public DataTable getNv_typeTho(string typeTho)
        {
            SqlCommand cmd = new SqlCommand("select id as [ID CCCD], name as [Full name], birthdate as [Date of birth], gender as Gender, typeTho as [Loai tho], img as [Picture CCCD] from EMPLOYEES where typeTho = @typeTho");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;
            DataTable table = this.getEmployee(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //insert nhân viên vô bảng
        public bool insertEmployee(nhanVienDTO nhanVienDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEES(id, name, birthdate, gender, typeTho, img)" +
            "VALUES (@id, @name, @birthdate, @gender, @typeTho, @img)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVienDTO.id;
                cmd.Parameters.Add("@name", SqlDbType.NChar).Value = nhanVienDTO.name;
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = nhanVienDTO.birthdate;
                cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = nhanVienDTO.gender;
                cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = nhanVienDTO.typeTho;
                cmd.Parameters.Add("@img", SqlDbType.Image).Value = nhanVienDTO.Img.ToArray();

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
