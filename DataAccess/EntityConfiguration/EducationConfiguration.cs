using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class EducationConfiguration : IEntityTypeConfiguration<Education>
{
    public void Configure(EntityTypeBuilder<Education> builder)
    {
        //Tablomuz
        builder.ToTable("Educations").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.StudentId).HasColumnName("StudentId").IsRequired();
        builder.Property(i => i.SituationId).HasColumnName("SituationId").IsRequired();
        builder.Property(i => i.University).HasColumnName("University").IsRequired();
        builder.Property(i => i.Department).HasColumnName("Department").IsRequired();
        builder.Property(i => i.StartedDate).HasColumnName("StartedDate").IsRequired();
        builder.Property(i => i.EndedDate).HasColumnName("EndedDate").IsRequired();
        builder.Property(i => i.IsContinue).HasColumnName("IsContinue").IsRequired();
        //İlişki
        builder.HasOne(i => i.Student);
        builder.HasOne(i => i.Situation);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}