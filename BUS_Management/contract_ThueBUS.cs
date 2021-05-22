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
    public class contract_ThueBUS
    {
        contract_ThueDAL contract_ThueDAL = new contract_ThueDAL();

        //get all id vehicle
        public DataTable getAllVehicle_ContractThue()
        {
            return this.contract_ThueDAL.getAllVehicle_ContractThue();
        }

        //insert
        public bool insertContract_Thue(contract_ThueDTO contract_ThueDTO)
        {
            return this.contract_ThueDAL.insertContract_Thue(contract_ThueDTO);
        }
    }
}
