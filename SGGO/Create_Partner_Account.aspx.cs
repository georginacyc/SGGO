using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_Partner_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
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

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            string email = partner_email_tb.Text;
            string fname = partner_fn_tb.Text;
            string lname = "";
            string hp = partner_hp_tb.Text;
            string address = partner_address_tb.Text;
            string postal = partner_postalcode_tb.Text;
            string pw = "password";
            var extension = System.IO.Path.GetExtension(Server.HtmlEncode(picture_file.FileName));
            var filename = fname + hp.Substring(4, 4) + extension; // first name + last 4 digits of phone number
            picture_file.SaveAs(Request.PhysicalApplicationPath + "/Images/Profile_Pictures/" + filename);

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateAccount(email, pw, "salt", "Partner", fname, lname, DateTime.Now, hp, postal, address, filename, null, null);
            Response.Redirect("Partner_Login.aspx");
        }
    }
}