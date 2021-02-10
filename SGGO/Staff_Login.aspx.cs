using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
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
                // initializing hashing thingy
                SHA512Managed hashing = new SHA512Managed();

                // salting plaintext and hashing after
                string saltedpw = pw + staff.Password_Salt;
                string hashedpw = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltedpw)));

                if (staff.Password == hashedpw)
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
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(email_tb.Text.Trim());

            var pass = true;

            if (user == null)
            {
                error_lb.Text = "Invalid credentials";
                pass = false;
            }
            else
            {
                var suspended = client.CheckSuspended(user.Email);
                if (suspended)
                {
                    int span = 30 - Convert.ToInt16(DateTime.Now.Subtract(Convert.ToDateTime(user.Locked_Since)).TotalMinutes);
                    error_lb.Text = "Your account has been locked. Please wait " + span + " minutes before trying again.";
                    pass = false;
                }
                else
                {
                    string salt = user.Password_Salt;

                    // initializing hashing thingy
                    SHA512Managed hashing = new SHA512Managed();

                    // salting plaintext and hashing after
                    string saltedpw = password_tb.Text.Trim() + salt;
                    string hashedpw = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltedpw)));

                    if (hashedpw == user.Password)
                    {
                        client.CheckAttempts(user.Email, true);
                        pass = true;
                    }
                    else
                    {
                        client.CheckAttempts(user.Email, false);
                        error_lb.Text = "Invalid credentials";
                        pass = false;
                    }
                }
            }

            if (pass)
            {
                // log in
                Session["LoggedIn"] = user.Email;

                string guid = Guid.NewGuid().ToString();
                Session["AuthToken"] = guid;

                Response.Cookies.Add(new HttpCookie("AuthToken", guid));
                client.UpdateLastLogin(user.Email);
                Response.Redirect("Staff_Home.aspx");
            }
            //DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //var staff = client.GetAccountByEmail(email);

            //error_lb.Text = "";
            //bool pass = true;
            //if (String.IsNullOrEmpty(email_tb.Text) || String.IsNullOrEmpty(password_tb.Text))
            //{
            //    error_lb.Text = "Please fill all fields.";
            //    pass = false;
            //}
            //var suspended = client.CheckSuspended();
            //if (suspended)
            //{
            //    int span = 30 - Convert.ToInt16(DateTime.Now.Subtract(Convert.ToDateTime(user.Suspended_Since)).TotalMinutes);
            //    error_lb.Text = "Your account has been locked. Please wait " + span + " minutes before trying again.";
            //    pass = false;
            //}
            //if (pass && Check(email_tb.Text, password_tb.Text))
            //{
            //    Session["LoggedIn"] = email_tb.Text;
            //    string guid = Guid.NewGuid().ToString();
            //    Session["AuthToken"] = guid;
            //    Response.Cookies.Add(new HttpCookie("AuthToken", guid));
            //    Response.Redirect("Staff_Home.aspx");
            //}
            //else if (pass && !Check(email_tb.Text, password_tb.Text))
            //{
            //    error_lb.Text = "Invalid email or password.";
            //}
        }
    }
}