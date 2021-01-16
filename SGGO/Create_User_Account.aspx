<%@ Page Title="Create_User_Account" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Create_User_Account.aspx.cs" Inherits="SGGO.Create_User_Account" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="MainContent">




    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Label1" runat="server" Text="Join us"></asp:Label>
            <br />
            <br />
            <br />
            <asp:Label ID="lbl_fname" runat="server" Text="First Name"></asp:Label>
            <asp:TextBox ID="tb_fname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_lname" runat="server" Text="Last Name"></asp:Label>
            <asp:TextBox ID="tb_lname" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="tb_email" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_pw" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="tb_pw" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="lbl_confirmpw" runat="server" Text="Confirm Password"></asp:Label>
            <asp:TextBox ID="tb_confirmpw" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <br />
        </div>
    </form>
</asp:Content>
