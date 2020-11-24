<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="SurpriseProject.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    
    <style type="text/css">
        .auto-style1 {
            width: 122px;
        }
        .auto-style2 {
            width: 160px;
        }
        .auto-style3 {
            margin-left: 23px;
        }
        .auto-style4 {
            margin-left: 387px;
        }
    </style>
    
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>Login</caption>
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="154px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="154px"></asp:TextBox>
                    </td>
                </tr>
            </table>
            </div>
            <div>
                <br />
                <asp:Button ID="btn1" runat="server" Text="Login" CssClass="auto-style4" Width="120px" OnClick="btn1_Click" />
                <asp:Button ID="btn2" runat="server" Text="Home" CssClass="auto-style3" Width="120px" OnClick="btn2_Click"/>
                <br />
                <br />&nbsp;  
                <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
            </div>
    </form>
</body>
</html>
