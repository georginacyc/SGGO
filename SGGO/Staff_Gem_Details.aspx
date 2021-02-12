<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Gem_Details.aspx.cs" Inherits="SGGO.Staff_Gem_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            font-weight: bold;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width:40%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
        <asp:Label ID="title_lb" runat="server" Font-Bold="True" Font-Size="40px"></asp:Label>
        <br />
        <table style="width:100%;" cellpadding="5px">
            <tr>
                <td colspan="2">
                    <asp:Image ID="gem_img" style="max-height:300px; height:auto; width:auto;" runat="server" />
                </td>
            </tr>
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
                <td class="auto-style4"><b>I</b><span class="auto-style1">D:</span></td>
                <td>
                    <asp:Label ID="id_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Partner:</td>
                <td>
                    <asp:Label ID="partner_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">Type:</td>
                <td>
                    <asp:Label ID="type_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style9">

                    <b>D</b><span class="auto-style1">ate:</span></td>
                <td>
                    <asp:Label ID="date_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style1">

                    Location</td>
                <td>

                    <asp:Label ID="location_lb" runat="server"></asp:Label>

                </td>
            </tr>
            <tr>
                <td class="auto-style1">Description:</td>
                <td rowspan="2" style="vertical-align: top">
                    <asp:Label ID="description_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">&nbsp;</td>
                <td class="auto-style2" style="text-align: right;">
                    <asp:Button ID="approve_btn" runat="server" Text="Approve" CssClass="btn btn-success" OnClick="approve_btn_Click" />
    &nbsp;
                    <asp:Button ID="disapprove_btn" runat="server" Text="Reject" CssClass="btn btn-danger" OnClick="disapprove_btn_Click" />
                </td>
            </tr>
        </table>

    </div>
</asp:Content>
