<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Point_Shop_Main_Page.aspx.cs" Inherits="SGGO.Point_Shop_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table class="w-100">
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lb_point_shop" runat="server" Text="POINT SHOP"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="lb_points" runat="server" Text="Your Points: WIP"></asp:Label>
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lb_featured_item" runat="server" Text="Featured item"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_featured" runat="server" OnClick="btn_featured_Click" Text="Take me to it!" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Label ID="lb_categories" runat="server" Text="Categories:"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_staycation" runat="server" OnClick="btn_staycation_Click" Text="Staycations" />
                </td>
                <td>
                    <asp:Button ID="btn_travel_v" runat="server" OnClick="btn_travel_v_Click" Text="Travel Vouchers" />
                </td>
                <td>
                    <asp:Button ID="btn_food_v" runat="server" OnClick="btn_food_v_Click" Text="Food Vouchers" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
