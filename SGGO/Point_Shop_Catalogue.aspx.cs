using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Point_Shop_Catalogue : System.Web.UI.Page
    {
        string email = null;
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null) //checks for normal session, the new session "AuthToken" and new cookie 
                {
                    //String authToken = Session["AuthToken"].ToString();
                    //String cookie = Request.Cookies["AuthToken"].Value;
                    //if (!authToken.Equals(cookie))
                    //comes here when the 3 conditions above is not null and checks if they match
                    if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                    {
                        Response.Redirect("Login.aspx", false);
                    }
                    else
                    {
                        email = (string)Session["email"];
                        DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                        var userObj = client.GetAccountByEmail(email);
                        if (userObj != null)
                        {

                            lb_points.Text = "Your points: "+ userObj.Diamonds.ToString();
                        }

                        else
                        {
                            lb_points.Text = "Your points: 0";
                        }

                    }

                }
                else
                {
                    Response.Redirect("Login.aspx", false);
                }
            }
        }

        protected void PSIGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            string PSIid = PSI_gv.SelectedRow.Cells[0].Text;
            //Cody u can put the code to push the id of the voucher thing here
        }
    }
}