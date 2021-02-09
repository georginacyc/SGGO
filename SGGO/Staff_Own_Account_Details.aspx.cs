using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Own_Account_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void changepw_btn_Click(object sender, EventArgs e)
        {
            Response.Redirect("Staff_Change_Password.aspx");
        }
    }
}