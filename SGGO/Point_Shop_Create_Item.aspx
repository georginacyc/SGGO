<%@ Page  Title="Create Point Shop Item" Language="C#" MasterPageFile="~/Partner.Master" AutoEventWireup="true" CodeBehind="Point_Shop_Create_Item.aspx.cs" Inherits="SGGO.Point_Shop_Create_Item" %>

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
    <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="New Point Shop Item"></asp:Label>
    <br />
    <table class="auto-style5" id="formtable">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_name" runat="server" Text="Name"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_name" runat="server" Width="100%"></asp:TextBox>
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
                <asp:RadioButtonList ID="rb_type" runat="server" AutoPostBack="True" RepeatDirection="Horizontal" Width="307px">
                    <asp:ListItem>Package</asp:ListItem>
                    <asp:ListItem>Voucher</asp:ListItem>
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
                <asp:Label ID="lb_price" runat="server" Text="Monetary Value: " ></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_price" runat="server" Width="100%" TextMode="Number"></asp:TextBox>
            </td>
        </tr>
            <tr id="date_row" >
            <td class="auto-style7">
                &nbsp;
            </td>
            
            <td>
                &nbsp;
            </td>
        </tr>
        
        </table>
    
    <br />
    <asp:Label ID="lb_image" runat="server" Text="Item Image:"></asp:Label>
    <br />
    <asp:FileUpload ID="ImageUpload" runat="server" Width="521px" />
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