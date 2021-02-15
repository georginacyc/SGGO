<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Draft_Trails.aspx.cs" Inherits="SGGO.Staff_Draft_Trails" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid" style="width: 70%; margin:auto">
        <br />
        <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="Draft Trails"></asp:Label>
        <asp:Label ID="lb_msg" runat="server"></asp:Label>
    <br />
    <asp:GridView ID="gv_draftTrails" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal"  Width="100%" OnRowCommand="gv_draftTrails_RowCommand">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Title" ReadOnly="True" />
            <asp:BoundField DataField="date" DataFormatString="{0:dd/MM/yyyy}" HeaderText="Publish Date" ReadOnly="True" />
            <asp:ButtonField ButtonType="Button" Text="Edit" CommandName="edit"/>

            <asp:ButtonField ButtonType="Button" Text="Delete" CommandName="delete" />
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

</div>
</asp:Content>
