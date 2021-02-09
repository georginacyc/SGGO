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
            staff_password_tb.Attributes.Add("onkeyup", "pwdChecker();");
            staff_password2_tb.Attributes.Add("onkeyup", "pwdMatcher();");

            //if (Session["LoggedIn"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            //{
            //    if (Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
            //    {
            //        DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //        var user = client.GetAccountByEmail(Session["LoggedIn"].ToString());
            //    }
            //    else
            //    {
            //        Response.Redirect("Staff_Login.aspx");
            //    }
            //}
            //else
            //{
            //    Response.Redirect("Staff_Login.aspx");
            //}
        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            error_lb.Text = "";
            bool pass = true; // overall validation
            bool empty = false; // empty checck

            string email = staff_email_tb.Text;
            string fname = staff_fn_tb.Text;
            string lname = staff_ln_tb.Text;
            DateTime dob = Convert.ToDateTime(staff_dob_tb.Text);
            string hp = staff_hp_tb.Text;
            string postal = staff_postalcode_tb.Text;
            string address = staff_address_tb.Text;
            string pw = staff_password_tb.Text;
            string pw2 = staff_password2_tb.Text;

            if (String.IsNullOrEmpty(email) || String.IsNullOrEmpty(fname) || String.IsNullOrEmpty(lname) || String.IsNullOrEmpty(hp) || String.IsNullOrEmpty(address) || String.IsNullOrEmpty(postal) || String.IsNullOrEmpty(pw) || String.IsNullOrEmpty(pw2))
            {
                error_lb.Text = "Please fill all fields";
                empty = true;
            }

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
            }

            if (!empty && pass)
            {
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
                int result = client.CreateAccount(email, hashedpw, pwsalt, "Staff", fname, lname, dob, hp, address, "000001", 0);
                Response.Redirect("Staff_Accounts_List.aspx");
            }

                
        }
    }
}