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
    public class customerDAL : MyDB
    {
        public DataTable getCustomer(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get all khách hàng cho thuê xe
        public DataTable getAllCustomer_ChoThue()
        {
            SqlCommand cmd = new SqlCommand("select * from CUSTOMER where status = @status");
            cmd.Parameters.Add("@status", SqlDbType.Int).Value = 1;

            DataTable table = this.getCustomer(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //del khách hàng
        public bool DelCustomer(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CUSTOMER where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = id;
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

        //Update info khách hàng
        public bool UpdateCustomer(customerDTO customerDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("update CUSTOMER set fname = @fname, lname = @lname, gender = @gender, address = @address, phone = @phone where id = @id", this.getConnection);
                cmd.Parameters.Add("@fname", SqlDbType.NChar).Value = customerDTO.fname;
                cmd.Parameters.Add("@lname", SqlDbType.NChar).Value = customerDTO.lname;
                cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = customerDTO.gender;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerDTO.address;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = customerDTO.phone;
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = customerDTO.id;

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

        //get Datatable by id
        public DataTable getData_byId(string id)
        {
            SqlCommand cmd = new SqlCommand("select * from CUSTOMER where id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = id;
            DataTable table = this.getCustomer(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //insert customer vô bảng
        public bool insertCustomer(customerDTO customerDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER(id, fname, lname, gender, address, phone, status)" +
            "VALUES (@id, @fname, @lname, @gender, @address, @phone, @status)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = customerDTO.id;
                cmd.Parameters.Add("@fname", SqlDbType.NChar).Value = customerDTO.fname;
                cmd.Parameters.Add("@lname", SqlDbType.NChar).Value = customerDTO.lname;
                cmd.Parameters.Add("@gender", SqlDbType.NChar).Value = customerDTO.gender;
                cmd.Parameters.Add("@address", SqlDbType.NVarChar).Value = customerDTO.address;
                cmd.Parameters.Add("@phone", SqlDbType.Int).Value = customerDTO.phone;
                cmd.Parameters.Add("@status", SqlDbType.Int).Value = customerDTO.status;

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
