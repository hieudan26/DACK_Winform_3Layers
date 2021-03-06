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
    public class customer_VehicleDAL : MyDB
    {
        public DataTable getcustomer_Vehicle(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get full info xe được quyền cho thuê
        public DataTable getFullInfoVehicle_Thue()
        {
            SqlCommand cmd = new SqlCommand("select id as ID, type as [Type], img1 as IMG1, img2 as IMG2 from CUSTOMER_VEHICLE, VEHICLE where CUSTOMER_VEHICLE.id_Veh = VEHICLE.id");

            DataTable table = this.getcustomer_Vehicle(cmd);

            if (table.Rows.Count > 0)
            {
                return table;
            }    
            else
            {
                return null;
            }    
        }

        //get all vehicle by id cus
        public DataTable getAllVehicle_IdCus(string id_cus)
        {
            SqlCommand cmd = new SqlCommand("select * from CUSTOMER_VEHICLE where id_cus = @id");

            cmd.Parameters.Add("@id", SqlDbType.NChar).Value = id_cus;
            
            DataTable table = this.getcustomer_Vehicle(cmd);
            
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get all distinct
        public DataTable getAll_distinct()
        {
            SqlCommand cmd = new SqlCommand("select distinct(id_Cus) from CUSTOMER_VEHICLE");
            DataTable table = this.getcustomer_Vehicle(cmd);
            if (table.Rows.Count > 0)
            {
                return table;
            }
            else
            {
                return null;
            }
        }

        //get all
        public DataTable getAll()
        {
            SqlCommand cmd = new SqlCommand("select * from CUSTOMER_VEHICLE");
            DataTable table = this.getcustomer_Vehicle(cmd);
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
        public bool insertcustomer_Vehicle(customer_VehicleDTO customer_VehicleDTO)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO CUSTOMER_VEHICLE(id_Cus, id_Veh)" +
            "VALUES (@id_Cus, @id_Veh)", this.getConnection);
                cmd.Parameters.Add("@id_Cus", SqlDbType.NChar).Value = customer_VehicleDTO.id_Cus;
                cmd.Parameters.Add("@id_Veh", SqlDbType.NChar).Value = customer_VehicleDTO.id_Veh;

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
