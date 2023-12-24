using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class ExperienceConfiguration : IEntityTypeConfiguration<Experience>
{
    public void Configure(EntityTypeBuilder<Experience> builder)
    {
        //Tablomuz
        builder.ToTable("Experiences").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.CompanyName).HasColumnName("CompanyName").IsRequired();
        builder.Property(i => i.Position).HasColumnName("Position").IsRequired();
        builder.Property(i => i.Sector).HasColumnName("Sector").IsRequired();
        builder.Property(i => i.StartedDate).HasColumnName("StartedDate").IsRequired();
        builder.Property(i => i.EndedDate).HasColumnName("EndedDate").IsRequired();
        builder.Property(i => i.JobDescription).HasColumnName("JobDescription").IsRequired();
        builder.Property(i => i.City).HasColumnName("City").IsRequired();
        builder.Property(i => i.IsContinue).HasColumnName("IsContinue").IsRequired();
        //İlişki
        builder.HasOne(i => i.Student);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}