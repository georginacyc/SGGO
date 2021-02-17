﻿<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/User.Master" CodeBehind="User_Login.aspx.cs" Inherits="SGGO.User_Login" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">


    <form id="form1" runat="server">
        <div class="card" style="width: 55%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
        <table class="auto-style1">
            <tr>
                <td>
                    <asp:Label ID="Label1" runat="server"  Font-Bold="True" Font-Size="40px" Text="Login"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="label" runat="server" Text="Email"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_email" runat="server"  ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="tb_pw" TextMode="Password" runat="server" ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    <asp:Button ID="btn_login" runat="server"  class="btn btn-dark" Text="Login" OnClick="btn_login_Click" Width="196px" />
                </td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="Button1" runat="server" class="btn btn-dark" OnClick="Button1_Click" Text="Click here to register" Width="196px" Font-Size="10px" />
                    
                </td>
            </tr>
            <tr>
                <td>

                </td>
                <td>
                    <asp:Label ID="lblMsg2" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
            </div>
        
    </form>

</asp:Content>
