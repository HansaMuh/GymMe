<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminHistoryDetailView.aspx.cs" Inherits="GymMe.Views.AdminHistoryDetailView" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Transaction Detail View</title>
            <link href="../CSS/DetailCustomer.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                Transaction Detail View
            </h1>
            <asp:GridView ID="GridViewDetail" class="GridDetail" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="TransactionId" SortExpression="TransactionID" />
                    <asp:BoundField DataField="SupplementID" HeaderText="SupplementId" SortExpression="SupplementID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>
            </asp:GridView>
        </body>
    </html>
</asp:Content>
