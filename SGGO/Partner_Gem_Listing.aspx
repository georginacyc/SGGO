<%@ Page Title="" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Partner_Gem_Listing.aspx.cs" Inherits="SGGO.Partner_Gem_Listing" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <table style="width:100%; text-align:center;">
            <tr>
                <td style="width: 549px">&nbsp;</td>
                <td style="width: 317px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td rowspan="3" style="width: 549px">
                    <asp:Image ID="gem_image" runat="server" Height="221px" Width="390px" ImageUrl="~/Test_Image/Cafe-De-Nicoles.jpg" />
                </td>
                <td style="width: 317px">
                    &nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 317px">
                    <b><asp:Label ID="gem_title" runat="server">Nicole flower cafe</asp:Label></b>
                </td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 317px">
                    <asp:Label ID="lbl_gemId" runat="server" Visible="False"></asp:Label>
                </td>
                <td style="width: 350px">
                    &nbsp;</td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    <asp:Label ID="gem_add" runat="server"></asp:Label>
                </td>
                <td style="width: 317px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    
                    <b><asp:Label ID="gem_desc" runat="server">Most Instagram-Worthy Floral-Themed Café With Soufflé Pancakes Found At East Coast.</asp:Label></b>
                </td>
                <td style="width: 317px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px"><b>Reviews</b></td>
                <td style="width: 317px">
                    &nbsp;</td>
                <td style="width: 350px">
                    &nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    <div style="padding-left:20px">
                    <asp:GridView ID="gvReview" runat="server" AutoGenerateColumns="False" CellPadding="4" CssClass="myDatagrid" Width="598px" DataKeyNames="review_id" OnSelectedIndexChanged="gvReview_SelectedIndexChanged" DataSourceID="GetGemReviews" ForeColor="#333333" GridLines="None" >
                        <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
                        <Columns>
      
                            <asp:BoundField DataField="rating" HeaderText="Rating (out of 5 stars)" SortExpression="rating" />
                            <asp:BoundField DataField="description" HeaderText="Description" SortExpression="description" />
                            <asp:CommandField SelectText="Report" ShowCancelButton="False" ShowSelectButton="True" >
                            <ItemStyle ForeColor="#990000" />
                            </asp:CommandField>
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
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">&nbsp;</td>
                <td style="width: 317px">&nbsp;</td>
                <td style="width: 350px">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td style="width: 549px">
                    <asp:Button ID="btn_back" runat="server" Height="36px" Text="Back" Width="174px" OnClick="btn_back_Click" />
                </td>
                <td style="width: 317px">
                    <asp:Button ID="btn_update" runat="server" Height="41px" Text="Request Update" CssClass="offset-sm-0" Width="174px" BackColor="#666666" ForeColor="White" />
                </td>
                <td style="width: 350px">
                    <asp:Button ID="btn_delete" runat="server" Height="41px" Text="Delete Gem" CssClass="offset-sm-0" Width="174px" BackColor="#660033" ForeColor="White" OnClick="btn_delete_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>
