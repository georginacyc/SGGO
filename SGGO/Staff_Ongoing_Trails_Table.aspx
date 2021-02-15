<%@ Page  Title="Ongoing Trails" MasterPageFile="~/Staff.Master" Language="C#" AutoEventWireup="true" CodeBehind="Staff_Ongoing_Trails_Table.aspx.cs" Inherits="SGGO.Staff_Ongoing_Trails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid" style="width: 70%; margin:auto">
        <asp:Label ID="lb_msg" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="Ongoing Trails"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal"  Width="100%">
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Title" ReadOnly="True" />
            <asp:BoundField DataField="date" DataFormatString="Mon-DD-YYYY" HeaderText="Date" ReadOnly="True" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="True" />
            <asp:ButtonField ButtonType="Button" CausesValidation="True" Text="Edit" />
            <asp:ButtonField ButtonType="Button" Text="Preview" />
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
