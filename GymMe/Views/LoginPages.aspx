    <%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPages.aspx.cs" Inherits="GymMe.Views.LoginPages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login | GymMe</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Login to GymMe
        </h1>
        <div class="profile-name">
            <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="inputusername" runat="server"></asp:TextBox>
        </div>

        <div class="profile-email">
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="inputpassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        
        <div class="rembemberME">
            <asp:CheckBox ID="CheckBox" runat="server" text="Remember Me"/>
        </div>

        <div class="Button">
            <asp:Button ID="BtnSubmit" runat="server" Text="Login" OnClick="BtnSubmit_Click"/>
            <asp:Button ID="BtnRegis" runat="server" Text="Register" OnClick="BtnRegis_Click"/>
        </div>

        <div class="ErrorMessage">
            <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
        </div>

    </form>
</body>
</html>
