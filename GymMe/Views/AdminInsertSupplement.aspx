<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminInsertSupplement.aspx.cs" Inherits="GymMe.Views.AdminInsertSupplement" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Insert Supplement | GymMe</title>
    <link href="../CSS/InsertNewItemStyle.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Fill in the following details to insert a new supplement:
    </h1>
    <section class="NewItem">
        <div class="SupName">
            <asp:Label class="name" ID="LblName" runat="server" Text="Supplement Name" />
            <asp:TextBox ID="InputName" runat="server" class="input" />
        </div>
                
        <div class="DOBSup">
            <asp:Label ID="LblDOB" runat="server" Text="Expiry Date" />
            <asp:Calendar ID="InputCalender" runat="server" />
        </div>

        <div class="Price">
            <asp:Label ID="LblPricce" runat="server" Text="Price" />
            <asp:TextBox ID="InputPrice" runat="server" class="input" />
        </div>

        <div class="ID_SUP">
            <asp:Label ID="LblId" runat="server" Text="Supplement Type ID" />
            <asp:TextBox ID="InputId" runat="server" class="input"/>
        </div>
        <asp:Button ID="ButtonInsert" runat="server" Text="Insert" OnClick="ButtonInsert_Click" class="but"/>
    </section>
    <div class="ErrorMessageUpdate">
        <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
    </div>
</asp:Content>
