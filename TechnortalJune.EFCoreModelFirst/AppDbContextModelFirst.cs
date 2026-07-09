using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnortalJune.EFCoreModelFirst
{
    public class AppDbContextModelFirst : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
             SqlConnectionStringBuilder _sb = new SqlConnectionStringBuilder()
            {
                DataSource = ".",
                InitialCatalog = "June2026",
                UserID = "sa",
                Password = "ZwehtetZ@18",
                TrustServerCertificate = true
            };
            optionsBuilder.UseSqlServer(_sb.ConnectionString);
        }
        public DbSet<StaffEntity> Staffs { get; set; }
    }
}
