using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class CompetenceConfiguration :  IEntityTypeConfiguration<Competence>
{
    public void Configure(EntityTypeBuilder<Competence> builder)
    {
        //Tablomuz
        builder.ToTable("Competences").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.StudentId).HasColumnName("StudentId").IsRequired();
        builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
        //İlişki
        builder.HasOne(i => i.Student);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}