using BoundedContext.Domain.Somethings;
using Microsoft.EntityFrameworkCore;

namespace BoundedContext.Repository.Entityframework
{
    public class CommandDbContext : DbContext
    {
        public CommandDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Something> Somethings { get; set; }
    }
}