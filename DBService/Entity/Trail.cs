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
    public class Trail
    {
        // Trail Properties

        public string TrailId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public string Gem1 { get; set; }
        public string Gem2 { get; set; }
        public string Gem3 { get; set; }
        public string Banner { get; set; }
        public string Status { get; set; }

        public Trail()
        {

        }

        public Trail(string trailId, string name, DateTime date, string description, string gem1, string gem2, string gem3, string banner, string status)
        {
            TrailId = trailId;
            Name = name;
            Date = date;
            Description = description;
            Gem1 = gem1;
            Gem2 = gem2;
            Gem3 = gem3;
            Banner = banner;
            Status = status;
        }

        // Insert

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Trail (trailid, name, date, description, gem1, gem2, gem3, banner, status) " + "VALUES (@trailid, @name, @date, @description, @gem1, @gem2, @gem3, @banner, @status)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@trailid", TrailId );
            cmd.Parameters.AddWithValue("@name", Name );
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@description", Description );
            cmd.Parameters.AddWithValue("@gem1", Gem1);
            cmd.Parameters.AddWithValue("@gem2", Gem2);
            cmd.Parameters.AddWithValue("@gem3", Gem3);
            cmd.Parameters.AddWithValue("@banner", Banner);
            cmd.Parameters.AddWithValue("@status", Status);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }


        // Select by Id

        public Trail SelectById(string id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Trail WHERE trailid = @trailid";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@trailid", id);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Trail tr = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string name = row["name"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string description = row["description"].ToString();
                string gem1 = row["gem1"].ToString();
                string gem2 = row["gem2"].ToString();
                string gem3 = row["gem3"].ToString();
                string banner = row["banner"].ToString();
                string status = row["status"].ToString();


                tr = new Trail(id, name, date, description, gem1, gem2, gem3, banner,status);
            }
            return tr;
        }

        // Select All

        public List<Trail> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Trail";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);


            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Trail> trailList = new List<Trail>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string trailid = row["trailid"].ToString();
                string name = row["name"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string description = row["description"].ToString();
                string gem1 = row["gem1"].ToString();
                string gem2 = row["gem2"].ToString();
                string gem3 = row["gem3"].ToString();
                string banner = row["banner"].ToString();
                string status = row["status"].ToString();

                Trail tr = new Trail(trailid, name, date, description, gem1, gem2, gem3, banner,status);
                trailList.Add(tr);
            }
            return trailList;
        }

        // Select by Status

        public List<Trail> SelectByStatus(string status)
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Trail WHERE status = @status";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@status", status);


            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Trail> trailList = new List<Trail>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string trailid = row["trailid"].ToString();
                string name = row["name"].ToString();
                DateTime date = Convert.ToDateTime(row["date"].ToString());
                string description = row["description"].ToString();
                string gem1 = row["gem1"].ToString();
                string gem2 = row["gem2"].ToString();
                string gem3 = row["gem3"].ToString();
                string banner = row["banner"].ToString();

                Trail tr = new Trail(trailid, name, date, description, gem1, gem2, gem3, banner, status);
                trailList.Add(tr);
            }
            return trailList;
        }



        //update trail
        public int UpdateTrail(string trailid)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Gem SET status = @status WHERE trailid = @trailid";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@trailid", trailid);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@description", Description);
            cmd.Parameters.AddWithValue("@gem1", Gem1);
            cmd.Parameters.AddWithValue("@gem2", Gem2);
            cmd.Parameters.AddWithValue("@gem3", Gem3);
            cmd.Parameters.AddWithValue("@banner", Banner);
            cmd.Parameters.AddWithValue("@status", Status);

          
            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;


        }

        // delete draft trail
        public void DeleteTrail(string trailid)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "DELETE Trail WHERE trailid = @trailid";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@trailid", trailid);

            conn.Open();
            System.Diagnostics.Debug.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }

    }
}
