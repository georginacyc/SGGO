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
            if (Session["LoggedIn"] != null && Session["Role"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();

                    Response.Redirect("Staff_Login.aspx");

                    if (Request.Cookies["ASP.NET_SessionId"] != null)
                    {
                        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                    }

                    if (Request.Cookies["AuthToken"] != null)
                    {
                        Response.Cookies["AuthToken"].Value = string.Empty;
                        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                    }
                }
                else
                {
                    if (Session["Role"].ToString() == "Staff")
                    {
                        // on page load codes here
                        if (!String.IsNullOrEmpty(Request.QueryString["email"]))
                        {
                            // retrieves selected user account, and displays info
                            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                            var user = client.GetAccountByEmail(Request.QueryString["email"]);
                            profile_img.Attributes["src"] = "/Images/Profile_Pictures/" + user.Profile_Picture;
                            type_lb.Text = user.Type;
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
                                diamonds_lb.Visible = false;
                                points_lb.Visible = false;
                            }
                            else
                            {
                                staffid_lb.Visible = false;
                            }
                        }
                        else
                        {
                            Response.Redirect("Staff_Accounts_List.aspx");
                        }
                    }
                    else
                    {
                        Session.Clear();
                        Session.Abandon();
                        Session.RemoveAll();

                        Response.Redirect("Staff_Login.aspx");

                        if (Request.Cookies["ASP.NET_SessionId"] != null)
                        {
                            Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                        }

                        if (Request.Cookies["AuthToken"] != null)
                        {
                            Response.Cookies["AuthToken"].Value = string.Empty;
                            Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                        }
                    }
                }
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();

                Response.Redirect("Staff_Login.aspx");

                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                }

                if (Request.Cookies["AuthToken"] != null)
                {
                    Response.Cookies["AuthToken"].Value = string.Empty;
                    Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                }
            }
        }

        protected void resetpw_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(Request.QueryString["email"]);
            client.StaffResetPassword(user.Email);
            resetpw_lb.Text = "Password has been reset to DOB or Date of Establishment (dd/MM) + Postal Code. E.g. 12/03539591";
        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff_Accounts_List.aspx");
        }
    }
}