using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class LanguageTypeConfiguration : IEntityTypeConfiguration<LanguageType>
    {
        public void Configure(EntityTypeBuilder<LanguageType> builder)
        {
            builder.ToTable("LanguageTypes").HasKey(lt => lt.Id);

            builder.Property(lt => lt.Id).HasColumnName("Id").IsRequired();
            builder.Property(lt => lt.Name).HasColumnName("Name").IsRequired();


            builder.HasMany(lt => lt.Languages);


            builder.HasQueryFilter(lt => !lt.DeletedDate.HasValue);
        }
    }
}
