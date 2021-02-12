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
        public string Post { get; set; }
        public string Author { get; set; }
        public string Rating { get; set; }
        public string Description { get; set; }

        public Review()
        {

        }

        // for creating a review
        public Review(string status, string post, string author, string rating, string description)
        {
            Status = status;
            Post = post;
            Author = author;
            Rating = rating;
            Description = description;
        }

        // retrieving individual reviews
        public Review(int review_id, string status, string post, string author, string rating, string description)
        {
            Review_Id = review_id;
            Status = status;
            Post = post;
            Author = author;
            Rating = rating;
            Description = description;
        }

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            string query = "INSERT INTO Review (status, post, author, rating, description)" + "VALUES (@status, @post, @author, @rating, @description)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", Status);
            cmd.Parameters.AddWithValue("@post", Post);
            cmd.Parameters.AddWithValue("@author", Author);
            cmd.Parameters.AddWithValue("@rating", Rating);
            cmd.Parameters.AddWithValue("@description", Description);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();


            return result;
        }


        // Select by Title

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
                string post = row["post"].ToString();
                string rating = row["rating"].ToString();
                string description = row["description"].ToString();

                review = new Review(review_id, status, post, author, rating, description);
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
                string post = row["post"].ToString();
                string author = row["author"].ToString();
                string rating = row["rating"].ToString();
                string description = row["description"].ToString();

                review = new Review(review_id, status, post, author, rating, description);
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
                string post = row["post"].ToString();
                string author = row["author"].ToString();
                string rating = row["rating"].ToString();

                Review review = new Review(review_id, status, post, author, rating, description);
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
    }
}
    