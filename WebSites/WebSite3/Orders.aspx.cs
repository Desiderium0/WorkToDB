using System;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class Orders : System.Web.UI.Page
{
    protected void Start_Click(object sender, EventArgs e)
    {
        int codeOrder, amount;
        SqlConnection connection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["poCS"].ConnectionString);
        SqlCommand insertCommand = new SqlCommand("INSERT INTO Orders (Code_order, Name, Code_Product, Date_order, Amount) VALUES (@Code_order, @Name, @Code_Product, @Date_order, @Amount)", connection);   

        connection.Open();

        if (!String.IsNullOrEmpty(NumberBox.Text))
            codeOrder = Convert.ToInt32(NumberBox.Text);
        else
        {
            codeOrder = 0;
            NumberBox.Text = "0";
        }

        if (!String.IsNullOrEmpty(AmountBox.Text))
            amount = Convert.ToInt32(AmountBox.Text);
        else
        {
            amount = 0;
            AmountBox.Text = "0";
        }
        try
        {
            insertCommand.Parameters.Add("Code_order", System.Data.SqlDbType.Int).Value = codeOrder;
            insertCommand.Parameters.Add("Name", System.Data.SqlDbType.Char, 30).Value = LoginList.SelectedValue;
            insertCommand.Parameters.Add("Code_Product", System.Data.SqlDbType.Int).Value = Code_Product.SelectedValue;
            insertCommand.Parameters.Add("Date_order", System.Data.SqlDbType.Date).Value = Calendar.SelectedDate;
            insertCommand.Parameters.Add("Amount", System.Data.SqlDbType.Int).Value = amount;
            int queryResult = insertCommand.ExecuteNonQuery();
            resultLabel.Text = "Запись добавлена!";
        }
        catch { resultLabel.Text = "Эта запись занята!"; }
        connection.Close();
    }
}