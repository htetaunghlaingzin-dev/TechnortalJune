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
    internal class LoginService
    {
        private readonly SqlConnectionStringBuilder _sqlcb;
        public LoginService()
        {
            _sqlcb = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "June2026",
                UserID = "sa",
                Password = "ZwehtetZ@18",
                TrustServerCertificate = true
            };
        }
        public void Login(string username, string password)
        {
            using (IDbConnection db = new SqlConnection(_sqlcb.ConnectionString))
            {
                db.Open();
                var query = db.Query($"SELECT * FROM [User] WHERE Username = @Username AND Password = @Password", new 
                { 
                    Username = username, 
                    Password = password 
                }
                ).FirstOrDefault();
                if (query != null)
                {
                    Console.WriteLine("Login successful!");
                }
                else
                {
                    Console.WriteLine("Login failed?");

                }
            }
        }
    }
}
