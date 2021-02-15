using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;

namespace SGGO
{
    public partial class User_Home : System.Web.UI.Page
    {
        
        protected void Page_Load(object sender, EventArgs e)
        {
            //if (Session["email"] != null)
            //{
            //    email = (string)Session["email"];
            string email = string.Empty;

            //}
            if (Session["email"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null) //checks for normal session, the new session "AuthToken" and new cookie 
            {
                //String authToken = Session["AuthToken"].ToString();
                //String cookie = Request.Cookies["AuthToken"].Value;
                //if (!authToken.Equals(cookie))
                //comes here when the 3 conditions above is not null and checks if they match
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Response.Redirect("User_Login.aspx", false);
                }
                else
                {

                    //ValidateUser(email);
                    //string message = "Simple MessageBox";
                    //string title = "Title";
                    //MessageBox.Show(message, title);
                  email = (string)Session["email"];
                  DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                  Account userObj = client.GetAccountByEmail(email);
                  //string email = userObj.Email;
                  if (userObj != null)
                  {
                      Label1.Text = "Welcome " + userObj.First_Name;
                  }
                  else
                  {
                      Label1.Text = "Welcome User";
                  }
                }



            }
            else
            {
                Response.Redirect("User_Login.aspx", false);
            }

        }

        

       

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("User_Profile.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            
            Response.Redirect("Gem_Catalogue.aspx");
        }

        
    }
}