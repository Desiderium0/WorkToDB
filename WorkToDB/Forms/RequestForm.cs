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
    public partial class RequestForm : Form
    {
        public RequestForm()
        {
            InitializeComponent();
        }

        private void RequestButton_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                sqlCommand.Parameters["@dateStart"].Value = DateTime.Parse(maskedTextBox1.Text);
                sqlCommand.Parameters["@dateEnd"].Value = DateTime.Parse(maskedTextBox2.Text);

                sqlCommand.ExecuteNonQuery();
                sqlConnection.Close();

                int count_save = (int)sqlCommand.Parameters["@count"].Value;
                countBox.Text = Convert.ToString(count_save);
            }
            catch
            {
                MessageBox.Show("Не верная дата!");
            }
        }
    }
}
