<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Review.aspx.cs" Inherits="SGGO.Gem_Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table style="width:1204px; text-align:center;">
            <tr>
                <td style="width: 401px">Rate &amp; Review</td>
                <td rowspan="3" style="width: 401px">
                    <asp:Image ID="Image1" runat="server" Height="179px" Width="367px" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 401px; height: 18px">
                    <asp:Label ID="review_date" runat="server"></asp:Label>
                </td>
                <td style="width: 402px; height: 18px"></td>
            </tr>
            <tr>
                <td style="width: 401px">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2" style="height: 99px">
                    <asp:TextBox ID="TextBox1" runat="server" Height="91px" Width="700px"></asp:TextBox>
                </td>
                <td style="width: 402px; height: 99px"></td>
            </tr>
            <tr>
                <td colspan="2">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btn_submit_review" runat="server" OnClick="Button1_Click" Text="Submit" Width="700px" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 401px">&nbsp;</td>
                <td style="width: 401px">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
