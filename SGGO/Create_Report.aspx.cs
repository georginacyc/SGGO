
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
        string type_id = null;
        string type_type = null;
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
                    userid = (string)Session["email"];

                    if ( Request.QueryString["gem"] != null)
                    {
                        type_id = Request.QueryString["gem"];
                        lbl_id.Text = type_id;
                        type_type = "gem";
                    }
                    if (Request.QueryString["rev"] != null)
                    {
                        type_id = Request.QueryString["rev"];
                        lbl_id.Text = type_id;
                        type_type = "review";
                    }
                    else
                    {
                        type_type = "gem";
                    }

                }
            }
            else
            {
                Response.Redirect("User_Login.aspx", false);
            }


            //userid = (string)Session["email"];
            //type_id = Request.QueryString["post"];
            //lbl_id.Text = type_id;
        }

        protected void btn_back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Catalogue.aspx");
        }

        protected void btn_submit_report_Click(object sender, EventArgs e)
        {
            DateTime date_reported = DateTime.Now;
            string post = lbl_id.Text;
            string type = type_type;
            string reported_by = userid;
            string reason = ddl_reason.SelectedValue;
            string remarks = tb_remark.Text;
            string status = "Unresolved";


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReport(date_reported,post,type,reported_by,reason,remarks,status);
            lbl_msg.Text = "Report successfully submitted, we will resolve it soon.";
            
        }
    }
}