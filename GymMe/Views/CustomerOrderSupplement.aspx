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
            <asp:GridView ID="SupplementGrid" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="SupplementGrid_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="SupplementID" HeaderText="SupplementId" SortExpression="SupplementID" />
                    <asp:BoundField DataField="SupplementName" HeaderText="SupplementName" SortExpression="SupplementName" />
                    <asp:BoundField DataField="SupplementExpiryDate" HeaderText="SupplementExpiryDate" SortExpression="SupplementExpiryDate" />
                    <asp:BoundField DataField="SupplementPrice" HeaderText="SupplementPrice" SortExpression="SupplementPrice" />
                    <asp:BoundField DataField="SupplementTypeId" HeaderText="SupplementTypeId" SortExpression="SupplementTypeId" />
                    <asp:TemplateField HeaderText="Order" ShowHeader="True">
                        <ItemTemplate>
                            <asp:Button ID="Order" runat="server" CommandName="Select" Text="Order" UseSubmitBehavior="false" />
                            <asp:TextBox ID="Quantity" runat="server"  Text="1" TextMode="Number" Width="50px" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="ErrorMessage">
                <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
            <div class="Button">
                <asp:Button ID="ClearCart" runat="server" Text="Clear Cart" OnClick="btnClearCart_Click"/>
                <asp:Button ID="Checkout" runat="server" Text="Checkout" OnClick="btnCheckout_Click"/>
            </div>

        </body>
    </html>
</asp:Content>
