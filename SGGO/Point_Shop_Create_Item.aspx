<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Point_Shop_Create_Item.aspx.cs" Inherits="SGGO.Point_Shop_Create_Item" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 141px;
        }
        .auto-style2 {
            width: 312px;
        }
        .auto-style3 {
            width: 124px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="lb_create_item" runat="server" Font-Bold="True" Font-Size="40px" Text="Create Point Shop Item"></asp:Label>
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1">Name: </td>
            <td class="auto-style2">
                <asp:TextBox ID="tb_item_name" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">Type:</td>
            <td>
                
                <asp:DropDownList ID="ddl_item_type" runat="server">
                    <asp:ListItem>- Select A Category -</asp:ListItem>
                    <asp:ListItem>Staycation Offer</asp:ListItem>
                    <asp:ListItem>Travel Voucher</asp:ListItem>
                    <asp:ListItem>Food Voucher</asp:ListItem>
                </asp:DropDownList>
                
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Location: </td>
            <td class="auto-style2">
                <asp:TextBox ID="tb_item_location" runat="server" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            
        </tr>
        <tr>
            <td class="auto-style1">Price: </td>
            <td class="auto-style2">
                <asp:TextBox ID="tb_item_price" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style3">Description: </td>
            <td>
                <asp:TextBox ID="tb_item_description" runat="server" Height="146px" Width="389px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Upload a picture:</td>
            <td class="auto-style2">
                <asp:FileUpload ID="FileUpload1" runat="server" />
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />
    <br />
</asp:Content>

