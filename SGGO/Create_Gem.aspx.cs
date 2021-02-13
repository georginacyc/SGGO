using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows;

namespace SGGO
{
    public partial class Create_Gem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if (tb_title.Text is null)
            {
                lb_uploadstatus.Text = "Gem title must be entered before banner upload can be attempted";
                lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (ImageUpload.HasFile)
                {
                    string filename = tb_title.Text + ".png";
                    ImageUpload.SaveAs(Path.Combine(Server.MapPath("/Images/Gem"), filename));
                    lb_uploadstatus.Text = "File Successfully Uploaded";
                    lb_uploadstatus.ForeColor = System.Drawing.Color.Green;
                }
                else
                {
                    lb_uploadstatus.Text = "Please Select Your File";
                    lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
                }
            }
        }


        protected void rb_type_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (rb_type.SelectedValue == "Activity")
            {
                lb_date.Visible = true;
                tb_date.Visible = true;
            }
            if (rb_type.SelectedValue == "Destination")
            {
                lb_date.Visible = false;
                tb_date.Visible = false;
            }
        }

        protected void btn_submit_Click(object sender, EventArgs e)
        {
            //bool valid = validate();

            //if (valid) {

            //}

            string title = tb_title.Text;
            string description = tb_description.Text;
            string type = rb_type.SelectedValue;
            string partner = tb_pc.Text;
            string location = tb_location.Text;
            DateTime? date = null;
            if (type == "Activity")
            {
                date = Convert.ToDateTime(tb_date.Text);
            }

            string image = title;


            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateGem(title, description, type, location, date, "Active", 0, partner, image);

            string success_msg = title + " has been successfully created";
            Session["success_gem_creation"] = success_msg;

            Response.Redirect("Staff_Gem_List.aspx");

        }

        /**
       protected bool validate()
        {
            string errormsg = "";
            if(tb_title.Text is null)
            {
                errormsg = "Title is empty. ";
            }
            if(tb_description.Text is null)
            {
                errormsg += "Description is empty. ";
            }
            if(tb_pc.Text is null)
            {
                errormsg += "Partner Company is empty. ";
            }
            if(tb_location is null)
            {
                errormsg += "Location is empty. ";
            }
            if (rb_type.SelectedValue == "Activity")
            {
                if(lb_date.Text is null)
                {
                    errormsg += "Date for activity is not specified. ";
                }
                else
                {
                    DateTime date = Convert.ToDateTime(tb_date.Text);
                    if(date < DateTime.Now)
                    {
                        errormsg += "Invalid date entered. ";
                    }
                }
            }

            lb_errormsg.Text = errormsg;

            if(errormsg == "")
            {
                return true;
            }
            else
            {
                return false;
            }

            
        }
        **/

    }
}