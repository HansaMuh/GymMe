<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="CustomerOrderSupplement.aspx.cs" Inherits="GymMe.Views.CustomerOrderSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Order Supplement | GymMe</title>
            <link href="../CSS/OrderSupplement.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                List of Available Supplements
            </h1>
            <asp:GridView ID="SupplementGrid" class="Order" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="SupplementGrid_SelectedIndexChanged">
                <Columns>
                    <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
                    <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
                    <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
                    <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
                    <asp:BoundField DataField="SupplementTypeId" HeaderText="Type ID" SortExpression="SupplementTypeId" />
                    <asp:TemplateField HeaderText="Order Supplement" ShowHeader="True">
                        <ItemTemplate>
                            <asp:Button ID="Order" runat="server" CommandName="Select" Text="Order" UseSubmitBehavior="false" class="but"/>
                            <asp:TextBox ID="Quantity" runat="server"  Text="1" TextMode="Number" Width="50px" class="quan"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
            <div class="ErrorMessage">
                <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
            <div class="Button">
                <asp:Button ID="ClearCart" runat="server" Text="Clear All Carts" OnClick="btnClearCart_Click" class="but-ac"/>
                <asp:Button ID="Checkout" runat="server" Text="Checkout Order" OnClick="btnCheckout_Click" class="but-ac"/>
            </div>

        </body>
    </html>
</asp:Content>
