using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Script.Serialization;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        public class MyObject
        {
            public string success { get; set; }
            public List<string> ErrorMessage { get; set; }
        }

        // site and secret keys for the google recaptcha are placed in a txt files (which are gitignored) as our project is on github for version control and better collaboration
        protected string sourcekey
        {
            get
            {
                StreamReader sr = File.OpenText(Server.MapPath("staffsitekey.txt"));
                return @"https://www.google.com/recaptcha/api.js?render=" + sr.ReadToEnd();
            }
        }

        protected string sitekey
        {
            get
            {
                StreamReader sr = File.OpenText(Server.MapPath("staffsitekey.txt"));
                return sr.ReadToEnd();
            }
        }

        protected string secretkey
        {
            get
            {
                StreamReader sr = File.OpenText(Server.MapPath("staffsecretkey.txt"));
                return @"https://www.google.com/recaptcha/api/siteverify?secret=" + sr.ReadToEnd();
            }
        }

        public bool ValidateCaptcha() // captcha check
        {
            bool result = true;
            string captcha = Request.Form["g-recaptcha-response"];
            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(secretkey + "&response=" + captcha);
            try
            {
                using (WebResponse wr = req.GetResponse())
                {
                    using (StreamReader sr = new StreamReader(wr.GetResponseStream()))
                    {
                        string jsonResponse = sr.ReadToEnd();

                        JavaScriptSerializer js = new JavaScriptSerializer();
                        MyObject jsonObject = js.Deserialize<MyObject>(jsonResponse);

                        result = Convert.ToBoolean(jsonObject.success);
                    }
                }
                return result;
            }
            catch (WebException ex)
            {
                throw ex;
            }
        }

        protected void Button1_Click(object sender, EventArgs e) // on login
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(email_tb.Text.Trim()); // gets staff account

            var pass = true;

            if (user == null) // if staff doesnt exist
            {
                error_lb.Text = "Invalid credentials"; // generic error message to prevent brute forcing
                pass = false;
            }
            else
            {
                var suspended = client.CheckSuspended(user.Email); // retuns boolean, checks if staff account is suspended
                if (suspended)
                {
                    int span = 30 - Convert.ToInt16(DateTime.Now.Subtract(Convert.ToDateTime(user.Locked_Since)).TotalMinutes);
                    error_lb.Text = "Your account has been locked. Please wait " + span + " minutes before trying again."; // error message updates staff on the duration their account is locked for
                    pass = false;
                }
                else // if not suspended, check password
                {
                    string salt = user.Password_Salt;

                    // initializing hashing thingy
                    SHA512Managed hashing = new SHA512Managed();

                    // salting plaintext and hashing after
                    string saltedpw = password_tb.Text.Trim() + salt;
                    string hashedpw = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltedpw)));

                    if (hashedpw == user.Password) // if password is correct
                    {
                        client.CheckAttempts(user.Email, true);
                        pass = true;
                    }
                    else // if password is incorrect, reduce attempts left by 1
                    {
                        client.CheckAttempts(user.Email, false);
                        error_lb.Text = "Invalid credentials"; // generic error message to prevent brute forcing
                        pass = false;
                    }
                }
            }

            if (!ValidateCaptcha()) // in the even that the captcha detects that the user is a bot
            {
                error_lb.Text = error_lb.Text + "Something went wrong, please refresh and try again.";
                pass = false;
            }

            if (pass)
            {
                // log in
                Session["LoggedIn"] = user.Email;
                Session["Role"] = user.Type; // sets user role as a session variable for future checks

                string guid = Guid.NewGuid().ToString();
                Session["AuthToken"] = guid;

                Response.Cookies.Add(new HttpCookie("AuthToken", guid));
                client.UpdateLastLogin(user.Email);
                Response.Redirect("Staff_Home.aspx");
            }
        }
    }
}