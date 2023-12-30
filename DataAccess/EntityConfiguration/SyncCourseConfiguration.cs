using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class SyncCourseConfiguration : IEntityTypeConfiguration<SyncCourse>
    {
        public void Configure(EntityTypeBuilder<SyncCourse> builder)
        {
            //Tablo
            builder.ToTable("SyncCourses").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
            builder.Property(i => i.Title).HasColumnName("Title").IsRequired();
            builder.Property(i => i.Language).HasColumnName("Language").IsRequired();
            builder.Property(i => i.Subtype).HasColumnName("Subtype").IsRequired();


            //İlişki
            builder.HasOne(i => i.Category);

            builder.HasMany(i => i.SyncCourses);
            builder.HasMany(i => i.SyncCourseContents);



            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
