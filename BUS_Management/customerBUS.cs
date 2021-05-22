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
    public class customerBUS
    {
        customerDAL customerDAL = new customerDAL();

        //get all khách hàng thuê xe
        public DataTable getAllCustomer_Thue()
        {
            return this.customerDAL.getAllCustomer_Thue();
        }

        //get all khách hàng cho thuê xe
        public DataTable getAllCustomer_ChoThue()
        {
            return this.customerDAL.getAllCustomer_ChoThue();
        }

        //del khách hàng
        public bool DelCustomer(string id)
        {
            return this.customerDAL.DelCustomer(id);
        }

        //Update info khách hàng
        public bool UpdateCustomer(customerDTO customerDTO)
        {
            return this.customerDAL.UpdateCustomer(customerDTO);
        }

        //get info customer by id
        public DataTable getData_byId(string id)
        {
            return this.customerDAL.getData_byId(id);
        }

        //insert customer
        public bool insertCustomer(customerDTO customerDTO)
        {
            return this.customerDAL.insertCustomer(customerDTO);
        }
    }
}
