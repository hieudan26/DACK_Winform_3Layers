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
    public class contract_ChoThueDAL : MyDB
    {
        public DataTable getContract_ChoThue(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get all id vehicle
        public DataTable getAllVehicle_ContractChoThue()
        {
            SqlCommand cmd = new SqlCommand("select * from CONTRACT_CHOTHUE");

            DataTable table = this.getContract_ChoThue(cmd);

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
        public bool insertContract_ChoThue(contract_ChoThueDTO contract_ChoThueDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO CONTRACT_CHOTHUE(id, idCustomer, idVehicle, dateSign, TotalCost, idEmployee)" +
            "VALUES (@id1, @id2, @id3, @ds, @TotalCost, @idEmployee)", this.getConnection);
                cmd.Parameters.Add("@id1", SqlDbType.NChar).Value = contract_ChoThueDTO.id;
                cmd.Parameters.Add("@id2", SqlDbType.NChar).Value = contract_ChoThueDTO.idCustomer;
                cmd.Parameters.Add("@id3", SqlDbType.NChar).Value = contract_ChoThueDTO.idVehicle;
                cmd.Parameters.Add("@ds", SqlDbType.Date).Value = contract_ChoThueDTO.dateSign;
                cmd.Parameters.Add("@TotalCost", SqlDbType.Float).Value = contract_ChoThueDTO.TotalCost;
                cmd.Parameters.Add("@idEmployee", SqlDbType.NChar).Value = contract_ChoThueDTO.idEmployee;

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
