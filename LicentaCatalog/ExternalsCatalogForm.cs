using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LicentaCatalog
{
    public partial class ExternalsCatalogForm : Form
    {
        public ExternalsCatalogForm()
        {
            InitializeComponent();
        }
        int idUser;
        public ExternalsCatalogForm(int idUser)
        {
            InitializeComponent();
            this.idUser = idUser;
        }

        private void ExternalsCatalogForm_Load(object sender, EventArgs e)
        {
            gridCatalogY1.BorderStyle = BorderStyle.None;
            gridCatalogY1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridCatalogY1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCatalogY1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridCatalogY1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCatalogY1.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridCatalogY1.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridCatalogY1.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY1.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY1.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridCatalogY1.EnableHeadersVisualStyles = false;
            gridCatalogY1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCatalogY1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCatalogY1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridCatalogY2.BorderStyle = BorderStyle.None;
            gridCatalogY2.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridCatalogY2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCatalogY2.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridCatalogY2.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCatalogY2.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridCatalogY2.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridCatalogY2.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY2.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY2.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridCatalogY2.EnableHeadersVisualStyles = false;
            gridCatalogY2.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCatalogY2.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCatalogY2.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridCatalogY3.BorderStyle = BorderStyle.None;
            gridCatalogY3.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridCatalogY3.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCatalogY3.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridCatalogY3.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCatalogY3.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridCatalogY3.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridCatalogY3.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY3.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY3.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridCatalogY3.EnableHeadersVisualStyles = false;
            gridCatalogY3.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCatalogY3.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCatalogY3.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            gridCatalogY4.BorderStyle = BorderStyle.None;
            gridCatalogY4.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(168, 218, 220);
            gridCatalogY4.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            gridCatalogY4.DefaultCellStyle.SelectionBackColor = Color.FromArgb(29, 53, 87);
            gridCatalogY4.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            gridCatalogY4.BackgroundColor = Color.FromArgb(3, 56, 125);
            gridCatalogY4.DefaultCellStyle.BackColor = Color.FromArgb(241, 250, 238);
            gridCatalogY4.DefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY4.AlternatingRowsDefaultCellStyle.Font = new Font("Microsoft Tai Le", 10);
            gridCatalogY4.ColumnHeadersDefaultCellStyle.Font = new Font("Microsoft Tai Le", 11);
            gridCatalogY4.EnableHeadersVisualStyles = false;
            gridCatalogY4.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            gridCatalogY4.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            gridCatalogY4.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;

            BLExternals bl = new BLExternals();
            DataTable dataTable = bl.GetStudents(idUser);
            comboBoxStudents.ValueMember = "StudentId";
            comboBoxStudents.DisplayMember = "StudentInfo";
            comboBoxStudents.DataSource = dataTable;
            comboBoxStudents.SelectedItem = null;
            gridCatalogY1.Visible = false;
            gridCatalogY2.Visible = false;
            gridCatalogY3.Visible = false;
            gridCatalogY4.Visible = false;
            lblY1.Visible = false;
            lblY2.Visible = false;
            lblY3.Visible = false;
            lblY4.Visible = false;
            btnExportExcel.Visible = false;
        }

        private void comboBoxStudents_SelectionChangeCommitted(object sender, EventArgs e)
        {
            lblSearchMsg.Visible = false;
            btnExportExcel.Visible = true;
            gridCatalogY1.Visible = false;
            gridCatalogY2.Visible = false;
            gridCatalogY3.Visible = false;
            gridCatalogY4.Visible = false;
            lblY1.Visible = false;
            lblY2.Visible = false;
            lblY3.Visible = false;
            lblY4.Visible = false;

            BLExternals bl = new BLExternals();
            int studyYear = bl.GetYear(Convert.ToInt32(comboBoxStudents.SelectedValue));
            if (studyYear >= 1)
            {
                if (studyYear >= 2)
                {
                    if (studyYear >= 3)
                    {
                        if (studyYear >= 4)
                        {
                            DataTable tableY4 = bl.GetCatalogInfoPerYear(Convert.ToInt32(comboBoxStudents.SelectedValue), 4);
                            gridCatalogY4.DataSource = tableY4;
                            gridCatalogY4.Columns["CourseName"].HeaderText = "Materie";
                            gridCatalogY4.Columns["PartialExam"].HeaderText = "Partial";
                            gridCatalogY4.Columns["FinalExam"].HeaderText = "Final";
                            gridCatalogY4.Columns["Laboratory"].HeaderText = "Laborator";
                            gridCatalogY4.Columns["Seminary"].HeaderText = "Seminar";
                            gridCatalogY4.Columns["BonusPoints"].HeaderText = "Puncte bonus";
                            gridCatalogY4.Columns["Total"].HeaderText = "Total";
                            gridCatalogY4.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
                            gridCatalogY4.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                            gridCatalogY4.Visible = true;
                            lblY4.Visible = true;
                        }

                        DataTable tableY3 = bl.GetCatalogInfoPerYear(Convert.ToInt32(comboBoxStudents.SelectedValue), 3);
                        gridCatalogY3.DataSource = tableY3;
                        gridCatalogY3.Columns["CourseName"].HeaderText = "Materie";
                        gridCatalogY3.Columns["PartialExam"].HeaderText = "Partial";
                        gridCatalogY3.Columns["FinalExam"].HeaderText = "Final";
                        gridCatalogY3.Columns["Laboratory"].HeaderText = "Laborator";
                        gridCatalogY3.Columns["Seminary"].HeaderText = "Seminar";
                        gridCatalogY3.Columns["BonusPoints"].HeaderText = "Puncte bonus";
                        gridCatalogY3.Columns["Total"].HeaderText = "Total";
                        gridCatalogY3.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
                        gridCatalogY3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                        gridCatalogY3.Visible = true;
                        lblY3.Visible = true;
                    }

                     DataTable tableY2 = bl.GetCatalogInfoPerYear(Convert.ToInt32(comboBoxStudents.SelectedValue), 2);
                    gridCatalogY2.DataSource = tableY2;
                    gridCatalogY2.Columns["CourseName"].HeaderText = "Materie";
                    gridCatalogY2.Columns["PartialExam"].HeaderText = "Partial";
                    gridCatalogY2.Columns["FinalExam"].HeaderText = "Final";
                    gridCatalogY2.Columns["Laboratory"].HeaderText = "Laborator";
                    gridCatalogY2.Columns["Seminary"].HeaderText = "Seminar";
                    gridCatalogY2.Columns["BonusPoints"].HeaderText = "Puncte bonus";
                    gridCatalogY2.Columns["Total"].HeaderText = "Total";
                    gridCatalogY2.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
                    gridCatalogY2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    gridCatalogY2.Visible = true;
                    lblY2.Visible = true;
                }

                DataTable tableY1 = bl.GetCatalogInfoPerYear(Convert.ToInt32(comboBoxStudents.SelectedValue), 1);
                gridCatalogY1.DataSource = tableY1;
                gridCatalogY1.Columns["CourseName"].HeaderText = "Materie";
                gridCatalogY1.Columns["PartialExam"].HeaderText = "Partial";
                gridCatalogY1.Columns["FinalExam"].HeaderText = "Final";
                gridCatalogY1.Columns["Laboratory"].HeaderText = "Laborator";
                gridCatalogY1.Columns["Seminary"].HeaderText = "Seminar";
                gridCatalogY1.Columns["BonusPoints"].HeaderText = "Puncte bonus";
                gridCatalogY1.Columns["Total"].HeaderText = "Total";
                gridCatalogY1.Columns["LastUpdate"].HeaderText = "Ultima actualizare";
                gridCatalogY1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                gridCatalogY1.Visible = true;
                lblY1.Visible = true;
            }
        }
        private void buttonExportExcel_Click(object sender, EventArgs e)
        {
            if (comboBoxStudents.SelectedValue != null)
            {
                using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx|Excel 97-2003 Workbook|*.xls|Excel Workbook(.csv)|*.csv" })
                {
                    sfd.InitialDirectory = "C";
                    sfd.Title = "SAVE AS EXCEL FILE";
                    sfd.FileName = "Export note - " + comboBoxStudents.GetItemText(comboBoxStudents.SelectedItem);
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        String path = sfd.FileName;

                        BLExternals bl = new BLExternals();
                        int studentId = Convert.ToInt32(comboBoxStudents.SelectedValue);
                        int studyYear = bl.GetYear(Convert.ToInt32(comboBoxStudents.SelectedValue));
                        DataTable tableY1 = bl.GetCatalogInfoPerYear(studentId, 1);
                        DataTable tableY2 = bl.GetCatalogInfoPerYear(studentId, 2);
                        DataTable tableY3 = bl.GetCatalogInfoPerYear(studentId, 3);
                        DataTable tableY4 = bl.GetCatalogInfoPerYear(studentId, 4);

                        tableY1.Columns["CourseName"].ColumnName = "Materie";
                        tableY1.Columns["PartialExam"].ColumnName = "Examen partial";
                        tableY1.Columns["FinalExam"].ColumnName = "Examen final";
                        tableY1.Columns["Laboratory"].ColumnName = "Laborator";
                        tableY1.Columns["Seminary"].ColumnName = "Seminar";
                        tableY1.Columns["BonusPoints"].ColumnName = "Puncte bonus";
                        tableY1.Columns["Total"].ColumnName = "Total";
                        tableY1.Columns["LastUpdate"].ColumnName = "Ultima actualizare";

                        Microsoft.Office.Interop.Excel.Application excel;
                        Microsoft.Office.Interop.Excel.Workbook excelworkBook;
                        Microsoft.Office.Interop.Excel.Worksheet excelSheet;
                        Microsoft.Office.Interop.Excel.Range excelCellrange;

                        try
                        {
                            if (studyYear >= 1)
                            {
                                // Start Excel and get Application object.
                                excel = new Microsoft.Office.Interop.Excel.Application();

                                // for making Excel visible
                                excel.Visible = false;
                                excel.DisplayAlerts = false;

                                // Creation a new Workbook
                                excelworkBook = excel.Workbooks.Add(Type.Missing);

                                // Workk sheet
                                excelSheet = (Microsoft.Office.Interop.Excel.Worksheet)excelworkBook.ActiveSheet;
                                excelSheet.Name = "Catalog";

                                excelSheet.Cells[1, 1] = comboBoxStudents.GetItemText(comboBoxStudents.SelectedItem) + ", " + DateTime.Now.ToShortDateString();

                                // loop through each row and add values to our sheet
                                int rowcount = 2;

                                for (int i = 1; i <= tableY1.Columns.Count; i++)
                                {
                                    // on the first iteration we add the column headers
                                    excelSheet.Cells[2, i] = tableY1.Columns[i - 1].ColumnName;
                                    excelSheet.Cells.Font.Color = System.Drawing.Color.Black;
                                }

                                excelSheet.Cells[rowcount + 1, 1] = "Anul 1";
                                excelSheet.Range[excelSheet.Cells[rowcount + 1, 1], excelSheet.Cells[rowcount + 1, tableY1.Columns.Count]].Merge();
                                excelSheet.Range[excelSheet.Cells[rowcount + 1, 1], excelSheet.Cells[rowcount + 1, tableY1.Columns.Count]].Cells.Font.Size = 14;
                                excelSheet.Cells[rowcount + 1, 1].Font.Bold = true;
                                excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount + 1, tableY1.Columns.Count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                rowcount = 3;

                                foreach (DataRow datarow in tableY1.Rows)
                                {
                                    rowcount += 1;
                                    for (int i = 1; i <= tableY1.Columns.Count; i++)
                                    {

                                        excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();
                                        if (i != 1)
                                            excelSheet.Cells[rowcount, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                        if (i == tableY1.Columns.Count - 1)
                                            excelSheet.Cells[rowcount, i].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

                                        //for alternate rows
                                        if (rowcount > 3)
                                        {
                                            if (i == tableY1.Columns.Count)
                                            {
                                                if (rowcount % 2 == 0)
                                                {
                                                    excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, tableY1.Columns.Count]];
                                                    FormattingExcelCells(excelCellrange, "#aec4d1", System.Drawing.Color.Black, false);
                                                    excelSheet.Cells[rowcount, i - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                                                }

                                            }
                                        }
                                    }

                                }
                                if (studyYear >= 2)
                                {
                                    excelSheet.Cells[rowcount + 2, 1] = "Anul 2";
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY2.Columns.Count]].Merge();
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY2.Columns.Count]].Cells.Font.Size = 14;
                                    excelSheet.Cells[rowcount + 2, 1].Font.Bold = true;
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY2.Columns.Count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                                    rowcount = rowcount + 2;
                                    foreach (DataRow datarow in tableY2.Rows)
                                    {
                                        rowcount += 1;
                                        for (int i = 1; i <= tableY2.Columns.Count; i++)
                                        {
                                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                                            if (i != 1)
                                                excelSheet.Cells[rowcount, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                            if (i == tableY1.Columns.Count - 1)
                                                excelSheet.Cells[rowcount, i].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

                                            //for alternate rows
                                            if (rowcount > 3)
                                            {
                                                if (i == tableY2.Columns.Count)
                                                {
                                                    if (rowcount % 2 == 0)
                                                    {
                                                        excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, tableY2.Columns.Count]];
                                                        FormattingExcelCells(excelCellrange, "#aec4d1", System.Drawing.Color.Black, false);
                                                        excelSheet.Cells[rowcount, i - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                                                    }

                                                }
                                            }

                                        }

                                    }
                                }
                                if (studyYear >= 3)
                                {
                                    excelSheet.Cells[rowcount + 2, 1] = "Anul 3";
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY3.Columns.Count]].Merge();
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY3.Columns.Count]].Cells.Font.Size = 14;
                                    excelSheet.Cells[rowcount + 2, 1].Font.Bold = true;
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY3.Columns.Count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                                    rowcount = rowcount + 2;
                                    foreach (DataRow datarow in tableY3.Rows)
                                    {
                                        rowcount += 1;
                                        for (int i = 1; i <= tableY3.Columns.Count; i++)
                                        {
                                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                                            if (i != 1)
                                                excelSheet.Cells[rowcount, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                            if (i == tableY1.Columns.Count - 1)
                                                excelSheet.Cells[rowcount, i].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

                                            //for alternate rows
                                            if (rowcount > 3)
                                            {
                                                if (i == tableY3.Columns.Count)
                                                {
                                                    if (rowcount % 2 == 0)
                                                    {
                                                        excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, tableY3.Columns.Count]];
                                                        FormattingExcelCells(excelCellrange, "#aec4d1", System.Drawing.Color.Black, false);
                                                        excelSheet.Cells[rowcount, i - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                                                    }

                                                }
                                            }

                                        }

                                    }
                                }
                                if (studyYear >= 4)
                                {
                                    excelSheet.Cells[rowcount + 2, 1] = "Anul 4";
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY4.Columns.Count]].Merge();
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY4.Columns.Count]].Cells.Font.Size = 14;
                                    excelSheet.Cells[rowcount + 2, 1].Font.Bold = true;
                                    excelSheet.Range[excelSheet.Cells[rowcount + 2, 1], excelSheet.Cells[rowcount + 2, tableY4.Columns.Count]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                                    rowcount = rowcount + 2;
                                    foreach (DataRow datarow in tableY4.Rows)
                                    {
                                        rowcount += 1;
                                        for (int i = 1; i <= tableY4.Columns.Count; i++)
                                        {
                                            excelSheet.Cells[rowcount, i] = datarow[i - 1].ToString();

                                            if (i != 1)
                                                excelSheet.Cells[rowcount, i].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                                            if (i == tableY1.Columns.Count - 1)
                                                excelSheet.Cells[rowcount, i].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);

                                            //for alternate rows
                                            if (rowcount > 3)
                                            {
                                                if (i == tableY4.Columns.Count)
                                                {
                                                    if (rowcount % 2 == 0)
                                                    {
                                                        excelCellrange = excelSheet.Range[excelSheet.Cells[rowcount, 1], excelSheet.Cells[rowcount, tableY4.Columns.Count]];
                                                        FormattingExcelCells(excelCellrange, "#aec4d1", System.Drawing.Color.Black, false);
                                                        excelSheet.Cells[rowcount, i - 1].Font.Color = System.Drawing.ColorTranslator.ToOle(System.Drawing.Color.Red);
                                                    }

                                                }
                                            }

                                        }

                                    }
                                }
                                // now we resize the columns
                                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[rowcount, tableY1.Columns.Count]];
                                excelCellrange.EntireColumn.AutoFit();
                                Microsoft.Office.Interop.Excel.Borders border = excelCellrange.Borders;
                                border.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                                border.Weight = 2d;


                                excelCellrange = excelSheet.Range[excelSheet.Cells[1, 1], excelSheet.Cells[2, tableY1.Columns.Count]];
                                FormattingExcelCells(excelCellrange, "#007099", System.Drawing.Color.White, true);


                                //now save the workbook and exit Excel


                                excelworkBook.SaveAs(path); ;
                                excelworkBook.Close();
                                excel.Quit();
                                MessageBox.Show("Fisierul a fost exportat cu succes.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                        }
                        finally
                        {
                            excelSheet = null;
                            excelCellrange = null;
                            excelworkBook = null;
                        }
                    }
                }
            }
        }
        public void FormattingExcelCells(Microsoft.Office.Interop.Excel.Range range, string HTMLcolorCode, System.Drawing.Color fontColor, bool IsFontbool)
        {
            range.Interior.Color = System.Drawing.ColorTranslator.FromHtml(HTMLcolorCode);
            range.Font.Color = System.Drawing.ColorTranslator.ToOle(fontColor);
            if (IsFontbool == true)
            {
                range.Font.Bold = IsFontbool;
            }
        }
    }
}
