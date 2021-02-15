<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Review.aspx.cs" Inherits="SGGO.Gem_Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <div class="card" style="width: 48%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
    <form id="form1" runat="server">
        
        <table style="width:700px; text-align:center;">
            <tr>
                <td style="width: 341px">&nbsp;</td>
                <td style="width: 381px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px"><asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="30px" Text="Rate & Review"></asp:Label></td>
                <td rowspan="3" style="width: 381px">
                    &nbsp;<asp:Image ID="gem_image" runat="server" Height="179px" Width="304px"  />
                </td>
            </tr>
            <tr>
                <td style="width: 341px; height: 18px">
                    <asp:Label ID="review_date" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ImageButton ID="Rating_1" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_1_Click" />
                    <asp:ImageButton ID="Rating_2" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_2_Click" />
                    <asp:ImageButton ID="Rating_3" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_3_Click" />
                    <asp:ImageButton ID="Rating_4" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_4_Click" />
                    <asp:ImageButton ID="Rating_5" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_5_Click" />
                 </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbl_rating_score" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="height: 99px ">
                    <br />
                    <asp:TextBox ID="tb_desc" runat="server" Height="91px" Width="694px" CssClass="form-control"></asp:TextBox>
                    <br />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbl_msg" runat="server" ForeColor="#006600"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_submit_review" Cssclass="btn btn-dark" runat="server" Text="Submit" Width="700px" OnClick="btn_submit_review_Click" />
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_back" runat="server" Cssclass="btn btn-outline-dark" Text="Back to Gem" Width="700px" OnClick="btn_back_Click" />
                </td>
            </tr>
        </table>
            
    </form>
    </div>
</asp:Content>
