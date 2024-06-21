using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace WorkToDB.Forms
{
    public partial class QueryForm : Form
    {
        public QueryForm()
        {
            InitializeComponent();
        }

        private void ExecQuery1_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Materials";

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand(select, sqlConnection);
            int rowsReturned = sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            DataSet dataSet = new DataSet();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(select, sqlConnection);
            dataAdapter.Fill(dataSet, "Materials");

            dataGridView1.DataSource = dataSet;
            dataGridView1.DataMember = "Materials";

        }

        private void ExecQuery2_Click(object sender, EventArgs e)
        {
            string select = "SELECT * FROM Contract";
            sqlConnection.Open();
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(select, sqlConnection);
            DataSet dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            sqlConnection.Close();
        }
    }
}
