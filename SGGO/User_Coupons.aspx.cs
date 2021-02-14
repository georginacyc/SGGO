using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class User_Coupons : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Page.IsPostBack == false)
            {
                //if (Session["SSTDAcNo"] != null)
                //{
                //    // Assign session variables for customer id, name and account labels
                //    lbCustId.Text = Session["SScustId"].ToString();
                //    lbCustname.Text = Session["SScustName"].ToString();
                //    lbAcc.Text = Session["SSTDAcNo"].ToString();

                //    // Retrieve TDMaster records by account
                //    MyDBServiceReference.Service1Client client = new MyDBServiceReference.Service1Client();
                //    TDMaster td = client.GetTDMasterByAccount(lbAcc.Text);

                //    // Show TDMaster info on form
                //    lbPrincipal.Text = td.Principal.ToString();
                //    lbMaturedAmt.Text = td.MaturedAmt.ToString();
                //    lbMaturedDte.Text = td.MaturityDate.ToString();
                //    ddlRenew.SelectedItem.Text = td.RenewMode;

                //    // Store the current renew mode to compare with new choice
                //    ViewState["currRenewMode"] = td.RenewMode; ;
                //}
                //else
                //{
                //    Response.Redirect("CustomerForm.aspx");
                //}

            }
        }
    }
}