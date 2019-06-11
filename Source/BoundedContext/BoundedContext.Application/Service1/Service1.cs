using System;
using BoundedContext.Contracts.Command.Service1;
using BoundedContext.Contracts.Command.Service1.DTOs;

namespace BoundedContext.Application.Service1
{
    public class Service1 : IService1
    {
        public Guid RegisterSomething(SomethingRegistrationDto registerDto)
        {
            throw new NotImplementedException();
        }
    }
}