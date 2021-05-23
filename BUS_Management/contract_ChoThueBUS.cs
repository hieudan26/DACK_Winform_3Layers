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

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable countTypeXe(string idEmployee, int typeXe)
        {
            return this.contract_ChoThueDAL.countTypeXe(idEmployee, typeXe);
        }

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable count(string idEmployee)
        {
            return this.contract_ChoThueDAL.count(idEmployee);
        }

        //del contract
        public bool RemoveContract(string idContract)
        {
            return this.contract_ChoThueDAL.RemoveContract(idContract);
        }

        //get all contract expired by idemployee
        public DataTable getAllContractChoThue_Expired(string idEmployee)
        {
            return this.contract_ChoThueDAL.getAllContractChoThue_Expired(idEmployee);
        }

        //get all id vehicle by idEmployee
        public DataTable getAllVehicle_ContractChoThueByIDEmployee(string IDEmployee)
        {
            return this.contract_ChoThueDAL.getAllVehicle_ContractChoThueByIDEmployee(IDEmployee);
        }

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
