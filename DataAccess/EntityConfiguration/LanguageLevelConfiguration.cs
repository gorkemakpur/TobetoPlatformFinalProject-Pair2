using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class LanguageLevelConfiguration : IEntityTypeConfiguration<LanguageLevel>
{
    public void Configure(EntityTypeBuilder<LanguageLevel> builder)
    {
        //Tablomuz
        builder.ToTable("LanguageLevels").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
        //İlişki
        builder.HasMany(i => i.Languages);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}