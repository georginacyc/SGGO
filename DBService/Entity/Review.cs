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
   public class Review
    {
        // Define class properties
        public int Review_Id { get; set; }
        public string Status { get; set; }
        public string Gem_Id { get; set; }
        public string Gem_Title { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }

        public Review()
        {

        }

        // for creating a review
        public Review(string status, string gem_id, string gem_title, string author, string rating, string description)
        {
            Status = status;
            Gem_Title = gem_title;
            Gem_Id = gem_id;
            Author = author;
            Rating = rating;
            Description = description;
        }

        // retrieving individual reviews
        public Review(int review_id, string status, string gem_id, string gem_title, string author, string rating, string description)
        {
            Review_Id = review_id;
            Status = status;
            Gem_Title = gem_title;
            Gem_Id = gem_id;
            Author = author;
            Rating = rating;
            Description = description;
        }

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["nina"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            string query = "INSERT INTO Review (status, gem_id, gem_title, author, rating, description)" + "VALUES (@status, @gem_id, @gem_title, @author, @rating, @description)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@gem_id", Gem_Id);
            cmd.Parameters.AddWithValue("@gem_title", Gem_Title);
            cmd.Parameters.AddWithValue("@author", Author);
            cmd.Parameters.AddWithValue("@rating", Rating);
            cmd.Parameters.AddWithValue("@description", Description);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();


            return result;
        }


        // Select by author

        public Review SelectByAuthor(string author)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Review WHERE author = @author";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@author", author);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Review review = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int review_id = Convert.ToInt32(row["review_id"]);
                string status = row["status"].ToString();
                string gem_id = row["gem_id"].ToString();
                string gem_title = row["gem_title"].ToString();
                string rating = row["rating"].ToString();
                string description = row["description"].ToString();

                review = new Review(review_id, status, gem_id, gem_title, author, rating, description);
            }
            return review;
        }

        // Select by ID
        public Review SelectById(int review_id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Review WHERE review_id = @id";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", review_id);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Review review = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string status = row["status"].ToString();
                string gem_id = row["gem_id"].ToString();
                string gem_title = row["gem_title"].ToString();
                string author = row["author"].ToString();
                string rating = row["rating"].ToString();
                string description = row["description"].ToString();

                review = new Review(review_id, status, gem_id, gem_title, author, rating, description);
            }
            return review;
        }

        //retrive all appreved reviews
        public Review SelectByStatus(string status)
        {
            string connStr = ConfigurationManager.ConnectionStrings["nina"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Review WHERE status = @status";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@status", status);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Review review = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int review_id = Convert.ToInt32(row["review_id"]);
                string gem_id = row["gem_id"].ToString();
                string gem_title = row["gem_title"].ToString();
                string author = row["author"].ToString();
                string rating = row["rating"].ToString();
                string description = row["description"].ToString();

                review = new Review(review_id, status, gem_id, gem_title, author, rating, description);
            }
            return review;
        }

        // Select All

        public List<Review> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Review";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Review> reviewList = new List<Review>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int review_id = Convert.ToInt32(row["review_id"]);
                string description = row["description"].ToString();
                string status = row["status"].ToString();
                string gem_id = row["gem_id"].ToString();
                string gem_title = row["gem_title"].ToString();
                string author = row["author"].ToString();
                string rating = row["rating"].ToString();

                Review review = new Review(review_id, status, gem_id, gem_title, author, rating, description);
                reviewList.Add(review);
            }
            return reviewList;
        }

        public void UpdateStatus(int id, string status)
        {
            System.Diagnostics.Debug.WriteLine(id.ToString() + status);
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Review SET status = @status WHERE review_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            System.Diagnostics.Debug.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }

        public void DeleteReview(int id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["nina"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "DELETE Review WHERE review_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            System.Diagnostics.Debug.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }

        public int CountPending()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT COUNT(*) FROM Review WHERE status = 'Pending'";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            var count = (Int32) cmd.ExecuteScalar();
            conn.Close();

            return count;
        }
    }
}
    