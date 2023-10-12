
using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    ConfigurationManager config = builder.Configuration;

    //Connect Db
    builder.Services.AddDbContext<MovieDbContext>(options =>
        options.UseMySql(config.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(10, 4, 25)),
            b => b.MigrationsAssembly("Clean-Architecture-Dotnet6.API")));

    builder.Services.AddApplication()
                    .AddInfrastructure();
    // Add services to the container.
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}

