<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Home.aspx.cs" Inherits="SGGO.Staff_Home" %>
<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>
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
                                <td rowspan="2" class="pendingNum">
                                    <asp:Label ID="reports_lb" runat="server"></asp:Label>
                                </td>
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
                                <td rowspan="2" class="pendingNum">
                                    <asp:Label ID="reviews_lb" runat="server"></asp:Label>
                                </td>
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
                                <td rowspan="2" class="pendingNum">
                                    <asp:Label ID="gems_lb" runat="server"></asp:Label>
                                </td>
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
    </div>
    <div class="row" style="width: 60%; margin: 10px auto auto auto;">
        <asp:Chart ID="test_chart" runat="server">
            <series>
                <asp:Series ChartType="Bar" Name="Test" ChartArea="ChartArea1">
                    <Points>
                        <asp:DataPoint AxisLabel="Youth" YValues="2" />
                        <asp:DataPoint AxisLabel="Young Adult" YValues="4" />
                        <asp:DataPoint AxisLabel="Adult" YValues="10" />
                        <asp:DataPoint AxisLabel="Elderly" YValues="3" />
                    </Points>
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:Chart ID="age_chart" runat="server">
            <series>
                <asp:Series ChartType="Bar" Name="age_series" ChartArea="age_chartarea">
                    <Points>
                    </Points>
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="age_chartarea">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
    </div>
</asp:Content>
