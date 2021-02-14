<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Listing.aspx.cs" Inherits="SGGO.Gem_Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <div class="card" style="width: 60%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
    <form id="form1" runat="server">
        <table style="width:100%; text-align:center;">
            <tr>
                <td style="width: 646px; height: 10px; padding:10px;">
                    <b><asp:Label ID="gem_title" runat="server" Font-Bold="True" Font-Size="30px">Nicole flower cafe</asp:Label></b>
                </td>
                <td style="width: 317px; float: left;">
                    &nbsp;</td>
            </tr>
            <tr>
                <td rowspan="3" style="width: 646px">
                    <asp:Image ID="gem_image" runat="server" Height="221px" Width="390px" ImageUrl="~/Test_Image/Cafe-De-Nicoles.jpg" />
                </td>
                <td style="width: 317px">
                    <asp:Label ID="lbl_gemId" runat="server" Visible="False"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 317px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 317px">
                <asp:ImageButton ID="fav" runat="server" Height="42px" Width="43px" ImageUrl="~/Test_Image/like.png" OnClick="fav_Click" />    
                    <br />
                    <asp:Label ID="lbl_like" runat="server"  Text="Add to Favourites"></asp:Label>
                </td>
            </tr>
            <tr>
                <td style="width: 646px">
                    &nbsp;</td>
                <td style="width: 317px">
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 646px">
                    
                    <b><asp:Label ID="gem_desc" runat="server">Most Instagram-Worthy Floral-Themed Café With Soufflé Pancakes Found At East Coast.</asp:Label></b>
                </td>
                <td style="width: 317px">
                    <asp:Button ID="btn_add" runat="server" Text="Locate Us" Height="41px" Width="184px" class="btn btn-dark" OnClick="btn_add_Click"/>
                </td>
            </tr>
            <tr>
                <td style="width: 646px"><b>Reviews</b></td>
                <td style="width: 317px">
                    <asp:Button ID="btn_review" runat="server" Height="41px" Text="Leave a Review" Width="184px" OnClick="btn_review_Click" class="btn btn-dark"/>
                </td>
            </tr>
            <tr>
                <td style="width: 646px">
                    <div style="padding-left:20px">
                    <asp:GridView ID="gvReview" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="myDatagrid" Width="609px" DataKeyNames="review_id" OnSelectedIndexChanged="gvReview_SelectedIndexChanged" DataSourceID="GetGemReviews" ForeColor="Black" GridLines="Horizontal" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" >
                        <Columns>
      
                            <asp:BoundField DataField="rating" HeaderText="Rating (out of 5 stars)" SortExpression="rating" />
                            <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                            <asp:CommandField SelectText="Report" ShowCancelButton="False" ShowSelectButton="True" >
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
                   
                    <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" 
                        ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review] WHERE (([status] = @status) AND ([gem_id] = @gem_id))">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Approved" Name="status" Type="String" />
                        <asp:SessionParameter Name="gem_id" SessionField="gem_id" Type="String" />
                    </SelectParameters>
                    </asp:SqlDataSource>

                    </div>
                </td>
                <td style="width: 317px">&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 646px">&nbsp;</td>
                <td style="width: 317px">
                    <asp:Button ID="btn_report" runat="server" Height="41px" OnClick="btn_report_Click1" Width="184px" Text="Report Gem" class="btn btn-danger" />
                </td>
            </tr>
            <tr>
                <td style="width: 646px">&nbsp;</td>
                <td style="width: 317px">&nbsp;</td>
            </tr>
        </table>
    </form>
        </div>
</asp:Content>
