<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Catalogue.aspx.cs" Inherits="SGGO.Gem_Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <div class="card" style="width: 80%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px; text-align:center;">
        <asp:Label ID="Label1" runat="server" Font-Size="40px" Text="Hidden Gems" ></asp:Label>
        <br />
    <form id="form1" runat="server" style="padding-left:10px;padding-top:15px;">
        
<asp:ListView ID="ListView_Gem" runat="server" 
              DataKeyNames="Id"  
              DataSourceID="SGGO" 
              GroupItemCount="3" >
   <EmptyDataTemplate>
      <table runat="server">
        <tr>
          <td>There are no gems currently sorry.</td>
        </tr>
     </table>
  </EmptyDataTemplate>
  <EmptyItemTemplate>
     <td runat="server" />
  </EmptyItemTemplate>
  <GroupTemplate>
    <tr ID="itemPlaceholderContainer" runat="server">
      <td ID="itemPlaceholder" runat="server"></td>
    </tr>
  </GroupTemplate>
  <ItemTemplate>
      <td runat="server" style="width:400px">
      <table border="0">
          <div class="card" style="width: 300px;">
          <img class="card-img-top" src="/Images/Gem/<%# Eval("image") %>.jpg" alt="Card image cap" style="width:300px; height:179px">
          <div class="card-body">
            <h3 class="card-title"><span class="ProductListHead"><%# Eval("title") %></span></h3>
            <p class="card-text"><span class="GemListItem"><b> Average Rating : </b><%# Eval("rating")%></span></p>
            <a href='Gem_Listing.aspx?gemId=<%# Eval("Id") %>' class="btn btn-dark" style="width:250px"><b>View Details<b></a>
          </div>
      </table>
    </td>
   </div>
  </ItemTemplate>
  <LayoutTemplate>
    <table runat="server">
      <tr runat="server">
        <td runat="server">
          <table ID="groupPlaceholderContainer" runat="server">
            <tr ID="groupPlaceholder" runat="server"></tr>
          </table>
        </td>
      </tr>
      <tr runat="server"><td runat="server"></td></tr>
    </table>
  </LayoutTemplate>
</asp:ListView>
        <asp:SqlDataSource ID="SGGO" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" SelectCommand="SELECT * FROM [Gem] WHERE (([type] = @type) AND ([status] = @status))" ProviderName="System.Data.SqlClient">
            <SelectParameters>
               
                <asp:Parameter DefaultValue="Destination" Name="type" Type="String" />
                <asp:Parameter DefaultValue="Pending" Name="status" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
    </div>
</asp:Content>
