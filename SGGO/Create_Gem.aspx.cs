using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Create_Gem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(Request.QueryString["email"]))
            {
                DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                var user = client.GetAccountByEmail(Request.QueryString["email"]);
                lb_pc_email.Text = user.Email;
                lb_pc.Text = user.First_Name;
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
            if (tb_title.Text != null && tb_description.Text != null && tb_location.Text != null)
            { 
                string title = tb_title.Text;
                string description = tb_description.Text;
                string type = rb_type.SelectedValue;
                string partner = lb_pc.Text;
                string partner_email = lb_pc_email.Text;
                string location = tb_location.Text;
                DateTime? date = null;
                if(type == "Activity")
                {
                    date = Convert.ToDateTime(tb_date.Text);
                }
                Service1Client client = new DBServiceReference.Service1Client();
                if (tb_title.Text is null)
                {
                    lb_uploadstatus.Text = "Gem title must be entered before banner upload can be attempted";
                    lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
                }
                else
                {
                    if (ImageUpload.HasFile)
                    {
                        var filename = tb_title.Text + System.IO.Path.GetExtension(Server.HtmlEncode(ImageUpload.FileName));
                        ImageUpload.SaveAs(Request.PhysicalApplicationPath + "/Images/Gem/" + filename);
                        lb_uploadstatus.Text = "File Successfully Uploaded";
                        lb_uploadstatus.ForeColor = System.Drawing.Color.Green;
                        string image = filename;
                        int result = client.CreateGem(partner_email, title, description, type, location, date, "Pending", 0, partner, image);
                    }
                    else
                    {
                        lb_uploadstatus.Text = "Please Select Your File";
                        lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
                    }
                }
            }


        Response.Redirect("Partner_Gem_List.aspx");
        }
    }
}