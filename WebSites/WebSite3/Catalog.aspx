<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Catalog.aspx.cs" Inherits="Catalog" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
        <title>Каталог</title>
    </head>

    <body>
        <form id="form1" runat="server">
            <div>
    
                <asp:Menu ID="Menu1" runat="server">
                    <Items>
                        <asp:MenuItem NavigateUrl="~/Default.aspx" Text="На главную" Value="На главную"></asp:MenuItem>
                    </Items>
                </asp:Menu>
    
            </div>
            <asp:ListView ID="ListView1" runat="server" DataKeyNames="Code_client" DataSourceID="SqlDataSource">
                <AlternatingItemTemplate>
                    <span style="background-color: #FFF8DC;">Code_client:
                    <asp:Label ID="Code_clientLabel" runat="server" Text='<%# Eval("Code_client") %>' />
                    <br />
                    FIO:
                    <asp:Label ID="FIOLabel" runat="server" Text='<%# Eval("FIO") %>' />
                    <br />
                    Telephone:
                    <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    <br />
                    Adres:
                    <asp:Label ID="AdresLabel" runat="server" Text='<%# Eval("Adres") %>' />
                    <br />
                    <br />
                    </span>
                </AlternatingItemTemplate>
                <EditItemTemplate>
                    <span style="background-color: #008A8C;color: #FFFFFF;">Code_client:
                    <asp:Label ID="Code_clientLabel1" runat="server" Text='<%# Eval("Code_client") %>' />
                    <br />
                    FIO:
                    <asp:TextBox ID="FIOTextBox" runat="server" Text='<%# Bind("FIO") %>' />
                    <br />
                    Telephone:
                    <asp:TextBox ID="TelephoneTextBox" runat="server" Text='<%# Bind("Telephone") %>' />
                    <br />
                    Adres:
                    <asp:TextBox ID="AdresTextBox" runat="server" Text='<%# Bind("Adres") %>' />
                    <br />
                    <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Обновить" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Отмена" />
                    <br />
                    <br />
                    </span>
                </EditItemTemplate>
                <EmptyDataTemplate>
                    <span>Нет данных.</span>
                </EmptyDataTemplate>
                <InsertItemTemplate>
                    <span style="">FIO:
                    <asp:TextBox ID="FIOTextBox" runat="server" Text='<%# Bind("FIO") %>' />
                    <br />
                    Telephone:
                    <asp:TextBox ID="TelephoneTextBox" runat="server" Text='<%# Bind("Telephone") %>' />
                    <br />
                    Adres:
                    <asp:TextBox ID="AdresTextBox" runat="server" Text='<%# Bind("Adres") %>' />
                    <br />
                    <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Вставить" />
                    <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Очистить" />
                    <br />
                    <br />
                    </span>
                </InsertItemTemplate>
                <ItemTemplate>
                    <span style="background-color: #DCDCDC;color: #000000;">Code_client:
                    <asp:Label ID="Code_clientLabel" runat="server" Text='<%# Eval("Code_client") %>' />
                    <br />
                    FIO:
                    <asp:Label ID="FIOLabel" runat="server" Text='<%# Eval("FIO") %>' />
                    <br />
                    Telephone:
                    <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    <br />
                    Adres:
                    <asp:Label ID="AdresLabel" runat="server" Text='<%# Eval("Adres") %>' />
                    <br />
                    <br />
                    </span>
                </ItemTemplate>
                <LayoutTemplate>
                    <div style="font-family: Verdana, Arial, Helvetica, sans-serif;" id="itemPlaceholderContainer" runat="server">
                        <span runat="server" id="itemPlaceholder" />
                    </div>
                    <div style="text-align: center;background-color: #CCCCCC;font-family: Verdana, Arial, Helvetica, sans-serif;color: #000000;">
                    </div>
                </LayoutTemplate>
                <SelectedItemTemplate>
                    <span style="background-color: #008A8C;font-weight: bold;color: #FFFFFF;">Code_client:
                    <asp:Label ID="Code_clientLabel" runat="server" Text='<%# Eval("Code_client") %>' />
                    <br />
                    FIO:
                    <asp:Label ID="FIOLabel" runat="server" Text='<%# Eval("FIO") %>' />
                    <br />
                    Telephone:
                    <asp:Label ID="TelephoneLabel" runat="server" Text='<%# Eval("Telephone") %>' />
                    <br />
                    Adres:
                    <asp:Label ID="AdresLabel" runat="server" Text='<%# Eval("Adres") %>' />
                    <br />
                    <br />
                    </span>
                </SelectedItemTemplate>
            </asp:ListView>
            <asp:SqlDataSource ID="SqlDataSource" runat="server" ConnectionString="<%$ ConnectionStrings:poCS %>" SelectCommand="SELECT * FROM [Client]"></asp:SqlDataSource>
        </form>
    </body>
</html>
