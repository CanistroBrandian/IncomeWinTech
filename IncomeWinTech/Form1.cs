using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.Office.Interop.Excel;
using DataTable = System.Data.DataTable;

namespace IncomeWinTech
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public DataTable dataTableForImportCatalog = new DataTable();
        public DataTable dataTableForImportIncome = new DataTable();


        private void btn_ImportIncome_Click(object sender, EventArgs e)
        {
            int xlRow;
            string strFileName;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Excel Office | *.csv";
            fileDialog.ShowDialog();

            strFileName = fileDialog.FileName;

            string[] raw_text = File.ReadAllLines(strFileName, Encoding.Default);
            string[] data_col = null;
            var iteration = 0;

            foreach (string text_line in raw_text)
            {


                data_col = text_line.Split(';');

                if (iteration == 0)
                {
                    dataTableForImportIncome.Columns.Add("Артикул");
                    dataTableForImportIncome.Columns.Add("Название");
                    dataTableForImportIncome.Columns.Add("Количество");
                    dataTableForImportIncome.Columns.Add("Единица измерения");
                    dataTableForImportIncome.Columns.Add("Цена");
                    iteration++;
                }
                if (data_col != null)
                    dataTableForImportIncome.Rows.Add(data_col);

            }
            dataGridView1.DataSource = dataTableForImportIncome;
        }

        private void btn_ImportCatalog_Click(object sender, EventArgs e)
        {
            //    var application = new Microsoft.Office.Interop.Excel.Application();
            //       Microsoft.Office.Interop.Excel.Workbook workbook;
            //    Microsoft.Office.Interop.Excel.Worksheet worksheet;
            //    Microsoft.Office.Interop.Excel.Range range;
            //  //  var workbook = application.Workbooks;

            int xlRow;
            string strFileName;
            OpenFileDialog fileDialog = new OpenFileDialog();

            fileDialog.Filter = "Excel Office | *.csv";
            fileDialog.ShowDialog();

            strFileName = fileDialog.FileName;

            //    if (strFileName != string.Empty)
            //    {
            //        application = new Microsoft.Office.Interop.Excel.Application();
            //        workbook = application.Workbooks.Open(strFileName, Type.Missing,
            //Type.Missing,
            //XlFileFormat.xlCSV,   // Format
            //Type.Missing,
            //Type.Missing,
            //Type.Missing,
            //Type.Missing,
            //';',          // Delimiter
            //Type.Missing,
            //Type.Missing,
            //Type.Missing,
            //Type.Missing,
            //Type.Missing,
            //Type.Missing);
            //        worksheet = workbook.Worksheets[1];
            //        range = worksheet.UsedRange;



            //        int i = 0;
            //        for (xlRow = 1; xlRow <= range.Rows.Count; xlRow++)
            //        {

            //            i++;
            //            dataGridView1.Rows.Add(range.Cells[xlRow, 1].Text,
            //                range.Cells[xlRow, 2].Text,
            //                range.Cells[xlRow, 3].Text,
            //                range.Cells[xlRow, 4].Text,
            //                range.Cells[xlRow, 5].Text);
            //        }
            //        workbook.Close();
            //        application.Quit();
            //    }

          
            string[] raw_text = File.ReadAllLines(strFileName, Encoding.Default);
            string[] data_col = null;
            var iteration = 0;

            foreach (string text_line in raw_text)
            {
               

                data_col = text_line.Split(';');

                if (iteration == 0)
                {
                    dataTableForImportCatalog.Columns.Add("Артикул");
                    dataTableForImportCatalog.Columns.Add("Название");
                    dataTableForImportCatalog.Columns.Add("Количество");
                    dataTableForImportCatalog.Columns.Add("Единица измерения");
                    dataTableForImportCatalog.Columns.Add("Цена");
                    iteration++;
                }
                if (data_col != null)
                    dataTableForImportCatalog.Rows.Add(data_col);

            }
         
        }

        private void btn_ChangeId_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExportIncome_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
