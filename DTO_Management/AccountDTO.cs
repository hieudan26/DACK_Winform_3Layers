using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO_Management
{
    public class AccountDTO
    {
        private int iID;

        public int ID { get => iID; set => iID = value; }

        private string sUsername;

        public string Username { get => sUsername; set => sUsername = value; }

        private string sPassword;

        public string Password { get => sPassword; set => sPassword = value; }

        public AccountDTO() { }

        public AccountDTO(int ID, string Username, string Password)
        {
            this.iID = ID;
            this.sUsername = Username;
            this.sPassword = Password;
        }

        public bool verifyPass(string Username, string Password)
        {
            if (!checkPass(Password))
            {
                return false;
            }
            else
                return true;
                
        }

        public bool checkPass(string pass)
        {
            if (pass.Length >= 7)
            {
                int flagChu = 0;
                int flagSo = 0;
                for (int i = 0; i < pass.Length; i++)
                {
                    if (flagChu == 1 && flagSo == 1)
                    {
                        return true;
                    }

                    if ((pass[i] >= 'A' && pass[i] <= 'Z') || (pass[i] >= 'a' && pass[i] <= 'z'))
                    {
                        flagChu = 1;
                    }

                    if (pass[i] >= '0' && pass[i] <= '9')
                    {
                        flagSo = 1;
                    }
                }
                return false;
            }
            else
                return false;
        }

        ~AccountDTO() { }
    }
}
