<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Report_Details.aspx.cs" Inherits="SGGO.Staff_Report_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 26px;
        }
        .auto-style2 {
            height: 25px;
        }
        .auto-style3 {
            height: 23px;
            width: 245px;
        }
        .auto-style4 {
            height: 22px;
            width: 245px;
        }
        .auto-style5 {
            height: 21px;
        }
        .auto-style6 {
            height: 15px;
        }
        .auto-style7 {
            height: 26px;
            width: 245px;
        }
        .auto-style8 {
            height: 15px;
            width: 245px;
        }
        .auto-style9 {
            width: 245px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width:40%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
        <asp:Label ID="report_lb" runat="server" Font-Bold="True" Font-Size="40px" Text="Report #"></asp:Label>
        <br />
        <table style="width:100%;">
            <tr>
                <td class="auto-style3"><strong>STATUS:</strong></td>
                <td class="auto-style2">
                    <asp:Label ID="status_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong></strong></td>
                <td class="auto-style2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style4"><strong>Date Reported:</strong></td>
                <td class="auto-style5">
                    <asp:Label ID="date_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7"><strong>Reported By:</strong></td>
                <td class="auto-style1">
                       <asp:Label ID="reporter_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style8"><strong>Type:</strong></td>
                <td class="auto-style6">
                    <asp:Label ID="type_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">

                    <strong>Reported Gem/Review:</strong></td>
                <td>
                    <asp:Label ID="reported_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style7">

                    <strong>Reason:</strong></td>
                <td class="auto-style1">

                    <asp:Label ID="reason_lb" runat="server"></asp:Label>

                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Remarks:</strong></td>
                <td class="auto-style2" rowspan="2" style="vertical-align: top">
                    <asp:Label ID="remarks_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" style="text-align: right;">
                    <asp:Button ID="resolve_btn" runat="server" Text="Mark As Resolved" CssClass="btn btn-danger" OnClick="disapprove_btn_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
