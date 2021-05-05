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
    public class shift_ThoSuaXeBUS
    {
        private const int SoNgay = 7; //So ngay chia ca
        private const int SoCatrongNgay = 3; //So ca /ngay
        private const int TongSoCa = SoNgay * SoCatrongNgay;
        private nhanVienDAL nhanvienDAL = new nhanVienDAL();
        private shift_ThoSuaXeDAL shift_ThoSuaXeDAL = new shift_ThoSuaXeDAL();

        //Reset
        public bool ResetShift_ThoSuaXe()
        {
            return this.shift_ThoSuaXeDAL.ResetShift_ThoSuaXe();
        }

        public DataTable getALLShift_ThoSuaXe()
        {
            return this.shift_ThoSuaXeDAL.getALLShift_ThoSuaXe();
        }

        public void chiaCaThoSuaXe()
        {
            DataTable table = this.nhanvienDAL.getNv_typeTho("Thợ Sửa");
            int SoNV = this.nhanvienDAL.countEmployee_byType("Thợ Sửa");
            int SoNVTrongCa = 3;
            List<List<List<int>>> Result = XuLy(SoNV, SoNVTrongCa);
            //int dem = 0;
            int thu = 2;
            int ca = 1;
            for (int i = 0; i < Result.Count; i++)//thứ
            {
                for (int j = 0; j < Result[i].Count; j++)//slca
                {
                    for (int k = 0; k < Result[i][j].Count; k++)//slnvtc
                    {
                        string id_NV = table.Rows[Result[i][j][k]]["id"].ToString();
                        shift_ThoSuaXeDTO shift_ThoSuaXeDTO = dto(id_NV, thu, ca);
                        this.shift_ThoSuaXeDAL.insertShift(shift_ThoSuaXeDTO);

                    }
                    ca++;
                    if (ca == 4)
                        ca = 1;
                }
                thu++;
                if (thu == 9)
                    thu = 2;
            }
        }

        private shift_ThoSuaXeDTO dto(string id_nv, int thu, int ca)
        {
            shift_ThoSuaXeDTO shift_ThoSuaXeDTO;
            if (thu == 2)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, ca, 0, 0, 0, 0, 0, 0);
            }
            else if (thu == 3)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, ca, 0, 0, 0, 0, 0);
            }
            else if (thu == 4)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, 0, ca, 0, 0, 0, 0);
            }
            else if (thu == 5)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, 0, 0, ca, 0, 0, 0);
            }
            else if (thu == 6)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, 0, 0, 0, ca, 0, 0);
            }
            else if (thu == 7)
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, 0, 0, 0, 0, ca, 0);
            }
            else
            {
                shift_ThoSuaXeDTO = new shift_ThoSuaXeDTO(id_nv, 0, 0, 0, 0, 0, 0, ca);
            }
            return shift_ThoSuaXeDTO;
        }

        private List<List<List<int>>> XuLy(int SoNV, int SoNVTrongCa)
        {
            List<List<int>> ChiaNhom1 = ChiaNhom(SoNV, SoNVTrongCa);
            List<List<List<int>>> Result = ChiaCa(SoCatrongNgay, ChiaNhom1);
            SapxepCa(Result);
            DoiCaTrung(Result);
            DienCathieuNguoi(Result, SoNV, SoNVTrongCa);
            ChinhSuaCuoi(Result, ChiaNhom1, SoNV, SoNVTrongCa);
            return Result;
        }

        private List<List<int>> ChiaNhom(int SoNV, int SoNVCa)
        {
            int i = 0; //dem NV
            int j = 0; //dem NV trong 1 ca
            List<int> arrShift = new List<int>();
            List<List<int>> arrResult = new List<List<int>>();
            while (i < SoNV)
            {
                if (j == SoNVCa)
                {
                    arrResult.Add(arrShift);
                    arrShift = new List<int>();
                    j = 0;
                }
                else
                {
                    arrShift.Add(i);
                    i++;
                    j++;
                }
            }
            arrResult.Add(arrShift);
            return arrResult;
        }
        private List<List<List<int>>> ChiaCa(int SoNVCa, List<List<int>> arrNhom)
        {
            int soNhom = arrNhom.Count;
            int Soluot = TongSoCa / soNhom; //dem NV
            int du = TongSoCa % soNhom; //dem NV trong 1 ca
            List<List<int>> arrResultLan1 = new List<List<int>>();
            int Solan = Soluot;
            if (Solan > SoCatrongNgay)
                Solan = SoCatrongNgay;// để chia cho khó trùng hơn đảm bảo 1 nhóm ko làm ca giông nhau
            int tempSolan = Solan;
            int indexNhom = 0;

            for (int i = 0; i < TongSoCa - du; i++)
            {
                if (tempSolan == 0)//đã in ra đủ số ca của 1 nhóm trong 1 chu kì bằng nhau
                {
                    if ((indexNhom % soNhom) == soNhom - 1)//theo chu kì 1 lần thêm vào toàn bộ nhóm
                    {
                        Soluot = Soluot - Solan;
                        if (Soluot < Solan)// khi số ca của mỗi nhóm còn lại ít hơn số ca của 1 ngày
                        {
                            Solan = Soluot;
                            Soluot = 100;
                        }
                    }
                    tempSolan = Solan;
                    indexNhom++;
                }
                tempSolan--;
                arrResultLan1.Add(arrNhom[indexNhom % soNhom]);
            }


            for (int i = 0; i < du; i++)// Thêm vào các ca dư chưa có Nhóm nào làm
            {
                arrResultLan1.Add(arrNhom[i % soNhom]);
            }
            List<List<List<int>>> arrResult = new List<List<List<int>>>();
            List<List<int>> arrTemp = new List<List<int>>();
            for (int i = 0; i < SoNgay; i++)
            {
                arrTemp = new List<List<int>>();
                for (int j = 0; j < SoCatrongNgay; j++)
                {
                    List<int> arr = new List<int>(arrResultLan1[(i * 3 + j) % TongSoCa]);
                    arrTemp.Add(arr);
                }
                arrResult.Add(arrTemp);
            }
            return arrResult;
        }
        private void SapxepCa(List<List<List<int>>> arrNhom)
        {
            //dichh ca 1 len 1 ca  2 len 2
            List<int> tempcol21 = arrNhom[SoNgay - 1][1];
            List<int> tempcol31 = arrNhom[SoNgay - 1][2];
            List<int> tempcol32 = arrNhom[SoNgay - 2][2];
            for (int i = SoNgay - 1; i > 0; i--)
            {
                if (i > 0)
                    arrNhom[i][1] = arrNhom[i - 1][1];
                if (i > 1)
                    arrNhom[i][2] = arrNhom[i - 2][2];
            }
            arrNhom[0][1] = tempcol21;
            arrNhom[0][2] = tempcol32;
            arrNhom[1][2] = tempcol31;
        }

        private void DoiCaTrung(List<List<List<int>>> arrNhom)
        {
            for (int i = 0; i < SoCatrongNgay; i++)
                this.ChuyenCaTrungTheoCot(arrNhom, i);

        }
        private void ChuyenCaTrungTheoCot(List<List<List<int>>> arrNhom, int Ca)
        {
            //hoan doi neu Ca lam sat nhau
            for (int i = 0; i < SoNgay; i++)
            {
                if (this.demSL(arrNhom, i, arrNhom[i][Ca][0]) > 1)
                {
                    for (int j = 0; j < SoNgay; j++)
                    {
                        if (this.demSL(arrNhom, j, arrNhom[i][Ca][0]) == 0 && this.demSL(arrNhom, i, arrNhom[j][Ca][0]) == 0)
                        {
                            List<int> temp = new List<int>(arrNhom[i][Ca]);
                            arrNhom[i][Ca] = arrNhom[j][Ca];
                            arrNhom[j][Ca] = temp;
                        }
                    }
                }
            }
        }
        private int demSL(List<List<List<int>>> arrNhom, int x, int value)
        {
            int dem = 0;
            for (int i = 0; i < 3; i++)
            {
                if (arrNhom[x][i][0] == value)
                    dem++;
            }
            return dem;
        }

        private void DienCathieuNguoi(List<List<List<int>>> arrNhom, int SoNV, int SoNVTrongCa)
        {
            int SoNguoiThieu = SoNV % SoNVTrongCa;
            int indexFill = SoNV - SoNguoiThieu - 1;
            int StepNV = 1;
            for (int j = 0; j < SoCatrongNgay; j++)
            {
                for (int i = 0; i < SoNgay; i++)
                {
                    while (arrNhom[i][j].Count < SoNVTrongCa)
                    {
                        if (indexFill < 0)
                            indexFill = SoNV - SoNguoiThieu - 1;
                        else
                        {
                            arrNhom[i][j].Add(indexFill);
                            indexFill = indexFill - StepNV;
                        }
                    }
                }
            }
        }

        private void ChinhSuaCuoi(List<List<List<int>>> arrNhom, List<List<int>> arrDSNhom, int SoNV, int SoNVCa)
        {
            List<int> NhomCuoi = arrDSNhom[arrDSNhom.Count - 1];
            int SoNhom = SoNV / SoNVCa;
            int SoCalamViec = SoNgay / (SoNhom + 1);
            int SoNVDuNhom = SoNV % SoNVCa;
            int indexDu = 0;

            for (int i = 0; i < SoCatrongNgay; i++)
            {
                for (int j = 0; j < SoNV; j++)
                {
                    if (this.demSLNV(arrNhom, j, i) > SoCalamViec + 1)
                    {
                        this.ChangeValue(arrNhom, i, j, NhomCuoi[indexDu]);
                        indexDu = (indexDu + 1) % NhomCuoi.Count;

                    }
                }
            }

            for (int i = 0; i < SoCatrongNgay; i++)
            {
                for (int j = 0; j < SoNV; j++)
                {
                    if (this.demSLNV(arrNhom, j, i) < SoCalamViec)
                    {
                        for (int k = 0; k < NhomCuoi.Count; k++)
                        {
                            if (this.demSLNV(arrNhom, NhomCuoi[k], i) > SoCalamViec + ((1 - (i % 2))))
                            {
                                this.ChangeValue(arrNhom, i, NhomCuoi[k], j);
                                break;
                            }
                        }
                    }
                }
            }
        }

        private void ChangeValue(List<List<List<int>>> arrNhom, int Ca, int Value1, int Value2)
        {
            for (int i = 0; i < SoNgay; i++)
            {
                for (int j = 0; j < arrNhom[i][Ca].Count; j++)
                {
                    if (Value1 == arrNhom[i][Ca][j] && this.KiemTraTonTai(arrNhom, i, Ca, Value2) == false)
                    {
                        arrNhom[i][Ca][j] = Value2;
                        return;
                    }
                }
            }

        }

        private bool KiemTraTonTai(List<List<List<int>>> arrNhom, int x, int y, int value)
        {
            for (int i = 0; i < arrNhom[x][y].Count; i++)
            {
                if (value == arrNhom[x][y][i])
                    return true;
            }
            return false;
        }

        private int demSLNV(List<List<List<int>>> arrNhom, int value, int Ca)
        {
            int dem = 0;
            for (int i = 0; i < SoNgay; i++)
            {
                if (this.KiemTraTonTai(arrNhom, i, Ca, value) == true)
                    dem++;
            }
            return dem;
        }
    }
}
