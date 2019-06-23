<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="ConstructionEquipmentsSol.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
        <link rel="stylesheet" type="text/css" href="css/Login.css">
    <style type="text/css">
        .auto-style1 {
            width: 167px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Constructo shop</h1>
            <h3>Login Page</h3>
            <table align="center">
                <tr>
                    <td>
                        <asp:Label ID="lblUsername" runat="server" Text="Username"></asp:Label>

                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtUsername" runat="server" placeholder="Username" Width="155px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lblPassword" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txtPassword" runat="server" placeholder="Password" TextMode="Password" Width="155px"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btnLogin" runat="server" Text="Login" OnClick="btnLogin_Click" />
                    </td>
                    <td class="auto-style1">
                        <asp:Label ID="lblErrorMessage" runat="server" Text="Invalid User Credintials!!" ForeColor="Red"></asp:Label>
                    </td>
                </tr>

            </table>
        </div>
    </form>
</body>
</html>
