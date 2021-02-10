<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Own_Account_Details.aspx.cs" Inherits="SGGO.Staff_Own_Account_Details" %>
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
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Your Account Details"></asp:Label>
    <br />
    <asp:Image ID="profile_img" style="max-width:300px; max-height:300px; height:auto; width:auto;" runat="server" src="/Images/Profile_Pictures/default.jpg" />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1"><strong>Email:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="email_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Staff Id:</strong></td>
            <td class="auto-style3">
                <asp:Label ID="staffid_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>First Name:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="fname_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Last Name: </strong> </td>
            <td class="auto-style3">
                <asp:Label ID="lname_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>DOB:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="dob_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>HP (+65):</strong></td>
            <td class="auto-style3">
                <asp:Label ID="hp_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>Postal Code:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="postal_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4"><strong>Address:</strong></td>
            <td class="auto-style3" rowspan="2">
                <asp:Label ID="address_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style5"></td>
            <td class="auto-style6">
                </td>
            <td class="auto-style7"></td>
            <td class="auto-style8">
                </td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>Account Created:</strong></td>
            <td class="auto-style2">
                <asp:Label ID="created_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1"><strong>Password Age:</strong></td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Button ID="changepw_btn" runat="server" OnClick="changepw_btn_Click" Text="Change Password" />
</asp:Content>
