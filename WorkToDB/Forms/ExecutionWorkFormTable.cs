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
    public partial class ExecutionWorkFormTable : Form
    {
        public ExecutionWorkFormTable()
        {
            InitializeComponent();
        }

        private void executionWorkBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.executionWorkBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);

        }

        private void ExecutionWorkFormTable_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Employee);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Contract". При необходимости она может быть перемещена или удалена.
            this.contractTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Contract);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.ExecutionWork". При необходимости она может быть перемещена или удалена.
            this.executionWorkTableAdapter.Fill(this.dB_PlasticWindowsDataSet.ExecutionWork);

        }

        private void RefreshButton_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.executionWorkBindingSource.EndEdit();
            this.executionWorkTableAdapter.Update(this.dB_PlasticWindowsDataSet);
        }

        private void ClearFilterButton_Click(object sender, EventArgs e)
        {
            executionWorkBindingSource.Filter = string.Empty;
        }

        private void FilterByEmployeeButton_Click(object sender, EventArgs e)
        {
            int currentRowIndex;

            try
            {
                if (executionWorkDataGridView.CurrentCell == null)
                    throw new Exception();
                else
                    currentRowIndex = executionWorkDataGridView.CurrentCell.RowIndex;

                executionWorkBindingSource.Filter = "employeeID = " + executionWorkDataGridView[1, currentRowIndex].Value;
            }
            catch
            {
                MessageBox.Show("Текущий пользователь не был найден", "Внимание!");
            }
        }

        private void FilterByDateButton_Click(object sender, EventArgs e)
        {
            int currentRowIndex;

            try
            {
                if (executionWorkDataGridView.CurrentCell == null)
                    throw new Exception();
                else
                    currentRowIndex = executionWorkDataGridView.CurrentCell.RowIndex;

                executionWorkBindingSource.Filter = String.Format("dateStart = '{0:dd.MM.yyyy}'", executionWorkDataGridView[2, currentRowIndex].Value);
            }
            catch
            {
                MessageBox.Show("Текущий пользователь не был найден", "Внимание!");
            }
        }

        private void FilterByStatusBytton_Click(object sender, EventArgs e)
        {
            int currentRowIndex;

            try
            {
                if (executionWorkDataGridView.CurrentCell == null)
                    throw new Exception();
                else
                    currentRowIndex = executionWorkDataGridView.CurrentCell.RowIndex;

                executionWorkBindingSource.Filter = $"statusExecution = '{executionWorkDataGridView[3, currentRowIndex].Value}'";
            }
            catch
            {
                MessageBox.Show("Текущий статус не был найден", "Внимание!");
            }
        }

        private void buyerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
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
