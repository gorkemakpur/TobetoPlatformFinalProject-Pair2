using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class LanguageConfiguration : IEntityTypeConfiguration<Language>
{
    public void Configure(EntityTypeBuilder<Language> builder)
    {
        builder.ToTable("Languages").HasKey(l => l.Id);
        builder.Property(l => l.Id).HasColumnName("Id").IsRequired();
        builder.Property(l => l.StudentId).HasColumnName("StudentId").IsRequired();
        builder.Property(l => l.LanguageTypeId).HasColumnName("LanguageTypeId").IsRequired();
        builder.Property(l => l.LanguageLevelId).HasColumnName("LanguageLevelId").IsRequired();
        //bu kısma bakılacak!
        builder.HasOne(l => l.Student);
        builder.HasOne(l => l.LanguageType);
        builder.HasOne(l => l.LanguageLevel);

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
    }
}
