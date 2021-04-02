using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class vehicleBUS
    {
        vehicleDAL Vehicle = new vehicleDAL();
        
        public bool insertVehicle(vehicleDTO vel)
        {
            return Vehicle.insertVehicle(vel);
        }
        public bool insertGuiXe(vehicleDTO vel,int type)
        {
            return Vehicle.insertGuiXe(vel, type);
        }
    }
}
