<%@ Page Title="" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Partner_Own_Account_Details.aspx.cs" Inherits="SGGO.Partner_Own_Account_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 151px;
        }
        .auto-style2 {
            width: 333px;
        }
        .auto-style3 {
            width: 620px;
        }
        .auto-style4 {
            width: 93px;
        }
        .auto-style5 {
            width: 151px;
            height: 26px;
        }
        .auto-style6 {
            width: 333px;
            height: 26px;
        }
        .auto-style7 {
            width: 93px;
            height: 26px;
        }
        .auto-style8 {
            height: 26px;
        }
        .auto-style9 {
            width: 620px;
            height: 26px;
        }
        .auto-style10 {
            width: 256px;
            height: 26px;
        }
        .auto-style11 {
            width: 256px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style5" colspan="1">&nbsp;</td>
            <td class="auto-style10" colspan="3">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Your Account Details"></asp:Label>
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style10">
    <asp:Image ID="profile_img" style="max-width:300px; max-height:300px; height:auto; width:auto;" runat="server" src="/Images/Profile_Pictures/default.jpg" />
            </td>
            <td class="auto-style6">
                &nbsp;</td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style10"><strong>Email:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="email_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style7">&nbsp;</td>
            <td class="auto-style9">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11"><strong>Company: </strong></td>
            <td class="auto-style2">
                <asp:Label ID="fname_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style3">
                <asp:Label ID="lname_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11"><strong>Date Established:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="dob_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>HP (+65):</strong></td>
            <td class="auto-style3">
                <asp:Label ID="hp_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11"><strong>Postal Code:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="postal_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Address:</strong></td>
            <td class="auto-style3" rowspan="2">
                <asp:Label ID="address_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style10"></td>
            <td class="auto-style6">
                </td>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11"><strong>Account Created:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="created_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                <asp:Button ID="changepw_btn" runat="server" CssClass="btn btn-warning" OnClick="changepw_btn_Click" Text="Change Password" BackColor="#666666" BorderColor="White" ForeColor="White" />
            </td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="Label2" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style11">&nbsp;</td>
            <td class="auto-style2">
                <asp:Label ID="lb_Need_Help" runat="server" Text="Need help with your account? Contact our Staff!"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br/>
    
</asp:Content>

