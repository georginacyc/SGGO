<%@ Page Title="" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Home_Page.aspx.cs" Inherits="SGGO.Home_Page" %>
<asp:Content ID="Content1" ContentPlaceHolderID="UserContent" runat="server">

<link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" />
<style type="text/css">

    .auto-style1 {
       position: absolute;
      top: 49%;
      left: 23%;
      transform: translate(-50%, -50%);
    }
    .auto-style2 {
        position: absolute;
        top: 65%;
        left: 30%;
        transform: translate(-50%, -50%);
        width:650px;
        padding:10px;
    }
    #text{
       display: inline-block;
    }

    .auto-style3 {
        position: absolute;
        top: 80%;
        left: 14%;
        transform: translate(-50%, -50%);
        padding:5px;
    }
    .auto-style4 {
        position: absolute;
        top: 80%;
        left: 29%;
        transform: translate(-50%, -50%);
        padding:5px;        
    }

</style>
<form id="form1" runat="server">
    <div id="home" style="overflow:hidden;">     
        
     <asp:Image ID="Image1" runat="server" ImageUrl="~/Test_Image/Home.jpg" Width="100%" />

        <div id="text" class=".d-flex">

            <asp:Label ID="lblWelcome" runat="server" Text="Welcome to SGGO" CssClass="auto-style1" ForeColor="White" 
                Font-Size="50px" Font-Bold="true"></asp:Label>

            <asp:Label ID="lblUsername" runat="server" CssClass="auto-style2" ForeColor="White" Font-Bold="true" 
                BackColor="#666666" >
                SGGO is your one-stop site to find Singapore’s hidden gems. 
                Discover homegrown businesses and support local tourism, 
                explore our catalogue of destinations and activities from our 
                partner companies and join our monthly trails for exciting 
                itineraries and additional points!</asp:Label>

            <asp:Button ID="btn_gems" runat="server" Text="Explore Hidden Gems" Height="41px" Width="184px" Font-Bold="true" 
                 Cssclass="btn btn-light ; auto-style3" OnClick="btn_gems_Click"/>

            <asp:Button ID="btn_trails" runat="server" Text="Explore Trails" Height="41px" Width="184px" Font-Bold="true" 
                Cssclass="btn btn-light ; auto-style4" OnClick="btn_trails_Click"/>

        </div>
    </div> 
    
    </form>
    
</asp:Content>
