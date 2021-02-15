<%@ Page Title="User_Home" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="User_Home.aspx.cs" Inherits="SGGO.User_Home" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">




    <form id="form1" runat="server">
        <div>
           
            <br />
            <asp:Label ID="Label1" runat="server" Text="Welcome" style="margin-left: 700px" Width="131px" Font-Bold="True" Font-Size="50px"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:LinkButton ID="LinkButton1" runat="server" style="margin-left: 825px" Width="131px" OnClick="LinkButton1_Click">View profile</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />        
            <asp:LinkButton ID="LinkButton2" runat="server" style="margin-left: 780px" Width="212px" OnClick="LinkButton2_Click1">View Hidden Gems</asp:LinkButton>
            <br />
            <br />
            <br />
            <br />
            <br />
            <br />

           
        </div>
    </form>

    </asp:Content>
