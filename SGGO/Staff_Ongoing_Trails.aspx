<%@ Page  Title="Ongoing Trails" MasterPageFile="~/Staff.Master" Language="C#" AutoEventWireup="true" CodeBehind="Staff_Ongoing_Trails.aspx.cs" Inherits="SGGO.Staff_Ongoing_Trails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid" style="width: 70%; margin:auto">
        <asp:Label ID="lb_msg" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="Ongoing Trails"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="OngoingTrailDataSource" ForeColor="Black" GridLines="Horizontal"  Width="100%">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Title" SortExpression="name" ReadOnly="True" />
            <asp:BoundField DataField="date" HeaderText="Publish Date" SortExpression="date" ReadOnly="True"/>
            <asp:BoundField DataField="status" HeaderText="Status" SortExpression="status" ReadOnly="True" />
            <asp:ButtonField ButtonType="Button" Text="Make Ongoing" CommandName="makeOngoing"/>
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
        <asp:SqlDataSource ID="OngoingTrailDataSource" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [name], [date], [status] FROM [Trail]">
            <SelectParameters>
                <asp:Parameter DefaultValue="Upcoming" Name="status" Type="String" />
                <asp:Parameter DefaultValue="Ongoing" Name="status2" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
    <asp:SqlDataSource ID="GemDataSource" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [title], [partner], [status], [type] FROM [Gem] ORDER BY [status] DESC"></asp:SqlDataSource>

</div>
</asp:Content>
