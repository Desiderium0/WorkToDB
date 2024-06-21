<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Registration.aspx.cs" Inherits="Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Регистрация пользователя</title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <h1>Регистрация</h1>
            </div>

            <div>
                <p>Введите логин: <asp:TextBox ID="NameBox" runat="server"/></p>
                <p>Введите пароль: <asp:TextBox ID="PasswordBox" runat="server"/></p>
                <p><asp:Button ID="Enter" runat="server" Text="Зарегистрироваться" OnClick="Enter_Click" Height="33px" Width="304px" /></p>
            </div>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:poCS %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
    
                <asp:Menu ID="Menu1" runat="server">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="На главную" Value="На главную"></asp:MenuItem>
                    </Items>
                </asp:Menu>
    
        </form>
    </body>
</html>
