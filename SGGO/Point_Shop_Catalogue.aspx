<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Point_Shop_Catalogue.aspx.cs" Inherits="SGGO.Point_Shop_Catalogue" %>
<asp:Content ID="Content2" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 177px;
        }
        .auto-style2 {
            width: 455px;
        }
    </style>
    </asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    
    <form>
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
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <div class ="container-fluid" style="width: 70%; margin:auto; font-size: 17px;">
        <asp:Label ID="lb_Company" runat="server" Font-Bold="True" Font-Size="40px"></asp:Label>
        <asp:GridView ID="PSI_gv" style="width:100%" runat="server" DataSourceID="MyPSIDS" OnSelectedIndexChanged="PSIGV_SelectedIndexChanged" AutoGenerateColumns="False" AllowSorting="True" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal">
        <Columns>
            <asp:BoundField DataField="point_shop_item_id" HeaderText="Id" ReadOnly="true" SortExpression="point_shop_item_id" />
            <asp:BoundField DataField="name" HeaderText="Name" ReadOnly="true" SortExpression="name" />
            <asp:BoundField DataField="price" HeaderText="Price" ReadOnly="true" SortExpression="price" />
            <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="true" SortExpression="type" />
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
    <asp:SqlDataSource ID="MyPSIDS" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" 
        SelectCommand="SELECT [point_shop_item_id], [name], [price], [type]  FROM [Point_Shop_Item]">
    </asp:SqlDataSource>

    </div>
        </form>
</asp:Content>