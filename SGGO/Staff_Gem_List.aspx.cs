using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Gem_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["success_gem_creation"] != null)
            {
                lb_msg.Text = Session["success_gem_creation"].ToString();
            }
            

        }

    }
}