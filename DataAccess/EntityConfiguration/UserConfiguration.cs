using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Core.Entities.Concrete;
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




            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
