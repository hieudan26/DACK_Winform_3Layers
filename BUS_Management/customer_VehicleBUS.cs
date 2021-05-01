using System;
using System.Collections.Generic;
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

        //insert
        public bool insertcustomer_Vehicle(customer_VehicleDTO customer_VehicleDTO)
        {
            return this.customer_VehicleDAL.insertcustomer_Vehicle(customer_VehicleDTO);
        }
    }
}
