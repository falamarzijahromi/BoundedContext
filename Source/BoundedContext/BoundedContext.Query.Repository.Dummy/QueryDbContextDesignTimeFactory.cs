using BoundedContext.Query.Repository.Entityframework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BoundedContext.Query.Repository.Migration
{
    public class QueryDbContextDesignTimeFactory : IDesignTimeDbContextFactory<QueryDbContext>
    {
        public QueryDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<QueryDbContext>();

            optionsBuilder.UseSqlServer(@"Server=.;Database=BoundedContext;Trusted_Connection=True;");

            return new QueryDbContext(optionsBuilder.Options);
        }
    }
}