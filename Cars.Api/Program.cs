using Cars.Application.Interfaces;
using Cars.Data;
using Cars.Data.Storage;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
public class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        var connectionString = builder.Configuration.GetConnectionString("CarsDbContext");

        builder.Services.AddDbContext<CarsDbContext>(options =>
            options.UseNpgsql(connectionString));

        builder.Services.AddControllers();
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

        builder.Services.AddScoped<ICarsStorage, CarsStorage>();
        builder.Services.AddScoped<ICarsService, ICarsService>();


        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API V1");
                c.RoutePrefix = string.Empty; // Делает Swagger главной страницей
            });
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}