<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FileUploadValidation.aspx.cs" Inherits="FormControllsValidation.FormControllsValidation.FileUploadValidation" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script>
        var ValidFileTypes = ["pdf", "docx", "jpg", "jpeg"];

        function ValidateFile()
        {
            var file = document.getElementById("<%=FileUpload1.ClientID %>");
            var label = document.getElementById("<%=lbMessage.ClientID %>");
            var path = file.value;
            var ext = path.substring(path.lastIndexOf(".") + 1, path.length).toLowerCase();
            var isValidFile = false;
            for (var i = 0; i < ValidFileTypes.length; i++)
            {
                if (ext == ValidFileTypes[i])
                {
                    isValidFile = true;
                    break;
                }
                
            }

            if (!isValidFile) {
                label.innerHTML = "Invalid file please upload valid file with extension:" + ValidFileTypes.join(".");
                label.style.color = "red";
            }

            return isValidFile;
        }

    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:FileUpload ID="FileUpload1" runat="server" />
            <asp:Button ID="btnUpload"   runat="server"   Text="upload" OnClientClick="return ValidateFile();" OnClick="btnUpload_Click" />
           <br />
            
            <asp:Label ID="lbMessage" runat="server" Text=""></asp:Label>
        </div>
    </form>
</body>
</html>
