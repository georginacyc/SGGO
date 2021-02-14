using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Partner_Gem_Listing : System.Web.UI.Page
    {
        string gemid;

        protected void Page_Load(object sender, EventArgs e)
        {
            gemid = Request.QueryString["gemId"];

            if (gemid != null)
            {
                this.Session["gem_id"] = gemid;

                lbl_gemId.Text = gemid;


                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                var gems = client.GetGemById(Convert.ToInt32(gemid));
                gem_title.Text = gems.Title;
                gem_desc.Text = gems.Description;
                gem_image.Attributes["src"] = "/Images/Gem/" + gems.Image;
                gem_add.Text = "Address : " + gems.Location;
            }
            else
            {
                Response.Redirect("Gem_Catalogue.aspx");
            }

        }
        protected void gvReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvReview.SelectedIndex;

            string id = gvReview.DataKeys[index].Value.ToString();
            Response.Redirect("Create_Report.aspx?rev=" + id);
        }

    }
}
