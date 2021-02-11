<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Catalogue.aspx.cs" Inherits="SGGO.Gem_Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <form id="form1" runat="server">
<asp:ListView ID="ListView_Gem" runat="server" 
              DataKeyNames="Id"  
              DataSourceID="SGGO" 
              GroupItemCount="2">
   <EmptyDataTemplate>
      <table runat="server">
        <tr>
          <td>No data was returned.</td>
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
    <td runat="server">
      <table border="0" width="300">
        <tr>
          <td>&nbsp</td>
          <td>
            <a href='Gem_Listing.aspx?gemId=<%# Eval("Id") %>'>
               <image src='Catalog/Images/Thumbs/<%# Eval("image") %>' 
                      width="100" height="75" border="0">
            </a> &nbsp
          </td>
          <td>
            <span 
               class="ProductListHead"><%# Eval("title") %></span><br>
            </a>
            <span class="GemListItem">
              <b> Rating : </b><%# Eval("rating")%>
            </span><br />
            <a href='Gem_Listing.aspx?gemId=<%# Eval("Id") %>'>
               <span class="GemListItem"><b>View Details<b></font></span>
            </a>
          </td>
        </tr>
      </table>
    </td>
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
        <asp:SqlDataSource ID="SGGO" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" SelectCommand="SELECT [Id], [title], [image], [rating] FROM [Gem]"></asp:SqlDataSource>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
    </form>
</asp:Content>
