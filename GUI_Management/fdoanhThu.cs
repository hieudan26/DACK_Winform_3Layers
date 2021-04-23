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
using System.Drawing.Printing;

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
            if (this.cbThanhToan.SelectedIndex != -1)
            {
                SaveFileDialog savefile = new SaveFileDialog();
                savefile.DefaultExt = "*.docx";
                savefile.Filter = "DOCX files(*.docx)|*.docx";

                if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
                {
                    MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Export_Data_To_Word(this.dgvExpired, savefile.FileName, 1);
                }
            }    
            else
            {
                MessageBox.Show("Chọn Bảng Cần Lưu", "Doanh Thu", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }    
        }

        private void btnSaveAll_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Export_AllData_To_Word(this.dgvExpired, savefile.FileName, 1);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.pdf";
            savefile.Filter = "PDF files(*.PDF)|*.pdf";

            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_AllData_To_Word(dgvExpired, savefile.FileName, 2);
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

        public void Export_AllData_To_Word(DataGridView DGV, string filename, int value)//1: Word,2: PDF
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
                paraHeading.Range.Text = "BẢNG DOANH THU NGÀY " + DateTime.Now.ToString("dd/MM/yyyy");
                paraHeading.Range.Font.Size = 28;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                paraHeading.Range.InsertParagraphAfter();

                this.ExporterObjects_Paragraph(ref document, this.doanhThuParkingBUS.getdoanhThuParking_InDay(), "Bảng gửi xe");
                this.ExporterObjects_Paragraph(ref document, this.doanhThuFixBUS.getDoanhThuFix_InDay(), "Bảng sửa xe ");
                this.ExporterObjects_Paragraph(ref document, this.doanhThuWashBUS.getDoanhThuWash_InDay(), "Bảng rửa xe");

                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Size = 16;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.Bold = 0;
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para1.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para1.Range.Text = "\nDoanh thu gửi Xe: " + this.txtGuiXe.Text +
                                    "\nDoanh thu Sửa Xe: " + this.txtSuaXe.Text +
                                    "\nDoanh thu Rửa Xe: " + this.txtRuaXe.Text +
                                    "\nTổng Doanh Thu: " + this.txtTongCong.Text;
                para1.Range.InsertParagraphAfter();


                // Word.WdParagraphAlignment.wdAlignParagraphRight;
                //Save pdf
                //object outputFileName = filename.Replace(".doc", ".pdf");
                //object fileFormat = WdSaveFormat.wdFormatPDF;
                //document.SaveAs(ref outputFileName, ref fileFormat);
                //Save the document
                if (value == 1)
                    document.SaveAs2(filename);
                else
                {
                    object outputFileName = filename.Replace(".doc", ".pdf");
                    object fileFormat = WdSaveFormat.wdFormatPDF;
                    document.SaveAs(ref outputFileName, ref fileFormat);
                }
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

        public void Export_Data_To_Word(DataGridView DGV, string filename, int value)//1: Word,2: PDF
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
                paraHeading.Range.Text = "BẢNG DOANH THU NGÀY " + DateTime.Now.ToString("dd/MM/yyyy");
                paraHeading.Range.Font.Size = 28;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                paraHeading.Range.InsertParagraphAfter();


                System.Data.DataTable table = DGV.DataSource as System.Data.DataTable;
                this.ExporterObjects_Paragraph(ref document, table, ("Bảng " + this.cbThanhToan.SelectedItem.ToString()));


                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                para1.Range.Font.Size = 16;
                para1.Range.Font.Name = "Times New Roman";
                para1.Range.Bold = 0;
                para1.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                para1.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para1.Range.Text = "\nDoanh thu gửi Xe: " + this.txtGuiXe.Text +
                                    "\nDoanh thu Sửa Xe: " + this.txtSuaXe.Text +
                                    "\nDoanh thu Rửa Xe: " + this.txtRuaXe.Text +
                                    "\nTổng Doanh Thu: " + this.txtTongCong.Text;
                para1.Range.InsertParagraphAfter();


                // Word.WdParagraphAlignment.wdAlignParagraphRight;
                //Save the document
                if (value == 1)
                    document.SaveAs2(filename);
                else
                {
                    object fileFormat = WdSaveFormat.wdFormatPDF;
                    document.SaveAs2(filename, ref fileFormat);
                }
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
                para.Range.Font.Size = 14;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                if (datatable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, datatable.Rows.Count, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "Biển số";
                    firstTable.Cell(1, 2).Range.Text = "Thời gian thanh toán";
                    firstTable.Cell(1, 3).Range.Text = "Tiền trả" + " (VNĐ)";
                    Object beforeRow = Type.Missing;

                    para.Range.Font.Bold = 0;
                    para.Range.Font.Size = 14;
                    para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        firstTable.Rows.Add(ref beforeRow);
                        firstTable.Cell(i + 2, 1).Range.Text = datatable.Rows[i][0].ToString();
                        firstTable.Cell(i + 2, 2).Range.Text = datatable.Rows[i][1].ToString();
                        firstTable.Cell(i + 2, 3).Range.Text = datatable.Rows[i][2].ToString();
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "Biển số";
                    firstTable.Cell(1, 2).Range.Text = "Thời gian thanh toán";
                    firstTable.Cell(1, 3).Range.Text = "Tiền trả" + " (VNĐ)";
                    Object beforeRow = Type.Missing;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" Err " + ex.Message);
            }
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
