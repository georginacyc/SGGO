using SGGO.DBServiceReference;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;


namespace SGGO
{
    public partial class User_Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        private bool ValidateInput()
        {
            bool result;
            lblMsg2.Text = String.Empty;

            if (tb_email.Text == "")
            {
                lblMsg2.Text += "First name is required" + "<br/>";
            }
            if (tb_pw.Text == "")
            {
                lblMsg2.Text += "Password is required" + "<br/>";
            }


            if (String.IsNullOrEmpty(lblMsg2.Text))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected void CheckAccount(string email, string pw)
        {

            DBServiceReference.Service1Client client = new DBServiceReference.Service1Client();
            //var user = client.GetAccountByEmail(email); //get this from Service1.cs
            Account userObj = client.GetAccountByEmail(email);
            SHA512Managed hashing = new SHA512Managed();
            //string dbHash = userObj.Password;
            string dbSalt = userObj.Password_Salt;
            if (userObj != null)
            {
                //if (dbSalt != null && dbSalt.Length > 0 && dbHash != null && dbHash.Length > 0)
                //{
                //string pwdWithSalt = pw + dbSalt;
                //byte[] hashWithSalt = hashing.ComputeHash(Encoding.UTF8.GetBytes(pwdWithSalt));
                //string userHash = Convert.ToBase64String(hashWithSalt);
                //SHA512Managed hashing = new SHA512Managed();
                string pwdWithSalt = pw + dbSalt;
               // byte[] plainHash = hashing.ComputeHash(Encoding.UTF8.GetBytes(pw));
                byte[] hashWithSalt = hashing.ComputeHash(Encoding.UTF8.GetBytes(pwdWithSalt));
                String pwhash = Convert.ToBase64String(hashWithSalt);

                if (pwhash.Equals(userObj.Password))
                    {

                        Session["email"] = email;
                        //create GUID and save into the session, a unique value that is hard to guess 
                        string guid = Guid.NewGuid().ToString();
                        Session["AuthToken"] = guid; // save to the new session variable called auth token

                        //create a new cookie with guid value
                        Response.Cookies.Add(new HttpCookie("AuthToken", guid));

                        Response.Redirect("User_Profile.aspx");
                    }
                //}


                    else
                    {

                        lblMsg2.Text = "User or password is invalid, please try again";

                    };
            }
            else
            {
                lblMsg2.Text = "Pw is incorrect";
            }


        }

        protected void btn_login_Click(object sender, EventArgs e)
        {
            if (ValidateInput() == true)
            {
                string email = tb_email.Text;
                string pw = tb_pw.Text;
                CheckAccount(email, pw);
            }
            else
            {
                lblMsg2.Visible = true;
            }

        }

        //protected string getDBHash(string email)
        //{
        //    string h = null;
        //    SqlConnection connection = new SqlConnection("cody");
        //    string sql = "select password FROM Account WHERE Email=@email";
        //    SqlCommand command = new SqlCommand(sql, connection);
        //    command.Parameters.AddWithValue("@email", email);
        //    try
        //    {
        //        connection.Open();
        //        using (SqlDataReader reader = command.ExecuteReader())
        //        {

        //            while (reader.Read())
        //            {
        //                if (reader["password"] != null)
        //                {
        //                    if (reader["password"] != DBNull.Value)
        //                    {
        //                        h = reader["password"].ToString();
        //                    }
        //                }
        //            }

        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        throw new Exception(ex.ToString());
        //    }
        //    finally { connection.Close(); }
        //    return h;
        //}
        //   protected string getDBSalt(string email)
        //   {
        //       string s = null;
        //       SqlConnection connection = new SqlConnection(ASDBConnectionString);
        //       string sql = "select pw_salt FROM ACCOUNT WHERE Email=@email";
        //       SqlCommand command = new SqlCommand(sql, connection);
        //       command.Parameters.AddWithValue("@email", email);
        //       try
        //       {
        //           connection.Open();
        //           using (SqlDataReader reader = command.ExecuteReader())
        //           {
        //               while (reader.Read())
        //               {
        //                   if (reader["pw_salt"] != null)
        //                   {
        //                       if (reader["pw_salt"] != DBNull.Value)
        //                       {
        //                           s = reader["pw_salt"].ToString();
        //                       }
        //                   }
        //               }
        //           }
        //       }
        //       catch (Exception ex)
        //       {
        //           throw new Exception(ex.ToString());
        //       }
        //       finally { connection.Close(); }
        //       return s;
        //   }
        //}
    }
}