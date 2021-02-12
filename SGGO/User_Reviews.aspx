<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Reviews.aspx.cs" Inherits="SGGO.User_Reviews" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <p>
            My Reviews</p>
            <asp:GridView ID="gvMyreview" runat="server" AutoGenerateColumns="False" DataKeyNames="review_id" OnSelectedIndexChanged="gvMyreview_SelectedIndexChanged" DataSourceID="GetGemReviews">
                <Columns>
                    <asp:BoundField DataField="review_id" HeaderText="Id" InsertVisible="False" ReadOnly="True" SortExpression="review_id" />
                    <asp:BoundField DataField="post" HeaderText="Post" SortExpression="post" />
                    <asp:BoundField DataField="rating" HeaderText="Rating" SortExpression="rating" />
                    <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                    <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" />
                    <asp:CommandField SelectText="Delete" ShowCancelButton="False" ShowSelectButton="True" HeaderText="Delete Review" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review] WHERE ([author] = @author)">
                <SelectParameters>
                    <asp:SessionParameter Name="author" SessionField="user" Type="String" />
                </SelectParameters>
        </asp:SqlDataSource>
        
            
    </form>
</asp:Content>
