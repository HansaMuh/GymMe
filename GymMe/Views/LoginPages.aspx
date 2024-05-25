<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPages.aspx.cs" Inherits="GymMe.Views.LoginPages" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>
            Login Page
        </h1>
        <div>
            <asp:Label ID="lblUsername" runat="server" Text="UserName"></asp:Label>
            <asp:TextBox ID="inputusername" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="inputpassword" runat="server" TextMode="Password"></asp:TextBox>
        </div>
        
        <div class="rembemberME">
            <asp:CheckBox ID="CheckBox" runat="server" text="Remember me"/>
        </div>

        <div class="SubmitLogin">
            <asp:Button ID="BtnSubmit" runat="server" Text="Submit" OnClick="BtnSubmit_Click"/>
        </div>

        <div class="ErrorMessage">
            <asp:Label ID="LblErrorMsg" runat="server" Text="Error Message" Visible="false" ForeColor="Red" />
        </div>

    </form>
</body>
</html>
