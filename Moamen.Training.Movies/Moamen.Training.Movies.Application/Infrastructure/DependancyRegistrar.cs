using Autofac;
using Moamen.Training.Movies.Application.Movies.Query;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moamen.Training.Movies.Application.Infrastructure
{
    public static class DependancyRegistrar
    {
        public static ContainerBuilder RegisterApplication(
            this ContainerBuilder container)
        {
            container.RegisterType<GetMoviesQuery>().As<IGetMoviesQuery>().InstancePerLifetimeScope();
            return container;
        }
    }
}
