<%@ Page Title="" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Partner_Login.aspx.cs" Inherits="SGGO.Partner_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Font-Size="25pt" Text="Login"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_email" runat="server"  Width="192px"></asp:TextBox>
                    <asp:Label ID="lb_error" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_pw" TextMode="Password" runat="server" Width="187px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btn_login" runat="server" Text="Login" OnClick="btn_login_Click" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        <div>
        </div>

</asp:Content>
