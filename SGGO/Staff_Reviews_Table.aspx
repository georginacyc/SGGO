<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Reviews_Table.aspx.cs" Inherits="SGGO.Staff_Reviews_Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid" style="width: 70%; margin:auto; font-size: 17px;">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Reviews List"></asp:Label>
    <asp:GridView ID="reviews_gv" runat="server" style="width:100%" DataSourceID="reviewDS" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="reviews_gv_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="review_id" HeaderText="ID" ReadOnly="True" SortExpression="review_id" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="True" SortExpression="status" />
            <asp:BoundField DataField="rating" HeaderText="Rating" ReadOnly="True" SortExpression="rating" />
            <asp:CommandField SelectText="Details" ShowCancelButton="False" ShowSelectButton="True" />
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
    <asp:SqlDataSource ID="reviewDS" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [review_id], [status], [rating] FROM [Review] ORDER BY [status] DESC"></asp:SqlDataSource>

        </div>
</asp:Content>
