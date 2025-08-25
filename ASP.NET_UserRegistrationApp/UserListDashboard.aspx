<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserListDashboard.aspx.cs" Inherits="SampleWebFormsApp.UserListDashboard" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Users List</title>
</head>
<body>
    <h1>Users List DashBoard</h1>
    <hr />
    <form id="form1" runat="server">
        <div>
            <asp:Repeater ID="rpUsers" runat="server" >
                <ItemTemplate>
                    <div style="border: 1px solid black; padding:15px; width:300px; height:100px; margin:10px; float:left">
                        <h3 style="margin: 10px 0;"><%# Eval("name") %></h3>
                        <p style="margin: 5px 0;">Email: <%# Eval("email") %></p>
                        <p style="margin:5px 0;">Age: <%# Eval("age") %></p>
                    </div>
                </ItemTemplate>
            </asp:Repeater>      
        </div>
        <div style="clear: both;"></div>
        <asp:Label runat="server" ID="lblError"></asp:Label>
    </form>
</body>
</html>
