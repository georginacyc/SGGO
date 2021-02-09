<%@ Page Title="Create_User_Account" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Create_User_Account.aspx.cs" Inherits="SGGO.Create_User_Account" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">




    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Font-Size="25pt" Text="Join us"></asp:Label>
            <br />
            <table style="width: 100%">
                <tr>
                    <td>
            <asp:Label ID="lbl_fname" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_fname_tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_lname" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_lname_tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_email_tb" runat="server" OnTextChanged="tb_email_TextChanged"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_pw" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_password_tb" TextMode="Password" runat="server" OnTextChanged="tb_pw_TextChanged" ></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_confirmpw" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox TextMode="Password" ID="tb_confirmpw" runat="server"></asp:TextBox>
                        <asp:Label ID="Label2" runat="server" Text="Password Strength/same pw"></asp:Label>
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        <asp:Button ID="btn_Create" runat="server" Text="Sign Up" OnClick="btn_Create_Click" />
                    </td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Label ID="lbMsg" runat="server" Text="Message"></asp:Label>
                    </td>
                    <td>                       
                    </td>
                </tr>

            </table>
            
        </div>
    </form>
</asp:Content>
