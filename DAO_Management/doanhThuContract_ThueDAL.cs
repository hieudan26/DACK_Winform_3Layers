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
    public class doanhThuContract_ThuDAL : MyDB
    {
        public DataTable getContract(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get số hợp đồng thuê xe và tổng thu
        public DataTable CountContract_SumTotal(string idEmployee)
        {
            SqlCommand cmd = new SqlCommand("select count(id) as SLHD, sum(TotalCost) as TDT from DOANHTHUCONTRACT_THUE where idEmployee = @id group by id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = idEmployee;

            DataTable table = this.getContract(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }    
        }

        //Remove
        public bool RemovedoanhThuContract_Thu(string idContract)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from DOANHTHUCONTRACT_THUE where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NChar).Value = idContract;
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

        //insert
        public bool insertdoanhThuContract_Thue(doanhThuContract_ThueDTO doanhThuContract_ThueDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO DOANHTHUCONTRACT_THUE(id, TotalCost, idEmployee)" +
            "VALUES (@id1, @TotalCost, @idEmployee)", this.getConnection);
                cmd.Parameters.Add("@id1", SqlDbType.NChar).Value = doanhThuContract_ThueDTO.id;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = doanhThuContract_ThueDTO.TotalCost;
                cmd.Parameters.Add("@idEmployee", SqlDbType.NChar).Value = doanhThuContract_ThueDTO.idEmployee;

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
