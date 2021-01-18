using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Accounts_List : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            var x = client.GetAllAccounts();

            accounts_gv.DataSource = x;
            accounts_gv.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}