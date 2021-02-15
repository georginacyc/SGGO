<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Create_Partner_Account.aspx.cs" Inherits="SGGO.Create_Partner_Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 144px;
        }
        .auto-style2 {
            width: 306px;
        }
        .auto-style3 {
            width: 113px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Create Partner Account"></asp:Label>
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">Store Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="partner_fn_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">Date Established:</td>
            <td>
                <asp:TextBox ID="partner_dob_tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">Email:</td>
            <td class="auto-style2">
                <asp:TextBox ID="partner_email_tb" runat="server" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;HP:</td>
            <td>
                <asp:TextBox ID="partner_hp_tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">Postal Code:</td>
            <td class="auto-style2">
                <asp:TextBox ID="partner_postalcode_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">Address:</td>
            <td class="auto-style2">
                <asp:TextBox ID="partner_address_tb" runat="server" Height="66px" Width="293px"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
    <asp:FileUpload ID="picture_file" runat="server" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />
            </td>
        </tr>
    </table>
    <br />
    <br />
</asp:Content>
