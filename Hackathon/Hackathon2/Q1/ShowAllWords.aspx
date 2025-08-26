<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ShowAllWords.aspx.cs" Inherits="SampleWebFormsApp.Hackathon2.Q1.ShowAllWords" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-weight: normal;
        }
        .bb{
            background-color:antiquewhite;
        }
        .text{
            text-align:center
        }
    </style>
</head>
<body class="bb">
    <form id="form1" runat="server" >
                <h2><span class="auto-style1">List of all Records :</span></h2>

        <div class="text">

    <asp:GridView ID="gvWords" runat="server" AutoGenerateColumns="false" Height="290px" Width="412px">
        <Columns>
            <asp:BoundField DataField="Word" HeaderText="Word"  />
            <asp:BoundField DataField="Translation" HeaderText="Translation" />
        </Columns>
        <SelectedRowStyle BorderColor="#009933" BorderStyle="Solid" />
    </asp:GridView>           
                    </div>

    </form>
</body>
</html>
