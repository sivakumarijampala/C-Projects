<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="PostBackEventsEx.aspx.cs" Inherits="FirstWebApplication.PostBackEventsEx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="TextBox1" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            <asp:Button ID="Button1" Text="submit" runat="server" OnClick="Button1_Click" />
        </div>
    </form>
</body>
</html>
