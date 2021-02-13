using System;
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
            if (Session["LoggedIn"] != null && Session["Role"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();

                    Response.Redirect("Staff_Login.aspx");

                    if (Request.Cookies["ASP.NET_SessionId"] != null)
                    {
                        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                    }

                    if (Request.Cookies["AuthToken"] != null)
                    {
                        Response.Cookies["AuthToken"].Value = string.Empty;
                        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                    }
                }
                else
                {
                    if (Session["Role"].ToString() == "Staff")
                    {
                        // on page load codes here
                        if (!String.IsNullOrEmpty(Request.QueryString["id"]))
                        {
                            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                            var review = client.GetReviewById(Convert.ToInt32(Request.QueryString["id"]));
                            // var gem = client.GetGemById(Convert.ToInt32(review.Gem_Id));


                            if (review.Status.Trim() == "Approved" || review.Status.Trim() == "Rejected")
                            {
                                approve_btn.Visible = false;
                                disapprove_btn.Visible = false;
                            }
                            review_lb.Text = review_lb.Text + review.Review_Id.ToString();
                            status_lb.Text = review.Status;
                            gem_lb.Text = "<a style='color: black; text-decoration: underline;' target='_blank' href='Gem_Listing.aspx?gemId=" + review.Gem_Id + "&gemT=" + review.Gem_Title + "'>" + review.Gem_Title + "</a>"; // now is id, will need to retrieve name with it next time. also want to make it clickable, link to gem page.
                            author_lb.Text = "<a style='color: black; text-decoration: underline;' target='_blank' href='Staff_Account_Details.aspx?email=" + review.Author + "'>" + review.Author + "</a>";
                            rating_lb.Text = review.Rating;
                            description_lb.Text = review.Description;
                        } else
                        {
                            Response.Redirect("Staff_Reviews_Table.aspx");
                        }
                    }
                    else
                    {
                        Session.Clear();
                        Session.Abandon();
                        Session.RemoveAll();

                        Response.Redirect("Staff_Login.aspx");

                        if (Request.Cookies["ASP.NET_SessionId"] != null)
                        {
                            Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                        }

                        if (Request.Cookies["AuthToken"] != null)
                        {
                            Response.Cookies["AuthToken"].Value = string.Empty;
                            Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                        }
                    }
                }
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();

                Response.Redirect("Staff_Login.aspx");

                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                }

                if (Request.Cookies["AuthToken"] != null)
                {
                    Response.Cookies["AuthToken"].Value = string.Empty;
                    Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                }
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