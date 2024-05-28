﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminUpdateSupplement.aspx.cs" Inherits="GymMe.Views.AdminUpdateSupplement" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
        <head>
            <title>Update Suppliment page</title>
        </head>
        <body>
            <section class="Update-suppliment">
                <h1>
                    Update Suppliment Page
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
                <asp:Button ID="ButtonUpdate" runat="server" Text="Update Data" OnClick="ButtonUpdate_Click" />
            </section>
            <div class="ErrorMessageUpdate">
                <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
        </body>
    </html>
</asp:Content>
