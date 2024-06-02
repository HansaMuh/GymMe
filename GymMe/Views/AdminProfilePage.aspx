<%@ Page Title="" Language="C#" MasterPageFile="~/Views/HomeAdminPage.Master" AutoEventWireup="true" CodeBehind="AdminProfilePage.aspx.cs" Inherits="GymMe.Views.AdminProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html xmlns="http://www.w3.org/1999/xhtml">
        <head>
            <title>Admin Profile Page</title>
            <link href="../CSS/AdminProfile.css" rel="stylesheet" />
        </head>
        <body>
            <h1>
                Admin Information
            </h1>
            <section class="GeneralInfo">
                <div class="UserName">
                    <asp:Label ID="LblName" runat="server" Text="Name" />
                    <asp:TextBox ID="InputName" runat="server" />
                </div>
            
                <div class="UserEmail">
                    <asp:Label ID="LblEmail" runat="server" Text="Email" />
                    <asp:TextBox ID="InputEmail" class="input" runat="server" />
                </div>
            
                <div class="GenderUser">
                    <asp:Label ID="LblGender" runat="server" Text="Gender" />
                    <asp:RadioButton ID="InputGenderMale" runat="server" text="Male" GroupName="Gender" class="ButGen"/>
                    <asp:RadioButton ID="InputGenderFemale" runat="server" text="Female" GroupName="Gender" class="ButGen"/>
                </div>
            
                <div class="DOBUser">
                    <asp:Label ID="LblDOB" class="dob" runat="server" Text="Date of Birth" />
                    <asp:Calendar ID="InputCalender" runat="server" />
                </div>
                <asp:Button ID="ButtonUpdateData" runat="server" Text="Update Information" OnClick="ButtonUpdateData_Click" class="but"/>
            </section>
            <div class="ErrorMessageUpdate">
                <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
            <h1>
                Admin Password
            </h1>
            <section class="UpdatePassword">
                <div class="OldPasswordUser">
                    <asp:Label ID="LblOldPassword" runat="server" Text="Old Password" />
                    <asp:TextBox ID="InputOld" runat="server" TextMode="Password" class="input"/>
                </div>
            
                <div class="NewpasswordUser">
                    <asp:Label ID="LblNewPassword" runat="server" Text="New Password" />
                    <asp:TextBox ID="InputNew" runat="server" TextMode="Password" class="input"/>
                </div>
                <asp:Button ID="ButtonUpdatePassword" runat="server" Text="Update Password" OnClick="ButtonUpdatePassword_Click" class="but"/>
            </section>
            <div class="ErrorMessageUpdatePass">
                <asp:Label ID="LblErrorMsgUpdatePass" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
            </div>
        </body>
    </html>
</asp:Content>
