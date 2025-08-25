<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SampleWebFormsApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Login</h1>
            <hr />
            <p>
                Email:
    <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="Username is required" ForeColor="IndianRed"></asp:RequiredFieldValidator>
            </p>
            <p>
                Password:
    <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required" ForeColor="IndianRed"></asp:RequiredFieldValidator>
            </p>
            <asp:Button runat="server" ID="btnLogin" Text="Enter" OnClick="btnLogin_Click" />
            <asp:Button ID="btnSignUp" runat="server" Text="Sign Up" OnClick="btnSignUp_Click" />

             <asp:Label ID="lblError" runat="server" BorderColor="#00CC00" BorderStyle="Dotted" ForeColor="Red" Height="126px" Width="438px"></asp:Label>
        </div>
    </form>
</body>
</html>
