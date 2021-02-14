<%@ Page Title="" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Partner_Gem_List.aspx.cs" Inherits="SGGO.Partner_Gem_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .auto-style2 {
            width: 455px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="w-100">
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style1">&nbsp;</td>
            <td class="auto-style2">
    <asp:Button ID="btn_GotoCreateGem" runat="server" OnClick="btn_GotoCreateGem_Click" Text="Create Gem" />
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div class ="container-fluid" style="width: 70%; margin:auto; font-size: 17px;">
        <asp:Label ID="lb_Company" runat="server" Font-Bold="True" Font-Size="40px"></asp:Label>
        <asp:GridView ID="gems_gv" style="width:100%" runat="server" DataSourceID="MyGemsDS" OnSelectedIndexChanged="GemsGV_SelectedIndexChanged" AutoGenerateColumns="False" AllowSorting="True" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="Id" HeaderText="Id" ReadOnly="true" SortExpression="Id" />
            <asp:BoundField DataField="title" HeaderText="Title" ReadOnly="true" SortExpression="title" />
            <asp:BoundField DataField="location" HeaderText="Location" ReadOnly="true" SortExpression="type" />
            <asp:BoundField DataField="rating" HeaderText="Rating" ReadOnly="true" SortExpression="rating" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="true" SortExpression="status" />
            <asp:CommandField SelectText="View Page" ShowCancelButton="false" ShowSelectButton="true" />
        </Columns>
        <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
        <HeaderStyle BackColor="#333333" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
        <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F7F7F7" />
        <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
        <SortedDescendingCellStyle BackColor="#E5E5E5" />
        <SortedDescendingHeaderStyle BackColor="#242121" />
    </asp:GridView>
    <asp:SqlDataSource ID="MyGemsDS" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [Id], [title], [location], [rating], [status]  FROM [Gem] WHERE ([partner] = @partner)">
        <SelectParameters>
            <asp:ControlParameter ControlID="lb_Company" Name="partner" Type="String" />
        </SelectParameters>
    </asp:SqlDataSource>

    </div>
</asp:Content>
