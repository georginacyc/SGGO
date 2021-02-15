<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Partner_Login.aspx.cs" Inherits="SGGO.Partner_Login" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">


    <form id="form1" runat="server">
        <div class="card" style="width: 55%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server"  Font-Bold="True" Font-Size="40px" Text="Partner"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server"  Font-Bold="True" Font-Size="40px" Text="Login"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label4" runat="server" Text="Email:"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_email" runat="server"  Width="192px"></asp:TextBox>
                    <asp:Label ID="lb_error" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 40px">
                    <asp:Label ID="Label5" runat="server" Text="Password:"></asp:Label>
                </td>
                <td style="height: 40px">
                    <asp:TextBox ID="tb_pw" TextMode="Password" runat="server" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btn_login" runat="server"  class="btn btn-dark" Text="Login" OnClick="btn_login_Click" Width="199px" Font-Size="15px" />
                </td>
            </tr>
        </table>
            </div>
        
    </form>
        
</asp:Content>
