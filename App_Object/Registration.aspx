<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FirstWebApplication.App_Object.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Employee Name</td>
                    <td><asp:TextBox ID="empText" runat="server" ></asp:TextBox></td>
                </tr>
                <tr>
                    <td>Employee Age</td>
                    <td><asp:TextBox ID="empAgeText" runat="server"></asp:TextBox></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="insertButton" runat="server" Text="Save" OnClick="InsertButton_Click" /></td>
                </tr>

            </table>
            
        </div>
    </form>
</body>
</html>
