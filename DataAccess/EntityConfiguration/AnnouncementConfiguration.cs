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
    public class AnnouncementConfiguration : IEntityTypeConfiguration<Announcement>
    {
        public void Configure(EntityTypeBuilder<Announcement> builder)
        {

            //Tablo
            builder.ToTable("Announcements").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.AnnouncementTypeId).HasColumnName("AnnouncementTypeId").IsRequired();
            builder.Property(i => i.Description).HasColumnName("Description").IsRequired();
            builder.Property(i => i.SendDate).HasColumnName("SendDate").IsRequired();

            //İlişki
            builder.HasOne(i => i.AnnouncementType);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
