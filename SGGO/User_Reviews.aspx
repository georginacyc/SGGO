<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Reviews.aspx.cs" Inherits="SGGO.User_Reviews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <div class="card" style="width: 80%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
    <form id="form1" runat="server" style="text-align:center;">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="My Reviews"></asp:Label>
            <asp:GridView ID="gvMyreview" runat="server" AutoGenerateColumns="False" DataKeyNames="review_id" OnSelectedIndexChanged="gvMyreview_SelectedIndexChanged" DataSourceID="GetGemReviews" CellPadding="4" ForeColor="Black" GridLines="Horizontal" Width="852px" HorizontalAlign="Center" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px">
                <Columns>
                    <asp:BoundField DataField="gem_title" HeaderText="Gem" SortExpression="gem_title" />
                    <asp:BoundField DataField="rating" HeaderText="Rating (out of 5 stars)" SortExpression="rating" />
                    <asp:BoundField DataField="description" HeaderText="     Description     " SortExpression="description" />
                    <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                    <asp:CommandField SelectText="Delete" ShowCancelButton="False" ShowSelectButton="True" HeaderText="Delete Review" >
                    <ItemStyle ForeColor="#990000" />
                    </asp:CommandField>
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
            <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review] WHERE ([author] = @author)">
                <SelectParameters>
                    <asp:SessionParameter Name="author" SessionField="user" Type="String" />
                </SelectParameters>
        </asp:SqlDataSource>
        
            
    </form>
        </div>
</asp:Content>
