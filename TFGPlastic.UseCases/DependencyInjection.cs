using Microsoft.Extensions.DependencyInjection;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;

namespace TFGPlastic.UseCases
{
    public static class DependencyInjection
    {
        public static IServiceCollection RegisterUseCases(this IServiceCollection services)
        {
            services.AddMediatR(cfg =>
            {
                cfg.RegisterServicesFromAssemblyContaining(typeof(DependencyInjection));
            });

            services.AddDbContext<TFGPlasticDbContext>(ServiceLifetime.Singleton);
            
            return services;
        }
    }
}
