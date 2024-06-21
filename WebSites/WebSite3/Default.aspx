<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Главная</title>
    </head>
    <body>
        <form id="form1" runat="server">
            <div>
            <asp:Menu ID="Menu3" runat="server">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Catalog.aspx" Text="Каталог" Value="Каталог"></asp:MenuItem>
                </Items>
            </asp:Menu>
            </div>
    
            <asp:Menu ID="Menu2" runat="server">
                <Items>
                    <asp:MenuItem NavigateUrl="~/Registration.aspx" Text="Регистрация" Value="Регистрация"></asp:MenuItem>
                </Items>
            </asp:Menu>
    
                <asp:Menu ID="Menu1" runat="server">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Orders.aspx" Text="Заказы" Value="Заказы"></asp:MenuItem>
                    </Items>
                </asp:Menu>
    
                <asp:Button runat="server" ID="triggerButton" Text="Нажми кнопку" OnClick="triggerButton_Click" />
                <asp:Label runat="server" ID="resultLabel" />
        </form>
    </body>
</html>
