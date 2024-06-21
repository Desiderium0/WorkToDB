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
    public partial class BuyerForm : Form
    {
        public BuyerForm()
        {
            InitializeComponent();
        }

        private void BuyerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Buyer". При необходимости она может быть перемещена или удалена.
            this.buyerTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Buyer);
        }

        private void AddRecordButton_Click(object sender, EventArgs e)
        {
            this.buyerBindingSource.AddNew();
        }

        private void DeleteRecordButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.buyerBindingSource.RemoveCurrent();
            }
            catch
            {
                MessageBox.Show("Удаление невозможно", "Ошибка!");
            }
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.buyerBindingSource.MovePrevious();
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            this.buyerBindingSource.MoveNext();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            this.buyerBindingSource.MoveFirst();
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            this.buyerBindingSource.MoveLast();
        }

        private void tableButtom_Click(object sender, EventArgs e)
        {
            var listBuyerForm = new ListBuyerForm();
            listBuyerForm.Show();
        }

        private void buyerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.buyerBindingSource.EndEdit();
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
                this.buyerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.dB_PlasticWindowsDataSet);
            }
            catch
            {
                MessageBox.Show("Проверьте правильность ввода данных!");
            }
        }
    }
}
