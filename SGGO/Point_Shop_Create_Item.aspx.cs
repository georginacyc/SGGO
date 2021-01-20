using System;
using System.Collections.Generic;
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

        }

        protected void submit_btn_Click(object sender, EventArgs e)
        {
            int value;

            if (int.TryParse(tb_item_price.Text, out value))
            {
                //parsing successful 
            }
            else
            {
                //parsing failed. 
            }
            string name = tb_item_name.Text;
            string type = ddl_item_type.Text;
            string partner = tb_item_location.Text;
            int price = value;
            string description = tb_item_description.Text;
            string image = FileUpload1.ToString();
            string qr = "qr";

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            int result = client.CreatePointShopItem(name, partner, description, price, image, type, qr);
            Response.Redirect("Point_Shop_Catalogue.aspx");
        }
    }
}