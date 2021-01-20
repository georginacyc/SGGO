<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Review.aspx.cs" Inherits="SGGO.Staff_Review" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server" >
    <div style="padding-left:100px;">
        <p>
            <br />
            <b>Reviews</b></p>
        <p>
            <asp:GridView ID="gvReview" runat="server" AutoGenerateColumns="False" CellPadding="0" CssClass="myDatagrid" Width="1003px" DataKeyNames="id" DataSourceID="GetGemReviews" >
                <Columns>
                
                    <asp:BoundField  HeaderText="id" ReadOnly="True" DataField="id" InsertVisible="False" SortExpression="id"/>
                    <asp:BoundField DataField="status" HeaderText="status" SortExpression="status" />
                    <asp:BoundField DataField="post" HeaderText="post" SortExpression="post" />
                    <asp:BoundField DataField="author" HeaderText="author" SortExpression="author" />
                    <asp:BoundField DataField="rating" HeaderText="rating" SortExpression="rating" />
                    <asp:BoundField DataField="description" HeaderText="description" SortExpression="description" />
                </Columns>
            </asp:GridView>
            <asp:SqlDataSource ID="GetGemReviews" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT * FROM [Review]"></asp:SqlDataSource>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server"></asp:SqlDataSource>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </p>
    </div>
</asp:Content>
