using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class User_Reviews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            string user = (string)Session["email"];
            this.Session["user"] = user;

            //DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //var review = client.GetReviewByAuthor(user);

            //gvMyreview.DataSource = review;
            //gvMyreview.DataBind();

        }

        protected void gvMyreview_SelectedIndexChanged(object sender, EventArgs e)
        {
            //delete review
            int index = gvMyreview.SelectedIndex;

            string id = gvMyreview.DataKeys[index].Value.ToString();

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            client.DeleteReview(Convert.ToInt32(id));

            Response.Redirect(Request.RawUrl);

        }
    }
}