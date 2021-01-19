<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Create_Trail.aspx.cs" Inherits="SGGO.Create_Trail"  %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style5 {
            width: 1373px
        }
        .auto-style7 {
            width: 221px;
        }
       
        .auto-style8 {
            width: 221px;
            height: 36px;
        }
        .auto-style9 {
            height: 36px;
        }
        #buttons{
            position: fixed;
            right: 10px;
        }
        #btn_create{
            margin-left:10px;
        }
        table,tr{
            margin:10px;
        }
       
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container-fluid">
    <asp:Label ID="lb_pagehead" runat="server" Font-Bold="True" Font-Size="40px" Text="New Trail"></asp:Label>
    <br />
    <table class="auto-style5" id="formtable">
        <tr>
            <td class="auto-style7">
                <asp:Label ID="lb_title" runat="server" Text="Title:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="tb_title" runat="server" Width="100%"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style8">
                <asp:Label ID="lb_date" runat="server" Text="Date:"></asp:Label>
            </td>
            <td class="auto-style9">
                <asp:DropDownList ID="dd_month" runat="server">
                    <asp:ListItem>January</asp:ListItem>
                    <asp:ListItem>February</asp:ListItem>
                    <asp:ListItem>March</asp:ListItem>
                    <asp:ListItem>April</asp:ListItem>
                    <asp:ListItem>May</asp:ListItem>
                    <asp:ListItem>June</asp:ListItem>
                    <asp:ListItem>July</asp:ListItem>
                    <asp:ListItem>August</asp:ListItem>
                    <asp:ListItem>September</asp:ListItem>
                    <asp:ListItem>October</asp:ListItem>
                    <asp:ListItem>November</asp:ListItem>
                    <asp:ListItem>December</asp:ListItem>
                </asp:DropDownList>
                <asp:TextBox ID="tb_year" placeholder="Year" runat="server"> </asp:TextBox>
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
                <asp:Label ID="lb_listings" runat="server" Text="Listings Involved:"></asp:Label>
            </td>
            <td>
                <asp:DropDownList ID="dd_gem" runat="server" DataSourceID="GemDataSource" DataTextField="title" DataValueField="title" Width="230px">
                </asp:DropDownList>
                <asp:Button ID="btn_addListing" runat="server" Text="+" Height="70%" OnClick="btn_addListing_Click" />
                <asp:Label ID="lb_adderror" runat="server"></asp:Label>
                <asp:SqlDataSource ID="GemDataSource" runat="server" ConnectionString="Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\SGGO_DB.mdf;Integrated Security=True;Connect Timeout=30" ProviderName="System.Data.SqlClient" SelectCommand="SELECT [title], [partner], [type] FROM [Gem] WHERE ([status] = @status)">
                    <SelectParameters>
                        <asp:Parameter DefaultValue="Active" Name="status" Type="String" />
                    </SelectParameters>
                </asp:SqlDataSource>
            </td>
        </tr>
        </table>
    <div class="card-deck" >
        <div class="card bg-light ">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem1_listing" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem1_pc" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem1_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
         <div class="card bg-light">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem2_listing" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem2_pc" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem2_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
        <div class="card bg-light">
                    <div class ="card-body">
                        <p class="card-title"> Listing Name: <asp:Label ID="lb_gem3_lisitng" runat="server" Text="-"></asp:Label> </p>
                        <p class="card-text">Partner Company: <asp:Label ID="lb_gem3_pc" runat="server" Text="-"></asp:Label></p>
                        <p class="card-text">Type: <asp:Label ID="lb_gem3_type" runat="server" Text="-"></asp:Label></p>
                    </div>
                </div>
    </div>
        





    <br />
    <asp:Label ID="lb_banner" runat="server" Text="Banner"></asp:Label>
    <br />
    <asp:FileUpload ID="BannerUpload" runat="server" Width="521px" />
        <asp:Button ID="btn_upload" runat="server" Text="Upload Image" margin-left="10px" OnClick="btn_upload_Click"/>
    <br />
        <asp:Label ID="lbl_uploaderror" runat="server" Text="[errormsg]"></asp:Label>
    <br />
    <br />
    <div id ="buttons">
    <asp:Button ID="btn_savedraft" runat="server" Text="Save As Draft" />
    <asp:Button ID="btn_create" runat="server" Text="Create Trail" OnClick="btn_create_Click" />
    </div>
    <br />
        </div>
</asp:Content>
