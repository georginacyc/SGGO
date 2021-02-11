using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class User_Profile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["email"] != null)
            //{
            //    email = (string)Session["email"];

            //    //    displayUserProfile(email);
            //}
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null) //checks for normal session, the new session "AuthToken" and new cookie 
            {
                //String authToken = Session["AuthToken"].ToString();
                //String cookie = Request.Cookies["AuthToken"].Value;
                //if (!authToken.Equals(cookie))
                //comes here when the 3 conditions above is not null and checks if they match
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("Login.aspx", false);
                }
                else
                {
                    lblMessage.Text = "Sucessfully logged in";
                    lblMessage.ForeColor = System.Drawing.Color.Green;
                    //btn_logout.Visible = true;
                    //displayUserProfile(email);
                }



            }
            else
            {
                Response.Redirect("Login.aspx", false);
            }
        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear(); // removes all the variables stored in session and if user try to browse your site same sessionID will be used which was previously assigned to him
            Session.Abandon(); //removes all the variables stored in session, fire session_end event and if user try to browse your site a new sessionID will be assigned to him.
            Session.RemoveAll(); //removing books from the bookshelf whereas Session.Abandon() is like throwing the bookshelf itself.

            Response.Redirect("User_Login.Aspx", false);

            if (Request.Cookies["ASP.NET_SessionId"] != null) // making sure the cookie is removed from the browser 
            {
                Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            }

            if (Request.Cookies["AuthToken"] != null) //then expire the authtoken cookie as well
            {
                Response.Cookies["AuthToken"].Value = string.Empty;
                Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
            }
        }
    }
}