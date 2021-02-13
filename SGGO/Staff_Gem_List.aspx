<%@ Page Title="All Gems" Language="C#"  MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Gem_List.aspx.cs" Inherits="SGGO.Staff_Gem_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid">
        <asp:Label ID="lb_msg" runat="server" BorderColor="#009900" ForeColor="#009900"></asp:Label>
        <br />
        <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="Gem List"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="GemDataSource" ForeColor="Black" GridLines="Horizontal"  Width="100%">
        <Columns>
            <asp:BoundField DataField="title" HeaderText="Title" ReadOnly="True" SortExpression="title" />
            <asp:BoundField DataField="partner" HeaderText="Partner" ReadOnly="True" SortExpression="partner" />
            <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="True" SortExpression="type" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="True" SortExpression="status" />
            <asp:CommandField ShowSelectButton="True" />
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
    <asp:SqlDataSource ID="GemDataSource" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [title], [partner], [status], [type] FROM [Gem] ORDER BY [status] DESC"></asp:SqlDataSource>

</div>
</asp:Content>
