using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Home_Page : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_gems_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Catalogue.aspx");
        }

        protected void btn_trails_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Monthly_Trail.aspx");
        }
    }
}