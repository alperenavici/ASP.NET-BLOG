using Blog.Entity.Entities;
using Microsoft.Extensions.DependencyInjection;
using Blog.Service.Services.Abstraction;
using Blog.Service.Services.Concrete;

namespace Blog.Service.Extensions;


public static class ServiceLayerExtensions
{
    
    public static IServiceCollection LoadServiceLayerExtension(this IServiceCollection services) 
    {
        services.AddScoped<IArticleService, ArticleService>();
        return services;
    }
    
}