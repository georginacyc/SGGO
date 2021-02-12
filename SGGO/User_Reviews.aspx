<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Reviews.aspx.cs" Inherits="SGGO.User_Reviews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server" style="text-align:center;">
        <p style="font-size:x-large">
            My Reviews</p>
            <asp:GridView ID="gvMyreview" runat="server" AutoGenerateColumns="False" DataKeyNames="review_id" OnSelectedIndexChanged="gvMyreview_SelectedIndexChanged" DataSourceID="GetGemReviews" CellPadding="4" ForeColor="#333333" GridLines="None" Width="800px" HorizontalAlign="Center">
                <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                <Columns>
                    <asp:BoundField DataField="gem_title" HeaderText="Gem" SortExpression="gem_title" />
                    <asp:BoundField DataField="rating" HeaderText="Rating" SortExpression="rating" />
                    <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                    <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                    <asp:CommandField SelectText="Delete" ShowCancelButton="False" ShowSelectButton="True" HeaderText="Delete Review" />
                </Columns>
                <EditRowStyle BackColor="#999999" />
                <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
                <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#E9E7E2" />
                <SortedAscendingHeaderStyle BackColor="#506C8C" />
                <SortedDescendingCellStyle BackColor="#FFFDF8" />
                <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
            </asp:GridView>
            <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review] WHERE ([author] = @author)">
                <SelectParameters>
                    <asp:SessionParameter Name="author" SessionField="user" Type="String" />
                </SelectParameters>
        </asp:SqlDataSource>
        
            
    </form>
</asp:Content>
