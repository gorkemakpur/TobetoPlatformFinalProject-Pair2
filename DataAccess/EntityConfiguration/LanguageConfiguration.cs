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

        builder.HasOne(l => l.Student)
           .WithMany(s => s.Languages)
           .HasForeignKey(l => l.StudentId);
        builder.HasOne(l => l.LanguageType)
           .WithMany(lt => lt.Languages)
           .HasForeignKey(l => l.LanguageTypeId);
        builder.HasOne(l => l.LanguageLevel)
           .WithMany(ll => ll.Languages)
           .HasForeignKey(l => l.LanguageLevelId);

        builder.HasQueryFilter(l => !l.DeletedDate.HasValue);
    }
}
