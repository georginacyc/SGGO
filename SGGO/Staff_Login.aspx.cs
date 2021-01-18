﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected bool Check(string email, string pw)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var staff = client.GetAccountByEmail(email);
            if (staff == null)
            {
                return false;
            } else
            {
                if (staff.Password == pw)
                {
                    return true;
                } else
                {
                    return false;
                }
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            bool pass = true;
            if (String.IsNullOrEmpty(email_tb.Text))
            {
                error_lb.Text = "Please input your staff email address";
                pass = false;
            }
            if (String.IsNullOrEmpty(password_tb.Text))
            {
                error2_lb.Text = "Please input your password";
                pass = false;
            }
            if (pass && Check(email_tb.Text, password_tb.Text))
            {
                Response.Redirect("Staff_Home.aspx");
            }
            else if (pass && !Check(email_tb.Text, password_tb.Text))
            {
                error2_lb.Text = null;
                error_lb.Text = "Invalid email or password.";
            }
        }
    }
}