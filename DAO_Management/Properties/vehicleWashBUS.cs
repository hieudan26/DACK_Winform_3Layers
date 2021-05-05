using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO_Management;
using DAL_Management;
using System.Data;

namespace BUS_Management
{
    public class vehicleWashBUS
    {
        vehicleWashDAL vehWashDAL = new vehicleWashDAL();

        //get status
        public DataTable getStatus(string id)
        {
            return this.vehWashDAL.getStatus(id);
        }

        //delete
        public bool DeleteVehicleWash(string id)
        {
            return this.vehWashDAL.DeleteVehicleWash(id);
        }

        //get wash_fee
        public int getWash_fee(string id)
        {
            return this.vehWashDAL.getWash_fee(id);
        }

        //get by id gần đúng
        public DataTable getVehicleByID_GanDung(string id)
        {
            return this.vehWashDAL.getVehicleByID_GanDung(id);
        }

        //get all
        public DataTable getAllVehicleWash()
        {
            return this.vehWashDAL.getAllVehicleWash();
        }

        //get data by type
        public DataTable getDataVehicleWash_ByType(int type)
        {
            return this.vehWashDAL.getDataVehicleWash_ByType(type);
        }

        //insert
        public bool insertVehicleWash(vehicleWashDTO vehWashDTO)
        {
            return this.vehWashDAL.insertVehicleWash(vehWashDTO);
        }
    }
}
