<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Monthly_Trail.aspx.cs" Inherits="SGGO.User_Monthly_Trail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <div style="text-align: center;">
        <asp:Image ID="img_banner" runat="server" Height="241px" Width="1351px" Source ="~/Images/Trail" />
        </div>
        <div class="row" style="width: 80%; margin: 10px auto auto auto;">
        <div class="col" style="left: 1px; top: 0px" >
                <div class="card" style="left: 0px; top: 0px">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="3" class="pendingNum">
                                    <asp:Image ID="img_gem1" runat="server" Height="36px" Width="42px" />
                                </td>
                                <td>
                                    <asp:Label ID="lb_gem1Title" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lb_gem1PC" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btn_gem1" runat="server" OnClick="btn_gem1_Click" Text="Go to Listing" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
        </div>
        <div class="col" >
                <div class="card">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="3" class="pendingNum">
                                    <asp:Image ID="img_gem2" runat="server" Height="36px" Width="42px" />
                                </td>
                                <td>
                                    <asp:Label ID="lb_gem2Title" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lb_gem2PC" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btn_gem2" runat="server" OnClick="btn_gem2_Click" Text="Go to Listing" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
        </div>
        <div class="col" >
                <div class="card">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="3" class="pendingNum">
                                    <asp:Image ID="img_gem3" runat="server" Height="36px" Width="42px" />
                                </td>
                                <td>
                                    <asp:Label ID="lb_gem3Title" runat="server" Font-Bold="True" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Label ID="lb_gem3PC" runat="server" ForeColor="Black"></asp:Label>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <asp:Button ID="btn_gem3" runat="server" OnClick="btn_gem3_Click" Text="Go to Listing" />
                                </td>
                            </tr>
                        </table>
                    </div>
                </div>
        </div>
            <br />
            
    </div>
        
        <div style="text-align: center; padding-top: 50px;">
            <asp:Label ID="lb_desc" runat="server" ></asp:Label>
            </div>


    </form>


</asp:Content>
