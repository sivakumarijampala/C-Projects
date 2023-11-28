<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="FirstWebApplication.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Login Form</caption>
                <tr>
                    <td> Enter UserName:</td>
                    <td><asp:TextBox runat="server" ID="userNameText"></asp:TextBox><br /></td>
                </tr>
                <tr>
                     <td> Enter Password:</td>
                     <td>
                         <asp:TextBox runat="server" ID="passwordText" TextMode="Password"></asp:TextBox><br /></td>
                </tr>
                <tr>
                    <td align="right"> <asp:Button ID="loginButton" runat="server" Text="Login" OnClick="loginButton_Click" /></td>
                    <td> <asp:Button ID="resetButton" runat="server" Text="Reset" OnClick="resetButton_Click" /></td>
                </tr>
            </table>
           
        </div>
    </form>
</body>
</html>
