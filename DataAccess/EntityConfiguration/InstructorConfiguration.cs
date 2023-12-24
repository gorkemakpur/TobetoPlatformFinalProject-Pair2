using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            //Tablomuz
            builder.ToTable("Instructors").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.UserId).HasColumnName("UserId").IsRequired();

            //İlişki
            builder.HasMany(i => i.SyncCourseInstructors);
            builder.HasOne(i => i.Users);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 


        }
    }
}
