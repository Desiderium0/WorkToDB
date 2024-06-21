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


namespace WorkToDB.Forms
{
    public partial class MaterialFormTable : Form
    {
        public MaterialFormTable()
        {
            InitializeComponent();
        }

        private void materialsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }

        private void MaterialFormTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Materials". При необходимости она может быть перемещена или удалена.
            this.materialsTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Materials);

        }

        private void deleteDataMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialsBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void saveMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Удалена строка ссылающаяся на другую таблицу.\nПерезапустите форму.", "Ошибка!");
            }
        }

        private void ExcelMenuItem_Click(object sender, EventArgs e)
        {
            Excel.Application app = new Excel.Application();
            Excel.Workbook workbook = app.Workbooks.Add(Type.Missing);
            Excel.Worksheet worksheet = null;
            app.Visible = true;
            worksheet = (Excel.Worksheet)workbook.Worksheets.get_Item(1);
            worksheet = workbook.ActiveSheet;

            for (int i = 1; i < materialsDataGridView.Columns.Count + 1; i++)
                worksheet.Cells[1, i] = materialsDataGridView.Columns[i - 1].HeaderText;

            for (int i = 0; i < materialsDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < materialsDataGridView.Columns.Count; j++)
                {
                    if (materialsDataGridView.Rows[i].Cells[j].Value != null)
                        worksheet.Cells[i + 2, j + 1] = materialsDataGridView.Rows[i].Cells[j].Value.ToString();
                    else
                        worksheet.Cells[i + 2, j + 1] = "";
                }
            }
        }

        private void HTMLMenuItem_Click(object sender, EventArgs e)
        {
            int i, j;
            saveFileDialog.DefaultExt = "html";
            saveFileDialog.Filter = "HTML files(*.html) |*.html";
            saveFileDialog.Title = "Экспорт: HTML";
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                System.IO.FileStream BookStream = new System.IO.FileStream(saveFileDialog.FileName, System.IO.FileMode.Create);
                try
                {
                    System.IO.StreamWriter StreamWriterBook = new System.IO.StreamWriter(BookStream);
                    /*далее прописываются теги HTML документа
                      Обязательные элементы: <html>
                                             <head>
                                             <title>_</title>
                                             </head>
                                             <body>
                                             </body>
                                             </html>
                     Также используем элемент <table>
                     Остальное -- просто дизайн страницы
                   */
                    StreamWriterBook.WriteLine("<html>");
                    StreamWriterBook.WriteLine("<head>");
                    StreamWriterBook.WriteLine("<meta content=\"text/html; charset=utf-8\" http-equiv=\"Content-Type\">");
                    StreamWriterBook.WriteLine("<title>Поставщики книг</title>");
                    StreamWriterBook.WriteLine("</head>");
                    StreamWriterBook.WriteLine("<body bgcol-or=\"000000\">");
                    //создание таблицы для вывода данных
                    StreamWriterBook.WriteLine("<table align=\"center\" cols=0 cellspacing=0>");
                    //вывод заголовков полей
                    StreamWriterBook.WriteLine("<tr>");
                    StreamWriterBook.WriteLine("<td colspan=6 align=\"center\" valign=\"top\">Поставщики");
                    StreamWriterBook.WriteLine("</td>");
                    StreamWriterBook.WriteLine("</tr>");
                    StreamWriterBook.WriteLine("<tr>");
                    for (j = 0; j < dB_PlasticWindowsDataSet.Materials.Columns.Count; j++)
                    {
                        StreamWriterBook.WriteLine("<td><font face=\"Verdana\" size=\"2\" color=\"8100cc\"><b>");
                        StreamWriterBook.WriteLine("" + dB_PlasticWindowsDataSet.Materials.Columns[j].ColumnName);
                        StreamWriterBook.WriteLine("</b></font></td>");
                    }
                    StreamWriterBook.WriteLine("</tr>");
                    for (i = 0; i < dB_PlasticWindowsDataSet.Materials.Rows.Count; i++)
                    {
                        if (i % 2 == 0)
                        {
                            StreamWriterBook.WriteLine("<tr bgcolor=\"3399cc\">");
                            for (j = 0; j < dB_PlasticWindowsDataSet.Materials.Columns.Count; j++)
                            {
                                StreamWriterBook.WriteLine("<td><font face=\"Verdana\" size=\"2\" color=\"000000\"><p align=\"center\">");
                                StreamWriterBook.WriteLine("" + dB_PlasticWindowsDataSet.Materials.Rows[i][j]);
                                StreamWriterBook.WriteLine("</font></td>");
                            }
                        }
                        else
                        {
                            StreamWriterBook.WriteLine("<tr>");
                            for (j = 0; j < dB_PlasticWindowsDataSet.Materials.Columns.Count; j++)
                            {
                                StreamWriterBook.WriteLine("<td><font face=\"Verdana\" size=\"2\" color=\"a1a1a1\"><p align=\"center\">");
                                StreamWriterBook.WriteLine("" + dB_PlasticWindowsDataSet.Materials.Rows[i][j]);
                                StreamWriterBook.WriteLine("</font></td>");
                            }
                            StreamWriterBook.WriteLine("</tr>");
                        }
                    }
                    StreamWriterBook.WriteLine("</table></center></body></html>");
                    MessageBox.Show("Экспорт успешно завершен!", "Экспорт...", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    StreamWriterBook.Flush();
                }
                catch
                {
                    MessageBox.Show("При передаче данных возникла ошибка!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                BookStream.Close();
                System.Diagnostics.Process.Start(BookStream.Name);
            }
        }

        private void CloseMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AppExitMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void UndoStripMenuItem_Click(object sender, EventArgs e)
        {
            this.materialsBindingSource.CancelEdit();
        }

        private void AddStripMenuItem8_Click(object sender, EventArgs e)
        {
            this.materialsBindingSource.AddNew();
        }

        private void DeleteStripMenuItem9_Click(object sender, EventArgs e)
        {
            try
            {
                this.materialsBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void SaveStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.materialsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Удалена строка ссылающаяся на другую таблицу.\nПерезапустите форму.", "Ошибка!");
            }
        }
    }
}
