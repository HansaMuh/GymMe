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
            <asp:GridView ID="SupplementGried" runat="server" AutoGenerateColumns="False"  OnSelectedIndexChanged="SupplementGried_SelectedIndexChanged" EnableEventValidation="True">
                <Columns>
                    <asp:BoundField DataField="SupplementID" HeaderText="SupplementId" SortExpression="SupplementID" />
                    <asp:BoundField DataField="SupplementName" HeaderText="SupplementName" SortExpression="SupplementName" />
                    <asp:BoundField HeaderText="SupplementExpiryDate" DataField="SupplementExpiryDate" SortExpression="SupplementExpiryDate" />
                    <asp:BoundField DataField="SupplementPrice" HeaderText="SupplementPrice" SortExpression="SupplementPrice" />
                    <asp:BoundField DataField="SupplementTypeId" HeaderText="SupplementTypeId" SortExpression="SupplementTypeId" />
                    <asp:TemplateField HeaderText="Order">
                        <ItemTemplate>
                            <asp:Button ID="Order" runat="server" CommandName="Order" CommandArgument="<%# ((GridViewRow) Container).RowIndex %>" Text="Order" />
                            <asp:TextBox ID="Quantity" runat="server" Text="1" TextMode="Number" Min="0" Width="50px"></asp:TextBox>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="ErrorMessage">
                <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
            <div class="Button">
                <asp:Button ID="ClearCart" runat="server" OnClick="btnClearCart_Click" Text="Clear Cart" />
                <asp:Button ID="Checkout" runat="server" OnClick="btnCheckout_Click" Text="Checkout" />
            </div>

        </body>
    </html>
</asp:Content>
