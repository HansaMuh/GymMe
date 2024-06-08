<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminManageSupplements.aspx.cs" Inherits="GymMe.Views.AdminManageSupplements" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Manage Supplements | GymMe</title>
    <link href="../CSS/ManageSupplementsStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Manage Supplements
    </h1>
    <section class="supp-detail">
        <asp:GridView ID="GridSupplement" DataKeyNames="SupplementId" runat="server" AutoGenerateColumns="False" OnRowEditing="GridViewSupplement_RowEditing" OnRowDeleting="GridViewSupplement_RowDeleting" OnSelectedIndexChanged="GridSupplement_SelectedIndexChanged">
            <Columns>
                <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName" />
                <asp:BoundField DataField="SupplementExpiryDate" DataFormatString="{0:d}" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
                <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                <asp:BoundField DataField="SupplementTypeId" HeaderText="Supplement Type ID" SortExpression="SupplementTypeId" />
                <asp:CommandField ButtonType="Button" HeaderText="Action" ShowCancelButton="False" ShowDeleteButton="True" ShowEditButton="True" ShowHeader="True" />
            </Columns>
        </asp:GridView>
    <asp:Button runat="server" Text="Insert New Supplement" OnClick="Unnamed1_Click" class="but-ac"/>
    </section>
</asp:Content>
