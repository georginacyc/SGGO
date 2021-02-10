<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Accounts_List.aspx.cs" Inherits="SGGO.Staff_Accounts_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #mainDiv {
            margin-left: 20%;
            margin-right: 20%;
        }
        #accounts_gv {
            height: 100%;
            width: 100%;
        }
    </style>
    <div id="mainDiv">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Accounts Table"></asp:Label>
        <asp:GridView ID="accounts_gv" runat="server" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="True" />
                <asp:BoundField DataField="first_name" HeaderText="Name" ReadOnly="True" />
                <asp:BoundField DataField="email" HeaderText="Email" ReadOnly="True" />
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
        <p>
        </p>
    </div>    
</asp:Content>
