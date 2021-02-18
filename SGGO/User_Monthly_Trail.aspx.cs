using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class User_Monthly_Trail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {


            List<Trail> eList = new List<Trail>();
            Service1Client client = new Service1Client();
            eList = client.GetTrailByStatus("ongoing").ToList<Trail>();
            Trail oTrail = eList[0];

            img_banner.ImageUrl = "~/Images/Trail/" + oTrail.Banner + ".png";

            lb_desc.Text = oTrail.Description;
            lb_gem1Title.Text = oTrail.Gem1;
            lb_gem2Title.Text = oTrail.Gem2;
            lb_gem3Title.Text = oTrail.Gem3;

            Gem x = client.GetGemByTitle(oTrail.Gem1);
            string pc1 = x.Partner.ToString();
            string type1 = x.Type.ToString();
            img_gem1.Attributes["src"] = "/Images/Gem/" + x.Image + ".jpeg";
            lb_gem1PC.Text = type1 + " by " + pc1;

            Gem x2 = client.GetGemByTitle(oTrail.Gem2);
            string pc2 = x2.Partner.ToString();
            string type2 = x2.Type.ToString();
            lb_gem2PC.Text = type2 + " by " + pc2;
            img_gem1.Attributes["src"] = "/Images/Gem/" + x2.Image + ".jpeg";

            Gem x3 = client.GetGemByTitle(oTrail.Gem3);
            string pc3 = x3.Partner.ToString();
            string type = x3.Type.ToString();
            lb_gem3PC.Text = type + " by " + pc3;
            img_gem1.Attributes["src"] = "/Images/Gem/" + x3.Image + ".jpeg";

        }

        protected void btn_gem1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            List<Trail> eList = new List<Trail>();
            eList = client.GetTrailByStatus("ongoing").ToList<Trail>();
            Trail oTrail = eList[0];
            Gem x = client.GetGemByTitle(lb_gem1Title.Text);
            System.Diagnostics.Debug.WriteLine(x.ToString());
            Response.Redirect("Gem_Listing.aspx?gemId=" + x.Gem_Id);
        }

        protected void btn_gem2_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            List<Trail> eList = new List<Trail>();
            eList = client.GetTrailByStatus("ongoing").ToList<Trail>();
            Trail oTrail = eList[0];
            Gem x = client.GetGemByTitle(oTrail.Gem2);
            Response.Redirect("Gem_Listing.aspx?gemId=" + x.Gem_Id);
        }

        protected void btn_gem3_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            List<Trail> eList = new List<Trail>();
            eList = client.GetTrailByStatus("ongoing").ToList<Trail>();
            Trail oTrail = eList[0];
            Gem x = client.GetGemByTitle(oTrail.Gem3);
            Response.Redirect("Gem_Listing.aspx?gemId=" + x.Gem_Id);
        }
    }

    
}