using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace BUS_Management
{
    public static class Global
    {
        ////0_Bảo Vệ //1_Thợ Sửa //2_Thợ Rửa //3_Nhân viên //4_All //5_Leaderbv //6_Leaderts //7_leadertr //8_leadernv
        public static int GlobalEmployeeType { get; private set; }
        public static System.Timers.Timer MyTimer = new System.Timers.Timer();
        public static int check = 0;
        public static void SetGlobalEmployeeType(int typeTho)
        {
            GlobalEmployeeType = typeTho;
        }

        public static string GlobalEmployeeId { get; private set; }
        public static void SetGlobalEmployeeId(string employeeId)
        {
            GlobalEmployeeId = employeeId;
        }
        
        public static void AutoSave()
        {
            MessageBox.Show("Bat dau");
            MyTimer.Interval = (1000);
            MyTimer.Elapsed += new ElapsedEventHandler(MyTimer_Tick);
            MyTimer.Start();
            
        }
        public static void MyTimer_Tick(object sender, EventArgs e)
        {
            TimeSpan now = DateTime.Now.TimeOfDay;
            TimeSpan start = new TimeSpan(21, 0, 0);
            if(now >= start && check == 0)
            {
                check = 1;
                AutoPrint print = new AutoPrint();
                print.Print();
            }
            else if(now < start)
            {
                check = 0;
            }    
        }
    }
}
