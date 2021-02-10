using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Reports_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var x = client.GetAllReports();

            reports_gv.DataSource = x;
            reports_gv.DataBind();
        }
    }
}