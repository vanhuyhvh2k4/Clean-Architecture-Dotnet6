
using Clean_Architecture_Dotnet6.Application.Commands;
using Clean_Architecture_Dotnet6.Application.Handlers;
using Clean_Architecture_Dotnet6.Application.Queries;
using Clean_Architecture_Dotnet6.Domain;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace Clean_Architecture_Dotnet6.Application
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IMovieService, MovieService>();

            services.AddTransient<IRequestHandler<GetMovieListQuery, List<Movie>>, GetMovieListHandler>();

            services.AddTransient<IRequestHandler<GetMovieByIdQuery, Movie>, GetMovieByIdHandler>();

            services.AddTransient<IRequestHandler<AddMovieCommand, Movie>, AddMovieHandler>();

            return services;
        }
    }
}
