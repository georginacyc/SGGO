using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Gem_Review : System.Web.UI.Page
    {
        string user = null;
        string gem_id = null;
        protected void Page_Load(object sender, EventArgs e)
        {
           user = (string)Session["email"];
           gem_id = (string)Request.QueryString["post"]; // id retrieve from gem listing
        }

        protected void Rating_1_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            lbl_rating_score.Text = "1";
        }

        protected void Rating_2_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            lbl_rating_score.Text = "2";
        }

        protected void Rating_3_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            lbl_rating_score.Text = "3";
        }

        protected void Rating_4_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_4.ImageUrl = "~/Test_Image/FilledStar.png";
            lbl_rating_score.Text = "4";
        }

        protected void Rating_5_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_4.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_5.ImageUrl = "~/Test_Image/FilledStar.png";
            lbl_rating_score.Text = "5";
        }

        protected void btn_submit_review_Click(object sender, EventArgs e)
        {
            string rating = lbl_rating_score.Text;
            string status = "Awaiting Approval";
            string description = tb_desc.Text;
            string post = gem_id;
            string author = "nina@yahoo.com";
                //user;


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReview(status, post, author, rating, description);
            
            
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Listing.aspx");
        }
    }
}