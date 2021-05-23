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

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable countTypeXe(string idEmployee, int typeXe)
        {
            return this.contract_ThueDAL.countTypeXe(idEmployee, typeXe);
        }

        //count so hơp đồng thuê xe, xe đạp ,máy hơi
        public DataTable count(string idEmployee)
        {
            return this.contract_ThueDAL.count(idEmployee);
        }

        //del contract
        public bool RemoveContract(string idContract)
        {
            return this.contract_ThueDAL.RemoveContract(idContract);
        }

        //get all contract expired by idemployee
        public DataTable getAllContract_Expired(string idEmployee)
        {
            return this.contract_ThueDAL.getAllContract_Expired(idEmployee);
        }

        //get all contract_Id employee
        public DataTable getAllContract_byIDEmployee(string idEmployee)
        {
            return this.contract_ThueDAL.getAllContract_byIDEmployee(idEmployee);
        }

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
