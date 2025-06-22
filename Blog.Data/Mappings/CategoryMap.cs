using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
namespace Blog.Data.Mappings;
using Blog.Entity.Entities;

public class CategoryMap: IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {

        builder.HasData(new Category
        {
            Id = Guid.Parse("3AA42229-1C0F-4630-8C1A-DB879ECD0427"),
            Name = "ASP.NET",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
        },new Category
        {
            Id = Guid.Parse("FD2060B6-A32F-46B6-94D4-A3AD14B6B372"),
            Name = "ASP.NET 2",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
          
        });
    }
    
}