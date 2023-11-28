<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postback.aspx.cs" Inherits="FirstWebApplication.postback" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button" runat="server" Text="Button" OnClick="Button_Click" />
            <asp:TextBox ID="TextBox" runat="server" AutoPostBack="True"></asp:TextBox>
        </div>
    </form>
</body>
</html>
