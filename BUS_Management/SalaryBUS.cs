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
    public class SalaryBUS
    {
        SalaryDAL salaryDAL = new SalaryDAL();
        nhanVienBUS nhanvienBUS = new nhanVienBUS();
        SalaryPerHourDAL salaryhour = new SalaryPerHourDAL();

        public bool insertSalaryNV(string IDnv, float Luong)
        {
            return this.salaryDAL.insertSalaryNV(IDnv, Luong);
        }

        public DataTable getLuongAll()
        {
            return this.salaryDAL.getLuongAll();
        }

        public void CreateBangLuong()
        {
            DataTable table = this.nhanvienBUS.getAllEmployees();
            if (table != null && table.Rows.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    this.salaryDAL.insertSalaryNV(table.Rows[i][0].ToString().Trim(), 0);
                }
            }
        }

        public bool UpdateLuong(string IDNV, float Bonus)
        {
            float LuongGoc = this.salaryDAL.getLuongNV(IDNV);
            float Total = Bonus + LuongGoc;
            if (this.salaryDAL.UpdateLuong(IDNV, Total))
                return true;
            return false;
        }

        public float getLuongHourPerCa(string type, int Ca)
        {
            return this.salaryhour.getLuongPerHour(type, Ca);
        }

        public float TruTre(int Minute)//Khỏi làm không điểm danh chơi bị trừ tiền đi
        {
            if (Minute > 30 && Minute <= 45)
                return 1;
            else if (Minute > 45 && Minute <= 60)
                return 2;
            else
                return 3;
        }

        public bool ResetNV(string IDNV)
        {
            if (this.salaryDAL.UpdateLuong(IDNV, 0))
                return true;
            return false;
        }

        public void ResetAllNV()
        {
            try
            {
                DataTable table = this.nhanvienBUS.getAllEmployees();
                if (table.Rows != null && table.Rows.Count > 0)
                {
                    for (int i = 0; i < table.Rows.Count; i++)
                    {
                        this.salaryDAL.UpdateLuong(table.Rows[i][0].ToString(), 0);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public bool UpdateLuongPerHour(string type, int Ca, float SoTien)
        {
            if (this.salaryhour.UpdateSalaryPerHour(type, Ca, SoTien))
                return true;
            return false;
        }
        public DataTable getFullLuongPerHour()
        {
            return this.salaryhour.getAllLuongPerHour();
        }
        public DataTable getLuongTypePerHour(string type)
        {
            return this.salaryhour.getLuongTypePerHour(type);
        }
        public DataTable getKetToanLuongAll()
        {
            return this.salaryDAL.getKetToanLuongAll();
        }
        public DataTable getKetToanLuongType(string type)
        {
            return this.salaryDAL.getKetToanLuongType(type);
        }
        public DataTable getKetToanLuongID(string idNV)
        {
            return this.salaryDAL.getKetToanLuongID(idNV);
        }
    }
}
