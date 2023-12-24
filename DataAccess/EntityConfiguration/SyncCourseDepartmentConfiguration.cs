using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class SyncCourseDepartmentConfiguration : IEntityTypeConfiguration<SyncCourseDepartment>
{
    public void Configure(EntityTypeBuilder<SyncCourseDepartment> builder)
    {
        builder.ToTable("SyncCourseDepartments").HasKey(x => x.Id);
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.DepartmentId).HasColumnName("DepartmentId").IsRequired();
        builder.Property(i => i.SyncCourseId).HasColumnName("SyncCourseId").IsRequired();
        builder.Property(i => i.StartedDate).HasColumnName("StartedDate").IsRequired();
        builder.Property(i => i.EndedDate).HasColumnName("EndedDate").IsRequired();
        
        //İlişki
        builder.HasOne(i => i.Department);
        builder.HasOne(i => i.SyncCourse);

        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}