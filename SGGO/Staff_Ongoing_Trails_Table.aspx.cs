using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SGGO.DBServiceReference;

namespace SGGO
{
    public partial class Staff_Ongoing_Trails : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            RefreshGridView();
        }


        private void RefreshGridView()
        {
            List<Trail> eList = new List<Trail>();
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            eList = client.GetAllTrails().ToList<Trail>();

            // using gridview to bind to the list of employee objects
            GridView1.Visible = true;
            GridView1.DataSource = eList;
            GridView1.DataBind();
        }
    }
}