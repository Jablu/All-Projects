<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Legacy3.aspx.cs" Inherits="Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="Assets/CSS/Default.css" rel="stylesheet" />
</head>
<body>
    <div class="mainDiv">
        <form id="loginForm" class="mainForm" runat="server">
        
            <%--<img class="iconSignIn" width="150px" height="60px" src="Assets/Images/icon.jpg" />--%>
            <p  class="textSignIn">Sign In</p>
            <p  class="textSignInDetails">with your Cafe Express Account</p>
            <asp:TextBox ID="unTB" runat="server" CssClass="unameSignIn" placeholder="Email or Username"></asp:TextBox>
            <br />
            <asp:TextBox ID="pwTB" runat="server" CssClass="unameSignIn" placeholder="Password"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="forgotPW" runat="server" Text="Forgot Password?" CssClass="textSignInDetails" ForeColor="#0078D7"></asp:Label>
            <br />
            <br /><br />

            <asp:Label ID="showBox" runat="server" Text="" ForeColor="OrangeRed" CssClass="textSignInDetails"></asp:Label>
            <br />

            <asp:Button ID="siBTN" runat="server" Text="Sign In" CssClass="gobtnSignIn" />

        </form>
    </div>
</body>
</html>
