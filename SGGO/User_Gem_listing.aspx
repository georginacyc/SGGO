<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Gem_listing.aspx.cs" Inherits="SGGO.User_Gem_listing" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">
    <form id="form1" runat="server">
        <table style="width:100%; text-align:center;" >
            <tr>
                <td rowspan="3" style="width: 439px">
                    <asp:Image ID="Image1" runat="server" Height="141px" Width="281px" />
                </td>
                <td style="width: 279px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 279px">
                    <asp:Label ID="gem_title" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 279px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="height: 38px; width: 439px">
                    <asp:Label ID="gem_desc" runat="server"></asp:Label>
                </td>
                <td style="width: 279px; height: 38px"></td>
                <td style="height: 38px"></td>
            </tr>
            <tr>
                <td style="width: 439px">&nbsp;</td>
                <td style="width: 279px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 439px">Reviews</td>
                <td style="width: 279px">
                    <asp:Button ID="Button1" runat="server" Height="33px" Text="Leave a Review" Width="177px" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 439px">
                    <asp:Label ID="gem_reviews" runat="server"></asp:Label>
                </td>
                <td style="width: 279px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 439px">&nbsp;</td>
                <td style="width: 279px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>

