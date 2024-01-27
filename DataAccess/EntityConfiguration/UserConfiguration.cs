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
            builder.Property(i => i.PasswordSalt).HasColumnName("PasswordSalt").IsRequired();
            builder.Property(i => i.PasswordHash).HasColumnName("PasswordHash").IsRequired();
            builder.Property(i => i.Status).HasColumnName("Status").IsRequired();


            //İlişki
            builder.HasMany(i => i.UserOperationClaims);



        builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }

}
