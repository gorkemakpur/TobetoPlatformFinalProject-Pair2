using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class AnnouncementUserConfiguration : IEntityTypeConfiguration<AnnouncementUser>
{
    public void Configure(EntityTypeBuilder<AnnouncementUser> builder)
    {
        //Tablomuz
        builder.ToTable("AnnouncementUsers").HasKey(i => i.Id);
        //Sütunlar
        builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
        builder.Property(i => i.AnnouncementId).HasColumnName("AnnouncementId").IsRequired();
        builder.Property(i => i.UserId).HasColumnName("UserId").IsRequired();
        builder.Property(i => i.IsRead).HasColumnName("IsRead").IsRequired();
        //İlişki
        builder.HasOne(i => i.Announcement);
        builder.HasOne(i => i.User);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}