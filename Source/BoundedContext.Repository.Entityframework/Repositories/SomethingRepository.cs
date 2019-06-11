using BoundedContext.Domain.Somethings;
using BoundedContext.Domain.Somethings.Repository;

namespace BoundedContext.Repository.Entityframework.Repositories
{
    public class SomethingRepository : ISomethingRepository
    {
        private readonly CommandDbContext _dbContext;

        public SomethingRepository(CommandDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void CreateSomething(Something something)
        {
            _dbContext.Somethings.Add(something);
        }
    }
}