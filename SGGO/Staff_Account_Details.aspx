<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Account_Details.aspx.cs" Inherits="SGGO.Staff_Account_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style3 {
            width: 381px;
        }
        .auto-style4 {
            width: 130px;
        }
        .auto-style9 {
            height: 26px;
        }
        .auto-style12 {
            width: 287px;
        }
        .auto-style13 {
            width: 119px;
        }
        .auto-style14 {
            width: 370px;
        }
        .auto-style15 {
            width: 370px;
            height: 26px;
        }
        .auto-style20 {
            width: 595px;
            height: 26px;
        }
        .auto-style22 {
            width: 415px;
        }
        .auto-style23 {
            width: 415px;
            height: 26px;
        }
        .auto-style24 {
            width: 595px;
        }
        .auto-style25 {
            width: 136px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: inline-block; width: 100%">
        <div style="width: 35%; margin-top: 10px; padding: 20px 20px 20px 20px; float:left;">
            <asp:Button ID="back_btn" runat="server" CssClass="btn btn-dark" style="width: auto; float:right" Text="< Back" OnClick="back_btn_Click" />
        </div>
        <div class="card" style="width: 30%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px; float: left;"> 
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Account Details"></asp:Label>
        <br />
        <br />
            <table class="auto-style12" style="width: auto; font-size: 18px">
                <tr>
                    <td rowspan="7" class="auto-style25" style="width: 50%;">
            <asp:Image ID="profile_img" style="max-width:300px; max-height:300px; height:auto; width:auto;" runat="server" src="/Images/Profile_Pictures/default.jpg" />
                    </td>
                    <td class="auto-style13"><strong>Type:</strong></td>
                    <td class="auto-style4">
                    <asp:Label ID="type_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"><strong>Email:</strong></td>
                    <td class="auto-style4">
                    <asp:Label ID="email_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    <asp:Label ID="staffid_tb" runat="server" Font-Bold="True">Staff Id:</asp:Label>
                    </td>
                    <td class="auto-style4">
                    <asp:Label ID="staffid_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"><strong>First Name:</strong></td>
                    <td class="auto-style4">
                    <asp:Label ID="fname_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13"><strong>Last Name:</strong></td>
                    <td class="auto-style4">
                    <asp:Label ID="lname_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">
                    <asp:Label ID="diamonds_lb" runat="server" Font-Bold="True">Diamonds:</asp:Label>
                    </td>
                    <td class="auto-style4">
                    <asp:Label ID="points_lb" runat="server"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style13">&nbsp;</td>
                    <td class="auto-style4">
                        &nbsp;</td>
                </tr>
            </table>
        <br />
        <table class="w-100" style="width: auto">
            <tr>
                <td class="auto-style14"><strong>DOB:</strong></td>
                <td class="auto-style24">
                    <asp:Label ID="dob_lb" runat="server"></asp:Label>
                </td>
                <td class="auto-style22"><strong>HP (+65):</strong></td>
                <td class="auto-style3">
                    <asp:Label ID="hp_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Postal Code:</strong></td>
                <td class="auto-style24">
                    <asp:Label ID="postal_lb" runat="server"></asp:Label>
                </td>
                <td class="auto-style22"><strong>Address:</strong></td>
                <td class="auto-style3" rowspan="2">
                    <asp:Label ID="address_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style14"></td>
                <td class="auto-style24">
                    </td>
                <td class="auto-style22"></td>
            </tr>
            <tr>
                <td class="auto-style15"><strong>Account Created:</strong></td>
                <td class="auto-style20">
                    <asp:Label ID="created_lb" runat="server"></asp:Label>
                </td>
                <td class="auto-style23">
                    &nbsp;</td>
                <td class="auto-style9">
                    &nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style14"><strong>Last Login:</strong></td>
                <td class="auto-style24">
                    <asp:Label ID="login_lb" runat="server"></asp:Label>
                </td>
                <td class="auto-style22">&nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
                <br />
            <div style="display: inline-block">
                <asp:Label ID="resetpw_lb" runat="server" ForeColor="Red"></asp:Label>
            <br />
        <asp:Button ID="resetpw_btn" runat="server" CssClass="btn btn-warning" style="width: 20%; float: left;" OnClick="resetpw_btn_Click" Text="Reset Password" />

        <asp:Button ID="print_btn" CssClass="btn btn-dark" style="width: 10%; float: right;" OnClientClick="javascript:window.print();" Text="Print" runat="server" />
            </div>
    
            </div>
        </div>
</asp:Content>
