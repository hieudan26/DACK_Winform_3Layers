using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Management
{
    public class MyDB
    {
        //Dan
        protected SqlConnection con = new SqlConnection(@"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=QLXeDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

        //AthonyducThang
        //protected SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-DE070V4\D2T;Initial Catalog=QLXeDB;Integrated Security=True");

        protected SqlConnection getConnection
        {
            get { return this.con; }
        }

        protected void openConnection()
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }

        protected void closeConnection()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
