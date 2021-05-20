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
    public class shift_NhanVienDAL : MyDB
    {
        public DataTable getALL(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        public DataTable getIdName_ByCaThu(int Ca, string Thu)
        {
            SqlCommand cmd = new SqlCommand("select id, name from SHIFT_NhanVien, EMPLOYEES where id = id_NV and " + Thu + " = @Ca");
            cmd.Parameters.Add("@Ca", SqlDbType.Int).Value = Ca;

            DataTable table = this.getALL(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //Gán bảng new qua bảng show
        public bool InsertIntoOld_FormNew()
        {
            SqlCommand cmd = new SqlCommand("insert into SHIFT_NhanVien select * from SHIFT_NhanVien_New", this.getConnection);
            this.openConnection();

            if (cmd.ExecuteNonQuery() == 1)
            {
                this.closeConnection();
                return true;
            }
            else
            {
                return false;
            }
        }

        //Reset new 
        public bool ResetShift_NhanVien_New()
        {
            SqlCommand cmd = new SqlCommand("Delete from SHIFT_NhanVien_New", this.getConnection);
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

        //Reset
        public bool ResetShift_NhanVien()
        {
            SqlCommand cmd = new SqlCommand("Delete from SHIFT_NhanVien", this.getConnection);
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

        public DataTable getALLShift_NhanVien_New()
        {
            SqlCommand cmd = new SqlCommand("select id, name, Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, ChuNhat from SHIFT_NhanVien_New, EMPLOYEES where id = id_NV");
            DataTable table = this.getALL(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
                return null;
        }

        public DataTable getALLShift_NhanVien()
        {
            SqlCommand cmd = new SqlCommand("select id, name, Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, ChuNhat from SHIFT_NhanVien, EMPLOYEES where id = id_NV");
            DataTable table = this.getALL(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
                return null;
        }

        public bool insertShift(shift_NhanVienDTO shift)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("insert into SHIFT_NhanVien_New (id_NV, Thu2, Thu3, Thu4, Thu5, Thu6, Thu7, ChuNhat) values (@id, @t2, @t3, @t4, @t5, @t6, @t7, @cn)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = shift.id_NV;
                cmd.Parameters.Add("@t2", SqlDbType.Int).Value = shift.Thu2;
                cmd.Parameters.Add("@t3", SqlDbType.Int).Value = shift.Thu3;
                cmd.Parameters.Add("@t4", SqlDbType.Int).Value = shift.Thu4;
                cmd.Parameters.Add("@t5", SqlDbType.Int).Value = shift.Thu5;
                cmd.Parameters.Add("@t6", SqlDbType.Int).Value = shift.Thu6;
                cmd.Parameters.Add("@t7", SqlDbType.Int).Value = shift.Thu7;
                cmd.Parameters.Add("@cn", SqlDbType.Int).Value = shift.ChuNhat;

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
