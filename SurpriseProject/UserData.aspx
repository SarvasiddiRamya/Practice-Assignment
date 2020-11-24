<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UserData.aspx.cs" Inherits="SurpriseProject.UserData" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 164px;
        }
        .auto-style2 {
            width: 210px;
        }
        .auto-style3 {
            margin-left: 25px;
        }
        .auto-style4 {
            margin-left: 476px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <caption>RegistrationForm</caption>
                <tr>
                    <td class="auto-style1">UserName</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="207px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" Width="207px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Confirm Password</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox3" runat="server" Width="207px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Age</td>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox4" runat="server" Width="207px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Gender</td>
                    <td class="auto-style2">
                        <asp:RadioButton ID="Rdb1" runat="server" Text="Male"></asp:RadioButton>
                        &nbsp;&nbsp;
                        <asp:RadioButton ID="Rdb2" runat="server" Text="Female"></asp:RadioButton>
                    </td>
                </tr>
            </table>
        </div>
        <div> 
            <br />
            <asp:Button ID="Btn1" runat="server" Text="Register" Width="136px" CssClass="auto-style4" OnClick="Btn1_Click"/>
            &nbsp;&nbsp;
            <asp:Button ID="Btn2" runat="server" Text="Home" Width="136px" CssClass="auto-style3" OnClick="Btn2_Click" />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="lbl1" runat="server" Text="Label"></asp:Label>
            <br />
        </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:UserConnectionString %>" SelectCommand="SELECT [UserName], [Password], [ConfirmPassword], [Age], [Gender] FROM [UserData1]"></asp:SqlDataSource>
        
    </form>
</body>
</html>