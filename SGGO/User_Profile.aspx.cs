using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class User_Profile : System.Web.UI.Page
    {
        string email = string.Empty;
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
                        Account userObj = client.GetAccountByEmail(email);
                        if (userObj != null)
                        {
                            
                            displayfname_lbl.Text = userObj.First_Name;
                            displaylname_lbl.Text = userObj.Last_Name;
                            displayemail_lbl.Text = userObj.Email;
                            displaydob_lbl.Text = userObj.Dob.ToString("dd/MM/yyyy");
                            displayphone_tb.Text = userObj.Hp;
                            displayaddress1_tb.Text = userObj.Address;
                            displayaddress2_tb.Text = userObj.Address;
                            displaypostalcode_tb.Text = userObj.Postal_Code;

                            //Session["email"] = userObj.Email;
                        }

                        else
                        {
                            displayfname_lbl.Text = String.Empty;
                            displaylname_lbl.Text = String.Empty;
                            displayemail_lbl.Text = String.Empty;
                            displaydob_lbl.Text = userObj.Dob.ToString("dd/MM/yyyy");
                            displayaddress1_tb.Text = String.Empty;
                            displayaddress2_tb.Text = String.Empty;
                            displaypostalcode_tb.Text = String.Empty;
                        }

                    }

                }
                else
                {
                    Response.Redirect("Login.aspx", false);
                }
            }
        }
        protected void btn_Update_Click(object sender, EventArgs e)
        {
           
            email = (string)Session["email"];
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            string address = displayaddress1_tb.Text + displayaddress2_tb.Text;         
            string hp = displayphone_tb.Text;
            string postal = displaypostalcode_tb.Text;
            client.UpdateUserProfile( email,  hp, address,  postal);
            lblMsg.Text = "Successfully Updated";
            lblMsg.ForeColor = Color.Green;
            lblMsg.Visible = true;

        }

        protected void btn_logout_Click(object sender, EventArgs e)
        {
            Session.Clear(); // removes all the variables stored in session and if user try to browse your site same sessionID will be used which was previously assigned to him
            Session.Abandon(); //removes all the variables stored in session, fire session_end event and if user try to browse your site a new sessionID will be assigned to him.
            Session.RemoveAll(); //removing books from the bookshelf whereas Session.Abandon() is like throwing the bookshelf itself.

            Response.Redirect("User_Login.Aspx", false);

            if (Request.Cookies["ASP.NET_SessionId"] != null) // making sure the cookie is removed from the browser 
            {
                Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
            }

            if (Request.Cookies["AuthToken"] != null) //then expire the authtoken cookie as well
            {
                Response.Cookies["AuthToken"].Value = string.Empty;
                Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
            }
        }

        protected void btn_reviews_Click(object sender, EventArgs e)
        {

        }

        protected void btn_favourities_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Favourites.aspx", false);
        }

        protected void btn_coupons_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Coupons.aspx", false);
        }
    }
}