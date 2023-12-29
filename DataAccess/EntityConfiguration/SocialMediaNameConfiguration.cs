using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class SocialMediaNameConfiguration : IEntityTypeConfiguration<SocialMediaName>
    {
        public void Configure(EntityTypeBuilder<SocialMediaName> builder)
        {
            //Tablo
            builder.ToTable("SocialMediaNames").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
           


            //İlişki
            builder.HasMany(i => i.SocialMedias);



            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
