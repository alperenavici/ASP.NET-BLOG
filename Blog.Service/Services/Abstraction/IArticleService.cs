using Blog.Entity.Entities;
namespace Blog.Service.Services.Abstraction;

public interface IArticleService
{
    Task<List<Article>> GetAllArticlesAsync();
}