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
    public class Report
    {
        // Define class properties
        public int Report_Id { get; set; }
        public DateTime Date_reported { get; set; }
        public string Post { get; set; }
        public string Type { get; set; }
        public string Reported_by { get; set; }
        public string Reason { get; set; }
        public string Remarks { get; set; }
        public string Status { get; set; }

        public Report()
        {

        }
        public Report(DateTime date_reported, string post, string type, string reported_by, string reason, string remarks, string status)
        {
            Date_reported = date_reported;
            Post = post;
            Type = type;
            Reported_by = reported_by;
            Reason = reason;
            Remarks =  remarks;
            Status = status;
        }

        public Report(int report_id, DateTime date_reported, string post, string type, string reported_by, string reason, string remarks, string status)
        {
            Report_Id = report_id;
            Date_reported = date_reported;
            Post = post;
            Type = type;
            Reported_by = reported_by;
            Reason = reason;
            Remarks = remarks;
            Status = status;
        }

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);
            string query = "INSERT INTO Reports (date_reported, post, type, reported_by, main_reason, remarks, status)" + "VALUES (@date_reported, @post, @type, @reported_by, @main_reason, @remarks, @status)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@date_reported", Date_reported);
            cmd.Parameters.AddWithValue("@post", Post);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@reported_by", Reported_by);
            cmd.Parameters.AddWithValue("@main_reason", Reason);
            cmd.Parameters.AddWithValue("@remarks", Remarks);
            cmd.Parameters.AddWithValue("@status", Status);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();


            return result;
        }


        // Select by Status

        public Report SelectByStatus(string status)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Reports WHERE status = @status";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@status", status);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Report report = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                int report_id = Convert.ToInt32(row["report_id"]);
                DateTime date = Convert.ToDateTime(row["date_reported"]);
                string post = row["post"].ToString();
                string type = row["type"].ToString();
                string reported_by = row["reported_by"].ToString();
                string reason = row["main_reason"].ToString();
                string remarks = row["remarks"].ToString();
              

                report = new Report(report_id, date, post, type, reported_by, reason, remarks,status);
            }
            return report;
        }

        // Select by Id
        public Report SelectById(int report_id)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Reports WHERE report_id = @id";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@id", report_id);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Report report = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                DateTime date = Convert.ToDateTime(row["date_reported"]);
                string post = row["post"].ToString();
                string type = row["type"].ToString();
                string reported_by = row["reported_by"].ToString();
                string reason = row["main_reason"].ToString();
                string remarks = row["remarks"].ToString();
                string status = row["status"].ToString();


                report = new Report(report_id, date, post, type, reported_by, reason, remarks, status);
            }
            return report;
        }

        // Select All

        public List<Report> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Reports ORDER BY status DESC";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Report> reportList = new List<Report>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                int report_id = Convert.ToInt32(row["report_id"]);
                DateTime date = Convert.ToDateTime(row["date_reported"]);
                string post = row["post"].ToString();
                string type = row["type"].ToString();
                string reported_by = row["reported_by"].ToString();
                string reason = row["main_reason"].ToString();
                string remarks = row["remarks"].ToString();
                string status = row["status"].ToString();

                Report report = new Report(report_id, date, post, type,reported_by,reason,remarks,status);
                reportList.Add(report);
            }
            return reportList;
        }

        public void UpdateStatus(int id, string status)
        {
            System.Diagnostics.Debug.WriteLine(id.ToString() + status);
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Reports SET status = @status WHERE report_id = @id";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@status", status);
            cmd.Parameters.AddWithValue("@id", id);

            conn.Open();
            System.Diagnostics.Debug.WriteLine(cmd.ExecuteNonQuery());
            conn.Close();
        }

        public int CountUnresolved()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT COUNT(*) FROM Reports WHERE status = 'Unresolved'";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            var count = (Int32)cmd.ExecuteScalar();
            conn.Close();

            return count;
        }
    }
}
