using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalJune.ConsoleApp
{
    internal class AdoDotNetService
    {
        public void Read()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "ZwehtetZ@18";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection String: " + sb.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection Opened");
            String query = @"SELECT [StudentId]
      ,[StudentName]
      ,[FatherName]
      ,[StudentNo]
      ,[Email]
      ,[DateOfBirth]
      ,[MobileNo]
      ,[IsDelete]
  FROM [dbo].[Student]
";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Closed");

            foreach (DataRow item in dt.Rows)
            {
                {
                    Console.WriteLine(item["StudentId"]);
                    Console.WriteLine(item["StudentName"]);
                    Console.WriteLine(item["FatherName"]);
                    Console.WriteLine(item["StudentNo"]);
                    Console.WriteLine(item["Email"]);
                    Console.WriteLine(item["DateOfBirth"]);
                    //Dateofbirth change chin dr myo atwt
                    DateTime dob = Convert.ToDateTime(item["DateOfBirth"]);
                    Console.WriteLine(dob.ToString("dd/MM/yyyy"));
                }
            }
        }
        public void Create()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "ZwehtetZ@18";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection String: " + sb.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection Opened");
            String query = @"INSERT INTO [dbo].[Student]
           ([StudentName]
           ,[FatherName]
           ,[StudentNo]
           ,[Email]
           ,[DateOfBirth]
           ,[MobileNo]
           ,[IsDelete])
VALUES
           ('Sophia Turner',
            'David Turner',
            'STU020',
            'sophia.turner@email.com',
            '2004-02-18',
            '0923456781',
            0);
";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Closed");
        }
        public void Update()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "ZwehtetZ@18";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection String: " + sb.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection Opened");
            String query = @"UPDATE [dbo].[Student]
SET
    StudentName = 'Sophia Adams',
    FatherName = 'David Adams',
    Email = 'sophia.adams@email.com',
    MobileNo = '0934567890'
WHERE StudentNo = 'STU020';
";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Closed");
        }
        public void Delete()
        {
            SqlConnectionStringBuilder sb = new SqlConnectionStringBuilder();
            sb.DataSource = ".";
            sb.InitialCatalog = "June2026";
            sb.UserID = "sa";
            sb.Password = "ZwehtetZ@18";
            sb.TrustServerCertificate = true;

            SqlConnection connection = new SqlConnection(sb.ConnectionString);
            Console.WriteLine("Connection String: " + sb.ConnectionString);
            Console.WriteLine("Connection opening...");
            connection.Open();
            Console.WriteLine("Connection Opened");
            String query = @"DELETE FROM [dbo].[Student]
      WHERE StudentNo='STU015';
";
            SqlCommand command = new SqlCommand(query, connection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            connection.Close();
            Console.WriteLine("Connection Closed");
        }
    }
}
