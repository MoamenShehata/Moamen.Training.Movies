using Autofac;
using AutoMapper.Contrib.Autofac.DependencyInjection;
using Moamen.Training.Movies.Application.Infrastructure;
using Moamen.Training.Movies.Persistance.Infrastructure;

namespace Moamen.Training.Movies.API.Infrastrcuture
{
    public static class DependancyRegistrar
    {
        public static ContainerBuilder RegisterDependancies(
            this ContainerBuilder container,
            string connectionString)
        {
            container
                    .RegisterApplication()
                    .RegisterPersistance(connectionString)
                    .RegisterAutoMapper(typeof(Program).Assembly);
            return container;
        }
    }
}
