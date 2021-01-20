using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBService.Entity
{
    public class Point_Shop_Item
    {
        public string Point_Shop_Item_Id { get; set; }
        public string Name { get; set; }
        public string Partner { get; set; }
        public string Description { get; set; }
        public int Price { get; set; }
        public string Image { get; set; }
        public string Type { get; set; }
        public string QR { get; set; }

        public Point_Shop_Item() { }

        public Point_Shop_Item(string name, string partner, string description, int price, string image, string type, string qr)
        {
            Name = name;
            Partner = partner;
            Description = description;
            Price = price;
            Image = image;
            Type = type;
            QR = "";
        }
        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["jon"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Point_Shop_Item (name,partner,description,price,image,type,qr) " + "VALUES (@name,@partner,@description,@price,@image,@type,@qr)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@partner", Partner);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@price", Price);
            cmd.Parameters.AddWithValue("@image", Image);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@qr", QR);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }
        public Point_Shop_Item SelectById(string Point_Shop_Item_Id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["jon"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT * FROM Point_Shop_Item WHERE Point_Shop_Item_Id = @point_shop_item_id";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@point_shop_item_id", Point_Shop_Item_Id);
            DataSet ds = new DataSet();
            da.Fill(ds);
            Point_Shop_Item item = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string name = row["name"].ToString();
                string partner = row["partner"].ToString();
                string description = row["description"].ToString();
                int price = (int)row["price"];
                string image = row["image"].ToString();
                string type = row["type"].ToString();
                string qr = row["qr"].ToString();
                item = new Point_Shop_Item(name, partner, description, price, image, type, qr);
            }
            return item;
        }
        public List<Point_Shop_Item> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Gem";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Point_Shop_Item> itemList = new List<Point_Shop_Item>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string name = row["name"].ToString();
                string partner = row["partner"].ToString();
                string description = row["description"].ToString();
                int price = (int)row["price"];
                string image = row["image"].ToString();
                string type = row["type"].ToString();
                string qr = row["qr"].ToString();
                Point_Shop_Item item = new Point_Shop_Item(name, partner, description, price, image, type, qr);
                itemList.Add(item);
            }
            return itemList;
        }
    }
}

