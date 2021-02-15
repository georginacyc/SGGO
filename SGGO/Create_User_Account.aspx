<%@ Page Title="Create_User_Account" Language="C#" MasterPageFile="~/User.Master" AutoEventWireup="true" CodeBehind="Create_User_Account.aspx.cs" Inherits="SGGO.Create_User_Account" %>
<asp:Content ID="Content1" runat="server" contentplaceholderid="UserContent">

    

        <form id="form1" runat="server">

    

        <div class="card" style="width: 55%; margin: 10px auto auto auto; padding: 20px 20px 20px 20px">
            <asp:Label ID="Label1" runat="server"  Font-Bold="True" Font-Size="40px" Text="Sign Up"></asp:Label>
            <br />
            <table style="width: 100%">
                <tr>
                    <td>
            <asp:Label ID="lbl_fname" runat="server" Text="First Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_fname_tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_lname" runat="server" Text="Last Name"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_lname_tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_email" runat="server" Text="Email"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_email_tb" runat="server" OnTextChanged="tb_email_TextChanged" TextMode="Email"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_pw" runat="server" Text="Password"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="user_password_tb" TextMode="Password" runat="server" OnTextChanged="tb_pw_TextChanged" ></asp:TextBox>                                        
                    </td>
                </tr>
                <tr>
                    <td>
            <asp:Label ID="lbl_confirmpw" runat="server" Text="Confirm Password"></asp:Label>
                    </td>
                    <td>
                       
            <asp:TextBox TextMode="Password" ID="user_confirmpw_tb" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>
                        <asp:Button ID="btn_checkpw" class="btn btn-dark btn-sm" runat="server" OnClick="btn_checkpw_Click" Text="Check Password"  />
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>
                        &nbsp;</td>
                    <td>
                        
                        <asp:Button ID="btn_Create" runat="server" class="btn btn-dark" Text="Sign Up" OnClick="btn_Create_Click" Width="196px"  />
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        
                        &nbsp;</td>
                    <td>
                        
                        <asp:Button ID="Button1" runat="server" Font-Size="10px" class="btn btn-dark " OnClick="Button1_Click" Width="196px" Text="Already have an account? Login here"   />
                        
                    </td>
                </tr>
                <tr>
                    <td>
                        
                        &nbsp;</td>
                    <td>                       
                        
                        <asp:Label ID="lbMsg" runat="server"></asp:Label>
                        
                    </td>
                </tr>

            </table>
            
        </div>
    
</form>
    
</asp:Content>
