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
    public class contract_ChoThueBUS
    {
        contract_ChoThueDAL contract_ChoThueDAL = new contract_ChoThueDAL();

        public DataTable getAllVehicle_ContractChoThue()
        {
            return this.contract_ChoThueDAL.getAllVehicle_ContractChoThue();
        }

        //insert
        public bool insertContract_ChoThue(contract_ChoThueDTO contract_ChoThueDTO)
        {
            return this.contract_ChoThueDAL.insertContract_ChoThue(contract_ChoThueDTO);
        }
    }
}
