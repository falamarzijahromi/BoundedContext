using System.Collections.Generic;
using BoundedContext.Contracts.Query.Query1.DTOs;

namespace BoundedContext.Contracts.Query.Query1
{
    public interface IQuery1
    {
        List<SomethingDto> GetSomethings();
    }
}