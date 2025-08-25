<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SignUp.aspx.cs" Inherits="SampleWebFormsApp.SignUp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Sign Up</h1>
            <hr />
            <p>
                Name:
                <asp:TextBox runat="server" ID="txtName"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtName" ErrorMessage="Username is required" ForeColor="IndianRed" Display="Dynamic"></asp:RequiredFieldValidator>
            </p>
            <p>
                Password:
                <asp:TextBox runat="server" ID="txtPassword" TextMode="Password"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtPassword" ErrorMessage="Password is Required" ForeColor="IndianRed"></asp:RequiredFieldValidator>
            </p>
            <p>
                Reenter Password:
                <asp:TextBox runat="server" ID="txtRePassword" TextMode="Password"></asp:TextBox>
                <asp:CompareValidator runat="server" ErrorMessage="Password not matching" ForeColor="IndianRed" ControlToValidate="txtPassword" ControlToCompare="txtRePassword" ValueToCompare="txtPassword" Display="Dynamic"></asp:CompareValidator>
            </p>
            <p>
                Email:
                <asp:TextBox runat="server" ID="txtEmail"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ControlToValidate="txtEmail" ErrorMessage="Email is Required" ForeColor="IndianRed" Display="Dynamic"></asp:RequiredFieldValidator>
                <asp:RegularExpressionValidator runat="server" ErrorMessage="Enter in correct format" ControlToValidate="txtEmail" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ForeColor="IndianRed" Display="Dynamic"></asp:RegularExpressionValidator>
                
            </p>
            <p>
                Age:
                <asp:TextBox runat="server" ID="txtAge" TextMode="Number"></asp:TextBox>
                <asp:RequiredFieldValidator runat="server" ErrorMessage="Age is required" ControlToValidate="txtAge" ForeColor="IndianRed"></asp:RequiredFieldValidator>
                <asp:RangeValidator runat="server" ControlToValidate="txtAge" MinimumValue="18" MaximumValue="50" ErrorMessage="Age must be b/w 18 and 50" ForeColor="IndianRed" Type="Integer" Display="Dynamic"></asp:RangeValidator>
            </p>
            <asp:Button Text="Save" ID="btnSave" runat="server" OnClick="btnSave_Click" />
            <br />
            <br />
            <asp:Label ID="lblError" runat="server" BorderColor="#00CC00" BorderStyle="Dotted" ForeColor="Red" Height="126px" Width="438px"></asp:Label>
        </div>
    </form>
</body>
</html>
