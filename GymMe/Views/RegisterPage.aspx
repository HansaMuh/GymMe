<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="GymMe.Views.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>RegisterPage</title>
</head>
<body>
    <form id="form1" runat="server">
        <div class="UserName">
            <asp:Label ID="LblName" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="InputName" runat="server"></asp:TextBox>
        </div>

        <div class="UserEmail">
            <asp:Label ID="LblEmail" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="InputEmail" runat="server"></asp:TextBox>
        </div>

         <div class="GenderUser">
             <asp:Label ID="LblGender" runat="server" Text="Gender"></asp:Label>
             <asp:RadioButton ID="InputGender" runat="server" text="Male" GroupName="Gender"/>
             <asp:RadioButton ID="InputGender" runat="server" text="Female" GroupName="Gender"/>
        </div>

         <div class="PasswordUser">
             <asp:Label ID="LblPassword" runat="server" Text="Password"></asp:Label>
             <asp:TextBox ID="InputPassword" runat="server"></asp:TextBox>
        </div>

         <div class="RepasswordUser">
             <asp:Label ID="LblRepassword" runat="server" Text="Re Tyoe Password"></asp:Label>
             <asp:TextBox ID="InputRePass" runat="server"></asp:TextBox>
        </div>

        <div class="DOBUser">
            <asp:Label ID="LblDOB" runat="server" Text="Date Of Birth"></asp:Label>
            <asp:Calendar ID="InputCallender" runat="server"></asp:Calendar>
        </div>

        <div class="SubmitRegis">
            <asp:Button ID="Submit_Input" runat="server" Text="Submit" OnClick="Submit_Input_Click" />
        </div>
    </form>
</body>
</html>
