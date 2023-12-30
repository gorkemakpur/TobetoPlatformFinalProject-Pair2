using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("Roles").HasKey(r => r.Id);

        builder.Property(r => r.Id).HasColumnName("Id").IsRequired();
        builder.Property(r => r.Type).HasColumnName("Type").IsRequired();

        builder.HasMany(r => r.Users);

        builder.HasQueryFilter(r => !r.DeletedDate.HasValue);
    }
}
