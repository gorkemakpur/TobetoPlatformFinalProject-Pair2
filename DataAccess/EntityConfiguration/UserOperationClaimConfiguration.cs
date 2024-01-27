using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Core.Entities.Concrete;
namespace DataAccess.EntityConfiguration
{
    public class UserOperationClaimConfiguration : IEntityTypeConfiguration<UserOperationClaim>
    {
        public void Configure(EntityTypeBuilder<UserOperationClaim> builder)
        {
            //Tablo
            builder.ToTable("UserOperationClaims").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.UserId).HasColumnName("UserId").IsRequired();
            builder.Property(i => i.OperationClaimId).HasColumnName("OperationClaimId").IsRequired();


            //İlişki
            builder.HasOne(i => i.User);
            builder.HasOne(i => i.OperationClaim);



            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }

}
