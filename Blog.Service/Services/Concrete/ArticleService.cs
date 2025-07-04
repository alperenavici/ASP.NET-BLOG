using AutoMapper;
using Blog.Service.Services.Abstraction;
using Blog.Entity.Entities;
using Blog.Data.UnitOfWorks;
using Blog.Entity.DTOs.Articles;



namespace Blog.Service.Services.Concrete;

public class ArticleService:IArticleService
{
    private readonly IUnitOfWork unitOfWork;
    private readonly IMapper mapper;
    
    public ArticleService(IUnitOfWork unitOfWork,IMapper mapper)
    {
        this.unitOfWork = unitOfWork;
        this.mapper = mapper;

    }
    
    public async Task<List<ArticleDto>> GetAllArticlesAsync()
    {
        
        var articles=await unitOfWork.GetRepository<Article>().GetAllAsync();
        var map=mapper.Map<List<ArticleDto>>(articles);
        
        return map;
    }
    
}