<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminHistoryView.aspx.cs" Inherits="GymMe.Views.AdminHistoryView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Admin View History</title>
            <link href="../CSS/HistoryCustomer.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                History Transaction Of user
            </h1>
            <asp:GridView ID="HistoryViewTable" class="GridHistory" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="HistoryViewTable_SelectedIndexChanged1" OnRowDataBound="HistoryTableRow">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="TransactionId" SortExpression="TransactionID" />
                    <asp:BoundField DataField="UserID" HeaderText="UserId" SortExpression="UserID" />
                    <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
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
