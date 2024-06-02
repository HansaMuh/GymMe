<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminInsertSupplement.aspx.cs" Inherits="GymMe.Views.AdminInsertSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Insert New Supplement</title>
            <link href="../CSS/InsertNewItemStyle.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                Add new Item
            </h1>
            <section class="NewItem">
                <div class="SupName">
                    <asp:Label class="name" ID="LblName" runat="server" Text="Name Suppliment" />
                    <asp:TextBox ID="InputName" runat="server" class="input" />
                </div>
                
                <div class="DOBSup">
                    <asp:Label ID="LblDOB" runat="server" Text="Date" />
                    <asp:Calendar ID="InputCalender" runat="server" />
                </div>

                <div class="Price">
                    <asp:Label ID="LblPricce" runat="server" Text="Price Suppliment" />
                    <asp:TextBox ID="InputPrice" runat="server" class="input" />
                </div>

                <div class="ID_SUP">
                    <asp:Label ID="LblId" runat="server" Text="ID Suppliment" />
                    <asp:TextBox ID="InputId" runat="server" class="input"/>
                </div>
                <asp:Button ID="ButtonInsert" runat="server" Text="Insert Data" OnClick="ButtonInsert_Click" class="but"/>
            </section>
            <div class="ErrorMessageUpdate">
                <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
        </body>
    </html>
</asp:Content>
