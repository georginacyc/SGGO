﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Point_Shop_Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_featured_Click(object sender, EventArgs e)
        {
            Response.Redirect("Point_Shop_Catalogue.aspx");
        }

        protected void btn_staycation_Click(object sender, EventArgs e)
        {
            Response.Redirect("Point_Shop_Catalogue.aspx");
        }

        protected void btn_travel_v_Click(object sender, EventArgs e)
        {
            Response.Redirect("Point_Shop_Catalogue.aspx");
        }

        protected void btn_food_v_Click(object sender, EventArgs e)
        {
            Response.Redirect("Point_Shop_Catalogue.aspx");
        }
    }
}