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

            // check session
            if (Session["LoggedIn"] != null && Session["Role"] != null && Session["AuthToken"] != null && Request.Cookies["AuthToken"] != null)
            {
                if (!Session["AuthToken"].ToString().Equals(Request.Cookies["AuthToken"].Value))
                {
                    Session.Clear();
                    Session.Abandon();
                    Session.RemoveAll();

                    Response.Redirect("Staff_Login.aspx");

                    if (Request.Cookies["ASP.NET_SessionId"] != null)
                    {
                        Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                        Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                    }

                    if (Request.Cookies["AuthToken"] != null)
                    {
                        Response.Cookies["AuthToken"].Value = string.Empty;
                        Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                    }
                }
                else
                {
                    if (Session["Role"].ToString() == "Staff")
                    {
                        // on page load codes here

                        //populate drop down list
                        //List<Gem> gemList = new List<Gem>();
                        //DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                        //gemList = client.GetAllGems().ToList<Gem>();

                        //foreach (Gem gem in gemList)
                        //{
                        //  dd_gem.Items.Add(gem.Title.ToString());
                        //}

                        if (Session["draft_edit"] != null && Session["draft_id"] != null)
                        {
                            var id = Session["draft_id"].ToString();
                            Service1Client client = new Service1Client();
                            Trail trail = client.GetTrailById(id);

                            tb_title.Text = trail.Name;
                            var date = trail.Date;
                            var month = date.Month.ToString();
                            tb_year.Text = date.Year.ToString();
                            dd_month.SelectedValue = month;
                            if (trail.Description == "none")
                            {
                                tb_description.Text = null;
                            }
                            if (trail.Gem1 != "-")
                            {
                                Gem gem1 = client.GetGemByTitle(trail.Gem1);
                                lb_gem1_listing.Text = gem1.Title;
                                lb_gem1_pc.Text = gem1.Partner;
                                lb_gem1_type.Text = gem1.Type;
                            }
                            if (trail.Gem2 != "-")
                            {
                                Gem gem2 = client.GetGemByTitle(trail.Gem2);
                                lb_gem1_listing.Text = gem2.Title;
                                lb_gem1_pc.Text = gem2.Partner;
                                lb_gem1_type.Text = gem2.Type;
                            }
                            if (trail.Gem3 != "-")
                            {
                                Gem gem3 = client.GetGemByTitle(trail.Gem3);
                                lb_gem1_listing.Text = gem3.Title;
                                lb_gem1_pc.Text = gem3.Partner;
                                lb_gem1_type.Text = gem3.Type;
                            }


                        }
                    }
                    else
                    {
                        Session.Clear();
                        Session.Abandon();
                        Session.RemoveAll();

                        Response.Redirect("Staff_Login.aspx");

                        if (Request.Cookies["ASP.NET_SessionId"] != null)
                        {
                            Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                            Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                        }

                        if (Request.Cookies["AuthToken"] != null)
                        {
                            Response.Cookies["AuthToken"].Value = string.Empty;
                            Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                        }
                    }
                }
            }
            else
            {
                Session.Clear();
                Session.Abandon();
                Session.RemoveAll();

                Response.Redirect("Staff_Login.aspx");

                if (Request.Cookies["ASP.NET_SessionId"] != null)
                {
                    Response.Cookies["ASP.NET_SessionId"].Value = string.Empty;
                    Response.Cookies["ASP.NET_SessionId"].Expires = DateTime.Now.AddMonths(-20);
                }

                if (Request.Cookies["AuthToken"] != null)
                {
                    Response.Cookies["AuthToken"].Value = string.Empty;
                    Response.Cookies["AuthToken"].Expires = DateTime.Now.AddMonths(-20);
                }
            }

            


        }

        protected void btn_create_Click(object sender, EventArgs e)
        {
            Service1Client client = new DBServiceReference.Service1Client();
            if (Session["draft_edit"] != null)
            {
                var id = Session["draft_id"].ToString();
                client.DeleteTrail(id);
            }

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

            int result = client.CreateTrail(trailid, title, date, description, gem1, gem2, gem3, banner,status);
            Session["draft_edit"] = false;
            Session.Remove("draft_id");

            Response.Redirect("Staff_Ongoing_Trails.aspx");

        }

        private bool ValidateInput()
        {
            bool result = true;
            var month = dd_month.SelectedValue;
            var year = tb_year.Text;
            var datestr = "1 " + month + " " + year;
            var date = DateTime.TryParse(datestr, out DateTime dob);
            if (!date)
            {
                lb_error.Text = "Missing fields, Title and Date must be filled to save as draft";
            }

            if (tb_title.Text == "")
            {
                lb_error.Text = "Missing fields, Title and Date must be filled to save as draft";
            }



            return result;
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

        protected void btn_savedraft_Click(object sender, EventArgs e)
        {

            bool validInput = ValidateInput();

            if (validInput)
            {
                string title = tb_title.Text;
                var month = dd_month.SelectedValue;
                var year = tb_year.Text;
                var datestr = "1 " + month + " " + year;
                DateTime date = Convert.ToDateTime(datestr);
                string description = tb_description.Text;
                if (description == "")
                {
                    description = "none";
                }
                string gem1 = lb_gem1_listing.Text;
                string gem2 = lb_gem2_listing.Text;
                string gem3 = lb_gem3_lisitng.Text;
                string banner = title;
                string trailid = month + year + "trail";
                string status = "draft";

                Service1Client client = new DBServiceReference.Service1Client();
                int result;
                if(Session["draft_edit"] != null)
                {

                }
                else
                {
                   result = client.CreateTrail(trailid, title, date, description, gem1, gem2, gem3, banner, status);
                }

               
                Session.Remove("draft_id");
                Session.Remove("draft_edit");
                Response.Redirect("Staff_Draft_Trails.aspx");
            }
            

            
        }
    }
}