<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Account_Details.aspx.cs" Inherits="SGGO.Staff_Account_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 172px;
        }
        .auto-style3 {
            width: 381px;
        }
        .auto-style4 {
            width: 130px;
        }
        .auto-style5 {
            width: 386px;
        }
        .auto-style6 {
            width: 172px;
            height: 26px;
        }
        .auto-style7 {
            width: 386px;
            height: 26px;
        }
        .auto-style8 {
            width: 130px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Account Details"></asp:Label>
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1"><strong>Email:</strong></td>
            <td class="auto-style5">
                <asp:Label ID="email_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Staff Id:</strong></td>
            <td class="auto-style3">
                <asp:Label ID="staffid_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>First Name:</strong></td>
            <td class="auto-style5">
                <asp:Label ID="fname_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Last Name: </strong> </td>
            <td class="auto-style3">
                <asp:Label ID="lname_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>DOB:</strong></td>
            <td class="auto-style5">
                <asp:Label ID="dob_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>HP (+65):</strong></td>
            <td class="auto-style3">
                <asp:Label ID="hp_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>Postal Code:</strong></td>
            <td class="auto-style5">
                <asp:Label ID="postal_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Address:</strong></td>
            <td class="auto-style3" rowspan="2">
                <asp:Label ID="address_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"></td>
            <td class="auto-style5">
                </td>
            <td class="auto-style4"></td>
            <td class="auto-style8">
                </td>
        </tr>
        <tr>
            <td class="auto-style6"><strong>Account Created:</strong></td>
            <td class="auto-style7">
                <asp:Label ID="created_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style8"><strong>Diamonds:</strong></td>
            <td class="auto-style9">
                <asp:Label ID="points_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>Last Login:</strong></td>
            <td class="auto-style5">
                <asp:Label ID="login_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
</asp:Content>
