
using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Infrastructure;

var builder = WebApplication.CreateBuilder(args);
{
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

