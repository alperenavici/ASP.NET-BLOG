using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.Entity.Entities;



namespace Blog.Data.Mappings;

public class ArticleMap:IEntityTypeConfiguration<Article>
{
    public void Configure(EntityTypeBuilder<Article> builder)
    {
        
        builder.HasData(
            new Article
            {
                Id = Guid.Parse("A1B2C3D4-E5F6-7890-ABCD-EF1234567890"),
                Title = "Asp.NET Core Core Deneme Makalesi 1",
                Content = "Asp.NET Core Core Deneme İçerik 1",
                ViewCount = 2,
                CategoryId = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
                ImageId = Guid.Parse("0D804AE8-17D6-470E-966D-3D82C4F46662"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
            },
            new Article
            {
                Id = Guid.Parse("B1C2D3E4-F5A6-7890-BCDE-EF1234567890"),
                Title = "Asp.NET Core Core Deneme Makalesi 2",
                Content = "Asp.NET Core Core Deneme İçerik 2",
                ViewCount = 24,
                CategoryId = Guid.Parse("FD2060B6-A32F-46B6-94D4-A3AD14B6B372"),
                ImageId = Guid.Parse("840A754B-F051-45F3-90C5-61D1E249D5A5"),
                CreatedBy = "Admin test",
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
            });
    }
    
    
}