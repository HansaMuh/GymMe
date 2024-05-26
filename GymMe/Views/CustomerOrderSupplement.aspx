<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="CustomerOrderSupplement.aspx.cs" Inherits="GymMe.Views.CustomerOrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Customer Order</title>
        </head>
        <body>
            <h1>
                Supplement Item
            </h1>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="SupplementID" HeaderText="SupplementId" SortExpression="SupplementID" />
                    <asp:BoundField DataField="SupplementName" HeaderText="SupplementName" SortExpression="SupplementName" />
                    <asp:BoundField HeaderText="SupplementExpiryDate" DataField="SupplementExpiryDate" SortExpression="SupplementExpiryDate" />
                    <asp:BoundField DataField="SupplementPrice" HeaderText="SupplementPrice" SortExpression="SupplementPrice" />
                    <asp:BoundField DataField="SupplementTypeId" HeaderText="SupplementTypeId" SortExpression="SupplementTypeId" />
                    <asp:ButtonField ButtonType="Button" CommandName="Select" HeaderText="Order" ShowHeader="True" Text="Buy" />
                </Columns>

            </asp:GridView>
        </body>
    </html>
</asp:Content>
