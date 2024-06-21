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
    public partial class EstimateForm : Form
    {
        public EstimateForm()
        {
            InitializeComponent();
        }

        private void estimateBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.estimateBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);

        }

        private void EstimateForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Estimate". При необходимости она может быть перемещена или удалена.
            this.estimateTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Estimate);
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            this.estimateBindingSource.AddNew();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.estimateBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.estimateBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.estimateBindingSource.MoveNext();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            this.estimateBindingSource.MoveFirst();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            this.estimateBindingSource.MoveLast();
        }

        private void estBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.estimateBindingSource.EndEdit();
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
                this.estimateBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}
