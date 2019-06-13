using System.Collections.Generic;
using System.Linq;
using BoundedContext.Contracts.Query.Query1;
using BoundedContext.Contracts.Query.Query1.DTOs;
using BoundedContext.Query.Entityframework;

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
            var somethingDtos =
                from something in _dbContext.Somethings
                select new SomethingDto
                {
                    Name = something.Name,
                    Id = something.Id,
                };

            return somethingDtos.ToList();
        }
    }
}