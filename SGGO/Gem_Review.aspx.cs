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
        protected void Page_Load(object sender, EventArgs e)
        {
           
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
            string status = "approved";
            string description = tb_desc.Text;
            string post = "";
            string author = "";


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReview(status, post, author, rating, description);
            Response.Write("<script>window.alert('Thank you for your review')</script>");
            //Response.Redirect("Gem_Listing.aspx");
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Listing.aspx");
        }
    }
}