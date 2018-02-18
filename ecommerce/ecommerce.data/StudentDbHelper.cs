using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.data
{
    public class StudentDbHelper
    {
        private static string connectionString =
            "Server=(localdb)\\MSSqlLocalDb;Integrated Security=True;Initial Catalog=ecommercedb;";

        public bool Insert(Student s)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "INSERT INTO Student (Name, RollNo, Grade," +
                "EnrolDate,Active) VALUES (@Name, @RollNo, @Grade," +
                "@EnrolDate,@Active)";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@RollNo", s.RollNo);
            cmd.Parameters.AddWithValue("@Grade", s.Grade);
            cmd.Parameters.AddWithValue("@EnrolDate", s.EnrolDate);
            cmd.Parameters.AddWithValue("@Active", s.Active);
            //Step 3: open connection
            conn.Open();
            //Step 4: Execute query
            cmd.ExecuteNonQuery();
            //Step 5: Close connection
            conn.Close();
            return true;
        }

        public bool Update(Student s)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "UPDATE Student SET Name=@Name," +
                "RollNo=@RollNo," +
                "Grade=@Grade," +
                "EnrolDate=@EnrolDate," +
                "Active=@Active WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@Name", s.Name);
            cmd.Parameters.AddWithValue("@RollNo", s.RollNo);
            cmd.Parameters.AddWithValue("@Grade", s.Grade);
            cmd.Parameters.AddWithValue("@EnrolDate", s.EnrolDate);
            cmd.Parameters.AddWithValue("@Active", s.Active);
            cmd.Parameters.AddWithValue("@Id", s.Id);
            //Step 3: open connection
            conn.Open();
            //Step 4: Execute query
            cmd.ExecuteNonQuery();
            //Step 5: Close connection
            conn.Close();
            return true;
        }

        public bool Delete(Student s)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "DELETE FROM Student WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@Id", s.Id);
            //Step 3: open connection
            conn.Open();
            //Step 4: Execute query
            cmd.ExecuteNonQuery();
            //Step 5: Close connection
            conn.Close();
            return true;
        }

        public DataTable Select()
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "SELECT Id,Name,RollNo,Grade,EnrolDate,Active" +
                " FROM Student";
            SqlCommand cmd = new SqlCommand(query, conn);
            //Step 3: open connection
            conn.Open();
            //Step 4: Instantiate SqlDataAdapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Step 5: Instantiate datatable
            DataTable dt = new DataTable();
            //Step 6: Execute query, fill datatable from dataadapter
            da.Fill(dt);
            //Step 7: Close connection
            conn.Close();
            return dt;
        }
    }
}
