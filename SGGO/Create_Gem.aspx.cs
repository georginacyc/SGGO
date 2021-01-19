using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_Gem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {

        }


        protected void rb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_type.SelectedValue == "Activity")
            {
                lb_date.Visible = true;
                Calendar1.Visible = true;
            }
            if (rb_type.SelectedValue == "Destination")
            {
                lb_date.Visible = false;
                Calendar1.Visible = false;
            }
        }


    }
}