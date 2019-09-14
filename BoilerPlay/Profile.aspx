<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="BoilerPlay.Profile" %>

<!DOCTYPE html>
<link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.3.1/css/bootstrap.min.css">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="NameTxtBox" runat="server" readonly="true" Height="50px" Width="888px"></asp:TextBox>
        </div>
        <button class="btn btn-dark" runat="server" id="MainBtn" title="Hello There" value="Hello" onServerClick="btnLogin_Click">Hello There</button>
        <input runat ="server" type="text" id="textBox" />
        <asp:Label runat="server" Text="Year: "></asp:Label>
        <asp:Label ID="Label1" runat="server" Text="Freshman"></asp:Label>
    </form>
</body>
</html>
