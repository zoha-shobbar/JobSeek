using JobSeek.Api.Models;
using JobSeek.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobSeek.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            foreach (var relationship in modelBuilder.Model.GetEntityTypes().SelectMany(e => e.GetForeignKeys()))
            {
                relationship.DeleteBehavior = DeleteBehavior.Restrict;
            }
        }

        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<User> users { get; set; }
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobEmployee> JobEmployees { get; set; }
        public DbSet<JobSeek.Api.Models.Entities.Employer>? Employer { get; set; }
     
    }
}
