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
        public static DateTime TimeLogin;
        public static SalaryBUS salaryBUS = new SalaryBUS();
        public static void SetGlobalEmployeeType(int typeTho)
        {
            GlobalEmployeeType = typeTho;
        }

        public static string GlobalEmployeeId { get; private set; }
        public static void SetGlobalEmployeeId(string employeeId)
        {
            GlobalEmployeeId = employeeId;
        }

        public static void TinhGioLam()
        {
            //Ở đây set Interval để tính thời gian bn + lương 1 lần 1000 = 1s
            MessageBox.Show("Bắt đầu tính giờ làm");
            MyTimer.Interval = (60000);
            MyTimer.Elapsed += new ElapsedEventHandler(MyTimeCongLuong);
            MyTimer.Start();

        }
        public static int getCaNowGlobal()
        {
            DateTime CurrTime = DateTime.Now;
            DateTime ca1_Begin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                , 0, 0, 0);
            DateTime ca2_Begin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                , 11, 30, 0);
            DateTime ca3_Begin = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                , 16, 0, 0, 0);
            DateTime ca3_End = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day
                , 21, 30, 0);
            //////////////////////////////////////
            if ((DateTime.Equals(ca1_Begin, CurrTime) || (DateTime.Compare(ca1_Begin, CurrTime) < 0))
                && (DateTime.Equals(ca2_Begin, CurrTime) || (DateTime.Compare(ca2_Begin, CurrTime) > 0)))
            {
                return 1;
            }
            else if ((DateTime.Equals(ca2_Begin, CurrTime) || (DateTime.Compare(ca2_Begin, CurrTime) < 0))
                && (DateTime.Equals(ca3_Begin, CurrTime) || (DateTime.Compare(ca3_Begin, CurrTime) > 0)))

            {
                return 2;
            }
            else if ((DateTime.Equals(ca3_Begin, CurrTime) || (DateTime.Compare(ca3_Begin, CurrTime) < 0))
                && (DateTime.Equals(ca3_End, CurrTime) || (DateTime.Compare(ca3_End, CurrTime) > 0)))
            {
                return 3;
            }
            else
                return -1;
        }
        public static void MyTimeCongLuong(object sender, EventArgs e)
        {

            try {
                int Ca = getCaNowGlobal();
                nhanVienBUS NV = new nhanVienBUS();
                DataTable table = NV.getEmployee_byID(Global.GlobalEmployeeId);
                string Type = table.Rows[0][4].ToString().Trim();
                float Luong = Global.salaryBUS.getLuongHourPerCa(Type, Ca);
                Global.salaryBUS.UpdateLuong(GlobalEmployeeId, Luong);
                table.Reset();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public static void AutoSave()
        {
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
