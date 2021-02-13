<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Generic.aspx.cs" Inherits="SGGO.Error_Pages.Generic" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Error</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.0.0/css/bootstrap.min.css" integrity="sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm" crossorigin="anonymous">
    <link rel="stylesheet" href="https://cdn.jsdelivr.net/npm/bootstrap-icons@1.3.0/font/bootstrap-icons.css">
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <div class="card" style="width: 70%; height: 40%; margin: 10px auto auto auto; padding: 20px; vertical-align: middle;">
                <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Oops! Something went wrong."></asp:Label>
                <br />
                <asp:Label ID="Label2" runat="server" Font-Bold="false" Font-Size="20px" Text="We're sorry for the inconvenience."></asp:Label>
                
                <br />
                <div style="text-align: center;">
                    <asp:Button ID="Button1" runat="server" CssClass="btn btn-dark" Text="Return" OnClick="Button1_Click" />
                </div>               
                
            </div>
        </div>
    </form>
</body>
</html>
