using Microsoft.EntityFrameworkCore;
using TwoArgumentsProj.Data.Models;

namespace TwoArgumentsProj.Data.DbContexts
{
    public class ArgumentDbContext : DbContext
    {

        public DbSet<ArgumentResult> ArgumentResults { get; set; }
        public ArgumentDbContext(DbContextOptions<ArgumentDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

        }
    }
}
