using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorkToDB.Forms
{
    public partial class DeveleryForm : Form
    {
        public DeveleryForm()
        {
            InitializeComponent();
        }

        private void DeveleryForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Estimate". При необходимости она может быть перемещена или удалена.
            this.estimateTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Estimate);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Develery". При необходимости она может быть перемещена или удалена.
            this.develeryTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Develery);
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            this.develeryBindingSource.AddNew();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.develeryBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.develeryBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.develeryBindingSource.MoveNext();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            this.develeryBindingSource.MoveFirst();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            this.develeryBindingSource.MoveLast();
        }

        private void develeryBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.develeryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.develeryBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}