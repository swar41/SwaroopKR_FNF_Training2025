<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="AddWords.aspx.cs" Inherits="SampleWebFormsApp.Hackathon2.Q1.AddWords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Add Word</title>
    <style type="text/css">
        .auto-style1 {
            font-size: large;
        }
        .bb{
            background-color:antiquewhite;
        }
    </style>
</head>
<body class="bb">
    <form id="form1" runat="server">
        <div>
            <h4>&nbsp;</h4>
            <h3><span class="auto-style1">Word: </span>
            <asp:Label ID="lblWord" runat="server" Text="Word:" CssClass="auto-style1" />
            </h3>
            <br />
            Enter Translation of the above word :<br />
            <asp:TextBox ID="txtTranslation" runat="server" Height="53px" Width="300px" />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server"></asp:Label>
            <br />
            <br />
            <asp:Button ID="btnSave" runat="server" Text="Save" OnClick="btnSave_Click" />
        &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Show all data" />
&nbsp;
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Go Back" />
        </div>
    </form>
</body>
</html>
