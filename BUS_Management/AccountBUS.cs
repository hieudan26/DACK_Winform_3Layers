using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Management;
using DTO_Management;

namespace BUS_Management
{
    public class AccountBUS
    {
        AccountDAL accDAL = new AccountDAL();

        public bool verifyAccount(AccountDTO acc)
        {
            return accDAL.verifyAccount(acc);
        }

        public bool insertAccount(AccountDTO acc)
        {
            return accDAL.insertAccount(acc);
        }

        public bool loginAccount(AccountDTO acc)
        {
            return accDAL.loginAccount(acc);
        }

        public bool changeInfoAccount(AccountDTO accold, AccountDTO accnew)
        {
            return accDAL.changeInfoAccount(accold, accnew);
        }

        public string forgotPassword(AccountDTO acc)
        {
            return accDAL.forgotPassword(acc);
        }
    }
}
