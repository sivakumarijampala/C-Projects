<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="FormControllsValidation.FormControllsValidation.Registration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   <script type="text/javascript">
       function validateEducation(source, args) {
           var checkBox1 = document.getElementById('<%= CheckBox1.ClientID %>');
        var checkBox2 = document.getElementById('<%= CheckBox2.ClientID %>');
        var checkBox3 = document.getElementById('<%= CheckBox3.ClientID %>');
        var checkBox4 = document.getElementById('<%= CheckBox4.ClientID %>');

           if (!checkBox1.checked && !checkBox2.checked && !checkBox3.checked && !checkBox4.checked) {
               args.IsValid = false;
           } else {
               args.IsValid = true;
           }
       }




       var ValidFileTypes = ["pdf", "docx", "jpg", "jpeg"];

       function ValidateFile() {
           var file = document.getElementById("<%=FileUpload1.ClientID %>");
           var label = document.getElementById("<%=lbMessage.ClientID %>");
           var path = file.value;
           var ext = path.substring(path.lastIndexOf(".") + 1, path.length).toLowerCase();
           var isValidFile = false;
           for (var i = 0; i < ValidFileTypes.length; i++) {
               if (ext == ValidFileTypes[i]) {
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

    <style>
        body {
            background-color:cadetblue; /* Replace with your desired color */
        }
    </style>
</head>
<body>
    <form id="form1" runat="server" >
        <div align="center">
            <h1>Registration</h1>
            <table>
                <tr>
                    <th>Name</th>              
                    <td><asp:TextBox runat="server" ID="NameTextBox"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator ID="requiredFieldValidator" runat="server" ErrorMessage="Name required" ForeColor="Red" ControlToValidate="NameTextBox"></asp:RequiredFieldValidator></td>
                    <td>
                        <asp:RegularExpressionValidator ID="regularExpressionValidation" runat="server" ErrorMessage="Name can not contain numbers and special characters" ControlToValidate="NameTextBox" ValidationExpression="^[a-zA-Z\s]+$" ForeColor="Red"></asp:RegularExpressionValidator></td>
                    </tr>
                    
                <tr>
                    <th>MobileNumber</th>
                    <td>
                        <asp:TextBox runat="server" ID="MobileNumberTextbox" ></asp:TextBox></td>
                     <td><asp:RequiredFieldValidator ID="requiredFieldValidator3" runat="server" ErrorMessage="Mobile Number required" ForeColor="Red" ControlToValidate="MobileNumberTextbox"></asp:RequiredFieldValidator></td>
                    <td>
                        <asp:RegularExpressionValidator ID="MobileNumberValidator" runat="server" ErrorMessage="Mobile number should be 10  adigit " ForeColor="Red" ControlToValidate="MobileNumberTextbox" ValidationExpression="\d{10}"> </asp:RegularExpressionValidator></td>
                </tr>
                
                 <tr>
                    <th>Email</th>
                    <td>
                        <asp:TextBox runat="server" ID="EmailTextBox" ></asp:TextBox></td>
                      <td><asp:RequiredFieldValidator ID="requiredFieldValidator2" runat="server" ErrorMessage="Email required" ForeColor="Red" ControlToValidate="EmailTextBox"></asp:RequiredFieldValidator></td>
                    <td>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ErrorMessage="Invalid Email Id" ForeColor="Red" ControlToValidate="EmailTextBox" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"> </asp:RegularExpressionValidator></td>
                </tr>

                 <tr>
                      <th>Age</th>
                            <td>
                                 <asp:TextBox runat="server" ID="AgeTextbox" TextMode="Number"></asp:TextBox>
                            </td>
                           <td>
                             <asp:RequiredFieldValidator ID="requiredFieldValidator1" runat="server" ErrorMessage="Age is required" ForeColor="Red" ControlToValidate="AgeTextbox"></asp:RequiredFieldValidator>
                              <asp:RangeValidator runat="server" ID="rangeValidator" ErrorMessage="Age must be between 1 and 99" ControlToValidate="AgeTextbox" Type="Integer" MinimumValue="1" MaximumValue="99" ForeColor="Red"></asp:RangeValidator>
                           </td>
                   </tr>
              
                <tr>
                    <th>Gender</th>
                    <td colspan="2"><asp:RadioButton runat="server" Text="Male" GroupName="gen" ID="RadioButton1"/>
                  
                    <asp:RadioButton  runat="server" Text="Female" GroupName="gen" ID="RadioButton2"/></td>
                  
                </tr>
               
                <tr>
                    <th>Address</th>
                    <td><asp:TextBox runat="server" ID="AddressText" TextMode="MultiLine"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator runat="server" ID="AddressValidate" ForeColor="Red" ControlToValidate="AddressText" ErrorMessage="Address Canot be blank"></asp:RequiredFieldValidator></td>
                </tr>

                <tr>
                    <th>City</th>
                    <td colspan="2">
                        <asp:DropDownList runat="server" ID="DropDownList">
                            <asp:ListItem>Bangalore</asp:ListItem>
                            <asp:ListItem>Hyderabad</asp:ListItem>
                           <asp:ListItem>Cheannai</asp:ListItem>
                            <asp:ListItem>Delhi</asp:ListItem>
                            <asp:ListItem>Noida</asp:ListItem>
                            <asp:ListItem>Mumbai</asp:ListItem>
                            <asp:ListItem>Pune</asp:ListItem>

                         </asp:DropDownList>

                    </td>
                    
                </tr>

                <tr>
                    <th>Education</th>
                    <td colspan="2">
                        <asp:CheckBox ID="CheckBox1" runat="server" Text="10th"/>
                         <asp:CheckBox ID="CheckBox2" runat="server" Text="12th"/>
                         <asp:CheckBox ID="CheckBox3" runat="server" text="Ug"/>
                         <asp:CheckBox ID="CheckBox4" runat="server" Text="PG" />
                        <asp:CustomValidator ID="customValidator" runat="server" ErrorMessage="Please select at least one education level" ForeColor="Red" ClientValidationFunction="validateEducation" />
                    </td>
                </tr>
                
                
                <tr>
                    <th>Upload Resume</th>
                    <td>
                     <asp:FileUpload ID="FileUpload1" runat="server" />
                    <asp:Button ID="btnUpload"   runat="server"   Text="upload" OnClientClick="return ValidateFile();" OnClick="btnUpload_Click" />
                     <br />
            
                   <asp:Label ID="lbMessage" runat="server" Text=""></asp:Label> 
                        </td>
                </tr>
                
                
                
                
                <tr>
                    <th>Password</th>
                    <td><asp:TextBox runat="server" ID="PasswordText" TextMode="Password"></asp:TextBox></td>
                    <td><asp:RequiredFieldValidator runat="server" ErrorMessage="must supply password" ControlToValidate="PasswordText" ID="RequiredFieldValidatorPassword" ForeColor="Red"></asp:RequiredFieldValidator></td>
                </tr>
                <tr>
                    <th>ReEnter Password</th>
                    <td><asp:TextBox ID="RePasswordText" runat="server" TextMode="Password"></asp:TextBox></td>
                    <td><asp:CompareValidator runat="server" ID="ComarePassword" ControlToValidate="RePasswordText" ControlToCompare="PasswordText" ErrorMessage="Password MisMatch" ForeColor="Red"></asp:CompareValidator></td>
                </tr>
                
                
                <tr>
                    <td align="center"><asp:Button ID="submitButton" runat="server" Text="Submit" /></td>
                    <td><asp:Button ID="resetButton" runat="server" Text="Reset" /></td>
                </tr>

                
                
            </table>
        </div>
    </form>
</body>
</html>
