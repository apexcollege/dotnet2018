using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ecommerce.data
{
    public class AttendanceDbHelper
    {
        private static string connectionString =
            "Server=(localdb)\\MSSqlLocalDb;Integrated Security=True;Initial Catalog=ecommercedb;";

        public bool Insert(Attendance a)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "INSERT INTO Attendance (StudentId, AttendanceDate," +
                "IsPresent,Remarks) VALUES (@StudentId, @AttendanceDate," +
                "@IsPresent,@Remarks)";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@StudentId", a.StudentId);
            cmd.Parameters.AddWithValue("@AttendanceDate", a.AttendanceDate);
            cmd.Parameters.AddWithValue("@IsPresent", a.IsPresent);
            cmd.Parameters.AddWithValue("@Remarks", a.Remarks);
            //Step 3: open connection
            conn.Open();
            //Step 4: Execute query
            cmd.ExecuteNonQuery();
            //Step 5: Close connection
            conn.Close();
            return true;
        }

        public bool Update(Attendance a)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "UPDATE Attendance SET StudentId=@StudentId," +
                "AttendanceDate=@AttendanceDate," +
                "IsPresent=@IsPresent," +
                "Remarks=@Remarks WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@StudentId", a.StudentId);
            cmd.Parameters.AddWithValue("@AttendanceDate", a.AttendanceDate);
            cmd.Parameters.AddWithValue("@IsPresent", a.IsPresent);
            cmd.Parameters.AddWithValue("@Remarks", a.Remarks);
            cmd.Parameters.AddWithValue("@Id", a.Id);
            //Step 3: open connection
            conn.Open();
            //Step 4: Execute query
            cmd.ExecuteNonQuery();
            //Step 5: Close connection
            conn.Close();
            return true;
        }

        public bool Delete(Attendance a)
        {
            //step 1: initialize connection
            SqlConnection conn = new SqlConnection(connectionString);
            //Step 2: instantiate sqlcommand, query
            string query = "DELETE FROM Attendance WHERE Id=@Id";
            SqlCommand cmd = new SqlCommand(query, conn);
            //pass value to each parameters of sql query
            cmd.Parameters.AddWithValue("@Id", a.Id);
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
            string query = "SELECT Id,StudentId,AttendanceDate,IsPresent,Remarks" +
                " FROM Attendance";
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
