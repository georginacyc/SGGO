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
    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public string Hp { get; set; }
        public string Address { get; set; }
        public DateTime Last_Login { get; set; }
        public DateTime Account_Created { get; set; }
        public string Staff_Id { get; set; }
        public int Points { get; set; }
        public List<int> Owns { get; set; }

        public Account()
        {

        }

        public Account(string email, string pw, string type, string name, string hp, string address, DateTime last_login, DateTime account_created, string staff_id, int points, List<int> owns)
        {
            Email = email;
            Password = pw;
            Type = type;
            Name = name;
            Hp = hp;
            Address = address;
            Last_Login = last_login;
            Account_Created = account_created;
            Staff_Id = staff_id;
            Points = points;
            Owns = owns;
        }

        /*// Staff Account
        public Account(string email, string pw, string type, string name, string hp, string address, string staff_id)
        {
            Email = email;
            Password = pw;
            Type = type;
            Name = name;
            Hp = hp;
            Address = address;
            Staff_Id = staff_id;
            Account_Created = DateTime.Now;
        }

        // Customer Account
        public Account(string email, string pw, string type, string name, string hp, string address, int points, List<int> owns)
        {
            Email = email;
            Password = pw;
            Type = type;
            Name = name;
            Hp = hp;
            Address = address;
            Points = points;
            Owns = owns;
            Account_Created = DateTime.Now;
        }

        // Partner Organisation Account
        public Account(string email, string pw, string type, string name, string hp, string address, List<int> owns)
        {
            Email = email;
            Password = pw;
            Type = type;
            Name = name;
            Hp = hp;
            Address = address;
            Owns = owns;
            Account_Created = DateTime.Now;
        }*/

        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["SGGO_DB"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Account (email, password, type, name, hp, address, last_login, account_created, staff_id, profile_pic, points) " + "VALUES (@email, @password, @type, @name, @hp, @address, @last_login, @account_created, @staf_id, @profile_pic, @points)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@name", Name);
            cmd.Parameters.AddWithValue("@hp", Hp);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@last_login", Last_Login);
            cmd.Parameters.AddWithValue("@account_created", Account_Created);
            cmd.Parameters.AddWithValue("@staff_id", Staff_Id);
            cmd.Parameters.AddWithValue("@profile_pic", null);
            cmd.Parameters.AddWithValue("@points", Points);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public Account SelectByEmail(string email)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Account WHERE email = @email";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@email", Email);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Account user = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string password = row["password"].ToString();
                string type = row["type"].ToString();
                string name = row["name"].ToString();
                string hp = row["hp"].ToString();
                string address = row["address"].ToString();
                DateTime last_login = Convert.ToDateTime(row["last_login"].ToString());
                DateTime account_created = Convert.ToDateTime(row["account_created"].ToString());
                string staff_id = row["staff_id"].ToString();
                int points = Convert.ToInt32(row["points"].ToString());
                // owns
                // string profile_pic = row["profile_pic"].tosmthsmth();

                user = new Account(email, password, type, name, hp, address, last_login, account_created, staff_id, points);
            }
            return user;
        }

        public List<Account> SelectAll()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Account";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Account> accountList = new List<Account>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string email = row["email"].ToString();
                string password = row["password"].ToString();
                string type = row["type"].ToString();
                string name = row["name"].ToString();
                string hp = row["hp"].ToString();
                string address = row["address"].ToString();
                DateTime last_login = Convert.ToDateTime(row["last_login"].ToString());
                DateTime account_created = Convert.ToDateTime(row["account_created"].ToString());
                string staff_id = row["staff_id"].ToString();
                int points = Convert.ToInt32(row["points"].ToString());
                // string profile_pic = row["profile_pic"].tosmthsmth();

                Account user = new Account(email, password, type, name, hp, address, last_login, account_created, staff_id, points);
                accountList.Add(user);
            }
            return accountList;
        }
    }
}