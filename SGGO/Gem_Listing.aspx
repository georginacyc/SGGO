<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Listing.aspx.cs" Inherits="SGGO.Gem_Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
        <table style="width:100%; text-align:center;">
            <tr>
                <td style="width: 549px">&nbsp;</td>
                <td style="width: 196px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="3" style="width: 549px">
                    <asp:Image ID="gem_image" runat="server" Height="221px" Width="390px" ImageUrl="~/Test_Image/Cafe-De-Nicoles.jpg" />
                </td>
                <td style="width: 196px">
                    &nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 196px">
                    <b><asp:Label ID="gem_title" runat="server">Nicole flower cafe</asp:Label></b>
                </td>
                <td style="width: 350px"><iframe src="https://www.google.com/maps/embed?pb=!1m14!1m8!1m3!1d15955.092294639131!2d103.9108875!3d1.3115352!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x0%3A0xe7875ff1ed2b842!2sNicole&#39;s%20Flower%3A%20Cafe%20%26%20Flower%20Delivery%20in%20Singapore!5e0!3m2!1sen!2ssg!4v1610976035355!5m2!1sen!2ssg" 
                        width="210" height="200"  style="border:0;"aria-hidden="false" tabindex="0"></iframe></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 196px">
                    <asp:Label ID="lbl_gemId" runat="server"></asp:Label>
                </td>
                <td style="width: 350px">
                    <asp:Button ID="btn_map" runat="server" Height="37px" Text="Bring Me" Width="148px" OnClick="btn_map_Click" />
                </td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    <asp:Label ID="gem_desc" runat="server">Most Instagram-Worthy Floral-Themed Café With Soufflé Pancakes Found At East Coast.</asp:Label>
                </td>
                <td style="width: 196px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px"><b>Reviews</b></td>
                <td style="width: 196px">
                    <asp:Button ID="btn_review" runat="server" Height="36px" Text="Leave a Review" Width="174px" OnClick="btn_review_Click"/>
                </td>
                <td style="width: 350px">
                    <asp:Button ID="btn_report" runat="server" Height="41px" OnClick="btn_report_Click1" Text="Report" />
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    <div style="padding-left:50px">
                    <asp:Label ID="gem_review" runat="server"></asp:Label>
                    <asp:GridView ID="gvReview" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid" Width="541px" DataKeyNames="id" DataSourceID="GetGemReviews" >
                        <Columns>
                            <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                            <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review]"></asp:SqlDataSource>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
                    </div>
                </td>
                <td style="width: 196px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">&nbsp;</td>
                <td style="width: 196px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">&nbsp;</td>
                <td style="width: 196px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</asp:Content>
