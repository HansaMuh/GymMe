<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminUpdateSupplement.aspx.cs" Inherits="GymMe.Views.AdminUpdateSupplement" %>
<asp:Content ID="Content0" ContentPlaceHolderID="ContentPlaceHolder0" runat="server">
    <title>Update Supplement | GymMe</title>
    <link href="../CSS/UpdateSupplement.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Supplement Information
    </h1>
    <section class="Update-suppliment">
        <div class="SupName">
            <asp:Label ID="LblName" runat="server" Text="Supplement Name" />
            <asp:TextBox ID="InputName" runat="server" class="input"/>
        </div>
                
        <div class="DOBSup">
            <asp:Label ID="LblDOB" runat="server" Text="Expiry Date" />
            <asp:Calendar ID="InputCalender" runat="server" class="input"/>
        </div>
            
        <div class="Price">
            <asp:Label ID="LblPricce" runat="server" Text="Price" />
            <asp:TextBox ID="InputPrice" runat="server" class="input"/>
        </div>
            
        <div class="ID_SUP">
            <asp:Label ID="LblId" runat="server" Text="Supplement Type ID" />
            <asp:TextBox ID="InputId" runat="server" class="input"/>
        </div>
        <asp:Button ID="ButtonUpdate" runat="server" Text="Update Supplement" OnClick="ButtonUpdate_Click" class="but"/>
    </section>
    <div class="ErrorMessageUpdate">
        <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
    </div>
</asp:Content>
