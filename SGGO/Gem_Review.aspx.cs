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

        public string rating_score = "0";

        protected void Rating_1_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            rating_score = "1";
        }

        protected void Rating_2_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            rating_score = "2";
        }

        protected void Rating_3_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            rating_score = "3";
        }

        protected void Rating_4_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_4.ImageUrl = "~/Test_Image/FilledStar.png";
            rating_score = "4";
        }

        protected void Rating_5_Click(object sender, ImageClickEventArgs e)
        {
            Rating_1.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_2.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_3.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_4.ImageUrl = "~/Test_Image/FilledStar.png";
            Rating_5.ImageUrl = "~/Test_Image/FilledStar.png";
            rating_score = "5";
        }

        protected void btn_submit_review_Click(object sender, EventArgs e)
        {
            string rating = rating_score;
            string status = "approved";
            string desc = tb_desc.Text;
            string post = "";
            string author = "";


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReview(status, post, author, rating, desc);
            Response.Redirect("Gem_Listing.aspx");
        }
    }
}