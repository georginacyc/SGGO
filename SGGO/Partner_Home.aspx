<%@ Page Title="" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Partner_Home.aspx.cs" Inherits="SGGO.Partner_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style1">
                <strong>
                <asp:Label ID="lb_welcome" runat="server" Text="WELCOME"></asp:Label>
                </strong>
            </td>
            <td class="auto-style1"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="btn_Login" runat="server" OnClick="btn_Login_Click" Text="Login" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
