using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration
{
    public class StudentInformationConfiguration : IEntityTypeConfiguration<StudentInformation>
    {
        public void Configure(EntityTypeBuilder<StudentInformation> builder)
        {
            //Tablo
            builder.ToTable("StudentInformations").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.StudentId).HasColumnName("AsyncCourseId").IsRequired();
            builder.Property(i => i.DistrictId).HasColumnName("DistrictId").IsRequired();
            builder.Property(i => i.BirthDate).HasColumnName("BirthDate").IsRequired();
            builder.Property(i => i.NationalityId).HasColumnName("NationalityId").IsRequired();
            builder.Property(i => i.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(i => i.About).HasColumnName("About").IsRequired();
            builder.Property(i => i.Country).HasColumnName("Country").IsRequired();
            builder.Property(i => i.AddressDescription).HasColumnName("AddressDescription").IsRequired();

            //İlişki
            builder.HasOne(i => i.District);
            builder.HasOne(i => i.Student);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
