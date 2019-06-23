<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="ConstructionEquipmentsSol.Home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Home</title>
    <link rel="stylesheet" type="text/css" href="css/Home.css">
    <style type="text/css">
        .auto-style2 {
            width: 15px;
        }
        .auto-style4 {
            width: 300px;
        }
        </style>
</head>
<body>
    <form id="form1" runat="server">
            <h1 class="auto-style4">Constructo shop</h1>
            <h3 class="auto-style4">Home Page</h3>
            <asp:Label ID="lblUserDetails" runat="server" Text=""></asp:Label>
            <asp:Button ID="btnLogout" runat="server" Text="Log out" OnClick="btnLogout_Click" />
            <table align="right" style="vertical-align: top;">
                <tr>
                    <td>
                        <asp:Label ID="Label9" runat="server" Text="Cart Value"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblCart" runat="server" Text="0"></asp:Label>
                    </td>
                    <td>
                        <asp:Button ID="btnCart" runat="server" Text="Go To Cart" href="Cart.aspx" OnClick="btnCart_Click"/>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="Label11" runat="server" Text="Added Points"></asp:Label>
                    </td>
                    <td>
                        <asp:Label ID="lblAddedPoints" runat="server" Text="0"></asp:Label>
                    </td>
                </tr>

                <%--<br /><asp:Label ID="Label10" runat="server" Text="Member points"></asp:Label>
                <asp:Label ID="lblCurrentPoints" runat="server" Text=""></asp:Label>--%>
                
            </table>
        <div>
            <br /><asp:Button ID="BtnAddToCrt" runat="server" Text="Add To Cart" OnClick="BtnAddToCrt_Click" />
            <asp:Button ID="btnReset" runat="server" Text="Reset" OnClick="btnReset_Click" />
            <br /><asp:Label ID="lblErrorMsg" runat="server" Text="Please enter a valid value" ForeColor ="Red"></asp:Label>
            <br />
        </div>
        <!--Table-->
        <table id="tblTools" align="center" >
            <tr>
                <td align="center" colspan="3">
                    <h2> Heavy tools</h2>
                </td>
                <td></td>

                <td align="center" colspan="3">
                    <h2> Regular tools</h2>
                </td>
                <td></td>

                <td>
                    <h2> Specialized tools</h2>
                </td>
            </tr>
            <tr>
                <td>
                 <div id="divBulldozer">
                    <asp:Label ID="lblBulldozer" runat="server" Text="Caterpillar bulldozer"></asp:Label>
                    <hr />
                    <div class ="bulldozer" >
                    </div>
                    <br /><asp:Label ID="Label2" runat="server" Text="Num of days"></asp:Label>
                    <asp:TextBox ID="TextBox1" runat="server">0</asp:TextBox>
                </div>
                </td>
                <td class="auto-style2">

                </td>
                <td>
                   <div id="divCrane">
                        <asp:Label ID="lblCrane" runat="server" Text="Komatsu crane"></asp:Label>
                        <hr />
                        <div class ="crane" >
                        </div>
                        <br /><asp:Label ID="Label3" runat="server" Text="Num of days"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server">0</asp:TextBox>
                    </div>
                </td>
                <td>

                </td>
                <td>
                 <div id="divTruck">
                    <asp:Label ID="Label1" runat="server" Text="KamAZ truck"></asp:Label>
                    <hr />
                    <div class ="Truck" >
                    </div>
                    <br /><asp:Label ID="Label4" runat="server" Text="Num of days"></asp:Label>
                    <asp:TextBox ID="TextBox3" runat="server">0</asp:TextBox>

                </div>
                </td>
                <td class="auto-style2">
                    
                </td>
                <td>
                   <div id="divSteamroller">
                        <asp:Label ID="Label5" runat="server" Text="Volvo steamroller"></asp:Label>
                        <hr />
                        <div class ="steamroller" >
                        </div>
                        <br /><asp:Label ID="Label6" runat="server" Text="Num of days"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server">0</asp:TextBox>
                    </div>
                </td>
                <td></td>
                <td>
                 <div id="divJackhammer">
                    <asp:Label ID="Label7" runat="server" Text="Bosch jackhammer"></asp:Label>
                    <hr />
                    <div class ="Jackhammer" >
                    </div>
                    <br /><asp:Label ID="Label8" runat="server" Text="Num of days"></asp:Label>
                    <asp:TextBox ID="TextBox5" runat="server">0</asp:TextBox>
                </div>
                </td>
            </tr>
            </table>


        
    </form>
</body>
</html>
