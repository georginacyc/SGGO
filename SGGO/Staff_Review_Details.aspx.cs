﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Review_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["id"]))
            {
                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                var review = client.GetReviewById(Convert.ToInt32(Request.QueryString["id"]));

                if (review.Status.Trim() == "Approved" || review.Status.Trim() == "Rejected")
                {
                    approve_btn.Visible = false;
                    disapprove_btn.Visible = false;
                }
                review_lb.Text = review_lb.Text + review.Review_Id.ToString();
                status_lb.Text = review.Status;
                gem_lb.Text = review.Post; // now is id, will need to retrieve name with it next time. also want to make it clickable, link to gem page.
                author_lb.Text = review.Author;
                rating_lb.Text = review.Rating;
                description_lb.Text = review.Description;
            } else
            {
                Response.Redirect("Staff_Reviews_Table.aspx");
            }
        }

        protected void approve_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateReviewStatus(Convert.ToInt32(Request.QueryString["id"]), "Approved");

            Response.Redirect("Staff_Reviews_Table.aspx");
        }

        protected void disapprove_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateReviewStatus(Convert.ToInt32(Request.QueryString["id"]), "Rejected");

            Response.Redirect("Staff_Reviews_Table.aspx");
        }
    }
}