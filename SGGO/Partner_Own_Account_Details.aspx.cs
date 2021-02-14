using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Partner_Own_Account_Details : System.Web.UI.Page
    {
        string email = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (!String.IsNullOrEmpty(Request.QueryString["email"]))
            //{
            //    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //    var user = client.GetAccountByEmail(Request.QueryString["email"]);
            //    profile_img.Attributes["src"] = "/Images/Profile_Pictures/" + user.Profile_Picture;
            //    email_lb.Text = user.Email;
            //    fname_lb.Text = user.First_Name;
            //    lname_lb.Text = user.Last_Name;
            //    dob_lb.Text = user.Dob.ToString("dd/MM/yyyy");
            //    hp_lb.Text = user.Hp;
            //    postal_lb.Text = user.Postal_Code;
            //    address_lb.Text = user.Address;
            //    created_lb.Text = user.Account_Created.ToString();
            //}
            //else
            //{
            //    Response.Redirect("Partner_Login.aspx");
            //}
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("Partner_Login.aspx", false);
                }
                else
                {
                    email = Session["email"].ToString();
                    displayPartnerProfile(email);
                }
            }
            else
            {
                Response.Redirect("Partner_Login.aspx", false);
            }
        }
        protected void displayPartnerProfile(string userid)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var partner = client.GetAccountByEmail(Session["email"].ToString());
            profile_img.Attributes["src"] = "/Images/Profile_Pictures/" + partner.Profile_Picture;
            email_lb.Text = partner.Email;
            fname_lb.Text = partner.First_Name;
            lname_lb.Text = partner.Last_Name;
            dob_lb.Text = partner.Dob.ToString("dd/MM/yyyy");
            hp_lb.Text = partner.Hp;
            postal_lb.Text = partner.Postal_Code;
            address_lb.Text = partner.Address;
            created_lb.Text = partner.Account_Created.ToString();
        }
        protected void changepw_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff_Change_Password.aspx");
        }
    }
}