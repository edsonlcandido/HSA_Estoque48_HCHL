using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

namespace HSA_Estoque.View
{
    public partial class FormReport : Form
    {
        DataTable _dt;
        public string title { get; set; }
        FormReport()
        {
            InitializeComponent();
        }

        public FormReport(DataTable dt)
        {
            InitializeComponent();
            _dt = dt;
        }

        private void FormReportHistorico_Load(object sender, EventArgs e)
        {
            this.Text = $"{title} - Relatório";
            dataGridViewMain.DataSource = _dt;
        }

        private void exportarParaExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                Filter = "Planilhas Excel|*.xlsx",
                Title = "Exportar planilha excel"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        int ColumnsCount;

                        Excel.Application excelApp = new Excel.Application();
                        excelApp.Workbooks.Add();
                        Excel._Worksheet workSheet = excelApp.ActiveSheet;

                        ColumnsCount = _dt.Columns.Count;
                        object[] Header = new object[ColumnsCount];

                        // column headings
                        for (int i = 0; i < ColumnsCount; i++)
                            Header[i] = _dt.Columns[i].ColumnName;

                        Excel.Range HeaderRange = workSheet.get_Range((Excel.Range)(workSheet.Cells[1, 1]), (Excel.Range)(workSheet.Cells[1, ColumnsCount]));
                        HeaderRange.Value = Header;

                        // DataCells
                        int RowsCount = _dt.Rows.Count;
                        object[,] Cells = new object[RowsCount, ColumnsCount];

                        for (int j = 0; j < RowsCount; j++)
                            for (int i = 0; i < ColumnsCount; i++)
                                Cells[j, i] = _dt.Rows[j][i];

                        workSheet.get_Range((Excel.Range)(workSheet.Cells[2, 1]), (Excel.Range)(workSheet.Cells[RowsCount + 1, ColumnsCount])).Value = Cells;

                        workSheet.SaveAs(sfd.FileName);
                        Console.WriteLine("Planilha Salva");
                        excelApp.Visible = true;

                        //using (XLWorkbook xLWorkbook = new XLWorkbook())
                        //{
                        //    xLWorkbook.Worksheets.Add(dt, "Coletas");
                        //    xLWorkbook.SaveAs(sfd.FileName);
                        //}

                        MessageBox.Show($"{title} exportado para arquivo excel.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
