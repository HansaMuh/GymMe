<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminInsertSupplement.aspx.cs" Inherits="GymMe.Views.AdminInsertSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Insert New Supplement</title>
        </head>
        <body>
            <section class="NewItem">
                <h1>
                    Add new Item
                </h1>
                <div class="SupName">
                    <asp:Label ID="LblName" runat="server" Text="Name Suppliment" />
                    <asp:TextBox ID="InputName" runat="server" />
                </div>
                
                <div class="DOBSup">
                    <asp:Label ID="LblDOB" runat="server" Text="Date" />
                    <asp:Calendar ID="InputCalender" runat="server" />
                </div>

                <div class="Price">
                    <asp:Label ID="LblPricce" runat="server" Text="Price Suppliment" />
                    <asp:TextBox ID="InputPrice" runat="server" />
                </div>

                <div class="ID_SUP">
                    <asp:Label ID="LblId" runat="server" Text="ID Suppliment" />
                    <asp:TextBox ID="InputId" runat="server" />
                </div>
                <asp:Button ID="ButtonInsert" runat="server" Text="Insert Data" OnClick="ButtonInsert_Click"/>
            </section>
            <div class="ErrorMessageUpdate">
                <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
        </body>
    </html>
</asp:Content>
