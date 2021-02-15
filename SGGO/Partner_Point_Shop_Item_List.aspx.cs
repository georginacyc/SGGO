using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Partner_Point_Shop_Item_List : System.Web.UI.Page
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
        protected void PSIGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PSIid = PSI_gv.SelectedRow.Cells[0].Text;
            Response.Redirect("Partner_Point_Shop_Item_Listing.aspx?PSIId=" + PSIid);
        }

        protected void btn_GotoCreateItem_Click(object sender, EventArgs e)
        {
            Response.Redirect("Point_Shop_Create_Item.aspx?email=" + email);
        }
    }
}