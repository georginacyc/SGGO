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
            if (!String.IsNullOrEmpty(Request.QueryString["id"]))
            {
                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                var report = client.GetReportById(Convert.ToInt32(Request.QueryString["id"]));

                if (report.Status.Trim() == "Resolved")
                {
                    resolve_btn.Visible = false;
                }
                report_lb.Text = report_lb.Text + report.Report_Id;
                status_lb.Text = report.Status;
                date_lb.Text = report.Date_reported.ToString();
                reporter_lb.Text = report.Reported_by; // links to account details page of reporter
                // reported_lb.Text = report.Post; // links to reported gem/review
                reason_lb.Text = report.Reason;
                remarks_lb.Text = report.Remarks;
            }
            else
            {
                Response.Redirect("Staff_Reports_Table.aspx");
            }
        }

        protected void disapprove_btn_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.UpdateReportStatus(Convert.ToInt32(Request.QueryString["id"]), "Resolved");

            Response.Redirect("Staff_Reports_Table.aspx");
        }
    }
}