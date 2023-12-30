using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using TFGPlastic.Core.Entity;
using TFGPlastic.Infrastructure.DataBase;

namespace TFGPlastic.Infrastructure
{

    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services)
        {
            // Configura la base de datos en memoria
            return services;
        }
    }
}

