<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="TransactionDetailCustomer.aspx.cs" Inherits="GymMe.Views.TransactionDetailCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Transaction Detail Customer</title>
            <link href="../CSS/DetailCustomer.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                Transaction Detail
            </h1>
            <asp:GridView ID="GridTransactionDetail" class="GridDetail" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="TransactionId" SortExpression="TransactionID" />
                    <asp:BoundField DataField="SupplementID" HeaderText="SupplementId" SortExpression="SupplementID" />
                    <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
                </Columns>

            </asp:GridView>
        </body>
    </html>
</asp:Content>
