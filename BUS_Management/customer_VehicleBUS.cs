﻿using System;
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
