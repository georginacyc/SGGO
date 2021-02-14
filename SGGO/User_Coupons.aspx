<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="User_Coupons.aspx.cs" Inherits="SGGO.User_Coupons" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="My Coupons"></asp:Label>
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False">
                <Columns>
                    <asp:BoundField DataField="Name" HeaderText="Name" ReadOnly="True" />
                    <asp:BoundField DataField="Description" HeaderText="Description" ReadOnly="True" />
                    <asp:BoundField DataField="Price" HeaderText="Price" ReadOnly="True" />
                </Columns>
            </asp:GridView>
        </div>
    </form>
</body>
</html>
