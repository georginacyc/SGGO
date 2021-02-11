<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Home.aspx.cs" Inherits="SGGO.Staff_Home" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        td {
            color:black;
            font-weight: bold;
            font-size: 20px;
        }
        .pendingNum {
            color: red;
            font-weight: bold;
            font-size: 70px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="row" style="width: 60%; margin: 10px auto auto auto;">
        <div class="col" >
            <a href="Staff_Reports_Table.aspx" style="text-decoration:none;">
                <div class="card">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="2" class="pendingNum">6</td>
                                <td>PENDING REPORTS</td>
                            </tr>
                            <tr>
                                <td>click here to view</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </a>
        </div>
        <div class="col" >
            <a href="Staff_Reviews_Table.aspx" style="text-decoration:none;">
                <div class="card">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="2" class="pendingNum">6</td>
                                <td>PENDING REVIEWS</td>
                            </tr>
                            <tr>
                                <td>click here to view</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </a>
        </div>
        <div class="col" >
            <a href="Staff_Gems_Table.aspx" style="text-decoration:none;">
                <div class="card">
                    <div class="card-body" style="text-align: center;">
                        <table style="width:100%;">
                            <tr>
                                <td rowspan="2" class="pendingNum">6</td>
                                <td>PENDING GEMS</td>
                            </tr>
                            <tr>
                                <td>click here to view</td>
                            </tr>
                        </table>
                    </div>
                </div>
            </a>
        </div>
</asp:Content>
