﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Gem_Listing : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_map_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://g.page/NicolesFlower?share");
        }

        protected void btn_review_Click(object sender, EventArgs e)
        {
            Response.Redirect("Gem_Review.aspx");
        }
    }
}