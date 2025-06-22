using Blog.Data.Repositories.Concretes;
using Blog.Data.Repositories.Abstractions;
using Blog.Data.UnitOfWorks;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;


namespace Blog.Data.Extensions;

public static class DataLayerExtensions
{
    public static IServiceCollection LoadDataLayerExtensions(this IServiceCollection services, IConfiguration config)
    {
        services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
        services.AddDbContext<AppDbContext>(opt=>opt.UseNpgsql((config.GetConnectionString("DefaultConnection"))));
        services.AddScoped<IUnitOfWork, UnitOfWork>();
        return services;

    }
    
    
}