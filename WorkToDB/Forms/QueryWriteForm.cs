using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkToDB.Forms
{
    public partial class QueryWriteForm : Form
    {
        public QueryWriteForm()
        {
            InitializeComponent();
        }

        private void executeQueryButton_Click(object sender, EventArgs e)
        {
            try
            {
                string select = Convert.ToString(richTextBox1.Text);

                sqlConnection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(select, sqlConnection);
                DataSet dataSet = new DataSet();
                adapter.Fill(dataSet);
                dataGridView1.DataSource = dataSet.Tables[0];
                sqlConnection.Close();
            }
            catch
            {
                MessageBox.Show("Пустой или не правильно записанный запрос!", "Ошибка!");
            }
        }
    }
}
