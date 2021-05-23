using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS_Management;
using System.IO;
using Microsoft.Office.Interop.Word;
using System.Drawing.Printing;

namespace GUI_Management
{
    public partial class fSchedule : Form
    {
        shift_BaoVeBUS shift_BaoVeBUS = new shift_BaoVeBUS();
        shift_ThoSuaXeBUS shift_ThoSuaXeBUS = new shift_ThoSuaXeBUS();
        shift_ThoRuaXeBUS shift_ThoRuaXeBUS = new shift_ThoRuaXeBUS();
        shift_NhanVienBUS shift_NhanVienBUS = new shift_NhanVienBUS();
        private int check = 0;
        public fSchedule()
        {
            InitializeComponent();
        }

        private void ClearflowLayoutPanel()
        {
            this.flpCa1_2.Controls.Clear();
            this.flpCa1_3.Controls.Clear();
            this.flpCa1_4.Controls.Clear();
            this.flpCa1_5.Controls.Clear();
            this.flpCa1_5.Controls.Clear();
            this.flpCa1_6.Controls.Clear();
            this.flpCa1_7.Controls.Clear();
            this.flpCa1_CN.Controls.Clear();

            this.flpCa2_2.Controls.Clear();
            this.flpCa2_3.Controls.Clear();
            this.flpCa2_4.Controls.Clear();
            this.flpCa2_5.Controls.Clear();
            this.flpCa2_5.Controls.Clear();
            this.flpCa2_6.Controls.Clear();
            this.flpCa2_7.Controls.Clear();
            this.flpCa2_CN.Controls.Clear();

            this.flpCa3_2.Controls.Clear();
            this.flpCa3_3.Controls.Clear();
            this.flpCa3_4.Controls.Clear();
            this.flpCa3_5.Controls.Clear();
            this.flpCa3_5.Controls.Clear();
            this.flpCa3_6.Controls.Clear();
            this.flpCa3_7.Controls.Clear();
            this.flpCa3_CN.Controls.Clear();
        }

        private void btnpBV_Click(object sender, EventArgs e)
        {
            try
            {
                this.check = 1;
                this.ClearflowLayoutPanel();
                this.LoadDataPhong_BaoVe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void LoadLaiFlow(System.Data.DataTable table, FlowLayoutPanel fl)
        {
            if(table != null)
            {
                this.LoadFlowLayoutPanel(table, fl);
                table.Clear();
            }
            
        }
        private void LoadDataPhong_BaoVe()
        {
            try
            {
                System.Data.DataTable table;
                //load Ca1_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_BaoVeBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
                //for (int j = 1; j < 4; j++)
                //{
                //    for (int i = 2; i < 9; i++)
                //    {
                //        string nameFlowLayoutPanel = "flpCa";
                //        FlowLayoutPanel fl = new FlowLayoutPanel();
                //        fl.Name = nameFlowLayoutPanel + j.ToString() + "_" + i.ToString();
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error :" + ex.Message);
            }
        }

        /*private string Thu(int i)
        {
            if (i == 0)
            {
                return "Thu2";
            }    
            else if (i == 1)
            {
                return "Thu3";
            }    
            else if (i == 2)
            {
                return "Thu4";
            }    
            else if (i == 3)
            {
                return "Thu5";
            }    
            else if (i == 4)
            {
                return "Thu6";
            }    
            else if (i == 5)
            {
                return "Thu7";
            }
            else
            {
                return "ChuNhat";
            }
        }*/

        private string XuLyTen(string label)
        {
            int ViTriSpaceCuoiCung = label.LastIndexOf(" ");
            if (ViTriSpaceCuoiCung != -1)
            {
                label = label.Remove(0, ViTriSpaceCuoiCung + 1);
                return label;
            }
            else
                return label;
        }

        private void LoadFlowLayoutPanel(System.Data.DataTable table, FlowLayoutPanel fl)
        {
            if (table != null)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Label lbSp = new Label(); lbSp.Text = "--------------------";
                    fl.Controls.Add(lbSp);
                    Label lbName = new Label();
                    lbName.Text = XuLyTen(table.Rows[i][1].ToString().Trim());
                    lbName.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    //lbName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
                    fl.Controls.Add(lbName);
                }
                Label lbSp2 = new Label(); lbSp2.Text = "--------------------";
                fl.Controls.Add(lbSp2);
            }
        }

        private void btnpSX_Click(object sender, EventArgs e)
        {
            try
            {
                this.check = 2;
                this.ClearflowLayoutPanel();
                this.LoadDataPhong_SuaXe();
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataPhong_SuaXe()
        {
            try
            {
                System.Data.DataTable table;
                //load Ca1_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu2");
                if(table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_2);
                    table.Clear();
                }
                //load Ca2_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu2");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_2);
                    table.Clear();
                }
                //load Ca3_Thu2
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu2");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_2);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_3);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu4");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_4);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu5");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_5);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu6");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_6);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa1_7);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_7);
                    table.Clear();
                }
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "Thu7");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_7);
                    table.Clear();
                }
                    
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(2, "ChuNhat");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa2_CN);
                    table.Clear();
                }    
                    
                //
                table = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(3, "ChuNhat");
                if (table != null)
                {
                    this.LoadFlowLayoutPanel(table, this.flpCa3_CN);
                    table.Clear();
                }    
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpRS_Click(object sender, EventArgs e)
        {
            try
            {
                this.check = 3;
                this.ClearflowLayoutPanel();
                this.LoadDataPhong_RuaXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: ", ex.Message);
            }
        }

        private void LoadDataPhong_RuaXe()
        {
            try
            {
                System.Data.DataTable table;
                //load Ca1_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
            }    
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void btnpNS_Click(object sender, EventArgs e)
        {
            try
            {
                this.check = 4;
                this.ClearflowLayoutPanel();
                this.LoadDataPhong_NhanVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void LoadDataPhong_NhanVien()
        {
            try
            {
                System.Data.DataTable table;
                //load Ca1_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu2");
                this.LoadLaiFlow(table, this.flpCa1_2);
                //load Ca2_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu2");
                this.LoadLaiFlow(table, this.flpCa2_2);
                //load Ca3_Thu2
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu2");
                this.LoadLaiFlow(table, this.flpCa3_2);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu3");
                this.LoadLaiFlow(table, this.flpCa1_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa2_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu3");
                this.LoadLaiFlow(table, this.flpCa3_3);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu4");
                this.LoadLaiFlow(table, this.flpCa1_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu4");
                this.LoadLaiFlow(table, this.flpCa2_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu4");
                this.LoadLaiFlow(table, this.flpCa3_4);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu5");
                this.LoadLaiFlow(table, this.flpCa1_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu5");
                this.LoadLaiFlow(table, this.flpCa2_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu5");
                this.LoadLaiFlow(table, this.flpCa3_5);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu6");
                this.LoadLaiFlow(table, this.flpCa1_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu6");
                this.LoadLaiFlow(table, this.flpCa2_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu6");
                this.LoadLaiFlow(table, this.flpCa3_6);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "Thu7");
                this.LoadLaiFlow(table, this.flpCa1_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "Thu7");
                this.LoadLaiFlow(table, this.flpCa2_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "Thu7");
                this.LoadLaiFlow(table, this.flpCa3_7);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(1, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa1_CN);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(2, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa2_CN);
                //
                table = this.shift_NhanVienBUS.getIdName_ByCaThu(3, "ChuNhat");
                this.LoadLaiFlow(table, this.flpCa3_CN);
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: ", e.Message);
            }
        }

        private void gunaGradientButton1_Click(object sender, EventArgs e)
        {
            this.shift_ThoSuaXeBUS.InsertIntoOld_FormNew();
            this.btnpSX_Click(sender, e);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            System.Data.DataTable table = null;
            string head = "";
            switch (this.check)
            {
                
                case 0:
                    {
                        table = null;
                        break;
                    }
                case 1:
                    {
                        table = this.shift_BaoVeBUS.getShift();
                        head = "bảo vệ";
                        break;
                    }
                case 2:
                    {
                        table = this.shift_ThoSuaXeBUS.getShift();
                        head = "thợ sửa xe";
                        break;
                    }
                case 3:
                    {
                        table = this.shift_ThoRuaXeBUS.getShift();
                        head = "thợ rửa xe";
                        break;

                    }
                case 4:
                    {
                        table = this.shift_NhanVienBUS.getShift();
                        head = "nhân viên";
                        break;
                    }
            }
            if (table != null)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "DOCX files(*.docx)|*.docx";

                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Export_AllData_To_Word(table, savefile.FileName, head);
                }
            }
            else
                MessageBox.Show("Vui lòng chọn để in");
        }

        public void CreateDocument(string docFilePath, Image image)
        {
            _Application oWord = new Microsoft.Office.Interop.Word.Application();
            //Nếu tạo một Document
            _Document oDoc = oWord.Documents.Add();
            //Nếu mở một Document
            //Microsoft.Office.Interop.Word._Document oDoc = oWord.Documents.Open(docFilePath, ReadOnly: false, Visible: true);

            //Để xem điều gì đang xảy ra trong khi điền tập tài liệu từ Visible = true
            oWord.Visible = true;

            //Chèn ảnh từ mảng byte vào MS Word, sử dụng Clipboard để dán Image vào tài liệu
            Object oMissing = System.Reflection.Missing.Value;
            Clipboard.SetDataObject(image);
            var oPara = oDoc.Content.Paragraphs.Add(ref oMissing);
            oPara.Range.Paste();
            oPara.Range.InsertParagraphAfter();

            //Nếu tạo document
            oDoc.SaveAs(docFilePath);
            //Nếu mở một document
            //oDoc.Save();
            oDoc.Close();
            oWord.Quit();
        }
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image returnImage = Image.FromStream(ms);
                return returnImage;
            }
        }

        public void Export_AllData_To_Word(System.Data.DataTable table, string filename, string head)//1: Word,2: PDF
        {

            try
            {
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();
                winword.ShowAnimation = false;
                winword.Visible = false;
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);
                document.Content.SetRange(0, 0);
                document.Content.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;


                Microsoft.Office.Interop.Word.Paragraph paraHeading = document.Content.Paragraphs.Add(ref missing);
                DateTime date = DateTime.Now.StartOfWeek(DayOfWeek.Monday);
                paraHeading.Range.Font.Size = 28;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.Text = "Bảng phân công việc hàng tuần bắt đầu từ " + date.ToString("dd/MM/yyyy");
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                this.ExporterObjects_Paragraph(ref document, table, "Bảng phân công công việc "+head);
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Size = 16;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.Bold = 0;
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para1.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;

                para1.Range.InsertParagraphAfter();


                // Word.WdParagraphAlignment.wdAlignParagraphRight;
                //Save pdf
                //object outputFileName = filename.Replace(".doc", ".pdf");
                //object fileFormat = WdSaveFormat.wdFormatPDF;
                //document.SaveAs(ref outputFileName, ref fileFormat);
                //Save the document
                document.SaveAs2(filename);

                ((Microsoft.Office.Interop.Word._Document)document).Close(ref missing, ref missing, ref missing);
                ((Microsoft.Office.Interop.Word._Application)winword).Quit(ref missing, ref missing, ref missing);


                MessageBox.Show("Document created successfully !");
                System.Diagnostics.Process.Start(filename);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

       
        private void ExporterObjects_Paragraph(ref Document document, System.Data.DataTable datatable, string namePara)
        {
            try
            {
                object missing = System.Reflection.Missing.Value;
                Microsoft.Office.Interop.Word.Paragraph para = document.Content.Paragraphs.Add(ref missing);
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 16;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.Text = "\n" + namePara;
                para.Range.InsertParagraphAfter();


                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 13;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                if (datatable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 8, 4, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.AllowAutoFit = true;
                    firstTable.Cell(1, 1).Range.Text = "Thứ ";
                    firstTable.Cell(1, 2).Range.Text = "Ca 1";
                    firstTable.Cell(1, 3).Range.Text = "Ca 2";
                    firstTable.Cell(1, 4).Range.Text = "Ca 3";

                    firstTable.Cell(2, 1).Range.Text = "Thứ 2";
                    firstTable.Cell(3, 1).Range.Text = "Thứ 3";
                    firstTable.Cell(4, 1).Range.Text = "Thứ 4";
                    firstTable.Cell(5, 1).Range.Text = "Thứ 5";
                    firstTable.Cell(6, 1).Range.Text = "Thứ 6";
                    firstTable.Cell(7, 1).Range.Text = "Thứ 7";
                    firstTable.Cell(8, 1).Range.Text = "Chủ Nhật";
                    Object beforeRow = Type.Missing;
                    para.Range.Font.Bold = 0;
                    para.Range.Font.Size = 13;
                    para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;



                    for (int i = 1; i <= 3; i++)
                    {
                        for (int j = 2; j <= 8; j++)
                        {
                            string res = "";
                            string tempstr = "";
                            if (j < 8)
                            {
                                tempstr = "Thu" + j;
                            }
                            else
                            {
                                tempstr = "ChuNhat";
                            }
                            System.Data.DataTable dt = shift_BaoVeBUS.getIdName_ByCaThu(i, tempstr);
                            switch(check)
                            {
                                case 1:
                                    {
                                        dt = shift_BaoVeBUS.getIdName_ByCaThu(i, tempstr);
                                        break;
                                    }
                                case 2:
                                    {
                                        dt = this.shift_ThoSuaXeBUS.getIdName_ByCaThu(i, tempstr);
                                        break;
                                    }
                                case 3:
                                    {
                                        dt = this.shift_ThoRuaXeBUS.getIdName_ByCaThu(i, tempstr);
                                        break;
                                    }
                                case 4:
                                    {
                                        dt = this.shift_NhanVienBUS.getIdName_ByCaThu(i, tempstr);
                                        break;
                                    }
                            }    
                            if (dt != null)
                            {
                                for (int k = 0; k < dt.Rows.Count; k++)
                                {
                                    res += dt.Rows[k][1].ToString() + "\n";

                                }
                                firstTable.Cell(j, i + 1).Range.Text = res;
                            }


                        }
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "Ca 1";
                    firstTable.Cell(1, 2).Range.Text = "Ca 2";
                    firstTable.Cell(1, 3).Range.Text = "Ca 3";
                    Object beforeRow = Type.Missing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Err " + ex.Message);
            }
        }
    }
    public static class DateTimeExtensions
    {
        public static DateTime StartOfWeek(this DateTime dt, DayOfWeek startOfWeek)
        {
            int diff = (7 + (dt.DayOfWeek - startOfWeek)) % 7;
            return dt.AddDays(-1 * diff).Date;
        }
    }
}
