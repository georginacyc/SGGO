
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
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_back_Click(object sender, EventArgs e)
        {

        }

        protected void btn_submit_report_Click(object sender, EventArgs e)
        {
            DateTime date_reported = DateTime.Now;
            string type = "";
            string reported_by = "";
            string reason = "";
            string remarks = "";
            string status = "";


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateReport(date_reported,type,reported_by,reason,remarks,status);
            
            
        }
    }
}