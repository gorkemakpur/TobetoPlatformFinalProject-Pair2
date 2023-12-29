using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.ToTable("Students").HasKey(s => s.Id);
        builder.Property(s => s.Id).HasColumnName("Id").IsRequired();
        builder.Property(s => s.DepartmentId).HasColumnName("DepartmentId").IsRequired();
        builder.Property(s => s.UserId).HasColumnName("UserId").IsRequired();

        builder.HasMany(s => s.Applications);
        builder.HasMany(s => s.Languages);
        builder.HasMany(s => s.Certificates);
        builder.HasMany(s => s.Experiences);
        builder.HasMany(s => s.Competences);
        builder.HasMany(s => s.Educations);
        builder.HasMany(s => s.SocialMedias);

        builder.HasOne(s => s.User);
        builder.HasOne(s => s.Department);

        builder.HasQueryFilter(s => !s.DeletedDate.HasValue);
    }
}
