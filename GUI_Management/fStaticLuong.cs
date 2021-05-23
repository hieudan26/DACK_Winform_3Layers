using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_Management;
using BUS_Management;
using Microsoft.Office.Interop.Word;
using System.IO;

namespace GUI_Management
{
    public partial class fStaticLuong : Form
    {
        danhSachLuongDaThanhToanBUS danhSachLuongDaThanhToanBUS = new danhSachLuongDaThanhToanBUS();

        public fStaticLuong()
        {
            InitializeComponent();
        }

        private void fStaticLuong_Load(object sender, EventArgs e)
        {
            this.LoadDataGridView();
            this.LoadLabel();
            this.LoadChart();
        }

        private void LoadChart()
        {
            this.chart1.Series["Series1"].Points.AddXY("Bảo Vệ", int.Parse(this.txtBV.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Thợ Sửa", int.Parse(this.txtTS.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Thợ Rửa", int.Parse(this.txtTR.Text.Trim()));
            this.chart1.Series["Series1"].Points.AddXY("Nhân Viên", int.Parse(this.txtNV.Text.Trim()));
            this.chart1.Series[0].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.RangeBar;
        }

        private void LoadLabel()
        {
            System.Data.DataTable table = new System.Data.DataTable();
            table = this.danhSachLuongDaThanhToanBUS.sum("Bảo Vệ");
            if (table != null)
            { 
                this.txtBV.Text = table.Rows[0][0].ToString().Trim();
            }    
            else
            {
                this.txtBV.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Thợ Sửa");
            if (table != null)
            {
                this.txtTS.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtTS.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Thợ Rửa");
            if (table != null)
            {
                this.txtTR.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtTR.Text = "0";
            }

            table = this.danhSachLuongDaThanhToanBUS.sum("Nhân Viên");
            if (table != null)
            {
                this.txtNV.Text = table.Rows[0][0].ToString().Trim();
            }
            else
            {
                this.txtNV.Text = "0";
            }
        }

        private void LoadDataGridView()
        {
            try
            {
                this.dgv.ReadOnly = true;
                this.dgv.DataSource = this.danhSachLuongDaThanhToanBUS.getFullInfo();
                this.dgv.RowTemplate.Height = 50;
                this.dgv.AllowUserToAddRows = false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e.Message);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            string nameType = "Lịch Sử Thanh Toán Tiền Lương Cho Nhân Viên";

            SaveFileDialog savefile = new SaveFileDialog();
            savefile.DefaultExt = "*.docx";
            savefile.Filter = "DOCX files(*.docx)|*.docx";
            if (savefile.ShowDialog() == DialogResult.OK && savefile.FileName.Length > 0)
            {
                Export_Data_To_Word(this.dgv, savefile.FileName, nameType);
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
        public void Export_Data_To_Word(DataGridView DGV, string filename, string nameType)
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
                paraHeading.Range.Text = "Công Ty TNHH MTV SPKT";
                paraHeading.Range.Font.Size = 14;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();

                paraHeading.Range.Text = "Phòng nhân sự";
                paraHeading.Range.Font.Size = 16;
                paraHeading.Range.Font.Name = "Times New Roman";
                paraHeading.Range.Bold = 1;
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                paraHeading.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                paraHeading.Range.InsertParagraphAfter();
                paraHeading.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;

                System.Data.DataTable table = DGV.DataSource as System.Data.DataTable;
                this.ExporterObjects_Paragraph(ref document, table, nameType);



                // Word.WdParagraphAlignment.wdAlignParagraphRight;
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
                para.Range.Font.Size = 13;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.Text = "\n" + namePara;
                para.Range.InsertParagraphAfter();


                para.Range.Font.Bold = 1;
                para.Range.Font.Size = 10;
                para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;
                if (datatable.Rows.Count > 0)
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.AllowAutoFit = true;
                    firstTable.Borders.Enable = 1;
                    
                    firstTable.Cell(1, 1).Range.Text = "ID Nhân Viên";
                    firstTable.Cell(1, 2).Range.Text = "Tên Nhân Viên";
                    firstTable.Cell(1, 3).Range.Text = "Loại Thợ";
                    firstTable.Cell(1, 4).Range.Text = "Ngày Thanh Toán";
                    firstTable.Cell(1, 5).Range.Text = "Lương";


                    Object beforeRow = Type.Missing;

                    para.Range.Font.Bold = 0;
                    para.Range.Font.Size = 10;
                    para.Range.Font.Color = Microsoft.Office.Interop.Word.WdColor.wdColorBlack;
                    para.Range.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphLeft;


                    for (int i = 0; i < datatable.Rows.Count; i++)
                    {
                        firstTable.Rows.Add(ref beforeRow);
                        firstTable.Cell(i + 2, 1).Range.Text = datatable.Rows[i][0].ToString();
                        firstTable.Cell(i + 2, 2).Range.Text = datatable.Rows[i][1].ToString();
                        firstTable.Cell(i + 2, 3).Range.Text = datatable.Rows[i][2].ToString();
                        firstTable.Cell(i + 2, 4).Range.Text = DateTime.Parse(datatable.Rows[i][3].ToString()).ToString("dd/MM/yyyy");
                        firstTable.Cell(i + 2, 5).Range.Text = datatable.Rows[i][4].ToString();
                    }
                }
                else
                {
                    Microsoft.Office.Interop.Word.Table firstTable = document.Tables.Add(para.Range, 1, datatable.Columns.Count, ref missing, ref missing);
                    firstTable.Borders.Enable = 1;
                    firstTable.Cell(1, 1).Range.Text = "ID Nhân Viên";
                    firstTable.Cell(1, 2).Range.Text = "Tên Nhân Viên";
                    firstTable.Cell(1, 3).Range.Text = "Loại Thợ";
                    firstTable.Cell(1, 4).Range.Text = "Ngày Thanh Toán";
                    firstTable.Cell(1, 5).Range.Text = "Lương";
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
