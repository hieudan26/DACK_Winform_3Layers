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
    public class vehicleFixDAL : MyDB
    {
        public DataTable getVehicleFix(SqlCommand cmd)
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
            SqlCommand cmd = new SqlCommand("select VEHICLE.id, park, fix, wash from VEHICLE_FIX, VEHICLE where VEHICLE_FIX.id = VEHICLE.id and VEHICLE.id = @id");
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //check dịch vụ đã đang đki rồi ko thể đki thêm đc nữa
        public bool VerifyIDandService_Existed(string id, string service)
        {
            SqlCommand cmd = new SqlCommand("select * from VEHICLE_FIX where id = @id and service = @service", this.getConnection);
            cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = service;
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
            {
                return true;
            }    
            else
            {
                return false;
            }    
        }

        //del vehicle fix xóa dịch vụ của từng thằng
        public bool DeleteVehicleFix(string id, string service)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("Delete from VEHICLE_FIX where id = @id and service = @service", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = service;
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

        //lay vehicle fix bang id gần đúng
        public DataTable getVehicleByID_GanDung(string id)
        {
            SqlCommand cmd = new SqlCommand("Select VEHICLE_FIX.id, service, type, img1, img2  from VEHICLE_FIX inner join VEHICLE on VEHICLE_FIX.id = VEHICLE.id " +
                "where VEHICLE.id like N'%" + id + "%'");
            //cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = id;
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //get datatable theo type
        public DataTable getVehicleFix_info_byType(int type)
        {
            SqlCommand cmd = new SqlCommand("select VEHICLE_FIX.id, service, type, img1, img2  from VEHICLE_FIX, VEHICLE where VEHICLE.id = VEHICLE_FIX.id and VEHICLE.type = @type");
            cmd.Parameters.Add("@type", SqlDbType.Int).Value = type;
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //get datatable thông tin vehicle fix tất cả distinct
        public DataTable getVehicleFix_info_all_distinct()
        {
            SqlCommand cmd = new SqlCommand("select distinct VEHICLE_FIX.id, type, CAST(img1 AS VARBINARY(8000)) as img1, CAST(img2 AS VARBINARY(8000)) as img2  from VEHICLE_FIX, VEHICLE where VEHICLE.id = VEHICLE_FIX.id");
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }

        //get datatable thông tin vehicle fix tất cả
        public DataTable getVehicleFix_info_all()
        {
            SqlCommand cmd = new SqlCommand("select distinct VEHICLE_FIX.id, type  from VEHICLE_FIX, VEHICLE where VEHICLE.id = VEHICLE_FIX.id");
            DataTable table = this.getVehicleFix(cmd);
            if (table.Rows.Count > 0)
                return table;
            else
                return null;
        }    

        //insert vafp table VEHICLE_FIX
        public bool insertVehicle_FIX(vehicleFixDTO velFIX)
        {
            try
            {
                this.openConnection();

                SqlCommand cmd = new SqlCommand("INSERT INTO VEHICLE_FIX (id, service)" +
            "VALUES (@id, @service)", this.getConnection);
                cmd.Parameters.Add("@id", SqlDbType.NVarChar).Value = velFIX.id;
                cmd.Parameters.Add("@service", SqlDbType.NVarChar).Value = velFIX.service;
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
