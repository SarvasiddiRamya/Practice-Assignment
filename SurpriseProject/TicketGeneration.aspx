<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TicketGeneration.aspx.cs" Inherits="SurpriseProject.TicketGeneration" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 178px;
        }
        .auto-style2 {
            margin-left: 549px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td class="auto-style1">PassengerName</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" TextMode="Password" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Gender</td>
                    <td>
                        <asp:RadioButton ID="rdb1" runat="server" Text="Male" GroupName="Gender"/>
                        &nbsp;
                         <asp:RadioButton ID="rdb2" runat="server" Text="Female" GroupName="Gender"/>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">PassengerClassTickets</td>
                    <td>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" Width="207px">
                            <asp:ListItem>General Class</asp:ListItem>
                               <asp:ListItem>Economy Class</asp:ListItem>
                               <asp:ListItem>Business Class</asp:ListItem>

                        </asp:RadioButtonList>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Source</td>
                    <td>
                         <asp:TextBox ID="TextBox3" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>

                <tr>
                    <td class="auto-style1">Destination</td>
                    <td>
                         <asp:TextBox ID="TextBox4" runat="server" Width="200px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="btn1" runat="server" Text="TicketGenerate" CssClass="auto-style2" Width="163px" OnClick="btn1_Click" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:TicketConnectionString %>" SelectCommand="SELECT * FROM [TicketTable1]"></asp:SqlDataSource>
        </p>
    </form>
</body>
</html>
