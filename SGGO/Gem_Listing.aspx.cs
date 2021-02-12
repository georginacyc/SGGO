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
            lbl_gemId.Text = gemid;
            //displayGem(gemid);
        }

        protected void btn_map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://g.page/NicolesFlower?share");
        }

        protected void btn_review_Click(object sender, EventArgs e)
        {
            //Response.Redirect("Create_Report.aspx?post=" + "123");
            Response.Redirect("Gem_Review.aspx?id="+ lbl_gemId.Text);
        }

        protected void btn_report_Click1(object sender, EventArgs e)
        {
            //Response.Redirect("Create_Report.aspx?post=" + "123");
            Response.Redirect("Create_Report.aspx?post=" + lbl_gemId.Text);
        }

        protected void gvReview_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = gvReview.SelectedRow.Cells[0].Text;
        }
    }
}