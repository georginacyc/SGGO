<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Create_Gem.aspx.cs"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 1373px
        }
        .auto-style7 {
            width: 221px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="New Trail"></asp:Label>
    <br />
    <table class="auto-style5">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_title" runat="server" Text="Title:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_title" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_date" runat="server" Text="Date:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_date" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_description" runat="server" Text="Description:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_description" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_listings" runat="server" Text="Listings Involved:"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        </table>
    
    <div class ="card-deck">
        <div class="card bg-light">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem1_listing" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem1_pc" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem1_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
         <div class="card bg-light">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem2_listing" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem2_pc" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem2_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
        <div class="card bg-light">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem3_lisitng" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem3_listing" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem3_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
    </div>





    <br />
    <asp:Label ID="lb_banner" runat="server" Text="Banner"></asp:Label>
    <br />
    <asp:FileUpload ID="FileUpload1" runat="server" Width="521px" />
    <br />
    <br />
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />
    <br />
</asp:Content>
