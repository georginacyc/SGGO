using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Own_Account_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();

                    Response.Redirect("Staff_Login.aspx");

                    if (Request.Cookies["ASP.NET_SessionId"] != null)
                    {
                        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                    }

                    if (Request.Cookies["AuthToken"] != null)
                    {
                        Response.Cookies["AuthToken"].Value = string.Empty;
                        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                    }
                }
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();

                Response.Redirect("Staff_Login.aspx");

                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                }

                if (Request.Cookies["AuthToken"] != null)
                {
                    Response.Cookies["AuthToken"].Value = string.Empty;
                    Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                }
            }
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var user = client.GetAccountByEmail(Session["LoggedIn"].ToString());
            profile_img.Attributes["src"] = "/Images/Profile_Pictures/" + user.Profile_Picture;
            email_lb.Text = user.Email;
            staffid_lb.Text = user.Staff_Id;
            fname_lb.Text = user.First_Name;
            lname_lb.Text = user.Last_Name;
            dob_lb.Text = user.Dob.ToString();
            hp_lb.Text = user.Hp;
            postal_lb.Text = user.Postal_Code;
            address_lb.Text = user.Address;
            created_lb.Text = user.Account_Created.ToString();
        }

        protected void changepw_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff_Change_Password.aspx");
        }
    }
}