using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Blog.Entity.Entities;

namespace Blog.Data.Mappings;

public class ImageMap:IEntityTypeConfiguration<Image>
{
    public void Configure(EntityTypeBuilder<Image> builder)
    {
        builder.HasData(new Image
        {
                Id=Guid.Parse("0D804AE8-17D6-470E-966D-3D82C4F46662"),
                fileName = "images/testimage",
                FileType = "jpg",
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.UtcNow,
                IsDeleted = false
                
        }, new Image
        {
            Id=Guid.Parse("840A754B-F051-45F3-90C5-61D1E249D5A5"),
            fileName = "images/testimage",
            FileType = "jpg",
            CreatedBy = "Admin Test",
            CreatedDate = DateTime.UtcNow,
            IsDeleted = false
            
        });
    }
    
    
}