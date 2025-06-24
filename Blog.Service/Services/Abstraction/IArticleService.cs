using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;
namespace Blog.Service.Services.Abstraction;

public interface IArticleService
{
    Task<List<ArticleDto>> GetAllArticlesAsync();
}