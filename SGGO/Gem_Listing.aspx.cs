using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Gem_Listing : System.Web.UI.Page
    {
        string gemid;
       
        protected void Page_Load(object sender, EventArgs e)
        {
            gemid = Request.QueryString["gemId"];
            this.Session["gem_id"] = gemid;
            //gem = Request.QueryString["gem"];
            lbl_gemId.Text = gemid;
            

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var gems = client.GetGemById(Convert.ToInt32(gemid));
            gem_title.Text = gems.Title;
            gem_desc.Text = gems.Description;
            gem_image.ImageUrl = gems.Image;
            gem_add.Text = gems.Location;

            //var review = client.GetReviewByStatus("Pending");
            //gvReview.DataSource = review;
            //gvReview.DataBind();
        }

        protected void btn_map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://g.page/NicolesFlower?share");
        }

        protected void btn_review_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Create_Report.aspx?post=" + "123");
            Response.Redirect("Gem_Review.aspx?gem="+ lbl_gemId.Text);
        }

        protected void btn_report_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("Create_Report.aspx?post=" + "123");
            Response.Redirect("Create_Report.aspx?gem=" + lbl_gemId.Text);
        }

        protected void gvReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = gvReview.SelectedIndex;

            string id = gvReview.DataKeys[index].Value.ToString();
            Response.Redirect("Create_Report.aspx?rev=" + id);
        }
    }
}