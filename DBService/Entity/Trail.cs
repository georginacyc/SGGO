﻿using System;
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
        public int Gem1 { get; set; }
        public int Gem2 { get; set; }
        public int Gem3 { get; set; }
        public string Banner { get; set; }

        public Trail()
        {

        }

        public Trail(string trailId, string name, DateTime date, string description, int gem1, int gem2, int gem3, string banner)
        {
            TrailId = trailId;
            Name = name;
            Date = date;
            Description = description;
            Gem1 = gem1;
            Gem2 = gem2;
            Gem3 = gem3;
            Banner = banner;
        }

        // Insert

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["danae"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Trail (trailid, name, date, description, gem1, gem2, gem3, banner) " + "VALUES (@trailid, @name, @date, @description, @gem1, @gem2, @gem3, @banner)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@trailid", TrailId );
            cmd.Parameters.AddWithValue("@name", Name );
            cmd.Parameters.AddWithValue("@date", Date);
            cmd.Parameters.AddWithValue("@description", Description );
            cmd.Parameters.AddWithValue("@gem1", Gem1);
            cmd.Parameters.AddWithValue("@gem2", Gem2);
            cmd.Parameters.AddWithValue("@gem3", Gem3);
            cmd.Parameters.AddWithValue("@banner", Banner);

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
                int gem1 = Convert.ToInt32(row["gem1"].ToString());
                int gem2 = Convert.ToInt32(row["gem2"].ToString());
                int gem3 = Convert.ToInt32(row["gem3"].ToString());
                string banner = row["banner"].ToString();


                tr = new Trail(id, name, date, description, gem1, gem2, gem3, banner);
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
                int gem1 = Convert.ToInt32(row["gem1"].ToString());
                int gem2 = Convert.ToInt32(row["gem2"].ToString());
                int gem3 = Convert.ToInt32(row["gem3"].ToString());
                string banner = row["banner"].ToString();

                Trail tr = new Trail(trailid, name, date, description, gem1, gem2, gem3, banner);
                trailList.Add(tr);
            }
            return trailList;
        }


    }
}