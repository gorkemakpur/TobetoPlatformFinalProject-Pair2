using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.EntityConfiguration
{
    public class CategoryConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            // Tablomuz
            builder.ToTable("Categories").HasKey(c => c.Id);

            // Sütunlar
            builder.Property(c => c.Id).HasColumnName("Id").IsRequired();
            builder.Property(c => c.Name).HasColumnName("Name").IsRequired();

            // İlişkiler
            builder.HasMany(c => c.SyncCourses)
                .WithOne(sc => sc.Category)
                .HasForeignKey(sc => sc.CategoryId);



            builder.HasMany(c => c.AsyncCourses)
                .WithOne(ac => ac.Category)
                .HasForeignKey(ac => ac.CategoryId);
                

            // Uniq Key
            builder.HasIndex(c => c.Name).IsUnique();

            builder.HasQueryFilter(c => !c.DeletedDate.HasValue);
        }
    }
}