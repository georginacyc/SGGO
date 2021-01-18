<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Listing.aspx.cs" Inherits="SGGO.Gem_Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table style="width:100%; text-align:center;">
            <tr>
                <td style="width: 318px">&nbsp;</td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="3" style="width: 318px">
                    <asp:Image ID="Image1" runat="server" Height="179px" Width="367px" />
                </td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 312px">
                    <asp:Label ID="gem_title" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 312px">
                    <asp:Button ID="btn_map" runat="server" Height="37px" Text="Bring Me" Width="148px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 318px">
                    <asp:Label ID="gem_desc" runat="server"></asp:Label>
                </td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 318px">Reviews</td>
                <td style="width: 312px">
                    <asp:Button ID="btn_review" runat="server" Height="36px" Text="Leave a Review" Width="174px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 318px">
                    <asp:Label ID="gem_review" runat="server"></asp:Label>
                </td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 318px">&nbsp;</td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 318px">&nbsp;</td>
                <td style="width: 312px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
