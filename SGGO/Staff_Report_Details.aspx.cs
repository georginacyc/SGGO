using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Report_Details : System.Web.UI.Page
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
                            var report = client.GetReportById(Convert.ToInt32(Request.QueryString["id"]));
                            var gem = client.GetGemById(Convert.ToInt32(report.Post));

                            // checks if the review has already been dealt 
                            if (report.Status.Trim() == "Resolved")
                            {
                                resolve_btn.Visible = false;
                            }
                            report_lb.Text = report_lb.Text + report.Report_Id;
                            status_lb.Text = report.Status;
                            date_lb.Text = report.Date_reported.ToString("dd/MM/yyyy");
                            // adds anchor tags/hyperlinks to the following text
                            reporter_lb.Text = "<a style='color: black; text-decoration: underline;' target='_blank' href='Staff_Account_Details.aspx?email=" + report.Reported_by + "'>" + report.Reported_by + "</a>"; // links to account details page of reporter
                            type_lb.Text = report.Type;
                            reported_lb.Text = "<a style='color: black; text-decoration: underline;' target='_blank' href='Gem_Listing.aspx?gemId=" + report.Post.ToString() + "&gemT=" + gem.Title.ToString() + "'>" + gem.Title.ToString() + "</a>"; // links to reported gem/review
                            reason_lb.Text = report.Reason;
                            remarks_lb.Text = report.Remarks;
                        }
                        else
                        {
                            // if there is no report selected, send back to reports table.
                            Response.Redirect("Staff_Reports_Table.aspx");
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

        protected void disapprove_btn_Click(object sender, EventArgs e)
        {
            // updates status of report to 'Resolved'
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateReportStatus(Convert.ToInt32(Request.QueryString["id"]), "Resolved");

            Response.Redirect("Staff_Reports_Table.aspx");
        }

        protected void back_btn_Click(object sender, EventArgs e)
        {
            // 'back' button to bring users back to reports table
            Response.Redirect("Staff_Reports_Table.aspx");
        }
    }
}