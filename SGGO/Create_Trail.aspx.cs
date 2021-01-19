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
            string banner = title.Trim() + "Banner";
            string trailid = month + year + "trail";

            Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreateTrail(trailid, title, date, description, gem1, gem2, gem3, banner);

            //Response.Redirect("Staff_Accounts_List.aspx");

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
                lb_gem3_pc.Text = title;
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
            if (BannerUpload.HasFile)
            {
                string banner = tb_title.Text.Trim() + "Banner";
                string filename = Path.Combine(Server.MapPath("~/Images/Trail"), banner);
                BannerUpload.SaveAs(filename);
            }
            else
            {
                lbl_uploaderror.Text = "Please Select Your File";
                lbl_uploaderror.ForeColor = System.Drawing.Color.Red;
            }
        }


    }
}