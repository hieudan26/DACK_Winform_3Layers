using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class vehicleFixBUS
    {
        vehicleFixDAL vehFixDAL = new vehicleFixDAL();

        //get datatable thông tin vehicle fix tất cả distinct
        public DataTable getVehicleFix_info_all_distinct()
        {
            return this.vehFixDAL.getVehicleFix_info_all_distinct();
        }

        //get status
        public DataTable getStatus(string id)
        {
            return this.vehFixDAL.getStatus(id);
        }

        //check dịch vụ của id đó đã sài chưa
        public bool VerifyIDandService_Existed(string id, string service)
        {
            return this.vehFixDAL.VerifyIDandService_Existed(id, service);
        }

        //xoa theo id
        public bool DeleteVehicleFix(string id, string service)
        {
            return this.vehFixDAL.DeleteVehicleFix(id, service);
        }

        //search danh sách gần đúng by id
        public DataTable getVehicleByID_GanDung(string id)
        {
            return this.vehFixDAL.getVehicleByID_GanDung(id);
        }

        //load dgv by type
        public DataTable getVehicleFix_info_byType(int type)
        {
            return this.vehFixDAL.getVehicleFix_info_byType(type);
        }

        //load dgv all
        public DataTable getVehicleFix_info_all()
        {
            return this.vehFixDAL.getVehicleFix_info_all();
        }   

        //insert
        public bool insertVehicle_FIX(vehicleFixDTO vehFixDTO)
        {
            return this.vehFixDAL.insertVehicle_FIX(vehFixDTO);
        }
    }
}
