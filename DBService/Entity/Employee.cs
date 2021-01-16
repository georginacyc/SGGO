using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace MyDBService.Entity
{
    public class Employee
    {
        // Define class properties
        public string Nric { get; set; }
        public string Name { get; set; }
        public DateTime Birthdate { get; set; }
        public string Dept { get; set; }
        public double MthlySalary { get; set; }
        public double EmployeeCPF { get; set; }
        public double EmployerCPF { get; set; }

        public Employee()
        {

        }
        // Define a constructor to initialize all the properties
        public Employee(string nric, string name, DateTime dob, string dept, double mthlyWage)
        {
            Nric = nric;
            Name = name;
            Birthdate = dob;
            Dept = dept;
            MthlySalary = mthlyWage;
            EmployeeCPF = ComputeEeCPF();
            EmployerCPF = ComputeErCPF();
        }

        public int ComputeAge()
        {
            DateTime now = DateTime.Today;
            int age = DateTime.Today.Year - Birthdate.Year;
            if (now.Month < Birthdate.Month)
            {
                age--;
            }
            else
            {
                if (now.Month == Birthdate.Month && now.Day < Birthdate.Day)
                {
                    age--;
                }
            }
            return age;
        }

        public double ComputeEeCPF()
        {
            double contribute = 0;
            double payCap = MthlySalary;
            if (MthlySalary > 6000)
                payCap = 6000;

            int age = ComputeAge();
            if (age <= 55)
            {
                contribute = payCap * 0.2;
            }
            else if (age <= 60)
            {
                contribute = payCap * 0.13;
            }
            else if (age <= 65)
            {
                contribute = payCap * 0.075;
            }
            else
                contribute = payCap * 0.05;
            return Math.Round(contribute, 2);
        }

        public double ComputeErCPF()
        {
            double contribute = 0;
            double payCap = MthlySalary;
            if (MthlySalary > 6000)
            {
                payCap = 6000;
            }

            int age = ComputeAge();
            if (age <= 55)
            {
                contribute = payCap * 0.17;
            }
            else if (age <= 60)
            {
                contribute = payCap * 0.13;
            }
            else if (age <= 65)
            {
                contribute = payCap * 0.09;
            }
            else
                contribute = payCap * 0.075;
            return Math.Round(contribute, 2);
        }
        public int Insert()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            // Step 2 - Create a SqlCommand object to add record with INSERT statement
            string sqlStmt = "INSERT INTO Employee (nric, name, birthdate, department, mthlySalary) " +
                "VALUES (@paraNric,@paraName, @paraBirthdate, @paraDept, @paraMthlySalary)";
            SqlCommand sqlCmd = new SqlCommand(sqlStmt, myConn);

            // Step 3 : Add each parameterised variable with value
            sqlCmd.Parameters.AddWithValue("@paraNric", Nric);
            sqlCmd.Parameters.AddWithValue("@paraName", Name);
            sqlCmd.Parameters.AddWithValue("@paraBirthdate", Birthdate.ToShortDateString());
            sqlCmd.Parameters.AddWithValue("@paraDept", Dept);
            sqlCmd.Parameters.AddWithValue("@paraMthlySalary", MthlySalary);

            // Step 4 Open connection the execute NonQuery of sql command   
            myConn.Open();
            int result = sqlCmd.ExecuteNonQuery();

            // Step 5 :Close connection
            myConn.Close();

            return result;
        }
        public Employee SelectByNric(string nric)
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter to retrieve data from the database table
            string sqlStmt = "Select * from Employee where nric = @paraNric";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);
            da.SelectCommand.Parameters.AddWithValue("@paraNric", nric);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet.
            Employee emp = null;
            int rec_cnt = ds.Tables[0].Rows.Count;
            if (rec_cnt == 1)
            {
                DataRow row = ds.Tables[0].Rows[0];  // Sql command returns only one record
                string name = row["name"].ToString();
                DateTime dob = Convert.ToDateTime(row["birthdate"].ToString());
                string dept = row["department"].ToString();
                string payStr = row["mthlySalary"].ToString();
                double pay = Convert.ToDouble(payStr);
                emp = new Employee(nric, name, dob, dept, pay);
            }
            return emp;
        }
        public List<Employee> SelectAll()
        {
            //Step 1 -  Define a connection to the database by getting
            //          the connection string from App.config
            string DBConnect = ConfigurationManager.ConnectionStrings["MyDB"].ConnectionString;
            SqlConnection myConn = new SqlConnection(DBConnect);

            //Step 2 -  Create a DataAdapter object to retrieve data from the database table
            string sqlStmt = "Select * from Employee";
            SqlDataAdapter da = new SqlDataAdapter(sqlStmt, myConn);

            //Step 3 -  Create a DataSet to store the data to be retrieved
            DataSet ds = new DataSet();

            //Step 4 -  Use the DataAdapter to fill the DataSet with data retrieved
            da.Fill(ds);

            //Step 5 -  Read data from DataSet to List
            List<Employee> empList = new List<Employee>();
            int rec_cnt = ds.Tables[0].Rows.Count;
            for (int i = 0; i < rec_cnt; i++)
            {
                DataRow row = ds.Tables[0].Rows[i];  // Sql command returns only one record
                string nric = row["nric"].ToString();
                string name = row["name"].ToString();
                DateTime dob = Convert.ToDateTime(row["birthdate"].ToString());
                string dept = row["department"].ToString();
                string payStr = row["mthlySalary"].ToString();
                double pay = Convert.ToDouble(payStr);
                Employee obj = new Employee(nric, name, dob, dept, pay);
                empList.Add(obj);
            }
            return empList;
        }
    }
}
