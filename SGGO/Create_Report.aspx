<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Create_Report.aspx.cs" Inherits="SGGO.Create_Report" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
    <div class="card" style="width: 48%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
    <form id="form1" runat="server">
        <table style="width:500px; text-align:center;">
            <tr>
                <td style="width: 381px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 381px;">
                    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="30px" Text="Write a Report"></asp:Label></td>
            </tr>
            <tr>
                <td style="width: 381px">
                    <asp:Label ID="lbl_id" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 381px">
                    <asp:DropDownList ID="ddl_reason" runat="server" CssClass="offset-sm-0">
                        <asp:ListItem>- Main Reason -</asp:ListItem>
                        <asp:ListItem>Impersonation</asp:ListItem>
                        <asp:ListItem>False Information</asp:ListItem>
                        <asp:ListItem>Outdated Details</asp:ListItem>
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td style="width: 381px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 381px">
                    <asp:TextBox ID="tb_remark" runat="server" Height="91px" Width="700px"  CssClass="form-control"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td style="height: 42px">
                    <asp:Label ID="lbl_msg" runat="server" ForeColor="#008A00"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="height: 99px">
                    <asp:Button ID="btn_submit_report" runat="server" Text="Submit" Width="700px" Cssclass="btn btn-dark" OnClick="btn_submit_report_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="btn_back" runat="server" Cssclass="btn btn-outline-dark" Text="Back to Home" Width="700px" OnClick="btn_back_Click" />
                </td>
            </tr>
            <tr>
                <td>
                    &nbsp;</td>
            </tr>
            </table>
    </form>
    </div>
</asp:Content>
