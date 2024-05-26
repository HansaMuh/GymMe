<%@ Page Title="" Language="C#" MasterPageFile="~/Views/GymMeSite.Master" AutoEventWireup="true" CodeBehind="CustomerProfilePage.aspx.cs" Inherits="GymMe.Views.CustomerProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <html>
    <head>
        <title>ProfilePageForCustomer</title>
    </head>
    <body>
        <h1>
            Customer Information
        </h1>
        <section class="GeneralInfo">
            <div class="UserName">
                <asp:Label ID="LblName" runat="server" Text="Name" />
                <asp:TextBox ID="InputName" runat="server" />
            </div>

            <div class="UserEmail">
                <asp:Label ID="LblEmail" runat="server" Text="Email" />
                <asp:TextBox ID="InputEmail" runat="server" />
            </div>

            <div class="GenderUser">
                <asp:Label ID="LblGender" runat="server" Text="Gender" />
                <asp:RadioButton ID="InputGenderMale" runat="server" text="Male" GroupName="Gender" />
                <asp:RadioButton ID="InputGenderFemale" runat="server" text="Female" GroupName="Gender" />
            </div>

            <div class="DOBUser">
                <asp:Label ID="LblDOB" runat="server" Text="Date of Birth" />
                <asp:Calendar ID="InputCalender" runat="server" />
            </div>
            
            <asp:Button ID="ButtonUpdateDataInfo" runat="server" Text="Update Information" OnClick="ButtonUpdateData_Click" />
        </section>

        <div class="ErrorMessageUpdate">
            <asp:Label ID="LblErrorMsgUpdate" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
        </div>

        <h1>
            Update Password
        </h1>
        <section class="UpdatePassword">
            <div class="OldPasswordUser">
                <asp:Label ID="LblOldPassword" runat="server" Text="Old Password" />
                <asp:TextBox ID="InputOld" runat="server" TextMode="Password" />
            </div>

            <div class="NewpasswordUser">
                <asp:Label ID="LblNewPassword" runat="server" Text="New Password" />
                <asp:TextBox ID="InputNew" runat="server" TextMode="Password" />
            </div>
            <asp:Button ID="ButtonUpdatePassword" runat="server" Text="Update Password" OnClick="ButtonUpdatePassword_Click" />
        </section>
        <div class="ErrorMessageUpdatePass">
            <asp:Label ID="LblErrorMsgUpdatePass" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
        </div>
    </body>
    </html>
</asp:Content>
