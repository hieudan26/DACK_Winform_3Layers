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

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable countTypeXe(string idEmployee, int typeXe)
        {
            SqlCommand cmd = new SqlCommand("select count(CONTRACT_CHOTHUE.id) from CONTRACT_CHOTHUE, VEHICLE where CONTRACT_CHOTHUE.idVehicle = VEHICLE.id and idEmployee = @id and type = @type group by CONTRACT_CHOTHUE.id");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = typeXe;
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = idEmployee;
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

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable count(string idEmployee)
        {
            SqlCommand cmd = new SqlCommand("select count(CONTRACT_CHOTHUE.id), sum(TotalCost) from CONTRACT_CHOTHUE where idEmployee = @id group by id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = idEmployee;
            DataTable table = this.getContract_ChoThue(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //del contract
        public bool RemoveContract(string idContract)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("delete from CONTRACT_CHOTHUE where id = @id", this.getConnection);
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

        //get all contract expired by idemployee
        public DataTable getAllContractChoThue_Expired(string idEmployee)
        {
            DateTime CurrTime = DateTime.Now;
            string currtime = CurrTime.ToString("yyyy-MM-dd");

            SqlCommand cmd = new SqlCommand("select id as ID, idCustomer as [ID Customer], idVehicle as [ID Vehicle], dateSign as [Ngay hieu luc], TotalCost as [Gia tri HD] from CONTRACT_CHOTHUE where dateSign > '" + currtime + "' and idEmployee = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = idEmployee;

            DataTable table = this.getContract_ChoThue(cmd);

            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //get all id vehicle by idEmployee
        public DataTable getAllVehicle_ContractChoThueByIDEmployee(string IDEmployee)
        {
            SqlCommand cmd = new SqlCommand("select id as ID, idCustomer as [ID Customer], idVehicle as [ID Vehicle], dateSign as [Ngay hieu luc], TotalCost as [Gia tri HD] from CONTRACT_CHOTHUE where idEmployee = @id");
            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = IDEmployee;

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
