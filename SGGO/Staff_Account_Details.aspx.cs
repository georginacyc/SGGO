﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Account_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["email"]))
            {
                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                var user = client.GetAccountByEmail(Request.QueryString["email"]);
                profile_img.Attributes["src"] = "/Images/Profile_Pictures/" + user.Profile_Picture;
                email_lb.Text = user.Email;
                staffid_lb.Text = user.Staff_Id;
                fname_lb.Text = user.First_Name;
                lname_lb.Text = user.Last_Name;
                dob_lb.Text = user.Dob.ToString("dd/MM/yyyy");
                hp_lb.Text = user.Hp;
                postal_lb.Text = user.Postal_Code;
                address_lb.Text = user.Address;
                created_lb.Text = user.Account_Created.ToString();
                login_lb.Text = user.Last_Login.ToString();
                points_lb.Text = user.Diamonds.ToString();

                if (user.Type.Trim() == "Staff")
                {
                    resetpw_btn.Visible = false;
                }
            }
            else
            {
                Response.Redirect("Staff_Accounts_List.aspx");
            }
        }

        protected void resetpw_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(Request.QueryString["email"]);
            client.StaffResetPassword(user.Email);
            resetpw_lb.Text = "Password has been reset to DOB (or Date of Establishment) + Postal Code. E.g. 12/03/2001539591";
        }
    }
}