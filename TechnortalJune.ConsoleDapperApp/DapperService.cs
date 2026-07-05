using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalJune.ConsoleDapperApp
{
    internal class DapperService
    {
        private readonly SqlConnectionStringBuilder sb;
        public DapperService(){
            sb = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "June2026",
                UserID = "sa",
                Password = "ZwehtetZ@18",
                TrustServerCertificate = true
            };
        }
        public void Read()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString)) {
                db.Open();
                List<Student> lst = db.Query<Student>(@"SELECT * FROM [dbo].[Student]").ToList();
                foreach(var item in lst) {
                    Console.WriteLine($"id:{item.StudentId},Name:{item.StudentName},IsDelete:{item.IsDelete}");
                }
            }
        }
        public void Create()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result=db.Execute(@"INSERT INTO [dbo].[Student]
([StudentName], [FatherName], [StudentNo], [Email], [DateOfBirth], [MobileNo], [IsDelete])
VALUES
('Daniel Foster', 'Samuel Foster', 'STU011', 'daniel.foster@email.com', '2002-06-22', '0911111121', 0),
('Chloe Morgan', 'Henry Morgan', 'STU012', 'chloe.morgan@email.com', '2003-11-17', '0911111122', 0);");
                Console.WriteLine($"{result} rows affected");
            }
        }
        public void Update() {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute(@"UPDATE [dbo].[Student]
SET Email = 'updated.email1@email.com',
    MobileNo = '0922222221'
WHERE StudentNo IN ('STU011');");
                Console.WriteLine($"{result} rows affected");
            }
        }
        public void Delete()
        {
            using (IDbConnection db = new SqlConnection(sb.ConnectionString))
            {
                db.Open();
                int result = db.Execute(@"DELETE FROM [dbo].[Student]
WHERE Studentid=12;");
                Console.WriteLine($"{result} rows affected");
            }
        }
    public class Student()
        {
            public int StudentId { get; set; }
            public string StudentName { get; set; }
            public string FatherName { get; set; }
            public string StudentNo { get; set; }
            public string Email { get; set; }
            public DateTime DateOfBirth { get; set; }
            public string MobileNo { get; set; }
            public bool IsDelete { get; set; }

        }
    }}

