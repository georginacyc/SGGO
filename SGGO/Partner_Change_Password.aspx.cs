using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Partner_Change_Password : System.Web.UI.Page
    {
        string email = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("Partner_Login.aspx", false);
                }
                else
                {
                    email = Session["email"].ToString();
                    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                    var partner = client.GetAccountByEmail(Session["email"].ToString());
                }
            }
            else
            {
                Response.Redirect("Partner_Login.aspx", false);
            }
        }
        protected void submit_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            error_lb.Text = "";
            bool pass = true; // overall validation
            bool mt = false; // empty check
            string salt = "";
            string hashednew = "";

            // checking if any fields are empty
            if (String.IsNullOrWhiteSpace(current_tb.Text) || String.IsNullOrWhiteSpace(new_tb.Text) || String.IsNullOrWhiteSpace(new2_tb.Text))
            {
                error_lb.Text = "Please fill all fields. <br>";
                mt = true;
            }

            if (!mt)
            {
                // checks if user exists
                var user = client.GetAccountByEmail(Session["email"].ToString());

                // initializing hashing thingy
                SHA512Managed hashing = new SHA512Managed();

                // salting plaintext and hashing after
                salt = user.Password_Salt;
                string saltedpw = current_tb.Text.Trim() + salt;
                string hashedpw = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltedpw)));

                if (hashedpw != user.Password)
                {
                    error_lb.Text = error_lb.Text + "Incorrect password <br>";
                    pass = false;
                }

                string saltednew = new_tb.Text.Trim() + salt;
                hashednew = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltednew)));
                if (hashednew == user.Password || hashednew == user.Password_Last || hashednew == user.Password_Last2)
                {
                    error_lb.Text = error_lb.Text + "New password cannot be the same as current or previous 2 passwords <br>";
                    pass = false;
                }

                Regex pwRegex = new Regex(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d)(?=.*[$@$!%*?&])[A-Za-z\d$@$!%*?&]{8,}");
                if (!pwRegex.IsMatch(new_tb.Text.Trim()))
                {
                    error_lb.Text = error_lb.Text + "Please input a password that fulfills all criteria <br>";
                    pass = false;
                }

                TimeSpan span = DateTime.Now.Subtract(user.Password_Age);
                if (Convert.ToInt16(span.TotalMinutes) <= 5)
                {
                    error_lb.Text = error_lb.Text + "You must wait " + (5 - Convert.ToInt16(span.TotalMinutes)).ToString() + " more minutes to change your password <br>";
                    pass = false;
                }
            }

            if (!mt && pass)
            {
                int result = client.ChangePassword(Session["email"].ToString(), hashednew);
                if (result == 1)
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();

                    Response.Redirect("Partner_Home.aspx");

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
                    error_lb.Text = "Unable to change password. Please try again later.";
                }
            }
        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Partner_Own_Account_Details.aspx");
        }
    }
}