<%@ Page Title="" Language="C#" MasterPageFile="~/Staff.Master" AutoEventWireup="true" CodeBehind="Create_Staff_Account.aspx.cs" Inherits="SGGO.Create_Staff_Account" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            width: 291px;
        }
        .auto-style3 {
            width: 548px;
        }
        .auto-style4 {
            width: 162px;
        }
        .auto-style5 {
            width: 166px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="40px" Text="Create Staff Account"></asp:Label>
    <br />
    <br />
    <table class="w-100">
        <tr>
            <td class="auto-style4">Email</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_email_tb" runat="server" ReadOnly="True"></asp:TextBox>
            </td>
            <td class="auto-style5">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">First Name:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_fn_tb" runat="server" CssClass="offset-sm-0"></asp:TextBox>
            </td>
            <td class="auto-style5">Last Name: </td>
            <td class="auto-style3">
                <asp:TextBox ID="staff_ln_tb" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">DOB:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_dob_tb" runat="server" TextMode="Date"></asp:TextBox>
            </td>
            <td class="auto-style5">HP (+65):</td>
            <td class="auto-style3">
                <asp:TextBox ID="staff_hp_tb" runat="server" TextMode="Phone"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">Postal Code:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_postalcode_tb" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">Address:</td>
            <td class="auto-style3" rowspan="2">
                <asp:TextBox ID="staff_address_tb" runat="server" Height="39px" TextMode="MultiLine" Width="201px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style2">
                &nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">Password:</td>
            <td class="auto-style2">
                <asp:TextBox ID="staff_password_tb" TextMode="Password" runat="server"></asp:TextBox>
            </td>
            <td class="auto-style5">Confirm Password:</td>
            <td class="auto-style3">
                <asp:TextBox ID="staff_password2_tb" TextMode="Password" runat="server"></asp:TextBox>
            &nbsp;<asp:Label ID="pwd_match" runat="server" Font-Bold="True" ForeColor="Red">Passwords must match!</asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style4" colspan="2">Password Complexty: <span id="complexity_rating" style="font-weight: bold;"></span></td>
            <td class="auto-style5">
                &nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>
                &nbsp;</td>
        </tr>
    </table>
    <asp:Label ID="error_lb" runat="server" Font-Bold="True" ForeColor="Red"></asp:Label>
    <br />
    <br />
    Your password must meet the following criteria:<br />
    &nbsp;&nbsp;&nbsp; - <strong>
    <asp:Label ID="pwd_length" runat="server" ForeColor="Red" Text="At least 8 characters"></asp:Label>
    </strong>
    <br />
    &nbsp;&nbsp;&nbsp; - <strong>
    <asp:Label ID="pwd_case" runat="server" ForeColor="Red" Text="Mix of upper and lowercase characters"></asp:Label>
    </strong>
    <br />
    &nbsp;&nbsp;&nbsp; - <strong>
    <asp:Label ID="pwd_num" runat="server" ForeColor="Red" Text="At least 1 number"></asp:Label>
    </strong>
    <br />
    &nbsp;&nbsp;&nbsp; - <strong>
    <asp:Label ID="pwd_char" runat="server" ForeColor="Red" Text="At least 1 special character"></asp:Label>
    </strong>
    <br />
    <br />
    <br />
    <asp:Button ID="submit_btn" runat="server" Text="Submit" OnClick="submit_btn_Click" />
    <br />

    <script>
        document.getElementById("<%=pwd_match.ClientID %>").style.display = "none";

        function pwdChecker() {
            var pwd = document.getElementById("<%=staff_password_tb.ClientID %>").value;
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
            var pwd1 = document.getElementById("<%=staff_password_tb.ClientID %>").value;
            var pwd2 = document.getElementById("<%=staff_password2_tb.ClientID %>").value;

            if (pwd1 != pwd2) {
                document.getElementById("<%=pwd_match.ClientID %>").style.display = "";
            } else {
                document.getElementById("<%=pwd_match.ClientID %>").style.display = "none";
            }
        }
    </script>
</asp:Content>
