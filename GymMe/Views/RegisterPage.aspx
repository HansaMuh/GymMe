<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="GymMe.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegisterPage</title>
</head>
<body>
    <form id="form1" runat="server">
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

        <div class="PasswordUser">
            <asp:Label ID="LblPassword" runat="server" Text="Password" />
            <asp:TextBox ID="InputPassword" runat="server" TextMode="Password" />
        </div>

        <div class="RepasswordUser">
            <asp:Label ID="LblConfirmPassword" runat="server" Text="Confirm Password" />
            <asp:TextBox ID="InputConfirm" runat="server" TextMode="Password" />
        </div>

        <div class="DOBUser">
            <asp:Label ID="LblDOB" runat="server" Text="Date of Birth" />
            <asp:Calendar ID="InputCalender" runat="server" />
        </div>

        <div class="SubmitRegis">
            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click" />
        </div>

        <div class="ErrorMessage">
            <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
        </div>
    </form>
</body>
</html>
