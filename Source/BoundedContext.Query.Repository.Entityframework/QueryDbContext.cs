using BoundedContext.Query.Repository.Entityframework.Models.Somethings;
using Microsoft.EntityFrameworkCore;

namespace BoundedContext.Query.Repository.Entityframework
{
    public class QueryDbContext : DbContext
    {
        public QueryDbContext(DbContextOptions options) 
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(QueryDbContext).Assembly);
        }

        public DbSet<Something> Somethings { get; set; }

        public override void Dispose()
        {
            var connection = base.Database.GetDbConnection();

            connection.Close();
            connection.Dispose();

            base.Dispose();
        }
    }
}
