using BoundedContext.Application.Service1;
using BoundedContext.Query.Entityframework;
using BoundedContext.Query.Query1;
using BoundedContext.Repository.Entityframework;
using BoundedContext.Services.Acls.SomethingServices;
using Composition.ESF_1;
using Interceptors.ESF_1;
using UnitOfWork.ESF_1;

namespace BoundedContext.Composition
{
    public static class CompositionRoot
    {
        public static void RegisterDependecies(IIocContainer container)
        {
            RegisterRepos(container);

            RegisterServices(container);

            RegisterApplications(container);

            RegisterQueries(container);

            RegisterDbContexts(container);
        }

        private static void RegisterDbContexts(IIocContainer container)
        {
            container.RegisterFactoryPerGraph(
                new[] { typeof(IUnitOfWork), typeof(CommandDbContext) },
                r =>
                {
                    var factory = new CommandDbContextFactory();

                    return factory.CreateDbContext(new string[0]);
                });

            container.RegisterFactoryPerGraph(
                new[] { typeof(QueryDbContext) },
                r =>
                {
                    var factory = new QueryDbContextFactory();

                    return factory.CreateDbContext(new string[0]);
                });
        }

        private static void RegisterQueries(IIocContainer container)
        {
            container.RegisterAllServicesPerGraph(typeof(Query1).Assembly);
        }

        private static void RegisterApplications(IIocContainer container)
        {
            container.RegisterAllServicesPerGraph(
                typeof(Service1).Assembly,
                new[] { typeof(UnitOfWorkInterceptor) });
        }

        private static void RegisterServices(IIocContainer container)
        {
            container.RegisterAllServicesPerGraph(typeof(SomeService).Assembly);
        }

        private static void RegisterRepos(IIocContainer container)
        {
            container.RegisterAllServicesPerGraph(typeof(CommandDbContext).Assembly);
        }
    }
}
