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
    public class contract_ThueDAL : MyDB
    {
        public DataTable getContract_Thue(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get all id vehicle
        public DataTable getAllVehicle_ContractThue()
        {
            SqlCommand cmd = new SqlCommand("select * from CONTRACT_THUE");

            DataTable table = this.getContract_Thue(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //insert
        public bool insertContract_Thue(contract_ThueDTO contract_ThueDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO CONTRACT_THUE(id, idCustomer, idVehicle, dateSign, TotalCost, idEmployee)" +
            "VALUES (@id1, @id2, @id3, @ds, @TotalCost, @idEmployee)", this.getConnection);
                cmd.Parameters.Add("@id1", SqlDbType.NChar).Value = contract_ThueDTO.id;
                cmd.Parameters.Add("@id2", SqlDbType.NChar).Value = contract_ThueDTO.idCustomer;
                cmd.Parameters.Add("@id3", SqlDbType.NChar).Value = contract_ThueDTO.idVehicle;
                cmd.Parameters.Add("@ds", SqlDbType.Date).Value = contract_ThueDTO.dateSign;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = contract_ThueDTO.TotalCost;
                cmd.Parameters.Add("@idEmployee", SqlDbType.NChar).Value = contract_ThueDTO.idEmployee;

                if (cmd.ExecuteNonQuery() == 1)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:1 ", ex.Message);
            }
            finally
            {
                this.closeConnection();
            }
            return false;
        }
    }
}
