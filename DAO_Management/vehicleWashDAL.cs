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
    public class vehicleWashDAL : MyDB
    {
        public DataTable getVehicleWash(SqlCommand cmd)
        {
            cmd.Connection = this.getConnection;
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }

        //get status
        public DataTable getStatus(string id)
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, park, fix, wash from VEHICLE_WASH, VEHICLE where VEHICLE_WASH.id = VEHICLE.id and VEHICLE.id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicleWash(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //delete
        public bool DeleteVehicleWash(string id)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from VEHICLE_WASH where id = @id", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
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

        //lay giá dịch vụ
        public int getWash_fee(string id)
        {
            SqlCommand cmd = new SqlCommand("Select * from VEHICLE_WASH inner join SERVICE_VEHICLE_WASH on VEHICLE_WASH.type = SERVICE_VEHICLE_WASH.type and VEHICLE_WASH.id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicleWash(cmd);
            if (table.Rows.Count > 0)
                return (int)table.Rows[0]["wash_fee"];
            else
                return -1;
        }

        //lay vehicle wash bang id gần đúng
        public DataTable getVehicleByID_GanDung(string id)
        {
            SqlCommand cmd = new SqlCommand("Select VEHICLE_WASH.id, VEHICLE_WASH.type, img1, img2 from VEHICLE_WASH inner join VEHICLE on VEHICLE_WASH.id = VEHICLE.id " +
                "where VEHICLE.id like N'%" + id + "%'");
            //cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicleWash(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //get all
        public DataTable getAllVehicleWash()
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE_WASH.id, VEHICLE_WASH.type, img1, img2 from VEHICLE_WASH, VEHICLE where VEHICLE.id = VEHICLE_WASH.id");
            DataTable table = this.getVehicleWash(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //filter by type
        public DataTable getDataVehicleWash_ByType(int type)
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE_WASH.id, VEHICLE_WASH.type, img1, img2 from VEHICLE_WASH, VEHICLE where VEHICLE.id = VEHICLE_WASH.id and VEHICLE.type = @type");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            DataTable table = this.getVehicleWash(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //insert xe rửa
        public bool insertVehicleWash(vehicleWashDTO vel)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE_WASH (id, type)" +
            "VALUES (@id, @type)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = vel.id;
                cmd.Parameters.Add("@type", SqlDbType.Int).Value = vel.type;
                
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
