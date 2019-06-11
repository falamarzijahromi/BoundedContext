using System.Collections.Generic;
using BoundedContext.Contracts.Query.Query1;
using BoundedContext.Contracts.Query.Query1.DTOs;
using BoundedContext.Query.Repository.Entityframework;

namespace BoundedContext.Query.Query1
{
    public class Query1 : IQuery1
    {
        private readonly QueryDbContext _dbContext;

        public Query1(QueryDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<SomethingDto> GetSomethings()
        {
            throw new System.NotImplementedException();
        }
    }
}