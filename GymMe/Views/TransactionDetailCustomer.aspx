﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="TransactionDetailCustomer.aspx.cs" Inherits="GymMe.Views.TransactionDetailCustomer" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Transaction Details | GymMe</title>
    <link href="../CSS/DetailCustomer.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        List of Transaction Details
    </h1>
    <asp:GridView ID="GridTransactionDetail" class="GridDetail" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="SupplementID" HeaderText="Supplement ID" SortExpression="SupplementID" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>

    </asp:GridView>
</asp:Content>
