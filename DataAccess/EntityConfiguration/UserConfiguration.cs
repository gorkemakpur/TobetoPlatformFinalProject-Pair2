using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            //Tablo
            builder.ToTable("Users").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.RoleId).HasColumnName("RoleId").IsRequired();
            builder.Property(i => i.CityId).HasColumnName("CityId").IsRequired();
            builder.Property(i => i.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(i => i.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(i => i.Email).HasColumnName("Email").IsRequired();
            builder.Property(i => i.Email).HasColumnName("Password").IsRequired();
            builder.Property(i => i.Email).HasColumnName("ConfirmPassword").IsRequired();
            builder.Property(i => i.Email).HasColumnName("BirthDate").IsRequired();
            builder.Property(i => i.Email).HasColumnName("NationalityId").IsRequired();
            builder.Property(i => i.Email).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(i => i.Email).HasColumnName("About").IsRequired();
            builder.Property(i => i.Email).HasColumnName("Country").IsRequired();
            builder.Property(i => i.Email).HasColumnName("AddressDescription").IsRequired();


            //İlişki
            builder.HasOne(i => i.Role);
            builder.HasOne(i => i.District);

            builder.HasMany(i => i.AnnouncementUsers);
            builder.HasMany(i => i.Instructors);
            builder.HasMany(i => i.Students);



            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
