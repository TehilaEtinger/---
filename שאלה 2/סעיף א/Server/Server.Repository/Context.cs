using Microsoft.EntityFrameworkCore;
using Repository.Interfaces;
using Server.Repository.Entities;

namespace Server.Repository
{
    public class Context : DbContext, IDataSource
    {
        public DbSet<Patient> Patients { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source =localhost; Initial Catalog = CoronaManagement; Integrated Security = True; TrustServerCertificate =True ");
            optionsBuilder.UseLazyLoadingProxies(true).UseSqlServer(@"Data Source =localhost; Initial Catalog = CoronaManagement; Integrated Security = True; TrustServerCertificate =True ");
        }
    }
}