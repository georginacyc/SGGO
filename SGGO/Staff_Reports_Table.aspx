<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Reports_Table.aspx.cs" Inherits="SGGO.Staff_Reports_Table" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="width: 60%; margin:auto; font-size: 17px;">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Reports Table"></asp:Label>
        <asp:GridView ID="reports_gv" runat="server" AutoGenerateColumns="False" AllowPaging="True" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" OnSelectedIndexChanged="reports_gv_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="report_id" HeaderText="ID" ReadOnly="True" />
            <asp:BoundField DataField="status" HeaderText="Status" ReadOnly="True" />
            <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="True" />
            <asp:BoundField DataField="reason" HeaderText="Reason" ReadOnly="True" />
            <asp:CommandField SelectText="Details" ShowCancelButton="False" ShowSelectButton="True" />
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
