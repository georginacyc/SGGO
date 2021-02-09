using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Text.RegularExpressions;

namespace SGGO
{
    public partial class Create_User_Account : System.Web.UI.Page
    {

        Regex passReg = new Regex(@"^(?=.*[a-zA-Z])(?=.*[!-/])(?=.*\d).{8}$"); // Minimum eight characters, at least one letter and one number:
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
            lbMsg.Text = String.Empty;

            if (user_fname_tb.Text == "")
            {
                lbMsg.Text += "First name is required" + "<br/>";
            }
            if (user_lname_tb.Text == "")
            {
                lbMsg.Text += "Last name is required" + "<br/>";
            }
            if (user_email_tb.Text == "")
            {
                lbMsg.Text += "Email is required" + "<br/>";
            }
            if (user_password_tb.Text == "")
            {
                lbMsg.Text += "Password is required" + "<br/>";
            }
            //if(passReg.IsMatch(tb_pw.Text))
            //{
            //    lbMsg.Text += "Password is valid" + "<br/>";
            //}
           
            if (String.IsNullOrEmpty(lbMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //private void PasswordChange()
        //{
        //    if (passReg.IsMatch(tb_pw.Text))
        //        lbMsg.Text = "Password validated";
        //    else
        //        lbMsg.Text = "Password invalid";
        //}


        protected void btn_Create_Click(object sender, EventArgs e)
        {
            ValidateInput();
            //PasswordChange();
            string email = user_email_tb.Text;
            string fname = user_fname_tb.Text;
            string lname = user_lname_tb.Text;
            string pw = user_password_tb.Text;

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //int result = client.CreateAccount(email, pw, "User", fname, lname, "90098008", "Blk 123 NYP",null, DateTime.Now, null, null, null);
            


        }
    }
}