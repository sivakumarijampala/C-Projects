<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FirstWebApplication.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
           
            <!--runat attribute is used to tell this is an asp .net server controll -->
            <!--in asp.net controll even after submiting data the value still present -->
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="Click Me" OnClick="Button1_Click" />
            <br />

            <!--html controll-->
            <!-- in html controll once the form data submited it clears data-->
            <input type="text" name="Textbox2" />
            <input type="submit" name="submit1" />
        </div>
    </form>
</body>
</html>
