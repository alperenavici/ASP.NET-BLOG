using Blog.Service.Services.Abstraction;
using Blog.Entity.Entities;
using Blog.Data.UnitOfWorks;


namespace Blog.Service.Services.Concrete;

public class ArticleService:IArticleService
{
    private readonly IUnitOfWork unitOfWork;
    
    public ArticleService(IUnitOfWork unitOfWork)
    {
        this.unitOfWork = unitOfWork;
        
    }
    
    public async Task<List<Article>> GetAllArticlesAsync()
    {
        return await unitOfWork.GetRepository<Article>().GetAllAsync();
    }
    
}