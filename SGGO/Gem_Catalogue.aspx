<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Gem_Catalogue.aspx.cs" Inherits="SGGO.Gem_Catalogue" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">
    <br />
    <p style="text-align:center;font-size:x-large">Hidden Gems</p>
    <form id="form1" runat="server" style="padding-left:80px;padding-top:15px;">
        
<asp:ListView ID="ListView_Gem" runat="server" 
              DataKeyNames="Id"  
              DataSourceID="SGGO" 
              GroupItemCount="3">
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
      <table border="0" width="400">
        <tr>
          <td>&nbsp</td>
          <td>
               <image src='~/Images/Gem/<%# Eval("image") %>' 
                      width="200" height="100" border="0">
            </a> &nbsp</td>
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
        <asp:SqlDataSource ID="SGGO" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" SelectCommand="SELECT * FROM [Gem] WHERE (([type] = @type) AND ([status] = @status))" ProviderName="System.Data.SqlClient">
            <SelectParameters>
               
                <asp:Parameter DefaultValue="Destination" Name="type" Type="String" />
                <asp:Parameter DefaultValue="Pending" Name="status" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    </form>
</asp:Content>
