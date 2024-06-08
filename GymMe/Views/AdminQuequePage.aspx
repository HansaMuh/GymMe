<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminQuequePage.aspx.cs" Inherits="GymMe.Views.AdminQuequePage" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Order Queues | GymMe</title>
    <link href="../CSS/AdminQuequeStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <section class="Queque">
        <h1>
            List of Order Queues
        </h1>
        <h2>
            Unhandled Orders
        </h2>
        <div class="que-Unhandled">
            <asp:GridView ID="UnhandledSituation" runat="server" AutoGenerateColumns="False" DataKeyNames="TransactionID">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                    <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                    <asp:BoundField DataField="TransactionDate" DataFormatString="{0:d}" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                    <asp:TemplateField HeaderText="Action" ShowHeader="True">
                        <ItemTemplate>
                            <asp:Button ID="WillHandled" class="but" runat="server" Text="Handle Order" CommandArgument='<%# Eval("TransactionID") %>' OnClick="ClickHandle" />
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
        <h2>
            Handled Orders
        </h2>
        <div class="que-handled">
            <asp:GridView ID="HandledSituation" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="TransactionID" HeaderText="Transaction ID" SortExpression="TransactionID" />
                    <asp:BoundField DataField="UserID" HeaderText="User ID" SortExpression="UserID" />
                    <asp:BoundField DataField="TransactionDate" DataFormatString="{0:d}" HeaderText="Transaction Date" SortExpression="TransactionDate" />
                    <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                </Columns>
            </asp:GridView>
        </div>
    </section>
</asp:Content>
