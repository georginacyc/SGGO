using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.DataVisualization.Charting;

namespace SGGO
{
    public partial class Staff_Home : System.Web.UI.Page
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
                        DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
                        var user = client.GetAccountByEmail(Session["LoggedIn"].ToString());

                        reports_lb.Text = client.CountUnresolvedReports().ToString();
                        reviews_lb.Text = client.CountPendingReviews().ToString();
                        gems_lb.Text = client.CountPendingGems().ToString();

                        // populating charts
                        //double[] youthdata = new double[15];
                        //double[] yadultdata = new double[25];
                        //double[] adultdata = new double[20];
                        //double[] elderlydata = new double[5];

                        //var series = age_chart.Series[0];
                        //series.YValueType = ChartValueType.Int32;


                        ////var series = new Series("AgeGroups");
                        ////series.ChartArea = "ChartArea1";
                        ////series.ChartType = SeriesChartType.Bar;

                        //var ydp = new DataPoint();
                        //ydp.AxisLabel = "Youth";
                        //ydp.YValues = youthdata;

                        //var yadp = new DataPoint();
                        //yadp.AxisLabel = "Young Adult";
                        //yadp.YValues = yadultdata;

                        //var adp = new DataPoint();
                        //adp.AxisLabel = "Adult";
                        //adp.YValues = adultdata;

                        //var edp = new DataPoint();
                        //edp.AxisLabel = "Elderly";
                        //edp.YValues = elderlydata;

                        //series.Points.Insert(0, ydp);
                        //series.Points.Insert(1, yadp);
                        //series.Points.Insert(2, adp);
                        //series.Points.Insert(3, edp);

                        //var ydp = series.Points.Add(youthdata);
                        //ydp.AxisLabel = "Youth";
                        //var yadp = series.Points.Add(yadultdata);
                        //yadp.AxisLabel = "Young Adult";
                        //var adp = series.Points.Add(adultdata);
                        //adp.AxisLabel = "Adult";
                        //var edp = series.Points.Add(elderlydata);
                        //edp.AxisLabel = "Elderly";


                        //var chart = age_chart.Series;
                        //chart.Add(series);
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
    }
}