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
    public class AsyncCourseContentConfiguration : IEntityTypeConfiguration<AsyncCourseContent>
    {
        public void Configure(EntityTypeBuilder<AsyncCourseContent> builder)
        {
            //Tablo
            builder.ToTable("AsyncCourseContents").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.AsyncCourseId).HasColumnName("AsyncCourseId").IsRequired();
            builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
            builder.Property(i => i.Url).HasColumnName("Url").IsRequired();
            builder.Property(i => i.Language).HasColumnName("Language").IsRequired();
            builder.Property(i => i.Category).HasColumnName("Category").IsRequired();
            builder.Property(i => i.Subtype).HasColumnName("Subtype").IsRequired();
            builder.Property(i => i.Producer).HasColumnName("Producer").IsRequired();
            builder.Property(i => i.Description).HasColumnName("Description").IsRequired();

            //İlişki
            builder.HasOne(i => i.AsyncCourse);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
