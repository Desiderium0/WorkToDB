using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Registration : System.Web.UI.Page
{
    protected void Enter_Click(object sender, EventArgs e)
    {
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["poCS"].ConnectionString);
        SqlCommand insertCommand = new SqlCommand("INSERT INTO Users (Name, Password) VALUES (@Name, @Password)", connection);

        insertCommand.Parameters.Add("Name", System.Data.SqlDbType.Char, 30).Value = NameBox.Text;
        insertCommand.Parameters.Add("Password", System.Data.SqlDbType.Char, 30).Value = PasswordBox.Text;
        connection.Open();
        int queryResult = insertCommand.ExecuteNonQuery();
        connection.Close();
    }
}