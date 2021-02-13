<%@ Page Title="User_Profile" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Profile.aspx.cs" Inherits="SGGO.User_Profile" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">




    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server" Font-Size="25pt" Text="My Profile"></asp:Label>
                </td>
                <td>
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label2" runat="server" Text="First Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="displayfname_lbl" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label3" runat="server" Text="Last Name"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="displaylname_lbl" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label4" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="displayemail_lbl" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label5" runat="server" Text="Date of Birth"></asp:Label>
                </td>
                <td>
                    <asp:Label ID="displaydob_lbl" runat="server" Text="Label"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label6" runat="server" Text="PhoneNumber"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="displayphone_tb" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label7" runat="server" Text="Address Line 1"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="displayaddress1_tb" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label8" runat="server" Text="Address Line 2"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="displayaddress2_tb" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label9" runat="server" Text="Postal Code"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="displaypostalcode_tb" runat="server" ></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                </td>
                <td>
                    <asp:Button ID="btn_Update" runat="server" Text="Update" OnClick="btn_Update_Click" />
                    <asp:Button ID="btn_logout" runat="server" OnClick="btn_logout_Click" Text="Logout" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_reviews" runat="server" Height="42px" OnClick="btn_reviews_Click" Text="My reviews" />
                </td>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
        </table>
        <div>
        </div>
    </form>

    </asp:Content>

