<%@ Page  Title="Create Gem" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Create_Gem.aspx.cs" Inherits="SGGO.Create_Gem" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 1373px
        }
        .auto-style7 {
            width: 221px;
        }
       
        #button{
            position: absolute;
            right: 10px;
        }
        table,tr{
            margin:10px;
        }
       
        .auto-style8 {
            width: 221px;
            height: 26px;
        }
        .auto-style9 {
            height: 26px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
    <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="New Gem"></asp:Label>
        <br />
        <asp:Label ID="lb_errormsg" runat="server" BorderColor="#993333" ForeColor="Black"></asp:Label>
    <br />
    <table class="auto-style5" id="formtable">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_title" runat="server" Text="Title"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_title" runat="server" Width="100%"></asp:TextBox>
               
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_description" runat="server" Text="Description:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_description" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_type" runat="server" Text="Type:"></asp:Label>
            </td>
            <td>
                <asp:RadioButtonList ID="rb_type" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Width="307px" OnSelectedIndexChanged="rb_type_SelectedIndexChanged">
                    <asp:ListItem>Destination</asp:ListItem>
                    <asp:ListItem>Activity</asp:ListItem>
                </asp:RadioButtonList>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">

                <asp:Label ID="lb_partner" runat="server" Text="Partner Company:" ></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:Label ID="lb_pc" runat="server" Width="100%"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">

                &nbsp;</td>
            <td class="auto-style9">
                <asp:Label ID="lb_pc_email" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_location" runat="server" Text="Location:" ></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_location" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
            <tr id="date_row" >
            <td class="auto-style7">
                <asp:Label ID="lb_date" runat="server" Text="Date:"></asp:Label>
            </td>
            
            <td>
                <asp:TextBox ID="tb_date" TextMode="DateTimeLocal" runat="server"></asp:TextBox>
            </td>
        </tr>
        
        </table>
    
    <br />
    <asp:Label ID="lb_image" runat="server" Text="Gem Image:"></asp:Label>
    <br />
    <asp:FileUpload ID="ImageUpload" runat="server" Width="521px" />
        <asp:Button ID="btn_upload" runat="server" Text="Upload Image" margin-left="10px" OnClick="btn_upload_Click"/>
    <br />
        <asp:Label ID="lb_uploadstatus" runat="server"></asp:Label>
    <br />
    <br />
        <div id="button">
        
        <asp:Button ID="btn_submit" runat="server" Text="Submit" OnClick="btn_submit_Click" />
        
        </div>
        
    <br />
        </div>

    
</asp:Content>