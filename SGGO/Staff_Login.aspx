<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Staff_Login.aspx.cs" Inherits="SGGO.Staff_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table style="width:100%;">
            <tr>
                <td style="width: 105px"><strong>Staff Login</strong></td>
                <td style="width: 202px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 105px">Email:</td>
                <td style="width: 202px">
                    <asp:TextBox ID="email_tb" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="error_lb" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 105px">Password:</td>
                <td style="width: 202px">
                    <asp:TextBox ID="password_tb" TextMode="Password" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Label ID="error2_lb" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 105px">&nbsp;</td>
                <td style="width: 202px">
                    <asp:Button ID="login_btn" runat="server" OnClick="Button1_Click" Text="Login" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
