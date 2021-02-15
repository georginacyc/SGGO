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
    public partial class Point_Shop_Create_Item : System.Web.UI.Page
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
        protected void btn_submit_Click(object sender, EventArgs e)
        {
            string name = tb_name.Text;
            string description = tb_description.Text;
            string type = rb_type.SelectedValue.ToString();
            string partner = lb_pc.Text;
            string partner_email = lb_pc_email.Text;
            int value = int.Parse(tb_price.Text);
            Service1Client client = new DBServiceReference.Service1Client();
            if (tb_name.Text is null)
            {
                lb_uploadstatus.Text = "Gem title must be entered before banner upload can be attempted";
                lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
            }
            else
            {
                if (ImageUpload.HasFile)
                {
                    var filename = tb_name.Text + System.IO.Path.GetExtension(Server.HtmlEncode(ImageUpload.FileName));
                    ImageUpload.SaveAs(Request.PhysicalApplicationPath + "/Images/Point_Shop_Items/" + filename);
                    lb_uploadstatus.Text = "File Successfully Uploaded";
                    lb_uploadstatus.ForeColor = System.Drawing.Color.Green;
                    string image = filename;
                    int result = client.CreatePointShopItem(name, partner, partner_email, description, value, image, type);
                }
                else
                {
                    lb_uploadstatus.Text = "Please Select Your File";
                    lb_uploadstatus.ForeColor = System.Drawing.Color.Red;
                }
            }


            Response.Redirect("Partner_Point_Shop_Item_List.aspx");
        }
    }
}