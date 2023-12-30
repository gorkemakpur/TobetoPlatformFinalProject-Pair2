using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.EntityConfiguration
{
    public class AsyncCourseConfiguration : IEntityTypeConfiguration<AsyncCourse>
    {
        public void Configure(EntityTypeBuilder<AsyncCourse> builder)
        {
            //Tablo
            builder.ToTable("AsyncCourses").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.CategoryId).HasColumnName("CategoryId").IsRequired();
            builder.Property(i => i.Name).HasColumnName("Name").IsRequired();

            //İlişki
            builder.HasOne(i => i.Category);

            builder.HasMany(i => i.AsyncCourseContents);
            builder.HasMany(i => i.AsyncCourseDepartments);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
