using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class DistrictConfiguration : IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        //Tablomuz
        builder.ToTable("Districts").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.CityId).HasColumnName("CityId").IsRequired();
        builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
        //İlişki
        builder.HasOne(i => i.City);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}