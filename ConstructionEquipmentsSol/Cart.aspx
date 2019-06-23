<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Cart.aspx.cs" Inherits="ConstructionEquipmentsSol.Cart" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Cart</title>
        <link rel="stylesheet" type="text/css" href="css/Home.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div >
                <h1 class="auto-style4" align="left">Constructo shop</h1>
                <h3 class="auto-style4" align="left">Cart Page</h3>
                <asp:Label ID="lblUserDetails" runat="server" Text="" align="right"></asp:Label>
                <asp:Button ID="btnLogout" runat="server" Text="Log out" OnClick="btnLogout_Click" align="right"/>
            </div>

            
            <h1>
                Your Cart contains the below items.
            </h1>
            <asp:Label ID="Label1" runat="server" Text="Cart Details"></asp:Label>
            <br /><br />
            <asp:Label ID="lblInvoice" runat="server" Text=""></asp:Label>
            <br /><br />
            <asp:Button ID="GetInvoice" runat="server" Text="Get Invoice" OnClick="GetInvoice_Click" />
            <asp:Button ID="btnCancel" runat="server" Text="Cancel" OnClick="btnCancel_Click" />
        </div>
    </form>
</body>
</html>
