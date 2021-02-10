<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Staff_Login.aspx.cs" Inherits="SGGO.Staff_Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <div class="card" style="width: 19%; margin: 10px auto auto auto;">
        <div class="card-body">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Staff Login"></asp:Label>
            <form id="form1" runat="server">
                <table cellpadding="7px" style="width: 100%">
                    <tr>
                        <td >
                            Email:
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:TextBox ID="email_tb" runat="server" CssClass="form-control" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            Password:
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:TextBox ID="password_tb" TextMode="Password" runat="server" CssClass="form-control" ></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td >
                            <asp:Label ID="error_lb" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
                        </td>
                    </tr>
                    <tr>
                        <td style="text-align: right;">
                            <asp:Button ID="login_btn" runat="server" OnClick="Button1_Click" Text="Login" CssClass="btn btn-dark" />
                        </td>
                    </tr>
                </table>
            </form>
        </div>
    </div>
</asp:Content>
