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
        }

        protected void reports_gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = reports_gv.SelectedRow.Cells[0].Text;
            Response.Redirect("Staff_Report_Details.aspx?id=" + id);
        }
    }
}