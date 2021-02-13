<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Own_Account_Details.aspx.cs" Inherits="SGGO.Staff_Own_Account_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 620px;
        }
        .auto-style4 {
            width: 93px;
        }
        .auto-style5 {
            width: 460px;
        }
        .auto-style6 {
            width: 1070px;
        }
        .auto-style7 {
            width: 618px;
        }
        .auto-style8 {
            width: 133px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 40%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px" >    
    <asp:Label ID="Label2" runat="server" Font-Bold="True" Font-Size="40px" Text="Account Details"></asp:Label>
    <br />
    <br />
        <table class="auto-style12" style="width: auto; font-size: 18px">
            <tr>
                <td rowspan="7" class="auto-style25" style="width: 50%;">
        <asp:Image ID="profile_img" style="max-width:300px; max-height:300px; height:auto; width:auto;" runat="server" src="/Images/Profile_Pictures/default.jpg" />
                </td>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Email:</strong></td>
                <td class="auto-style4">
                <asp:Label ID="email_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                <asp:Label ID="staffid_tb" runat="server" Font-Bold="True">Staff Id:</asp:Label>
                </td>
                <td class="auto-style4">
                <asp:Label ID="staffid_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>First Name:</strong></td>
                <td class="auto-style4">
                <asp:Label ID="fname_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Last Name:</strong></td>
                <td class="auto-style4">
                <asp:Label ID="lname_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8">
                    &nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style8">&nbsp;</td>
                <td class="auto-style4">
                    &nbsp;</td>
            </tr>
        </table>
    <br />
    <table class="w-100" style="width: auto">
        <tr>
            <td class="auto-style7"><strong>DOB:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="dob_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style5"><strong>HP (+65):</strong></td>
            <td class="auto-style3">
                <asp:Label ID="hp_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Postal Code:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="postal_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style5"><strong>Address:</strong></td>
            <td class="auto-style3" rowspan="2">
                <asp:Label ID="address_lb" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style6">
                </td>
            <td class="auto-style5"></td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Account Created:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="created_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style9">
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style7"><strong>Last Login:</strong></td>
            <td class="auto-style6">
                <asp:Label ID="login_lb" runat="server"></asp:Label>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
            <br />
        <div style="display: inline-block">
        <br />
    <asp:Button ID="changepw_btn" runat="server" CssClass="btn btn-warning" OnClick="changepw_btn_Click" Text="Change Password" />
        </div>
    
        </div>
    </asp:Content>
