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
                        DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                        var gem = client.GetGemById(Convert.ToInt32(Request.QueryString["id"]));

                        gem_img.Attributes["src"] = "/Images/Gem/" + gem.Image + ".png";
                        title_lb.Text = gem.Title;
                        status_lb.Text = gem.Status;
                        id_lb.Text = gem.Gem_Id.ToString();
                        // adds anchor tags/hyperlinks to the following text
                        partner_lb.Text = "<a style='color: black; text-decoration: underline;' target='_blank' href='Staff_Account_Details.aspx?email=" + gem.Partner_Email + "'>" + gem.Partner + "</a>";
                        type_lb.Text = gem.Type;
                        date_lb.Text = gem.Date == null ? null : Convert.ToDateTime(gem.Date).ToString("dd/MM/yyyy");
                        location_lb.Text = gem.Location;
                        description_lb.Text = gem.Description;

                        // checks if the gem has been dealt with
                        if (gem.Status == "Approved" || gem.Status == "Rejected")
                        {
                            approve_btn.Visible = false;
                            disapprove_btn.Visible = false;
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
            // updates status of gems to 'Approved'
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateGemStatus(Convert.ToInt32(Request.QueryString["id"]), "Approved");

            Response.Redirect("Staff_Gems_Table.aspx");
        }

        protected void disapprove_btn_Click(object sender, EventArgs e)
        {
            // updates status of gems to 'Disapproved'
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateGemStatus(Convert.ToInt32(Request.QueryString["id"]), "Rejected");

            Response.Redirect("Staff_Gems_Table.aspx");
        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            // 'back' button to bring staff back to gems table
            Response.Redirect("Staff_Gems_Table.aspx");
        }
    }
}