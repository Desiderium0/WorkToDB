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
    public partial class ListBuyerForm : Form
    {
        private DataGridViewColumn dataGridViewColumn;

        public ListBuyerForm()
        {
            InitializeComponent();
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

        private void ListBuyerForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dB_PlasticWindowsDataSet.Buyer". При необходимости она может быть перемещена или удалена.
            this.buyerTableAdapter.Fill(this.dB_PlasticWindowsDataSet.Buyer);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            sortButton.Enabled = true;
        }

        private void sortButton_Click(object sender, EventArgs e)
        {
            dataGridViewColumn = new DataGridViewColumn();

            switch (listBox1.SelectedIndex)
            {
                case 0:
                    dataGridViewColumn = dataGridViewTextBoxColumn1;
                    break;
                case 1:
                    dataGridViewColumn = dataGridViewTextBoxColumn2;
                    break;
                case 2:
                    dataGridViewColumn = dataGridViewTextBoxColumn4;
                    break;
                case 3:
                    dataGridViewColumn = dataGridViewTextBoxColumn3;
                    break;
                case 4:
                    dataGridViewColumn = dataGridViewTextBoxColumn6;
                    break;
                case 5:
                    dataGridViewColumn = dataGridViewTextBoxColumn5;
                    break;
            }
           
            if (ascendingRadioButton.Checked)
                buyerDataGridView.Sort(dataGridViewColumn, ListSortDirection.Ascending);
            else
                buyerDataGridView.Sort(dataGridViewColumn, ListSortDirection.Descending);
        }

        private void filterButton_Click(object sender, EventArgs e)
        {
            buyerBindingSource.Filter = $"adress = '{nameComboBox.Text}'";
        }

        private void findButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < buyerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < buyerDataGridView.RowCount; j++)
                {
                    buyerDataGridView[i, j].Style.BackColor = Color.White;
                    buyerDataGridView[i, j].Style.ForeColor = Color.Black;
                }
            }

            for (int i = 0; i < buyerDataGridView.ColumnCount; i++)
            {
                for (int j = 0; j < buyerDataGridView.RowCount - 1; j++)
                {
                    if (buyerDataGridView[i, j].Value.ToString().Contains(criterionTextBox.Text))
                    {
                        buyerDataGridView[i, j].Style.BackColor = Color.AliceBlue;
                        buyerDataGridView[i, j].Style.ForeColor = Color.Blue;
                    }
                }
            }
        }

        private void showAllButton_Click(object sender, EventArgs e)
        {
            buyerBindingSource.Filter = String.Empty;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
