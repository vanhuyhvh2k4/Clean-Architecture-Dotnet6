
using Microsoft.Extensions.DependencyInjection;

namespace Clean_Architecture_Dotnet6.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();

            return services;
        }
    }
}
