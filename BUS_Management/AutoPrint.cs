using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using Microsoft.Office.Interop.Word;

namespace BUS_Management
{
    class AutoPrint
    {
        vehicleParkingBUS vehicleBUS = new vehicleParkingBUS();
        doanhThuParkingBUS doanhThuParkingBUS = new doanhThuParkingBUS();
        doanhThuFixBUS doanhThuFixBUS = new doanhThuFixBUS();
        doanhThuWashBUS doanhThuWashBUS = new doanhThuWashBUS();
        public void Print()
        {
        // Phải chỉnh lại đường dẫn khi cài qua máy khác
            string name = @"D:\HK2N2\WIndow\DACK\DTMN\DTNgay" + DateTime.Now.ToString("dd/MM/yyyy").Replace("/","")+".docx";
            Export_AllData_To_Word(name, 1);
            MessageBox.Show("File saved!", "Message Dialog", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        public void Export_AllData_To_Word(string filename, int value)//1: Word,2: PDF
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
                string dtgx = this.doanhThuParkingBUS.sumDoanhThu_InDay().ToString().Trim();
                string dtsx = this.doanhThuFixBUS.sumDoanhThu_InDay().ToString().Trim();
                string dtrx = this.doanhThuWashBUS.sumDoanhThu_InDay().ToString().Trim();
                int dttotal = int.Parse(dtgx)+ int.Parse(dtsx) + int.Parse(dtrx);
                para1.Range.Text = "\nDoanh thu gửi Xe: " + dtgx +
                                    "\nDoanh thu Sửa Xe: " + dtsx +
                                    "\nDoanh thu Rửa Xe: " + dtrx +
                                    "\nTổng Doanh Thu: " + dttotal;
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
    }
}
