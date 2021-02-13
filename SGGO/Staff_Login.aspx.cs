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

        public bool ValidateCaptcha()
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

            if (!ValidateCaptcha())
            {
                error_lb.Text = error_lb.Text + "Something went wrong, please refresh and try again.";
                pass = false;
            }

            if (pass)
            {
                // log in
                Session["LoggedIn"] = user.Email;
                Session["Role"] = user.Type;

                string guid = Guid.NewGuid().ToString();
                Session["AuthToken"] = guid;

                Response.Cookies.Add(new HttpCookie("AuthToken", guid));
                client.UpdateLastLogin(user.Email);
                Response.Redirect("Staff_Home.aspx");
            }
        }
    }
}