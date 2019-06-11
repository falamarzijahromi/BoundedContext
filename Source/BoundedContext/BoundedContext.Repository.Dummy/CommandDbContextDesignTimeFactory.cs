using BoundedContext.Repository.Entityframework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace BoundedContext.Repository.Migration
{
    public class CommandDbContextDesignTimeFactory : IDesignTimeDbContextFactory<CommandDbContext>
    {
        public CommandDbContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<CommandDbContext>();

            optionsBuilder.UseSqlServer(@"Server=.;Database=BoundedContext;Trusted_Connection=True;");

            return new CommandDbContext(optionsBuilder.Options);
        }
    }
}
