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
    public partial class AutorizationForm : Form
    {
        public AutorizationForm()
        {
            InitializeComponent();
        }

        private void ExecLoginButton_Click(object sender, EventArgs e)
        {
            string login = textBox1.Text;
            string password = textBox2.Text;

            try
            {
                if (!String.IsNullOrEmpty(login) && login.Length >= 5
                    && !String.IsNullOrEmpty(password) && password.Length >= 5)
                {
                    sqlConnection.Open();
                    sqlCommand.Parameters["@login"].Value = login;
                    sqlCommand.Parameters["@password"].Value = password;
                    sqlCommand.ExecuteNonQuery();
                    sqlConnection.Close();
                    MessageBox.Show("Пользователь добавлен!");
                }
                else
                    MessageBox.Show("Введите логин и пароль не менее 5 символов");
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно добавить пользователя!");
            }
        }

        private void Add_Click(object sender, EventArgs e)
        {
            try
            {
                sqlConnection.Open();

                sqlCommand1.Parameters["@text"].Value = $"GRANT {comboBox1.Text} ON {comboBox2.Text} TO {loginBox.Text}";
                
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Разрешение добавлено!");
            }
            catch (Exception)
            {
                MessageBox.Show("Невозможно добавление разрешение!\nПроверьте правильность ввода");
            }

        }
    }
}
