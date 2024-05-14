using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;   
using ParkirApp.model;
using OfficeOpenXml.Style;
using OfficeOpenXml;
using System.IO;

namespace ParkirApp.view
{
    public partial class Laporan : UserControl
    {
        public Laporan()
        {
            InitializeComponent();
        }


        private void Laporan_Load(object sender, EventArgs e)
        {

        }

        private void BtnTampilkan_Click(object sender, EventArgs e)
        {

            dataGridView1.DataSource = LaporanM.GetListData(Datepicker1.Value.ToString("yyyy-MM-dd"), Datepicker2.Value.ToString("yyyy-MM-dd"));

        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            PrintPreviewDialog1.Document = PrintDocument1;
            PrintPreviewDialog1.ShowDialog();
        }

        private void PrintDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));

            e.Graphics.DrawImage(objBmp, 120, 100);

            e.Graphics.DrawString(label1.Text, new Font("Verdana", 30, FontStyle.Bold), Brushes.Black, new Point(300, 30));
        }

        private void ExportToExcel(DataGridView dataGridView, string searchData)
        {
            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet =
               excelPackage.Workbook.Worksheets.Add("Sheet1");

                for (int j = 1; j <= dataGridView.ColumnCount; j++)
                {
                    if (dataGridView.Columns[j - 1].HeaderText != null)
                    {
                        worksheet.Cells[1, j].Value = dataGridView.Columns[j -
                       1].HeaderText;
                    }
                }

                for (int i = 0; i < dataGridView.RowCount; i++)
                {
                    for (int j = 0; j < dataGridView.Rows[i].Cells.Count; j++)
                    {
                        string cellValue = (dataGridView.Rows[i].Cells[j].Value !=
                       null ? dataGridView.Rows[i].Cells[j].Value.ToString() : "");
                        worksheet.Cells[i + 2, j + 1].Value = cellValue;
                    }
                }
                FileInfo excelFile = new FileInfo(searchData);
                excelPackage.SaveAs(excelFile);
            }
        }


        private void btnExportExcel_Click(object sender, EventArgs e)
        {

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Excel Files|*.xlsx|All Files|*.*";
            saveFileDialog.FileName = "ExportedData.xlsx";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                string directory = Path.GetDirectoryName(saveFileDialog.FileName);
                string fileNameWithoutExt =
               Path.GetFileNameWithoutExtension(saveFileDialog.FileName);
                string extension = Path.GetExtension(saveFileDialog.FileName);
                int count = 1;
                string filePath = saveFileDialog.FileName;
                while (File.Exists(filePath))
                {
                    filePath = Path.Combine(directory, $"{fileNameWithoutExt} ({ count}){ extension} ");
                count++;
                }
                ExportToExcel(dataGridView1, filePath);
            }
        }
    }
}
