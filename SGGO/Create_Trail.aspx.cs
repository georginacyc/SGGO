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
    public partial class Create_Trail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_create_Click(object sender, EventArgs e)
        {

            string title = tb_title.Text;
            var month = dd_month.SelectedValue;
            var year = tb_year.Text;
            var datestr = "1 " + month + " " + year;
            DateTime date = Convert.ToDateTime(datestr);
            string description = tb_description.Text;
            string gem1 = lb_gem1_listing.Text;
            string gem2 = lb_gem2_listing.Text;
            string gem3 = lb_gem3_lisitng.Text;
            string banner = title;
            string trailid = month + year + "trail";
            string status = "upcoming";

            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateTrail(trailid, title, date, description, gem1, gem2, gem3, banner,status);

            Response.Redirect("Staff_Ongoing_Trails.aspx");

        }

       

        protected void btn_addListing_Click(object sender, EventArgs e)
        {
            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            string title = dd_gem.SelectedValue;
            Gem x = client.GetGemByTitle(title);
            string pc = x.Partner.ToString();
            string type = x.Type.ToString();

            if (lb_gem1_listing.Text == "-")
            {
                lb_gem1_listing.Text = title;
                lb_gem1_pc.Text = pc;
                lb_gem1_type.Text = type;

            }else if (lb_gem2_listing.Text == "-")
            {
                lb_gem2_listing.Text = title;
                lb_gem2_pc.Text = pc;
                lb_gem2_type.Text = type;
            }
            else if (lb_gem3_pc.Text == "-")
            {
                lb_gem3_lisitng.Text = title;
                lb_gem3_pc.Text = pc;
                lb_gem3_type.Text = type;
            }
            else
            {
                lb_adderror.Text = "Max Listings Have Been Reached";
                lb_adderror.ForeColor = System.Drawing.Color.Red;
            }



        }

        protected void btn_upload_Click(object sender, EventArgs e)
        {
            if(tb_title.Text is null)
            {
                lb_uploadstatus.Text = "Trail title must be entered before banner upload can be attempted";
                lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (BannerUpload.HasFile)
                {
                    string filename = tb_title.Text + ".png";
                    BannerUpload.SaveAs(Path.Combine(Server.MapPath("/Images/Trail"), filename));
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


    }
}