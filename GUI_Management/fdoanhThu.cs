using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace GUI_Management
{
    public partial class fdoanhThu : Form
    {
        vehicleParkingBUS vehicleBUS = new vehicleParkingBUS();
        fQuanLyXe fQuanLyXeGui = new fQuanLyXe();
        doanhThuParkingBUS doanhThuParkingBUS = new doanhThuParkingBUS();
        doanhThuFixBUS doanhThuFixBUS = new doanhThuFixBUS();
        doanhThuWashBUS doanhThuWashBUS = new doanhThuWashBUS();

        public fdoanhThu(fQuanLyXe fQuanLy)
        {
            InitializeComponent();
            this.fQuanLyXeGui = fQuanLy;
        }

        int counter = 0;
        int len = 0;
        string txt;

        //Dòng chữ chạy nhấp nháy
        private void timer1_Tick(object sender, EventArgs e)
        {
            counter++;

            if (counter > len)
            {
                counter = 0;
                lbContent.Text = "";
            }

            else
            {
                lbContent.Text = txt.Substring(0, counter);

                if (lbContent.ForeColor == System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54))))))
                    lbContent.ForeColor = Color.LightPink;
                else
                    lbContent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(52)))), ((int)(((byte)(54)))));
            }
        }

        private bool LoadDataGridView(System.Data.DataTable table)
        {
            if (table != null)
            {
                this.dgvExpired.ReadOnly = true;
                this.dgvExpired.RowTemplate.Height = 60;
                this.dgvExpired.AutoResizeRows();
                this.dgvExpired.AutoResizeColumns();
                this.dgvExpired.DataSource = table;
                this.dgvExpired.AllowUserToAddRows = false;
                return true;
            }
            else
            {
                //MessageBox.Show("Empty");
                return false;
            }  
        }

        private void loadTxt()
        {
            try
            {
                int sumGuiXe = this.doanhThuParkingBUS.sumDoanhThu_InDay();
                this.txtGuiXe.Text = sumGuiXe.ToString() + " VND";
                int sumSuaXe = this.doanhThuFixBUS.sumDoanhThu_InDay();
                this.txtSuaXe.Text = sumSuaXe.ToString() + " VND";
                int sumRuaXe = this.doanhThuWashBUS.sumDoanhThu_InDay();
                this.txtRuaXe.Text = sumRuaXe.ToString() + " VND";

                this.txtTongCong.Text = (sumGuiXe + sumRuaXe + sumSuaXe).ToString() + " VND";
            }    
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        private void fdoanhThu_Load(object sender, EventArgs e)
        {
            txt = lbContent.Text;
            len = txt.Length;
            lbContent.Text = "";
            timer1.Start();
            this.loadTxt();
        }

        private int xacDinhThu()
        {
            int thu = (int)DateTime.Now.DayOfWeek + 1;
            if (thu == 1)
                thu = 8;

            return thu;
        }

        private string LoaiGui(int type)
        {
            string LoaiGui = "";
            
            if (type == 0)
            {
                LoaiGui = "hourFee";
            }
            else if (type == 1)
            {
                LoaiGui = "dateFee";
            }
            else if (type == 2)
            {
                LoaiGui = "weekFee";
            }
            else
            {
                LoaiGui = "monthFee";
            }
            return LoaiGui;
        }

        private MemoryStream picture(int i)
        {
            byte[] pic;
            pic = (byte[])this.dgvExpired.CurrentRow.Cells[i].Value;
            MemoryStream picture = new MemoryStream(pic);
            return picture;
        }

        private void dgvExpired_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(dgvExpired, savefile.FileName);
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
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
        public void Export_Data_To_Word(DataGridView DGV, string filename)
        {
            //if (DGV.Rows.Count != 0)
            //{
            //    int RowCount = DGV.Rows.Count;
            //    int ColumnCount = DGV.Columns.Count;
            //    Object[,] DataArray = new object[RowCount + 1, ColumnCount + 1];

            //    //add row
            //    int r = 0;
            //    for (int c = 0; c <= ColumnCount - 1; c++)
            //    {
            //        for (r = 0; r <= RowCount - 1; r++)
            //        {
            //            DataArray[r, c] = DGV.Rows[r].Cells[c].Value;
            //        }
            //    }

            //    Document oDoc = new Document();

            //    oDoc.Application.Visible = true;
            //    //page orintation
            //    oDoc.PageSetup.Orientation = WdOrientation.wdOrientLandscape;
            //    dynamic oRange = oDoc.Content.Application.Selection.Range;
            //    //in ra doanh thu
            //    Object oMissing = System.Reflection.Missing.Value;
            //    var oPara1 = oDoc.Content.Paragraphs.Add(ref oMissing);
            //    string Temp = "\nSố Lượng xe đạp: " + this.txtSLXeDap.Text + "\n"
            //                  + "Doanh Thu xe đạp: " + this.txtDTXeDap.Text + "\n"
            //                  + "Số Lượng xe máy: " + this.txtSLXeMay.Text + "\n"
            //                  + "Doanh Thu xe máy: " + this.txtDTXeMay.Text + "\n"
            //                  + "Số Lượng xe hơi: " + this.txtSLXeHoi.Text + "\n"
            //                  + "Doanh Thu xe hơi: " + this.txtDTXeHoi.Text + "\n"
            //                  + "Tổng Doanh Thu trong ngày hôm nay: " + this.txtTong.Text + "\n";
            //    oPara1.Range.InsertBefore(Temp);
            //    oPara1.Range.InsertParagraph();

            //    string oTemp = "";
            //    //in ra bang
            //    for (r = 0; r <= RowCount - 1; r++)
            //    {
            //        for (int c = 0; c <= ColumnCount - 1; c++)
            //        {
            //            oTemp = oTemp + DataArray[r, c] + "\t";
            //        }
            //    }
            //    //table format
            //    oRange.Text = oTemp;

            //    object Separator = WdTableFieldSeparator.wdSeparateByTabs;
            //    object ApplyBorders = true;
            //    object AutoFit = true;
            //    object AutoFitBehavior = WdAutoFitBehavior.wdAutoFitContent;

            //    oRange.ConvertToTable(ref Separator, ref RowCount, ref ColumnCount,
            //                          Type.Missing, Type.Missing, ref ApplyBorders,
            //                          Type.Missing, Type.Missing, Type.Missing,
            //                          Type.Missing, Type.Missing, Type.Missing,
            //                          Type.Missing, ref AutoFit, ref AutoFitBehavior, Type.Missing);

            //    oRange.Select();

            //    oDoc.Application.Selection.Tables[1].Select();
            //    oDoc.Application.Selection.Tables[1].Rows.AllowBreakAcrossPages = 0;
            //    oDoc.Application.Selection.Tables[1].Rows.Alignment = 0;
            //    oDoc.Application.Selection.Tables[1].Rows[1].Select();
            //    oDoc.Application.Selection.InsertRowsAbove(1);
            //    oDoc.Application.Selection.Tables[1].Rows[1].Select();

            //    //header row style
            //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Bold = 1;
            //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Name = "Tahoma";
            //    oDoc.Application.Selection.Tables[1].Rows[1].Range.Font.Size = 14;

            //    //add header row manually
            //    for (int c = 0; c <= ColumnCount - 1; c++)
            //    {
            //        oDoc.Application.Selection.Tables[1].Cell(1, c + 1).Range.Text = DGV.Columns[c].HeaderText;
            //    }
            //    //table style
            //    oDoc.Application.Selection.Tables[1].set_Style("Grid Table 4 - Accent 5");
            //    oDoc.Application.Selection.Tables[1].Rows[1].Select();
            //    oDoc.Application.Selection.Cells.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;

            //    //header text
            //    foreach (Section section in oDoc.Application.ActiveDocument.Sections)
            //    {
            //        Range headerRange = section.Headers[WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
            //        headerRange.Fields.Add(headerRange, WdFieldType.wdFieldPage);
            //        headerRange.Text = "Bảng xe quá hạn";
            //        headerRange.Font.Size = 16;
            //        headerRange.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;
            //    }
            //    byte[] imgbyte;
            //    MemoryStream ms;
            //    Image finalPic;
            //    //save image
            //    for (r = 0; r <= RowCount - 1; r++)
            //    {
            //        imgbyte = (byte[])dgvExpired.Rows[r].Cells[2].Value;
            //        ms = new MemoryStream(imgbyte);
            //        finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
            //        Clipboard.SetDataObject(finalPic);
            //        oDoc.Application.Selection.Tables[1].Cell(r + 2, 3).Range.Paste();
            //        oDoc.Application.Selection.Tables[1].Cell(r + 2, 3).Range.InsertParagraph();

            //        imgbyte = (byte[])dgvExpired.Rows[r].Cells[3].Value;
            //        ms = new MemoryStream(imgbyte);
            //        finalPic = (Image)(new Bitmap(Image.FromStream(ms), new Size(70, 70)));
            //        Clipboard.SetDataObject(finalPic);
            //        oDoc.Application.Selection.Tables[1].Cell(r + 2, 4).Range.Paste();
            //        oDoc.Application.Selection.Tables[1].Cell(r + 2, 4).Range.InsertParagraph();
            //    }
                
            //    //save the file
            //    oDoc.SaveAs(filename);
            //}
        }

        private void cbThanhToan_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.cbThanhToan.SelectedIndex == 0)//gui xe
            {
                this.LoadDataGridView(this.doanhThuParkingBUS.getdoanhThuParking_InDay());
            }    
            else if (this.cbThanhToan.SelectedIndex == 1)
            {
                this.LoadDataGridView(this.doanhThuFixBUS.getDoanhThuFix_InDay());
            }
            else
            {
                this.LoadDataGridView(this.doanhThuWashBUS.getDoanhThuWash_InDay());
            }    
        }
    }
}
