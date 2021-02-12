<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Review_Details.aspx.cs" Inherits="SGGO.Staff_Review_Details" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 312px;
        }
        .auto-style3 {
            width: 23px;
        }
        .auto-style4 {
            width: 23px;
            height: 26px;
        }
        .auto-style5 {
            width: 312px;
            height: 26px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="card" style="width: 30%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
        <asp:Label ID="review_lb" runat="server" Font-Bold="True" Font-Size="40px" Text="Review #"></asp:Label>
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
                <td class="auto-style4"><strong>Gem:</strong></td>
                <td class="auto-style5">
                    <asp:Label ID="gem_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Author:</strong></td>
                <td class="auto-style2">
                    <asp:Label ID="author_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Rating:</strong></td>
                <td class="auto-style2">
                    <asp:Label ID="rating_lb" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style3"><strong>Description:</strong></td>
                <td class="auto-style2" rowspan="2"style="vertical-align: top">
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
