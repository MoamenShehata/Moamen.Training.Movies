using Autofac;
using Moamen.Training.Movies.Application.Common;
using Moamen.Training.Movies.Domain.Movies;
using Moamen.Training.Movies.Persistance.Movies;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Persistance.Infrastructure
{
    public static class DependancyRegistrar
    {
        public static ContainerBuilder RegisterPersistance(
            this ContainerBuilder container,
            string connectionstring)
        {
            container.RegisterType<MoviesRepository>().As<IRepository<Movie>>().InstancePerLifetimeScope();
            container.RegisterType<MoviesDataContext>()
                .AsSelf()
                .WithParameter(new NamedParameter("connectionString", connectionstring));
            return container;
        }
    }
}
