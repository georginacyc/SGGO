<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Create_Report.aspx.cs" Inherits="SGGO.Create_Report" %>
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
                <td style="width: 341px">&nbsp;</td>
                <td style="width: 381px; text-align:center;" >
                    Write a Report</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px; height: 18px">
                    &nbsp;</td>
                <td style="width: 381px">
                    &nbsp;</td>
                <td style="width: 402px; height: 18px"></td>
            </tr>
            <tr>
                <td class="auto-style1">
                    &nbsp;</td>
                <td style="width: 381px">
                    <asp:TextBox ID="tb_desc" runat="server" Height="91px" Width="700px" style="margin-left: 88"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="height: 42px"></td>
                <td style="height: 42px"></td>
                <td style="width: 402px; height: 42px;"></td>
            </tr>
            <tr>
                <td style="height: 99px">
                    &nbsp;</td>
                <td style="height: 99px">
                    <asp:Button ID="btn_submit_report" runat="server" Text="Submit" Width="700px" BackColor="Gray" />
                </td>
                <td style="width: 402px; height: 99px"></td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>
                    <asp:Button ID="btn_back" runat="server" Text="Back to Home" Width="700px" OnClick="btn_back_Click" />
                </td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 341px">&nbsp;</td>
                <td style="width: 381px">&nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
            <tr>
                <td colspan="2">
                    &nbsp;</td>
                <td style="width: 402px">&nbsp;</td>
            </tr>
        </table>
    </form>
    
</asp:Content>
