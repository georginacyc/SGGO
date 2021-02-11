
using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_Report : System.Web.UI.Page
    {
        string userid = null;
        string type_id;
        protected void Page_Load(object sender, EventArgs e)
        {
            userid = (string)Session["email"];
            type_id = Request.QueryString["post"];
            lbl_id.Text = type_id;
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Home.aspx");
        }

        protected void btn_submit_report_Click(object sender, EventArgs e)
        {
            DateTime date_reported = DateTime.Now;
            string type = lbl_id.Text;
            string reported_by = "nina@yahoo.com";
                //userid;
            string reason = ddl_reason.SelectedValue;
            string remarks = tb_remark.Text;
            string status = "Unresolved";


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReport(date_reported,type,reported_by,reason,remarks,status);
            lbl_msg.Text = "Report successfully submitted, we will resolve it soon.";
            
        }
    }
}