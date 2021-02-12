using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Gem_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var gem = client.GetGemById(Convert.ToInt32(Request.QueryString["id"]));

            gem_img.Attributes["src"] = "/Images/Gem/" + gem.Image + ".png";
            title_lb.Text = gem.Title;
            status_lb.Text = gem.Status;
            id_lb.Text = gem.Gem_Id.ToString();
            partner_lb.Text = gem.Partner;
            type_lb.Text = gem.Type;
            date_lb.Text = gem.Date == null ? null : Convert.ToDateTime(gem.Date).ToString("dd/MM/yyyy");
            location_lb.Text = gem.Location;
            description_lb.Text = gem.Description;

            if (gem.Status == "Approved" || gem.Status == "Rejected")
            {
                approve_btn.Visible = false;
                disapprove_btn.Visible = false;
            }

        }

        protected void approve_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateGemStatus(Convert.ToInt32(Request.QueryString["id"]), "Approved");

            Response.Redirect("Staff_Gems_Table.aspx");
        }

        protected void disapprove_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateGemStatus(Convert.ToInt32(Request.QueryString["id"]), "Rejected");

            Response.Redirect("Staff_Gems_Table.aspx");
        }
    }
}