using JobSeek.Api.Models.Entities;
using Microsoft.EntityFrameworkCore;

namespace JobSeek.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options) { }

        public DbSet<JobCategory> JobCategories { get; set; }
    }
}
