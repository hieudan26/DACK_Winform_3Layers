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
            string NameDepart = "";
            if (typeTho == "Bảo Vệ")
            {
                NameDepart = "Phòng Bảo Vệ";
            }    
            else if (typeTho == "Thợ Sửa")
            {
                NameDepart = "Phòng Sửa Xe";
            }    
            else
            {
                NameDepart = "Phòng Rửa Xe";
            }

            string idDep = this.phongBanDAL.getPhongBan_byName(NameDepart).Rows[0]["id"].ToString();

            try {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update EMPLOYEES set name = @name, departmentId = @deptid, birthdate = @dob, gender = @gender, typeTho = @typeTho, img = @img where id = @id", this.getConnection);
                cmd.Parameters.Add("@name", SqlDbType.NChar).Value = name;
                cmd.Parameters.Add("@deptid", SqlDbType.NChar).Value = idDep;
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
            SqlCommand cmd = new SqlCommand("select * from EMPLOYEES where id = @id");
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

        //tìm kiếm hỗn hợp 
        public DataTable getEmployee_ByIDandName(string ID_name)
        {
            SqlCommand cmd = new SqlCommand("select * from EMPLOYEES where concat(id, name) like N'%" + ID_name + "%'");
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
            SqlCommand cmd = new SqlCommand("select * from EMPLOYEES");
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
            SqlCommand cmd = new SqlCommand("select * from EMPLOYEES where typeTho = @typeTho");
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

                SqlCommand cmd = new SqlCommand("INSERT INTO EMPLOYEES(id, name, departmentId, birthdate, gender, typeTho, img)" +
            "VALUES (@id, @name, @depId, @birthdate, @gender, @typeTho, @img)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = nhanVienDTO.id;
                cmd.Parameters.Add("@name", SqlDbType.NChar).Value = nhanVienDTO.name;
                cmd.Parameters.Add("@depId", SqlDbType.NChar).Value = nhanVienDTO.departmentId;
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
