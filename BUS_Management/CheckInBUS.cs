using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL_Management;
using DAO_Management;
using DTO_Management;

namespace BUS_Management
{
    public class CheckInBUS
    {
        CheckInDAL checkinDAL = new CheckInDAL();
        nhanVienBUS nhanvienBUS = new nhanVienBUS();
        shift_BaoVeBUS shiftbaoveBUS = new shift_BaoVeBUS();
        shift_NhanVienBUS shiftnhanvienBUS = new shift_NhanVienBUS();
        shift_ThoRuaXeBUS shiftthoruaBUS = new shift_ThoRuaXeBUS();
        shift_ThoSuaXeBUS shiftthosuaBUS = new shift_ThoSuaXeBUS();

        public void CreateCheckIn()
        {
            for (int i = 1; i <= 3; i++)
            {
                for (int j = 2; j <= 8; j++)
                {
                    string tempstr = "";
                    if (j < 8)
                    {
                        tempstr = "Thu" + j;
                    }
                    else
                    {
                        tempstr = "ChuNhat";
                    }
                    DataTable table = this.shiftbaoveBUS.getIdName_ByCaThu(i, tempstr);
                    addCheckInTable(table, i, j);
                    table = this.shiftnhanvienBUS.getIdName_ByCaThu(i, tempstr);
                    addCheckInTable(table, i, j);
                    table = this.shiftthoruaBUS.getIdName_ByCaThu(i, tempstr);
                    addCheckInTable(table, i, j);
                    table = this.shiftthosuaBUS.getIdName_ByCaThu(i, tempstr);
                    addCheckInTable(table, i, j);
                }
            }
        }
        private void addCheckInTable(DataTable table,int i,int j)
        {
            if (table != null)
            {
                for (int k = 0; k < table.Rows.Count; k++)
                {
                    string res = "";
                    res = table.Rows[k][0].ToString();
                    if (!checkinDAL.insertEmtyCa(res, j, i, 0))
                        MessageBox.Show("Loi Khong them duoc ca");
                }
            }
        }
        public bool ResetBang()
        {
            return this.checkinDAL.DeleteAll();
        }
        public bool AttendNV(string IdNV,string thu,int Ca)
        {
            int ngay= this.CD(thu);
            return this.checkinDAL.AttendCa(IdNV, ngay, Ca, 1);
        }
        private int CD(string thu)
        {
            switch(thu)
            {
                case "Monday": return 2;
                case "Tuesday": return 3;
                case "Wednesday": return 4;
                case "Thursday": return 5;
                case "Friday": return 6;
                case "Saturday": return 7;
                case "Sunday": return 8;
            }
            return 0;
        }
    }
}
