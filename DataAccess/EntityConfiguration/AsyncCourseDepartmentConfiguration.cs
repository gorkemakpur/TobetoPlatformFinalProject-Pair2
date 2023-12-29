using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.EntityConfiguration
{
    public class AsyncCourseDepartmentConfiguration : IEntityTypeConfiguration<AsyncCourseDepartment>
    {
        public void Configure(EntityTypeBuilder<AsyncCourseDepartment> builder)
        {
            // Tablomuz
            builder.ToTable("AsyncCourseDepartments").HasKey(acd => acd.Id);

            // Sütunlar
            builder.Property(acd => acd.Id).HasColumnName("Id").IsRequired();
            builder.Property(acd => acd.DepartmentId).HasColumnName("DepartmentId").IsRequired();
            builder.Property(acd => acd.AsyncCourseId).HasColumnName("AsyncCourseId").IsRequired();
            builder.Property(acd => acd.StartedDate).HasColumnName("StartedDate").IsRequired();
            builder.Property(acd => acd.EndedDate).HasColumnName("EndedDate").IsRequired();

            // Uniq Key(bakılacak)
           // builder.HasIndex(indexExpression: acd => new { acd.DepartmentId, acd.AsyncCourseId }, name: "UK_AsyncCourseDepartments_DepartmentId_AsyncCourseId").IsUnique();

            // İlişki
            builder.HasOne(acd => acd.AsyncCourse)
                .WithMany(ac => ac.AsyncCourseDepartments)
                .HasForeignKey(acd => acd.AsyncCourseId);


            builder.HasOne(acd => acd.Department)
                .WithMany(d => d.AsyncCourseDepartments)
                .HasForeignKey(acd => acd.DepartmentId);
                

            builder.HasQueryFilter(acd => !acd.DeletedDate.HasValue);
        }
    }
}