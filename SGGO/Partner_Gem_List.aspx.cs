using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Partner_Gem_List : System.Web.UI.Page
    {
        string email = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("Partner_Login.aspx", false);
                }
                else
                {
                    email = Session["email"].ToString();
                    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                    var partner = client.GetAccountByEmail(Session["email"].ToString());
                    lb_Company.Text = partner.First_Name;
                }
            }
            else
            {
                Response.Redirect("Partner_Login.aspx", false);
            }
        }
        protected void btn_GotoCreateGem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Create_Gem.aspx?email=" + email);
        }
        protected void GemsGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string gemid = gems_gv.SelectedRow.Cells[0].Text;
            Response.Redirect("Partner_Gem_Listing.aspx?gemId=" + gemid);
        }
    }
}