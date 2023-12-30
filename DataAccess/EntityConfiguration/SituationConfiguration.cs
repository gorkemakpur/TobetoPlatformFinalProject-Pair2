using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class SituationConfiguration : IEntityTypeConfiguration<Situation>
{
    public void Configure(EntityTypeBuilder<Situation> builder)
    {
        builder.ToTable("Situations").HasKey(s => s.Id);

        builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
        builder.Property(s => s.Name).HasColumnName("Name").IsRequired();

        builder.HasMany(s => s.Educations);

        builder.HasQueryFilter(r => !r.DeletedDate.HasValue);
    }
}
