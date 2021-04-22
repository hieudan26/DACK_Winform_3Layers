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
    public class nhanVienDAL : MyDB
    {
        public DataTable getEmployee(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //Del nhân viên
        public bool DelEmployee(string IDEmployee)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from EMPLOYEES where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = IDEmployee;
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
            cmd.Parameters.Add("@typeTho", SqlDbType.NVarChar).Value = typeTho;
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
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = nhanVienDTO.id;
                cmd.Parameters.Add("@name", SqlDbType.NVarChar).Value = nhanVienDTO.name;
                cmd.Parameters.Add("@depId", SqlDbType.NVarChar).Value = nhanVienDTO.departmentId;
                cmd.Parameters.Add("@birthdate", SqlDbType.Date).Value = nhanVienDTO.birthdate;
                cmd.Parameters.Add("@gender", SqlDbType.NVarChar).Value = nhanVienDTO.gender;
                cmd.Parameters.Add("@typeTho", SqlDbType.NVarChar).Value = nhanVienDTO.typeTho;
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
