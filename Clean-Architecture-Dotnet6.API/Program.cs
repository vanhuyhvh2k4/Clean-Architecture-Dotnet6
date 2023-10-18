
using Clean_Architecture_Dotnet6.Application;
using Clean_Architecture_Dotnet6.Infrastructure;
using MediatR;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
{
    ConfigurationManager config = builder.Configuration;

    // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
    builder.Services.AddEndpointsApiExplorer();
    builder.Services.AddSwaggerGen();

    //Connect Db
    builder.Services.AddDbContext<MovieDbContext>(options =>
        options.UseMySql(config.GetConnectionString("DefaultConnection"),
            new MySqlServerVersion(new Version(10, 4, 25)),
            b => b.MigrationsAssembly("Clean-Architecture-Dotnet6.API")));

    builder.Services.AddApplication()
                    .AddInfrastructure();

    builder.Services.AddMediatR(typeof(MovieRepository).Assembly);
    // Add services to the container.
    builder.Services.AddControllers();
}

var app = builder.Build();
{
    // Configure the HTTP request pipeline.
    if (app.Environment.IsDevelopment())
    {
        app.UseSwagger();
        app.UseSwaggerUI();
    }


    app.UseHttpsRedirection();

    app.MapControllers();

    app.Run();
}

