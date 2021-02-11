using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SGGO
{
    public partial class Partner_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            bool result;
            lblMsg2.Text = String.Empty;

            if (tb_email.Text == "")
            {
                lblMsg2.Text += "First name is required" + "<br/>";
            }
            if (tb_pw.Text == "")
            {
                lblMsg2.Text += "Last name is required" + "<br/>";
            }


            if (String.IsNullOrEmpty(lblMsg2.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void CheckAccount(string email, string pw)
        {
            ValidateInput();
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(email); //get this from Service1.cs
            if (user == null)
            {
                lblMsg2.Text = "User not found, please try again";
            }
            //else if(pw != user.pw)
            else if (pw == null)
            {
                lblMsg2.Text = "Pw is incorrect";

            }
            else
            {
                Session["email"] = email;
                //create GUID and save into the session, a unique value that is hard to guess 
                string guid = Guid.NewGuid().ToString();
                Session["AuthToken"] = guid; // save to the new session variable called auth token

                //create a new cookie with guid value
                Response.Cookies.Add(new HttpCookie("AuthToken", guid));
            }


        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            string email = tb_email.Text;
            string pw = tb_pw.Text;
            CheckAccount(email, pw);
            Response.Redirect("Partner_Own_Account_Details.aspx?email=" + email);
        }
    }
}