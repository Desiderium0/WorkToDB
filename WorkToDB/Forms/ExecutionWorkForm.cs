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
    public partial class ExecutionWorkForm : Form
    {
        public ExecutionWorkForm()
        {
            InitializeComponent();
        }

        private void executionWorkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.executionWorkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);

        }

        private void ExecutionWorkForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Contract". При необходимости она может быть перемещена или удалена.
            //this.contractTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.ExecutionWork". При необходимости она может быть перемещена или удалена.
            this.executionWorkTableAdapter.Fill(this.dB_PlasticWindowsDataSet.ExecutionWork);

        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            this.executionWorkBindingSource.AddNew();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.executionWorkBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.executionWorkBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.executionWorkBindingSource.MoveNext();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            this.executionWorkBindingSource.MoveFirst();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            this.executionWorkBindingSource.MoveLast();
        }

        private void toTableForm_Click(object sender, EventArgs e)
        {
            var executionWorkFormTable = new ExecutionWorkFormTable();
            executionWorkFormTable.Show();
        }

        private void executBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.executionWorkBindingSource.EndEdit();
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
                this.executionWorkBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}
