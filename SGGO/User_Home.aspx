<%@ Page Title="User_Home" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Home.aspx.cs" Inherits="SGGO.User_Home" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">




    <form id="form1" runat="server">
        <div class="card" style="width: 55%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
           
            <table style="width: 100%">
            <tr>
                <td>
                    &nbsp;</td>
                    <td>
                        <asp:Label ID="Label1" runat="server"  Font-Bold="True" Font-Size="40px" Text="Welcome"></asp:Label>
                    </td>
                    <td></td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td>

                        

                    </td>
                    <td>
                        
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" class="btn btn-dark" Text="View Profile"/>
                        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" class="btn btn-dark" Text="View Hidden Gems"/>
                         
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                    </td>
                </tr>
                <tr>
                    <td></td>
                    <td>
                        &nbsp;</td>
                    <td></td>
                </tr>
           </table>
        </div>
    </form>

    </asp:Content>
