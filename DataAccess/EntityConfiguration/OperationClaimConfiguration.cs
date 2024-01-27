using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

using Core.Entities.Concrete;
namespace DataAccess.EntityConfiguration
{
    public class OperationClaimConfiguration : IEntityTypeConfiguration<OperationClaim>
    {
        public void Configure(EntityTypeBuilder<OperationClaim> builder)
        {
            //Tablo
            builder.ToTable("OperationClaims").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.Name).HasColumnName("Name").IsRequired();

            //İlişki
            builder.HasMany(i => i.UserOperationClaims);



            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
