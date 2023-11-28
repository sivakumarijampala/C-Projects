<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Data.aspx.cs" Inherits="FirstWebApplication.App_Object.Data" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
   
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
                <asp:Button ID="Button1" runat="server" Text="AddEmployee" OnClick="Button1_Click" />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false"  OnRowCommand="Row_Command" OnRowDeleting="Row_Deleting">
                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Name" HeaderText="Name"/>
                    <asp:BoundField DataField="Age" HeaderText="Age"/>
                    <asp:TemplateField HeaderText="Actions">
                       
                        <ItemTemplate>
                        <asp:LinkButton ID="linkDelete" runat="server" text="Edit" CommandName="Edit" CommandArgument='<%# Container.DataItemIndex %>'/>
                        <asp:LinkButton ID="linkEdit" runat="server" text="Delete" CommandName="Delete" CommandArgument='<%# Container.DataItemIndex %>'/>
                       </ItemTemplate>
                   
                    </asp:TemplateField>
                    
                </Columns>
            </asp:GridView>

            
            
        </div>
            

    </form>
</body>
</html>


