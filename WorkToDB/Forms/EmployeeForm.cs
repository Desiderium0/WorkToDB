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
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void employeeBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employeeBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Employee". При необходимости она может быть перемещена или удалена.
            this.employeeTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Employee);
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.AddNew();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.employeeBindingSource.RemoveCurrent();
            }
            catch (Exception)
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MoveNext();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MoveFirst();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            this.employeeBindingSource.MoveLast();
        }

        private void emplBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.employeeBindingSource.EndEdit();
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
                this.employeeBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}
