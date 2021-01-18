 using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_Staff_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            string email = staff_email_tb.Text;
            string fname = staff_fn_tb.Text;
            string lname = staff_ln_tb.Text;
            string hp = staff_hp_tb.Text;
            string address = staff_address_tb.Text;
            string pw = staff_password_tb.Text;

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateAccount(email, pw, "Staff", fname, lname, hp, address, null, DateTime.Now, null, null, null);
            Response.Redirect("Staff_Accounts_List.aspx");
        }
    }
}