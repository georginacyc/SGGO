<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Accounts_List.aspx.cs" Inherits="SGGO.Staff_Accounts_List" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <style>
        #mainDiv {
            width: 70%;
            margin:auto;
            font-size: 17px;
        }
        #accounts_gv {
            height: 100%;
            width: 100%;
        }
    </style>
    <div id="mainDiv">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Accounts Table"></asp:Label>
        <asp:GridView ID="accounts_gv" runat="server" style="width: 100%" DataSourceID="accountsDS" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AllowSorting="True" AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" ForeColor="Black" GridLines="Horizontal" AllowPaging="True">
            <Columns>
                <asp:BoundField DataField="type" HeaderText="Type" ReadOnly="True" SortExpression="type" />
                <asp:BoundField DataField="first_name" HeaderText="Name" ReadOnly="True" SortExpression="first_name"/>
                <asp:BoundField DataField="email" HeaderText="Email" ReadOnly="True" SortExpression="email" />
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
        <asp:SqlDataSource ID="accountsDS" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [type], [first_name], [email] FROM [Accounts] ORDER BY [type] DESC"></asp:SqlDataSource>

    </div>    
</asp:Content>
