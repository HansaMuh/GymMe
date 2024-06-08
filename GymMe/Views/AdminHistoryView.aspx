﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminHistoryView.aspx.cs" Inherits="GymMe.Views.AdminHistoryView" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>All Transaction History | GymMe</title>
    <link href="../CSS/HistoryCustomer.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        All Transaction History
    </h1>
    <asp:GridView ID="HistoryViewTable" class="GridHistory" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="HistoryViewTable_SelectedIndexChanged1" OnRowDataBound="HistoryTableRow">
        <Columns>
            <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
            <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
            <asp:BoundField DataField="TransactionDate" DataFormatString="{0:d}" HeaderText="Transaction Date" SortExpression="TransactionDate" />
            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
            <asp:TemplateField HeaderText="Action" ShowHeader="True">
                <ItemTemplate>
                    <asp:Button ID="Detail" runat="server" Text="View Details" CommandName="Select" class="but" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
