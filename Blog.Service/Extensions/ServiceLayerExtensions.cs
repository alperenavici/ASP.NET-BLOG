using System.Reflection;
using Microsoft.Extensions.DependencyInjection;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;

namespace Blog.Service.Extensions;


public static class ServiceLayerExtensions
{
    
    public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services)
    {
        var assembly = Assembly.GetExecutingAssembly();
        services.AddScoped<IArticleService, ArticleService>();
        services.AddAutoMapper(assembly);
        return services;
    }
    
}