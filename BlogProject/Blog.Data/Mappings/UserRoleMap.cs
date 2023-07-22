using Blog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Blog.Data.Mappings
{
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");
            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("F34456B2-2DEF-4B91-805E-24FB21544602"),
                RoleId = Guid.Parse("14054160-3E27-4936-A8E2-E17494D45225")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("B1FB55DF-2930-4211-A479-DFE0D5297675"),
                RoleId = Guid.Parse("64D9ECBD-5026-42A1-8518-A1482AD67684")
            });
        }
    }
}
