using BoundedContext.Domain.Somethings;
using Microsoft.EntityFrameworkCore;
using UnitOfWork.ESF_1;

namespace BoundedContext.Repository.Entityframework
{
    public class CommandDbContext : DbContext, IUnitOfWork
    {
        public CommandDbContext(DbContextOptions options) 
            : base(options)
        {
        }

        public DbSet<Something> Somethings { get; set; }

        public bool IsStarted => (base.Database.CurrentTransaction != null);

        public void Begin()
        {
            base.Database.BeginTransaction();
        }

        public void Commit()
        {
            base.SaveChanges();

            base.Database.CommitTransaction();
        }

        public void Rollback()
        {
            base.Database.RollbackTransaction();
        }

        public override void Dispose()
        {
            var connection = base.Database.GetDbConnection();

            connection.Close();
            connection.Dispose();

            base.Dispose();
        }
    }
}