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
    public class doanhThuContract_ChoThueDAL : MyDB
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
            SqlCommand cmd = new SqlCommand("select count(id) as SLHD, sum(TotalCost) as TDT from DOANHTHUCONTRACT_CHOTHUE where idEmployee = @id");
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
        public bool RemovedoanhThuContract_ChoThue(string idContract)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from DOANHTHUCONTRACT_CHOTHUE where id = @id", this.getConnection);
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
        public bool insertdoanhThuContract_ChoThue(doanhThuContract_ChoThueDTO doanhThuContract_ChoThueDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO DOANHTHUCONTRACT_CHOTHUE(id, TotalCost, idEmployee)" +
            "VALUES (@id1, @TotalCost, @idEmployee)", this.getConnection);
                cmd.Parameters.Add("@id1", SqlDbType.NChar).Value = doanhThuContract_ChoThueDTO.id;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = doanhThuContract_ChoThueDTO.TotalCost;
                cmd.Parameters.Add("@idEmployee", SqlDbType.NChar).Value = doanhThuContract_ChoThueDTO.idEmployee;

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
