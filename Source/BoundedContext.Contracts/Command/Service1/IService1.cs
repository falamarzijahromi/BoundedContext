using BoundedContext.Contracts.Command.Service1.DTOs;
using System;

namespace BoundedContext.Contracts.Command.Service1
{
    public interface IService1
    {
        Guid RegisterSomething(SomethingRegistrationDto registerDto);
    }
}