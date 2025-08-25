<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="SampleWebFormsApp.HomePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>UserApp</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>USER APP</h1>
            <asp:Button Text="Login" ID="btnLogin" runat="server" OnClick="btnLogin_Click"/>
            <asp:Button Text="SignUp" ID="btnSignUp" runat="server" OnClick="btnSignUp_Click"/>
        </div>
    </form>
</body>
</html>
