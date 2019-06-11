using System;
using BoundedContext.Contracts.Command.Service1;
using BoundedContext.Contracts.Command.Service1.DTOs;
using BoundedContext.Domain.Somethings;
using BoundedContext.Domain.Somethings.Repository;

namespace BoundedContext.Application.Service1
{
    public class Service1 : IService1
    {
        private readonly ISomethingRepository _somethingRepository;

        public Service1(ISomethingRepository somethingRepository)
        {
            _somethingRepository = somethingRepository;
        }

        public Guid RegisterSomething(SomethingRegistrationDto registerDto)
        {
            var something = new Something
            {
                Name = registerDto.Name,
            };

            _somethingRepository.CreateSomething(something);

            return something.Id;
        }
    }
}