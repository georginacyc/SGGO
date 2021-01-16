﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Create_Staff_Account.aspx.cs" Inherits="SGGO.Create_Staff_Account" %>
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
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Create Staff Account"></asp:Label>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style1">Email</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_email_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">First Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_fn_tb" runat="server" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            <td class="auto-style3">Last Name: </td>
            <td>
                <asp:TextBox ID="staff_ln_tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">DOB:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_dob_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">HP:</td>
            <td>
                <asp:TextBox ID="staff_hp_tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1">Postal Code:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_postalcode_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">Address:</td>
            <td>
                <asp:TextBox ID="staff_address_tb" runat="server"></asp:TextBox>
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
            <td class="auto-style1">Password:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_password_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">Confirm Password:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_password2_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" />
    <br />
</asp:Content>