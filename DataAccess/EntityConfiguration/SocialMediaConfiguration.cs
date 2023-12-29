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
    public class SocialMediaConfiguration : IEntityTypeConfiguration<SocialMedia>
    {
        public void Configure(EntityTypeBuilder<SocialMedia> builder)
        {
            //Tablo
            builder.ToTable("SocialMedias").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.SocialMediaNameId).HasColumnName("SocialMediaNameId").IsRequired();
            builder.Property(i => i.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(i => i.Url).HasColumnName("Url").IsRequired();
          

            //İlişki
            builder.HasOne(i => i.Students);
            builder.HasOne(i => i.SocialMediaName);

           

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }

}
