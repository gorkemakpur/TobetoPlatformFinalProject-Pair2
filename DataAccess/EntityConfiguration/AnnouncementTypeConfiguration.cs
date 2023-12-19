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
    public class AnnouncementTypeConfiguration : IEntityTypeConfiguration<AnnouncementType>
    {
        public void Configure(EntityTypeBuilder<AnnouncementType> builder)
        {
            //Tablo
            builder.ToTable("AnnouncementTypes").HasKey(i => i.Id);

            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.Type).HasColumnName("Type").IsRequired();

            //Uniq Key
            builder.HasIndex(indexExpression: i => i.Type, name: "UK_AnnouncementTypes_Type").IsUnique();

            //İlişki
            builder.HasMany(i => i.Announcements);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
