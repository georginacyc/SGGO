<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Staff_Change_Password.aspx.cs" Inherits="SGGO.Staff_Change_Password" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            max-width: 300px;
            width: 189px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div style="display: inline-block; width: 100%">
        <div style="width: 35%; margin-top: 10px; padding: 20px 20px 20px 20px; float:left;">
            <asp:Button ID="back_btn" runat="server" CssClass="btn btn-dark" style="width: auto; float:right" Text="< Back" OnClick="back_btn_Click" />
        </div>
        <div class="card" style="width: 30%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px; float: left">
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Change Password"></asp:Label>
            <table style="width:100%; " cellpadding="7px">
                <tr>
                    <td class="auto-style1">Current Password</td>
                    <td>
                        <asp:TextBox ID="current_tb" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">New Password</td>
                    <td>
                        <asp:TextBox ID="new_tb" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1">Confirm New Password</td>
                    <td>
                        <asp:TextBox ID="new2_tb" runat="server" CssClass="form-control" TextMode="Password"></asp:TextBox>
                        </td>
                </tr>
                <tr>
                    <td class="modal-sm" style="width: 166px" colspan="2">Password Complexity: <span id="complexity_rating" style="font-weight: bold;"></span></td>
                </tr>
            </table>
        <p>
                        <strong><asp:Label ID="pwd_match" runat="server" ForeColor="Red">Passwords must match!</asp:Label>
                        </strong></p>
            <p><strong>
            <asp:Label ID="error_lb" runat="server" ForeColor="Red"></asp:Label>
            </strong></p>
        <p>Your password must meet the following criteria:<br />
    &nbsp;&nbsp;&nbsp; -
        <strong>
        <asp:Label ID="pwd_length" runat="server" ForeColor="Red" Text="At least 8 characters"></asp:Label>
        </strong>
        <br />
    &nbsp;&nbsp;&nbsp; -
        <strong>
        <asp:Label ID="pwd_case" runat="server" ForeColor="Red" Text="Mix of upper and lowercase characters"></asp:Label>
        </strong>
        <br />
    &nbsp;&nbsp;&nbsp; -
        <strong>
        <asp:Label ID="pwd_num" runat="server" ForeColor="Red" Text="At least 1 number"></asp:Label>
        </strong>
        <br />
    &nbsp;&nbsp;&nbsp; -
        <strong>
        <asp:Label ID="pwd_char" runat="server" ForeColor="Red" Text="At least 1 special character"></asp:Label>
        </strong>
        <br />
        </p>
            <asp:Label ID="success_lb" runat="server" Text="You will be logged out upon successful password change."></asp:Label>
            <div class="display: inline-block">
            <asp:Button ID="submit_btn" runat="server" CssClass="btn btn-dark" style="width: 15%; float:right" Text="Submit" OnClick="submit_btn_Click" />

            </div>
        </div>
    </div>
    
    
    <script type="text/javascript">
        document.getElementById("<%=pwd_match.ClientID %>").style.display = "none";

        function pwdChecker() {
            var pwd = document.getElementById("<%=new_tb.ClientID %>").value;
            var score = 0;
            var rating = document.getElementById("complexity_rating");
            rating.innerHTML = "";

            if (pwd.length >= 8) {
                document.getElementById("<%=pwd_length.ClientID %>").style.color = "Green";
                document.getElementById("<%=pwd_length.ClientID %>").style.fontWeight = "normal";
                score += 1;
            } else {
                document.getElementById("<%=pwd_length.ClientID %>").style.color = "Red";
                document.getElementById("<%=pwd_length.ClientID %>").style.fontWeight = "bold";
            }

            var caseRegex = /.*[A-Z]+.*[a-z]+.*/;
            if (caseRegex.test(pwd)) {
                document.getElementById("<%=pwd_case.ClientID %>").style.color = "Green";
                document.getElementById("<%=pwd_case.ClientID %>").style.fontWeight = "normal";
                score += 1;
            } else {
                document.getElementById("<%=pwd_case.ClientID %>").style.color = "Red";
                document.getElementById("<%=pwd_case.ClientID %>").style.fontWeight = "bold";
            }

            var numRegex = /.*[0-9]+.*/;
            if (numRegex.test(pwd)) {
                document.getElementById("<%=pwd_num.ClientID %>").style.color = "Green";
                document.getElementById("<%=pwd_num.ClientID %>").style.fontWeight = "normal";
                score += 1;
            } else {
                document.getElementById("<%=pwd_num.ClientID %>").style.color = "Red";
                document.getElementById("<%=pwd_num.ClientID %>").style.fontWeight = "bold";
            }

            var charRegex = /[ `!@#$%^&*()_+\-=\[\]{};':"\\|,.<>\/?~]/;
            if (charRegex.test(pwd)) {
                document.getElementById("<%=pwd_char.ClientID %>").style.color = "Green";
                document.getElementById("<%=pwd_char.ClientID %>").style.fontWeight = "normal";
                score += 1;
            } else {
                document.getElementById("<%=pwd_char.ClientID %>").style.color = "Red";
                document.getElementById("<%=pwd_char.ClientID %>").style.fontWeight = "bold";
            }

            switch (score) {
                case 1:
                    rating.innerHTML = "Very Weak";
                    rating.style.color = "Red";
                    break;
                case 2:
                    rating.innerHTML = "Weak";
                    rating.style.color = "Red";
                    break;
                case 3:
                    rating.innerHTML = "Medium";
                    rating.style.color = "Red";
                    break;
                case 4:
                    rating.innerHTML = "Strong";
                    rating.style.color = "Green";
                    break;
                default:
                    rating.innerHTML = "Very Weak";
                    rating.style.color = "Red";
                    break;

            }
        }

        function pwdMatcher() {
            var pwd1 = document.getElementById("<%=new_tb.ClientID %>").value;
            var pwd2 = document.getElementById("<%=new2_tb.ClientID %>").value;

            if (pwd1 != pwd2) {
                document.getElementById("<%=pwd_match.ClientID %>").style.display = "";
            } else {
                document.getElementById("<%=pwd_match.ClientID %>").style.display = "none";
            }
        }
    </script>
</asp:Content>
