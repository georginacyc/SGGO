using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Account_Details : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (this.Page.PreviousPage != null)
            {
                ContentPlaceHolder cp = (ContentPlaceHolder)this.Page.PreviousPage.Master.FindControl("ContentPlaceHolder1");
                GridView gv = (GridView)cp.FindControl("accounts_gv");
                if (gv != null)
                {
                    GridViewRow row = gv.SelectedRow;
                    DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                    var user = client.GetAccountByEmail(row.Cells[2].Text);
                    email_lb.Text = user.Email;
                    staffid_lb.Text = user.Staff_Id;
                    fname_lb.Text = user.First_Name;
                    lname_lb.Text = user.Last_Name;
                    dob_lb.Text = user.Dob.ToString();
                    hp_lb.Text = user.Hp;
                    postal_lb.Text = "pp";
                    address_lb.Text = user.Address;
                    created_lb.Text = user.Account_Created.ToString();
                    login_lb.Text = user.Last_Login.ToString();
                    points_lb.Text = user.Points.ToString();
                }                    
            }
            else
            {
                Response.Redirect("Staff_Accounts_List.aspx");
            }
        }
    }
}