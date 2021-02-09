using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["LoggedIn"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                    var user = client.GetAccountByEmail(Session["LoggedIn"].ToString());
                }
                else
                {
                    Response.Redirect("Login.aspx");
                }
            }
            else
            {
                Response.Redirect("Login.aspx");
            }

        }
    }
}