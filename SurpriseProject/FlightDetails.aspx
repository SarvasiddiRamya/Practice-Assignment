<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="FlightDetails.aspx.cs" Inherits="SurpriseProject.FlightDetails" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style2 {
            margin-left: 3px;
        }
        .auto-style3 {
            width: 135px;
        }
        .auto-style4 {
            margin-left: 22px;
        }
        .auto-style5 {
            margin-left: 8px;
        }
        .auto-style6 {
            margin-left: 474px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <table align="center">
                <tr>
                    <td class="auto-style3">FlightID</td>
                    <td>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="auto-style2" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style3">FlightNumber</td>
                    <td>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="auto-style2" Width="185px"></asp:TextBox>
                    </td>
                 </tr>
                 <tr>
                    <td class="auto-style3">FlightName</td>
                    <td>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="auto-style2" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style3">Source</td>
                    <td>
                        <asp:TextBox ID="TextBox4" runat="server" CssClass="auto-style2" Width="185px"></asp:TextBox>
                    </td>
                </tr>
                 <tr>
                    <td class="auto-style3">Destination</td>
                    <td>
                        <asp:TextBox ID="TextBox5" runat="server" CssClass="auto-style2" Width="185px"></asp:TextBox>
                    </td>
                </tr>
            </table>
        </div>
        <div>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Data Added" OnClick="Button1_Click" CssClass="auto-style6" Width="123px" />
        &nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button2" runat="server" Text="Login" OnClick="Button2_Click" Width="88px" CssClass="auto-style5" />
            <asp:Button ID="Button3" runat="server" Text="Register" CssClass="auto-style4" OnClick="Button3_Click" Width="96px" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:FlightConnectionString %>" SelectCommand="SELECT [FlightId], [FlightNumber], [FlightName], [Source], [Destination] FROM [FlightTable]"></asp:SqlDataSource>
    </form>
</body>
</html>
