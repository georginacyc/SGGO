<%@ Page  Title="Ongoing Trails" MasterPageFile="~/Staff.Master" Language="C#" AutoEventWireup="true" CodeBehind="Staff_Ongoing_Trails.aspx.cs" Inherits="SGGO.Staff_Ongoing_Trails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class ="container-fluid" style="width: 70%; margin:auto">
        <asp:Label ID="lb_msg" runat="server"></asp:Label>
        <br />
        <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="Ongoing Trails"></asp:Label>
    <br />
    <asp:GridView ID="GridView1" runat="server" AllowPaging="True" onrowcommand="GridView1_RowCommand" onrowdatabound="GridView1_RowDataBound" AutoGenerateColumns ="False" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="4" DataSourceID="OngoingTrailDataSource" ForeColor="Black" GridLines="Horizontal"  Width="100%" >
        <Columns>
            <asp:BoundField DataField="name" HeaderText="Title" SortExpression="name" ReadOnly="True" />
            <asp:BoundField DataField="date" HeaderText="Publish Date" SortExpression="date" ReadOnly="True" DataFormatString="{0:yyyy MMMM}"/>
            <asp:TemplateField HeaderText="Status" SortExpression="status">
                <EditItemTemplate>
                    <asp:Label ID="lb_status" runat="server" Text='<%# Eval("status") %>'></asp:Label>
                </EditItemTemplate>
                <ItemTemplate>
                    <asp:Label ID="lb_status" runat="server" Text='<%# Bind("status") %>'></asp:Label>
                </ItemTemplate>
            </asp:TemplateField>
            <asp:TemplateField ShowHeader="False">
                <ItemTemplate>
                    <asp:Button ID="btn_makeOngoing" runat="server" CausesValidation="false" CommandName="makeOngoing" Text="Make Ongoing" />
                </ItemTemplate>
            </asp:TemplateField>
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
        <asp:SqlDataSource ID="OngoingTrailDataSource" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [name], [date], [status] FROM [Trail] WHERE ([status] NOT LIKE '%' + @status + '%')">
            <SelectParameters>
                <asp:Parameter DefaultValue="draft" Name="status" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

</div>
</asp:Content>
