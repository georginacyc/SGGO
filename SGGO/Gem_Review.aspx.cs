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
        string gemid = null;
        string gemtitle = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("User_Login.aspx", false);
                }
                else
                {
                    review_date.Text = DateTime.Now.ToString();
                    user = (string)Session["email"];
                    gemid = Request.QueryString["gem"]; // retrieve from gem id listing

                    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                    var gems = client.GetGemById(Convert.ToInt32(gemid));
                    gemtitle = gems.Title;
                }
            }
            else
            {
                Response.Redirect("User_Login.aspx", false);
            }


           //user = (string)Session["email"];
           //gem_id = (string)Request.QueryString["post"]; // id retrieve from gem listing
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
            string status = "Pending";
            string description = tb_desc.Text;
            string gem_id = gemid;
            string gem_title = gemtitle;
            string author = user;


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReview(status, gem_id,gem_title, author, rating, description);

            lbl_msg.Text = "Review submitted successfully , Your review is on its way to our staff. Thank you!";
            lbl_rating_score.Text = "0";
            tb_desc.Text = "";
            Rating_1.ImageUrl = "~/Test_Image/Star.png";
            Rating_2.ImageUrl = "~/Test_Image/Star.png";
            Rating_3.ImageUrl = "~/Test_Image/Star.png";
            Rating_4.ImageUrl = "~/Test_Image/Star.png";
            Rating_5.ImageUrl = "~/Test_Image/Star.png";


        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Listing.aspx?gemId="+gemid);
        }
    }
}