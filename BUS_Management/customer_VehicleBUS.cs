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
    public class customer_VehicleBUS
    {
        customer_VehicleDAL customer_VehicleDAL = new customer_VehicleDAL();

        //get all vehicle by id cus
        public DataTable getAllVehicle_IdCus(string id_cus)
        {
            return this.customer_VehicleDAL.getAllVehicle_IdCus(id_cus);
        }    

        //get all distinct
        public DataTable getAll_distinct()
        {
            return this.customer_VehicleDAL.getAll_distinct();
        }

        //get all
        public DataTable getAll()
        {
            return this.customer_VehicleDAL.getAll();
        }

        //insert
        public bool insertcustomer_Vehicle(customer_VehicleDTO customer_VehicleDTO)
        {
            return this.customer_VehicleDAL.insertcustomer_Vehicle(customer_VehicleDTO);
        }
    }
}
