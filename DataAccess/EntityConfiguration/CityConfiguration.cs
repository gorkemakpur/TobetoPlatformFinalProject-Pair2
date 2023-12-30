using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.EntityConfiguration
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            // Tablomuz
            builder.ToTable("Cities").HasKey(city => city.Id);

            // Sütunlar
            builder.Property(city => city.Id).HasColumnName("Id").IsRequired();
            builder.Property(city => city.Name).HasColumnName("Name").IsRequired();

            // İlişki
            builder.HasMany(city => city.Districts);
                

            // Uniq Key
            builder.HasIndex(city => city.Name).IsUnique();

            builder.HasQueryFilter(city => !city.DeletedDate.HasValue);
        }
    }
}