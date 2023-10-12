
using Clean_Architecture_Dotnet6.Application;
using Microsoft.Extensions.DependencyInjection;
using System.Runtime.CompilerServices;

namespace Clean_Architecture_Dotnet6.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IMovieRepository, MovieRepository>();

            return services;
        }
    }
}
