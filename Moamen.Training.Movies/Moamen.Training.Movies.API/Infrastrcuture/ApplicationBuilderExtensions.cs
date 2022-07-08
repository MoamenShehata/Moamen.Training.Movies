using Autofac;
using Autofac.Extensions.DependencyInjection;

namespace Moamen.Training.Movies.API.Infrastrcuture
{
    public static class ApplicationBuilderExtensions
    {
        public static void UseAutofacServiceProvider(this WebApplicationBuilder builder)
        {
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
        }

        public static void RegisterComponents(
            this WebApplicationBuilder builder,
            string connectionString)
        {
            builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
            {
                builder.RegisterDependancies(connectionString);
            });
        }


    }
}
