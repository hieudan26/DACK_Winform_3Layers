using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS_Management
{
    public static class Global
    {
        ////0_Bảo Vệ //1_Thợ Sửa //2_Thợ Rửa //3_Nhân viên //4_All //5_Leaderbv //6_Leaderts //7_leadertr //8_leadernv
        public static int GlobalEmployeeType { get; private set; }
        public static void SetGlobalEmployeeType(int typeTho)
        {
            GlobalEmployeeType = typeTho;
        }

        public static string GlobalEmployeeId { get; private set; }
        public static void SetGlobalEmployeeId(string employeeId)
        {
            GlobalEmployeeId = employeeId;
        }
    }
}
