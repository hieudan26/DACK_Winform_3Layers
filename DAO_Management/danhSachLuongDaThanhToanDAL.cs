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
    public class danhSachLuongDaThanhToanDAL : MyDB
    {
        public DataTable getLuong(SqlCommand cmd)
        {
            try {
                cmd.Connection = this.getConnection;
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable table = new DataTable();
                adapter.Fill(table);
                return table;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return null;
        }

        //sum luong by type
        public DataTable sum(string typeTho)
        {
            SqlCommand cmd = new SqlCommand("select sum(Luong) as SUM from LISTSALARY_DATHANHTOAN left join EMPLOYEES on LISTSALARY_DATHANHTOAN.id = EMPLOYEES.id where typeTho = @typeTho group by LISTSALARY_DATHANHTOAN.id");
            cmd.Parameters.Add("@typeTho", SqlDbType.NChar).Value = typeTho;

            DataTable table = this.getLuong(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //get full info nhan viên
        public DataTable getFullInfo()
        {
            SqlCommand cmd = new SqlCommand("select LISTSALARY_DATHANHTOAN.id as ID, name as [Full Name], typeTho as [Loai Tho], ngayThanhToan as [Ngay Thanh Toan], Luong from LISTSALARY_DATHANHTOAN left join EMPLOYEES on LISTSALARY_DATHANHTOAN.id = EMPLOYEES.id");

            DataTable table = this.getLuong(cmd);

            return table;
        }

        //insert
        public bool insert(danhSachLuongDaThanhToanDTO danhSachLuongDaThanhToanDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO LISTSALARY_DATHANHTOAN(id, ngayThanhToan, Luong)" +
            "VALUES (@id, @date, @Luong)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = danhSachLuongDaThanhToanDTO.id;
                cmd.Parameters.Add("@date", SqlDbType.Date).Value = danhSachLuongDaThanhToanDTO.ngayThanhToan;
                cmd.Parameters.Add("@Luong", SqlDbType.Float).Value = danhSachLuongDaThanhToanDTO.Luong;
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
