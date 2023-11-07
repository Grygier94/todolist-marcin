using Assignment.Api.Persistence.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assignment.Api.Persistence
{
    public interface IAppDbContext
    {
        DbSet<TaskEntity> Tasks { get; set; }
    }

    public class AppDbContext : DbContext, IAppDbContext
    {
        public AppDbContext() : base() { }

        public DbSet<TaskEntity> Tasks { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}
