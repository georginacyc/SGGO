using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_User_Account : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void tb_email_TextChanged(object sender, EventArgs e)
        {

        }

        protected void tb_pw_TextChanged(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            bool result;
            lbMsg.Text = String.Empty;

            if (tb_fname.Text == "")
            {
                lbMsg.Text += "First name is required" + "<br/>";
            }
            if (tb_lname.Text == "")
            {
                lbMsg.Text += "Last name is required" + "<br/>";
            }
            if (tb_email.Text == "")
            {
                lbMsg.Text += "Email is required" + "<br/>";
            }
            if (tb_pw.Text == "")
            {
                lbMsg.Text += "Password is required" + "<br/>";
            }
            if (tb_confirmpw.Text == "")
            {
                lbMsg.Text += "Please confirm your password" + "<br/>";
            }
            DateTime dob;
            result = DateTime.TryParse(tbBirthDate.Text, out dob);
            if (!result)
            {
                lbMsg.Text += "Birth Date is invalid" + "<br/>";
            }

            if (Department2.SelectedIndex == -1)
            {
                lbMsg.Text += "Department must be selected!" + "<br/>";
            }
            double wage;
            result = double.TryParse(tbMonthlySalary.Text, out wage);
            if (!result)
            {
                lbMsg.Text += "Monthly Wage is Invalid!" + "<br/>";
            }
            if (String.IsNullOrEmpty(lbMsg.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void btn_Create_Click(object sender, EventArgs e)
        {

        }
    }
}