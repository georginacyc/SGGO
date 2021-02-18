using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using SGGO.DBServiceReference;
using System.Web.UI.WebControls;

namespace SGGO
{
	public partial class Staff_Draft_Trails : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
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
                        RefreshGridView();
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

        private void RefreshGridView()
        {
            List<Trail> eList = new List<Trail>();
            Service1Client client = new Service1Client();
            eList = client.GetTrailByStatus("draft").ToList<Trail>();

            gv_draftTrails.Visible = true;
            gv_draftTrails.DataSource = eList;
            gv_draftTrails.DataBind();
        }

        protected void gv_draftTrails_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            // cancel the automatic delete action
            e.Cancel = true;

            // do the delete
            // Get index of row passed as command argument
            

            // complete delete action
            gv_draftTrails.DataBind();
        }


        protected void gv_draftTrails_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "edit")
            {
                // Get index of row passed as command argument
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                List<Trail> eList = new List<Trail>();
                Service1Client client = new Service1Client();
                eList = client.GetTrailByStatus("draft").ToList<Trail>();
                var id = eList[index].TrailId;
                Session["draft_edit"] = "true";
                Session["draft_id"] = id;
                Response.Redirect("Create_Trail.aspx");
            }


            if (e.CommandName == "delete")
            {
                // Get index of row passed as command argument
                int index = Convert.ToInt32(e.CommandArgument.ToString());
                List<Trail> eList = new List<Trail>();
                Service1Client client = new Service1Client();
                eList = client.GetTrailByStatus("draft").ToList<Trail>();
                var id = eList[index].TrailId;
                client.DeleteTrail(id);
                Session["draft_edit"] = "true";
                Session["draft_id"] = id;
                RefreshGridView();

                lb_msg.Text = "Draft has been deleted";
                lb_msg.ForeColor = System.Drawing.Color.Red;
            }
        }

    }
}