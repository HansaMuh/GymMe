<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="GymMe.Views.AdminHomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
    <head>
        <title>
            Admin Home Page
        </title>
        
    </head>
    <body>
        <h2>Home</h2>
        <p>Welcome back, Administrator!</p>
        <asp:GridView ID="HistoryViewTable" class="GridHistory" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="HistoryViewTable_SelectedIndexChanged1" OnRowDataBound="HistoryTableRow">
            <Columns>
                <asp:BoundField DataField="Users.UserName" HeaderText="CustomerName" SortExpression="Users.UserName" />
                <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                <asp:TemplateField HeaderText="Action" ShowHeader="True">
                    <ItemTemplate>
                        <asp:Button ID="Detail" runat="server" Text="View Details" CommandName="Select" class="but" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </body>
    </html>
</asp:Content>
