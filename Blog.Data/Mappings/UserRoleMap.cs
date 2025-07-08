using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings;

public class UserRoleMap:IEntityTypeConfiguration<AppUserRole>
{
    public void Configure(EntityTypeBuilder<AppUserRole> builder)
    {
        // Primary key
        builder.HasKey(r => new { r.UserId, r.RoleId });

        // Maps to the AspNetUserRoles table
        builder.ToTable("AspNetUserRoles");

        builder.HasData(new AppUserRole
        {
            UserId = Guid.Parse("8B72F6EE-8423-4B3F-B323-24B405CF6514"),
            RoleId = Guid.Parse("1C1FEF4F-DFE2-4420-BD38-B38C014A9531"),
            

        },new AppUserRole
        {
            UserId = Guid.Parse("FFFB1403-E7D7-4C8B-858E-25BCB97D7E47"),
            RoleId = Guid.Parse("97AD219E-93C8-4015-8679-2FF4BD481E04")
        });
    }
}