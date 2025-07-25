using Microsoft.EntityFrameworkCore;
using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
namespace Blog.Data.Mappings;


public class UserClaimMap:IEntityTypeConfiguration<AppUserClaim>
{
    public void Configure(EntityTypeBuilder<AppUserClaim> builder)
    {
        // Primary key
        builder.HasKey(uc => uc.Id);

        // Maps to the AspNetUserClaims table
        builder.ToTable("AspNetUserClaims");
    }
    
}

