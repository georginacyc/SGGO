using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Reviews_Table : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //var x = client.GetAllReview();

            //reviews_gv.DataSource = x;
            //reviews_gv.DataBind();
        }

        protected void reviews_gv_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = reviews_gv.SelectedRow.Cells[0].Text;
            Response.Redirect("Staff_Review_Details.aspx?id=" + id);
        }
    }
}