<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SearchWords.aspx.cs" Inherits="SampleWebFormsApp.Hackathon2.Q1.SearchWords" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Search Application</title>
    <style type="text/css">
        .auto-style2 {
            background-color: #00FFCC;
        }
        .bb{
            background-color:antiquewhite;
        }

    </style>
</head>
<body class="bb">
    <form id="form1" runat="server">
        <div >
            <h1 style="text-align: center;"><em><span class="auto-style2">SEARCH APPLICATION</span></em></h1>
            <hr />

            <h3>Enter the word to get the translation:</h3>

            <asp:TextBox ID="txtWord" runat="server" Width="333px" BorderStyle="Solid" Height="48px" />
            <br />
            <asp:RequiredFieldValidator ID="rfvWord" runat="server" ControlToValidate="txtWord"
                ErrorMessage="Word is missing!!" ForeColor="Red" />
            <br /><br />

            <asp:Button ID="btnSearch" runat="server" Text="Search" OnClick="btnSearch_Click" Width="108px" />
            <br /><br />

            <asp:Label ID="lblResult" runat="server" Font-Size="Large" ForeColor="Blue" Height="59px" Width="321px" />
            <br /><br />

            <asp:Button ID="btnAdd" runat="server" Text="Add to My Words" OnClick="btnAdd_Click" Visible="false" />
            &nbsp;
            <asp:Button ID="btnShowAll" runat="server" Text="Show All Words" OnClick="btnShowAll_Click" Visible="false" />
        </div>
    </form>
</body>
</html>
