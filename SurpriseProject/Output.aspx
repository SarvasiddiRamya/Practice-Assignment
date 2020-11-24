<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Output.aspx.cs" Inherits="SurpriseProject.Output" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 150px;
        }
        .auto-style2 {
            margin-left: 12px;
        }
        .auto-style3 {
            margin-left: 500px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td class="auto-style1">FlightID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">FlightNumber</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">FlightName</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">PassengerName</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server"  Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Age</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server"  Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Gender</td>
                    <td>
                        <asp:RadioButton ID="rdb1" runat="server" Text="Male" />
                        &nbsp;
                         <asp:RadioButton ID="rdb2" runat="server" Text="Female" />
                    </td>
                        
                    
                </tr>
                 <tr>
                    <td class="auto-style1">Source</td>
                    <td>
                        <asp:TextBox ID="TextBox6" runat="server"  Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style1">Destination</td>
                    <td>
                        <asp:TextBox ID="TextBox7" runat="server"  Width="185px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <p>
            <asp:Button ID="btn1" runat="server" Text="Submit" CssClass="auto-style3" Width="122px" OnClick="btn1_Click" />
            &nbsp;
            <asp:Button ID="btn2" runat="server" Text="Home" CssClass="auto-style2" Width="122px" OnClick="btn2_Click" />
        </p>
        <p>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:OutputConnectionString %>" SelectCommand="SELECT * FROM [OutputTable1]"></asp:SqlDataSource>
        </p>
    </form>
</body>
</html>
