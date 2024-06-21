<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Orders.aspx.cs" Inherits="Orders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title></title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
                <h1>Сделать заказ</h1>  
            </div>
            <div>
                <table>
                    <tr>
                        <td>
                            Номер заказа:
                        </td>
                        <td>
                            <asp:TextBox ID="NumberBox" runat="server">0</asp:TextBox>
                        </td>
                        <td rowspan="4">
                            <asp:Calendar ID="Calendar" runat="server" >
                            </asp:Calendar>
                        </td>
                    </tr>

                    <tr>
                        <td>Логин:</td>
                        <td>
                          <asp:DropDownList ID="LoginList" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" />                        
                          <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:poCS %>" SelectCommand="SELECT * FROM [Users]"></asp:SqlDataSource>
                        </td>
                    </tr>

                    <tr>
                       <td>Номер продукта:</td>
                       <td>
                          <asp:DropDownList ID="Code_Product" runat="server" DataSourceID="SqlDataSource2" DataTextField="Code_Product" DataValueField="Code_Product" />
                          <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:poCS %>" SelectCommand="SELECT * FROM [Product]"></asp:SqlDataSource>
                       </td>
                    </tr>

                    <tr>
                        <td>Введите количество Продуктов:</td>
                        <td>
                             <asp:TextBox ID="AmountBox" runat="server">0</asp:TextBox>
                        </td>
                    </tr>

                    <tr>
                        <td colspan="3">
                            <asp:Button ID="Start" runat="server" Text="Отправить заказ" OnClick="Start_Click" />
                        </td>
                    </tr>               
                    <tr>
                        <td>
                <asp:Label runat="server" ID="resultLabel" /></td>
                    </tr>
                </table>
            </div>
            <p>
    
                <asp:Menu ID="Menu1" runat="server">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="На главную" Value="На главную"></asp:MenuItem>
                    </Items>
                </asp:Menu>
    
        </form>
    </body>
</html>
