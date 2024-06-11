<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="CustomerOrderSupplement.aspx.cs" Inherits="GymMe.Views.CustomerOrderSupplement" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Order Supplement | GymMe</title>
    <link href="../CSS/OrderSupplement.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        List of Available Supplements
    </h1>
    <asp:GridView ID="SupplementGrid" class="Order" runat="server" AutoGenerateColumns="False" OnSelectedIndexChanged="SupplementGrid_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="SupplementID" HeaderText="ID" SortExpression="SupplementID" />
            <asp:BoundField DataField="SupplementName" HeaderText="Name" SortExpression="SupplementName" />
            <asp:BoundField DataField="SupplementExpiryDate" DataFormatString="{0:d}" HeaderText="Expiry Date" SortExpression="SupplementExpiryDate" />
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice" />
            <asp:BoundField DataField="SupplementType.SupplementTypeName" HeaderText="Type Name" SortExpression="SupplementType.SupplementTypeName" />
            <asp:TemplateField HeaderText="Order Supplement" ShowHeader="True">
                <ItemTemplate>
                    <asp:Button ID="Order" runat="server" CommandName="Select" Text="Order" UseSubmitBehavior="false" class="but"/>
                    <asp:TextBox ID="Quantity" runat="server"  Text="1" TextMode="Number" Width="50px" class="quan"/>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>

    <div class="Button">
        <asp:Button ID="ClearCart" runat="server" Text="Clear All Carts" OnClick="btnClearCart_Click" class="but-ac"/>
        <asp:Button ID="Checkout" runat="server" Text="Checkout Order" OnClick="btnCheckout_Click" class="but-ac"/>
    </div>
    <div>
        <asp:Label ID="LblSuccessionMsg" runat="server" Text="" Visible="false" ForeColor="Green" />
    </div>
    <div>
        <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
    </div>

    <h1>
        List of Carts
    </h1>
    <asp:GridView ID="GridViewCart" class="Order" runat="server" AutoGenerateColumns="False">
        <Columns>
            <asp:BoundField DataField="CartID" HeaderText="ID" SortExpression="CartID" />
             <asp:BoundField DataField="Supplement.SupplementName" HeaderText="Supplement Name" SortExpression="Supplement.SupplementName" />
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity" />
        </Columns>
    </asp:GridView>
</asp:Content>
