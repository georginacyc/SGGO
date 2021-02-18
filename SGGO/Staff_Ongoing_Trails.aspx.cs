using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SGGO
{
    public partial class Staff_Ongoing_Trails : System.Web.UI.Page
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

        // make ongoing only valid for upcoming trails
        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                var rowid = e.Row.RowIndex;
                Label status  = (Label)e.Row.FindControl("lb_status");
                if (status.Text != "upcoming") 
                {
                    Button btn = (Button)e.Row.FindControl("btn_makeOngoing"); 
                    btn.Visible = false;

                }
            }
        }

        protected List<Trail> getlist()
        {
            Service1Client client = new Service1Client();
            var all = client.GetAllTrails().ToList<Trail>();
            var draft = client.GetTrailByStatus("draft").ToList<Trail>();
            
            foreach(Trail trail in all)
            {
                var t = trail;
                foreach(Trail draftT in draft)
                {
                    if(t.TrailId == draftT.TrailId)
                    {
                        all.Remove(t);
                    }
                }
            }
            return all;


        }



            protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "makeOngoing")
            {
                int index = 0;
                // Get index of row passed as command argument
                try
                {
                     index = Convert.ToInt32(e.CommandArgument);
                }
                catch (System.FormatException)
                {
                     index = 0; // or other default value as appropriate in context.
                }

                
                List<Trail> eList = getlist();
                Service1Client client = new Service1Client();
                var id = eList[index].TrailId;
                // update the status
                client.UpdateTrailStatus(id, "ongoing");
                //change status of current ongoing
                eList = client.GetTrailByStatus("ongoing").ToList<Trail>();
                Trail current = eList[0];
                var currentId = current.TrailId;
                client.UpdateTrailStatus(currentId, "past");
                Response.Redirect("User_Monthly_Trail.aspx");
            }



        }
    }


    



}