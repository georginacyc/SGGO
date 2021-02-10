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
    public class Account
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string Password_Salt { get; set; }
        public string Password_Last { get; set; }
        public string Password_Last2 { get; set; }
        public DateTime Password_Age { get; set; }
        public string Type { get; set; }
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public DateTime Dob { get; set; }
        public string Hp { get; set; }
        public string Postal_Code { get; set; }
        public string Address { get; set; }
        public string Profile_Picture { get; set; }
        public DateTime? Last_Login { get; set; }
        public DateTime Account_Created { get; set; }
        public string Staff_Id { get; set; }
        public int? Diamonds { get; set; }
        // public List<int> Owns { get; set; }
        public int Attempts_Left { get; set; }
        public DateTime? Locked_Since { get; set; }

        public Account()
        {

        }

        // for retrieving accounts
        public Account(string email, string pw, string salt, string old_pw, string old_pw2, DateTime pw_age, string type, string first_name, string last_name, DateTime dob, string hp, string postal, string address, string profilepic, DateTime? last_login, DateTime account_created, string staff_id, int? diamonds, int attempts_left, DateTime? locked_since)
        {
            Email = email;
            Password = pw;
            Password_Salt = salt;
            Password_Last = old_pw;
            Password_Last2 = old_pw2;
            Password_Age = pw_age;
            Type = type;
            First_Name = first_name;
            Last_Name = last_name;
            Dob = dob;
            Hp = hp;
            Postal_Code = postal;
            Address = address;
            Profile_Picture = profilepic;
            Last_Login = last_login;
            Account_Created = account_created;
            Staff_Id = staff_id;
            Diamonds = diamonds;
            // Owns = owns;
            Attempts_Left = attempts_left;
            Locked_Since = locked_since;
        }

        // account creation
        public Account(string email, string pw, string salt, string type, string first_name, string last_name, DateTime dob, string hp, string postal, string address, string profilepic, string staff_id, int? diamonds)
        {
            Email = email;
            Password = pw;
            Password_Salt = salt;
            Type = type;
            First_Name = first_name;
            Last_Name = last_name;
            Dob = dob;
            Hp = hp;
            Postal_Code = postal;
            Address = address;
            Profile_Picture = profilepic;
            Staff_Id = staff_id;
            Diamonds = 0;
            // Owns = owns;
            Attempts_Left = 3;
            Account_Created = DateTime.Now;
            Password_Age = DateTime.Now;
        }

        // account creation
        public int Insert()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "INSERT INTO Accounts (email, password, password_salt, password_age, type, first_name, last_name, dob, hp, postal_code, address, profile_picture, account_created, staff_id, diamonds, attempts_left) " + "VALUES (@email, @password, @password_salt, @password_age, @type, @first_name, @last_name, @dob, @hp, @postal, @address, @profilepic, @account_created, @staff_id, @diamonds, @attempts_left)";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@email", Email);
            cmd.Parameters.AddWithValue("@password", Password);
            cmd.Parameters.AddWithValue("@password_salt", Password_Salt);
            cmd.Parameters.AddWithValue("@password_age", Password_Age);
            cmd.Parameters.AddWithValue("@type", Type);
            cmd.Parameters.AddWithValue("@first_name", First_Name);
            cmd.Parameters.AddWithValue("@last_name", string.IsNullOrEmpty(Last_Name) ? (object)DBNull.Value : Last_Name);
            cmd.Parameters.AddWithValue("@dob", Dob);
            cmd.Parameters.AddWithValue("@hp", Hp);
            cmd.Parameters.AddWithValue("@postal", Postal_Code);
            cmd.Parameters.AddWithValue("@address", Address);
            cmd.Parameters.AddWithValue("@profilepic", Profile_Picture);
            cmd.Parameters.AddWithValue("@account_created", Account_Created);
            cmd.Parameters.AddWithValue("@staff_id", string.IsNullOrEmpty(Staff_Id) ? (object)DBNull.Value : Staff_Id);
            cmd.Parameters.AddWithValue("@profile_pic", Profile_Picture);
            cmd.Parameters.AddWithValue("@diamonds", Diamonds);
            cmd.Parameters.AddWithValue("@attempts_left", Attempts_Left);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public Account SelectByEmail(string email)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Accounts WHERE email = @email";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.Parameters.AddWithValue("@email", email);

            DataSet ds = new DataSet();

            da.Fill(ds);

            Account user = null;
            int count = ds.Tables[0].Rows.Count;
            if (count == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];
                string password = row["password"].ToString();
                string salt = row["password_salt"].ToString();
                string old_pw = row["password_last"].ToString();
                string old_pw2 = row["password_last2"].ToString();
                DateTime pw_age = Convert.ToDateTime(row["password_age"].ToString());
                string type = row["type"].ToString();
                string first_name = row["first_name"].ToString();
                string last_name = row["last_name"].ToString();
                DateTime dob = Convert.ToDateTime(row["dob"].ToString());
                string hp = row["hp"].ToString();
                string postal = row["postal_code"].ToString();
                string address = row["address"].ToString();
                string profilepic = row["profile_picture"].ToString();
                DateTime? last_login;
                DateTime account_created;
                try
                {
                    last_login = Convert.ToDateTime(row["last_login"].ToString());
                }
                catch
                {
                    last_login = null;
                }
                try
                {
                    account_created = Convert.ToDateTime(row["account_created"].ToString());
                }
                catch
                {
                    account_created = DateTime.Now;
                }
                string staff_id = row["staff_id"].ToString();
                int diamonds = Convert.ToInt32(row["diamonds"].ToString());
                int attempts = Convert.ToInt16(row["Attempts_left"].ToString());
                DateTime? locked_since;
                try
                {
                    locked_since = Convert.ToDateTime(row["locked_since"].ToString());
                }
                catch
                {
                    locked_since = null;
                }
                //int diamonds = Convert.ToInt32(row["diamonds"].ToString());
                // owns
                // string profile_pic = row["profile_pic"].tosmthsmth();

                user = new Account(email, password, salt, old_pw, old_pw2, pw_age, type, first_name, last_name, dob, hp, postal, address, profilepic, last_login, account_created, staff_id, diamonds, attempts, locked_since);
            }
            return user;
        }

        public List<Account> SelectAll()
        {
            //return null;
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);

            string query = "SELECT * FROM Accounts";
            SqlDataAdapter da = new SqlDataAdapter(query, conn);

            DataSet ds = new DataSet();

            da.Fill(ds);

            List<Account> accountList = new List<Account>();
            int count = ds.Tables[0].Rows.Count;
            for (int i = 0; i < count; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];
                string email = row["email"].ToString();
                string password = row["password"].ToString();
                string salt = row["password_salt"].ToString();
                string old_pw = row["password_last"].ToString();
                string old_pw2 = row["password_last2"].ToString();
                DateTime pw_age = Convert.ToDateTime(row["password_age"].ToString());
                string type = row["type"].ToString();
                string first_name = row["first_name"].ToString();
                string last_name = row["last_name"].ToString();
                DateTime dob = Convert.ToDateTime(row["dob"].ToString());
                string hp = row["hp"].ToString();
                string postal = row["postal_code"].ToString();
                string address = row["address"].ToString();
                string profilepic = row["profile_picture"].ToString();
                DateTime? last_login;
                DateTime account_created;
                try
                {
                    last_login = Convert.ToDateTime(row["last_login"].ToString());
                }
                catch
                {
                    last_login = null;
                }
                account_created = Convert.ToDateTime(row["account_created"].ToString());
                string staff_id = row["staff_id"].ToString();
                int diamonds = Convert.ToInt32(row["diamonds"].ToString());
                int attempts = Convert.ToInt16(row["attempts_left"].ToString());
                DateTime? locked_since;
                try
                {
                    locked_since = Convert.ToDateTime(row["locked_since"].ToString());
                }
                catch
                {
                    locked_since = null;
                }
                //int diamonds = Convert.ToInt32(row["diamonds"].ToString());
                // owns
                // string profile_pic = row["profile_pic"].tosmthsmth();

                Account user = new Account(email, password, salt, old_pw, old_pw2, pw_age, type, first_name, last_name, dob, hp, postal, address, profilepic, last_login, account_created, staff_id, diamonds, attempts, locked_since);
                accountList.Add(user);
            }
            return accountList;
        }

        // update account details

        public int ChangePassword(string email, string newpass)
        {
            Account user = new Account().SelectByEmail(email);
            string currentpass = user.Password;
            string lastpass = user.Password_Last;

            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Accounts SET password = @new, password_last = @current, password_last2 = @old, password_age = @age WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@new", newpass);
            cmd.Parameters.AddWithValue("@current", currentpass);
            cmd.Parameters.AddWithValue("@old", lastpass);
            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@age", DateTime.Now);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public int UpdateLogin(string email)
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            string query = "UPDATE Accounts SET last_login = @last_login WHERE email = @email";
            SqlCommand cmd = new SqlCommand(query, conn);

            cmd.Parameters.AddWithValue("@last_login", DateTime.Now);
            cmd.Parameters.AddWithValue("@email", email);

            conn.Open();
            int result = cmd.ExecuteNonQuery();
            conn.Close();

            return result;
        }

        public bool CheckSuspended(string email) // true == suspended, false == not suspended
        {
            Account user = new Account().SelectByEmail(email);

            if (user.Locked_Since != null)
            {
                int span = Convert.ToInt16(DateTime.Now.Subtract(Convert.ToDateTime(user.Locked_Since)).TotalMinutes);
                if (span < 30)
                {
                    return true;
                }
                else
                {
                    if (user.Attempts_Left == 0)
                    {

                        string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

                        SqlConnection conn = new SqlConnection(connStr);

                        string query = "UPDATE Accounts SET attempts_left = @attempts_left WHERE email = @email";
                        SqlCommand cmd = new SqlCommand(query, conn);

                        cmd.Parameters.AddWithValue("@attempts_left", 3);
                        cmd.Parameters.AddWithValue("@email", user.Email);

                        conn.Open();
                        cmd.ExecuteNonQuery();
                        conn.Close();
                        return false;
                    }
                    return false;
                }
            }
            else
            {
                if (user.Attempts_Left == 0)
                {
                    string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

                    SqlConnection conn = new SqlConnection(connStr);

                    string query = "UPDATE Accounts SET attempts_left = @attempts_left, suspended_since = @since WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attempts_left", 0);
                    cmd.Parameters.AddWithValue("@since", DateTime.Now);
                    cmd.Parameters.AddWithValue("@email", user.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    //System.Diagnostics.Debug.WriteLine("suspended");
                    return true;
                }
                return false;
            }

        }

        public bool CheckAttempts(string email, bool pass) // true == attempt passed, false == attempt failed
        {

            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;

            SqlConnection conn = new SqlConnection(connStr);

            Account user = new Account().SelectByEmail(email);
            int attempts = user.Attempts_Left;

            if (pass)
            {
                string query = "UPDATE Accounts SET attempts_left = @attempts_left WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, conn);

                cmd.Parameters.AddWithValue("@attempts_left", 3);
                cmd.Parameters.AddWithValue("@email", user.Email);

                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();

                return true;
            }
            else
            {
                attempts -= 1;

                if (attempts > 0)
                {
                    string query = "UPDATE Accounts SET attempts_left = @attempts_left WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attempts_left", attempts);
                    cmd.Parameters.AddWithValue("@email", user.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return false;
                }
                else
                {
                    string query = "UPDATE Accounts SET attempts_left = @attempts_left, locked_since = @since WHERE email = @email";
                    SqlCommand cmd = new SqlCommand(query, conn);

                    cmd.Parameters.AddWithValue("@attempts_left", 0);
                    cmd.Parameters.AddWithValue("@since", DateTime.Now);
                    cmd.Parameters.AddWithValue("@email", user.Email);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                    conn.Close();
                    return false;
                }
            }
        }

        public string GetStaffId()
        {
            string connStr = ConfigurationManager.ConnectionStrings["ggna"].ConnectionString;
            SqlConnection conn = new SqlConnection(connStr);
            string query = "SELECT COUNT(*) FROM Accounts WHERE type = 'Staff'";
            SqlCommand cmd = new SqlCommand(query, conn);

            conn.Open();
            Int32 count = (Int32) cmd.ExecuteScalar();
            count++;
            conn.Close();

            string id = count.ToString().PadLeft(6, '0');

            return id;
        }
    }
}
