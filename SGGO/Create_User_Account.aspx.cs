using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

using System.Security.Cryptography;
using System.Text;
using System.Drawing;
using SGGO.DBServiceReference;

namespace SGGO
{
    public partial class Create_User_Account : System.Web.UI.Page
    {

        
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }

        protected void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            bool result;
            string email = string.Empty;
            lbMsg.Text = String.Empty;
            email = user_email_tb.Text;//(string)Session["email"];
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            Account userObj = client.GetAccountByEmail(email);

            if (user_fname_tb.Text == "")
            {
                lbMsg.Text += "First name is required" + "<br/>";
                lbMsg.ForeColor = Color.Red;
            }
            if (user_lname_tb.Text == "")
            {
                lbMsg.Text += "Last name is required" + "<br/>";
                lbMsg.ForeColor = Color.Red;
            }
            if (user_email_tb.Text != "")
            {
                if (userObj != null)
                {
                    if (user_email_tb.Text.Equals(userObj.Email))
                    {
                        lbMsg.Text += "User has already been registered" + "<br/>";
                        lbMsg.ForeColor = Color.Red;
                    }
                }

                
            }
            else
            {
                lbMsg.Text += "Email is required" + "<br/>";
                lbMsg.ForeColor = Color.Red;
            }
            if (user_password_tb.Text != "")
            {
                
                if (checkPw(user_password_tb.Text) <= 4)
                {
                    lbMsg.Text += "Please put a stronger password" + "<br/>";
                    lbMsg.ForeColor = Color.Red;
                }
                if (user_password_tb.Text != user_confirmpw_tb.Text)
                {
                    lbMsg.Text += "Passwords do not match" + "<br/>";
                    lbMsg.ForeColor = Color.Red;
                }
            }
            else
            {
                lbMsg.Text += "Password is required" + "<br/>";
                lbMsg.ForeColor = Color.Red;
            }
           
            
           
            if (String.IsNullOrEmpty(lbMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        protected void btn_checkpw_Click(object sender, EventArgs e)
        {
            int scores = checkPw(user_password_tb.Text);// Extract data from textbox
            string status = "";
            switch (scores)
            {
                case 1:
                    status = "Very Weak";
                    break;
                case 2:
                    status = "Weak";
                    break;
                case 3:
                    status = "Medium";
                    break;
                case 4:
                    status = "Strong";
                    break;
                case 5:
                    status = "Excellent";
                    break;
                default:
                    break;
            }
            lbMsg.Text = "Status : " + status;
            if (scores < 4) //any score below 4 will show red
            {
                lbMsg.ForeColor = Color.Red;
                return;
            }
            lbMsg.ForeColor = Color.Green;
        }

        protected int checkPw(string password) //server side validation for password
        {
            int score = 0;

            // score 1 very weak
            // if length of password is less than 8 chars
            if (password.Length < 8)
            {
                return 1;
            }
            else
            {
                score = 1;
            }
            // score 2 weak
            if (Regex.IsMatch(password, "[a-z]"))
            {
                score++; //++ is used to increment the value of its operand
            }
            // score 3 medium
            if (Regex.IsMatch(password, "[A-Z]"))
            {
                score++;
            }
            // score 4 strong
            if (Regex.IsMatch(password, "[0-9]"))
            {
                score++;
            }
            // score 5 excellent
            if (Regex.IsMatch(password, "[^a-zA-Z0-9]"))
            {
                score++;
            }
            return score;



        }


        protected void btn_Create_Click(object sender, EventArgs e)
        {
            string email = user_email_tb.Text;
            string fname = user_fname_tb.Text;
            string lname = user_lname_tb.Text;
            string pwsalt;
            string pwhash;
            

            if (ValidateInput() == true)
            {
                //string pwd = get value from your Textbox
                string pwd = user_password_tb.Text.ToString().Trim(); ;
                //Generate random "salt"
                RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
                byte[] saltByte = new byte[8];
                //Fills array of bytes with a cryptographically strong sequence of random values.
                rng.GetBytes(saltByte);
                pwsalt = Convert.ToBase64String(saltByte);
                SHA512Managed hashing = new SHA512Managed();
                string pwdWithSalt = pwd + pwsalt;
                byte[] plainHash = hashing.ComputeHash(Encoding.UTF8.GetBytes(pwd));
                byte[] hashWithSalt = hashing.ComputeHash(Encoding.UTF8.GetBytes(pwdWithSalt));
                pwhash = Convert.ToBase64String(hashWithSalt);
                RijndaelManaged cipher = new RijndaelManaged();

               

                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                int result = client.CreateAccount(email, pwhash, pwsalt, "User", fname, lname, DateTime.Now, "90098008", "711111", "Blk 123 NYP", "default.jpg", null, null );
                lbMsg.Text = "Successfully Registered";
                lbMsg.ForeColor = Color.Green;
                lbMsg.Visible = true;

            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Login.aspx");
        }

       
    }
}