using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DBService.Entity
{
    public class Gem
    {
        public int Gem_Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        public string Status { get; set; }
        public string Location { get; set; }
        public DateTime? Date { get; set; }
        public float? Rating { get; set; }
        public string Partner { get; set; }
        public string Image { get; set; }


        public Gem()
        {

        }

        // for retrieving gems
        public Gem(int id, string title, string description, string type, string location, DateTime? date, string status, float? rating, string partner, string image)
        {
            Gem_Id = id;
            Title = title;
            Description = description;
            Type = type;
            Location = location;
            Date = date;
            Status = status;
            Rating = rating;
            Partner = partner;
            Image = image;
        }

        // for creating gems
        public Gem(string title, string description, string type, string location, DateTime? date,string status, float? rating, string partner, string image)
        {
            Title = title;
            Description = description;
            Type = type;
            Location = location;
            Date = date;
            Status = status;
            Rating = rating;
            Partner = partner;
            Image = image;
        }

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Gem (title,description,type,status,location,date,rating,partner,image) " + "VALUES (@title,@description,@type,@status,@location,@date,@rating,@partner,@image)";
            SqlCommand cmd = new SqlCommand(query, conn);

            if(Date is null)
            {
                cmd.Parameters.AddWithValue("@date", DBNull.Value);
            }
            else
            {
                cmd.Parameters.AddWithValue("@date", Date);
            }


            cmd.Parameters.AddWithValue("@title", Title );
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@location",Location );
            cmd.Parameters.AddWithValue("@rating", DBNull.Value);
            cmd.Parameters.AddWithValue("@partner", Partner);
            cmd.Parameters.AddWithValue("@Image", Image);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }


        // Select by Title

        public Gem SelectByTitle(string title)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Gem WHERE title = @title";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@title", title);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Gem gem = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string description = row["description"].ToString();
                string type = row["type"].ToString();
                string status = row["status"].ToString();
                string location = row["location"].ToString();
                string partner = row["partner"].ToString();
                string image = row["image"].ToString();
                float rating;
                DateTime? date;
                if (row["rating"].Equals(System.DBNull.Value))
                {
                    rating = 0;
                }
                else
                {
                    rating = (float)Convert.ToDouble(row["rating"]);
                }

                if (row["date"].Equals(System.DBNull.Value))
                {
                    date = null;
                }
                else
                {
                    date = Convert.ToDateTime(row["date"]);
                }

                gem = new Gem(title, description, type, location, date, status, rating, partner, image);
            }
            return gem;
        }

        // Select by Id
        public Gem SelectById(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["nina"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Gem WHERE Id = @id";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", id);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Gem gem = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string title = row["description"].ToString();
                string description = row["description"].ToString();
                string type = row["type"].ToString();
                string status = row["status"].ToString();
                string location = row["location"].ToString();
                string partner = row["partner"].ToString();
                string image = row["image"].ToString();
                float rating;
                DateTime? date;
                if (row["rating"].Equals(System.DBNull.Value))
                {
                    rating = 0;
                }
                else
                {
                    rating = (float)Convert.ToDouble(row["rating"]);
                }

                if (row["date"].Equals(System.DBNull.Value))
                {
                    date = null;
                }
                else
                {
                    date = Convert.ToDateTime(row["date"]);
                }

                gem = new Gem(title, description, type, location, date, status, rating, partner, image);
            }
            return gem;
        }

        // Select All

        public List<Gem> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Gem";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Gem> gemList = new List<Gem>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string title = row["title"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string description = row["description"].ToString();
                string type = row["type"].ToString();
                string status = row["status"].ToString();
                string location = row["location"].ToString();
                string partner = row["partner"].ToString();
                string image = row["image"].ToString();
                float rating = (float)Convert.ToDouble(row["rating"].ToString());

                Gem gem = new Gem(title, description, type, location, date, status, rating, partner, image);
                gemList.Add(gem);
            }
            return gemList;
        }
        //end

        public void UpdateStatus(int id, string status)
        {
            System.Diagnostics.Debug.WriteLine(id.ToString() + status);
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Gem SET status = @status WHERE Id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            System.Diagnostics.Debug.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }
    }


}
