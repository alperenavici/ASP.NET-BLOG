using AutoMapper;
using Blog.Entity.DTOs.Articles;
using Blog.Entity.Entities;

namespace Blog.Service.AutoMapper.Artices;

public class ArticleProfile:Profile
{
    public ArticleProfile()
    {
        CreateMap<Article, ArticleDto>().ReverseMap();
        
    }
    
}