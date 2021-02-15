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
    public partial class Create_Staff_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["LoggedIn"] != null && Session["Role"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            //{
            //    if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
            //    {
            //        Session.Clear();
            //        Session.Abandon();
            //        Session.RemoveAll();

            //        Response.Redirect("Staff_Login.aspx");

            //        if (Request.Cookies["ASP.NET_SessionId"] != null)
            //        {
            //            Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
            //            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            //        }

            //        if (Request.Cookies["AuthToken"] != null)
            //        {
            //            Response.Cookies["AuthToken"].Value = string.Empty;
            //            Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
            //        }
            //    }
            //    else
            //    {
            //        if (Session["Role"].ToString() == "Staff")
            //        {
            //            // on page load codes here
            //            staff_password_tb.Attributes.Add("onkeyup", "pwdChecker();");
            //            staff_password2_tb.Attributes.Add("onkeyup", "pwdMatcher();");

            //            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //            staff_email_lb.Text = client.GetStaffId() + "@sggo.com";
            //        }
            //        else
            //        {
            //            Session.Clear();
            //            Session.Abandon();
            //            Session.RemoveAll();

            //            Response.Redirect("Staff_Login.aspx");

            //            if (Request.Cookies["ASP.NET_SessionId"] != null)
            //            {
            //                Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
            //                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            //            }

            //            if (Request.Cookies["AuthToken"] != null)
            //            {
            //                Response.Cookies["AuthToken"].Value = string.Empty;
            //                Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
            //            }
            //        }
            //    }
            //}
            //else
            //{
            //    Session.Clear();
            //    Session.Abandon();
            //    Session.RemoveAll();

            //    Response.Redirect("Staff_Login.aspx");

            //    if (Request.Cookies["ASP.NET_SessionId"] != null)
            //    {
            //        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
            //        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            //    }

            //    if (Request.Cookies["AuthToken"] != null)
            //    {
            //        Response.Cookies["AuthToken"].Value = string.Empty;
            //        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
            //    }
            //}
        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            error_lb.Text = "";
            bool pass = true; // overall validation
            bool empty = false; // empty checck

            // retrieves inputs
            string email = staff_email_lb.Text;
            string fname = staff_fn_tb.Text;
            string lname = staff_ln_tb.Text;
            string hp = staff_hp_tb.Text;
            string postal = staff_postalcode_tb.Text;
            string address = staff_address_tb.Text;
            string pw = staff_password_tb.Text;
            string pw2 = staff_password2_tb.Text;

            // checks if any fields are empty
            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname) || String.IsNullOrEmpty(hp) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(postal) || String.IsNullOrEmpty(pw) || String.IsNullOrEmpty(pw2) || String.IsNullOrEmpty(staff_dob_tb.Text) || !picture_file.HasFile)
            {
                error_lb.Text = "Please fill all fields";
                empty = true;
            }

            // if not empty, perform validation checks
            if (!empty)
            {
                Regex nameRegex = new Regex("^[A-Za-z]+$");
                if (!nameRegex.IsMatch(fname) || !nameRegex.IsMatch(lname))
                {
                    error_lb.Text = error_lb.Text + "Please input a valid name <br>";
                    pass = false;
                }

                Regex hpRegex = new Regex("^[89]{1}[0-9]{7}$");
                if (!hpRegex.IsMatch(hp))
                {
                    error_lb.Text = error_lb.Text + "Please input a valid contact number <br>";
                    pass = false;
                }

                Regex postalRegex = new Regex("^[0-9]{6}$");
                if (!postalRegex.IsMatch(postal))
                {
                    error_lb.Text = error_lb.Text + "Please input a valid postal code<br>";
                    pass = false;
                }

                Regex addressRegex = new Regex("^[0-9A-Za-z#]+$");
                if (!addressRegex.IsMatch(postal))
                {
                    error_lb.Text = error_lb.Text + "Please input a valid address<br>";
                    pass = false;
                }

                if (picture_file.PostedFile.ContentLength > 2100000)
                {
                    error_lb.Text = error_lb.Text + "Please upload a photo smaller than 2MB <br>";
                    pass = false;
                }

                var extension = System.IO.Path.GetExtension(Server.HtmlEncode(picture_file.FileName));
                System.Diagnostics.Debug.WriteLine(extension);
                if (extension != ".jpg" && extension != ".jpeg" && extension != ".png")
                {
                    error_lb.Text = error_lb.Text + "Please upload a .jpg/.jpeg/.png file <br>";
                    pass = false;
                }
            }

            // if fields are not empty, and pass validation checks
            if (!empty && pass)
            {
                DateTime dob = Convert.ToDateTime(staff_dob_tb.Text);

                var extension = System.IO.Path.GetExtension(Server.HtmlEncode(picture_file.FileName));
                var filename = fname + hp.Substring(4, 4) + extension; // first name + last 4 digits of phone number
                picture_file.SaveAs(Request.PhysicalApplicationPath + "/Images/Profile_Pictures/" + filename);

                // initializing bytes for salts
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] pwsaltbyte = new byte[8];

                // getting random salt bytes and converting into string
                rng.GetBytes(pwsaltbyte);
                string pwsalt = Convert.ToBase64String(pwsaltbyte);

                // initializing hashing thingy
                SHA512Managed hashing = new SHA512Managed();

                // salting plaintext and hashing after
                string saltedpw = pw + pwsalt;
                string hashedpw = Convert.ToBase64String(hashing.ComputeHash(Encoding.UTF8.GetBytes(saltedpw)));

                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                client.CreateAccount(email, hashedpw, pwsalt, "Staff", fname, lname, dob, hp, postal, address, filename, client.GetStaffId(), 0);
                Response.Redirect("Staff_Accounts_List.aspx");
            }

                
        }
    }
}