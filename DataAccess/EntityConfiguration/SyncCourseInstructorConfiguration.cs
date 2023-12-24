using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class SyncCourseInstructorConfiguration : IEntityTypeConfiguration<SyncCourseInstructor>
{
    public void Configure(EntityTypeBuilder<SyncCourseInstructor> builder)
    {
        builder.ToTable("SyncCourseInstructors").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.SyncCourseContentId).HasColumnName("SyncCourseContentId").IsRequired();
        builder.Property(i => i.InstructorId).HasColumnName("InstructorId").IsRequired();
        //İlişki
        builder.HasOne(i => i.SyncCourseContent);
        builder.HasOne(i => i.Instructor);

        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}