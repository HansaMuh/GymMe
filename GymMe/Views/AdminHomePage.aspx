<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminHomePage.aspx.cs" Inherits="GymMe.Views.AdminHomePage" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <link href="../CSS/HistoryCustomer.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Home</h2>
    <p>Welcome back, Administrator!</p>
    <p></p>
    <h2>List of Customers</h2>
    <asp:GridView ID="CustomerViewTable" class="GridHistory" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="ID" SortExpression="UserID" />
            <asp:BoundField DataField="UserName" HeaderText="Name" SortExpression="UserName" />
            <asp:BoundField DataField="UserEmail" HeaderText="Email" SortExpression="UserEmail" />
            <asp:BoundField DataField="UserDOB" DataFormatString="{0:d}" HeaderText="Date of Birth" SortExpression="UserDOB" />
            <asp:BoundField DataField="UserGender" HeaderText="Gender" SortExpression="UserGender" />
        </Columns>
    </asp:GridView>
</asp:Content>
