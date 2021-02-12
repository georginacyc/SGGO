<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Review.aspx.cs" Inherits="SGGO.Gem_Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table style="width:1204px; text-align:center;">
            <tr>
                <td style="width: 341px">&nbsp;</td>
                <td style="width: 381px">
                    &nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px">Rate &amp; Review</td>
                <td rowspan="3" style="width: 381px">
                    <asp:Image ID="Image1" runat="server" Height="179px" Width="304px" ImageUrl="~/Test_Image/Cafe-De-Nicoles.jpg" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px; height: 18px">
                    <asp:Label ID="review_date" runat="server"></asp:Label>
                </td>
                <td style="width: 402px; height: 18px"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    <asp:ImageButton ID="Rating_1" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_1_Click" />
                    <asp:ImageButton ID="Rating_2" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_2_Click" />
                    <asp:ImageButton ID="Rating_3" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_3_Click" />
                    <asp:ImageButton ID="Rating_4" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_4_Click" />
                    <asp:ImageButton ID="Rating_5" runat="server" Height="25px" Width="25px" ImageUrl="~/Test_Image/Star.png" OnClick="Rating_5_Click" />
                 </td>
                <td class="auto-style2">
                    <asp:Label ID="lbl_rating_score" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="height: 99px">
                    <asp:TextBox ID="tb_desc" runat="server" Height="91px" Width="700px"></asp:TextBox>
                </td>
                <td style="width: 402px; height: 99px"></td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Label ID="lbl_msg" runat="server" ForeColor="#006600"></asp:Label>
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_submit_review" runat="server" Text="Submit" Width="700px" OnClick="btn_submit_review_Click" BackColor="Gray" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px">&nbsp;</td>
                <td style="width: 381px">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_back" runat="server" Text="Back to Gem" Width="700px" OnClick="btn_back_Click" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
        </table>
    </form>
    
</asp:Content>
