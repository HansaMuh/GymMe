<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminQuequePage.aspx.cs" Inherits="GymMe.Views.AdminQuequePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Transaction queque</title>
        </head>
        <body>
            <section class="Queque">
                <h1>
                    History Page
                </h1>
                <div class="que-Unhandled">
                    <h2>
                        Unhandled-Section
                    </h2>
                    <asp:GridView ID="UnhandledSituation" runat="server" AutoGenerateColumns="False" DataKeyNames="TransactionID">
                        <Columns>
                            <asp:BoundField DataField="TransactionID" HeaderText="TransactionId" SortExpression="TransactionID" />
                            <asp:BoundField DataField="UserID" HeaderText="UserId" SortExpression="UserID" />
                            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                            <asp:TemplateField HeaderText="Action" ShowHeader="True">
                                <ItemTemplate>
                                    <asp:Button ID="WillHandled" runat="server" Text="Handled" CommandArgument='<%# Eval("TransactionID") %>' OnClick="ClickHandle" />
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>

                <div class="que-handled">
                    <h2>
                        handled-Section
                    </h2>
                    <asp:GridView ID="HandledSituation" runat="server" AutoGenerateColumns="False">
                        <Columns>
                            <asp:BoundField DataField="TransactionID" HeaderText="TransactionId" SortExpression="TransactionID" />
                            <asp:BoundField DataField="UserID" HeaderText="UserId" SortExpression="UserID" />
                            <asp:BoundField DataField="TransactionDate" HeaderText="TransactionDate" SortExpression="TransactionDate" />
                            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                        </Columns>
                    </asp:GridView>
                </div>
            </section>
        </body>
    </html>
</asp:Content>
