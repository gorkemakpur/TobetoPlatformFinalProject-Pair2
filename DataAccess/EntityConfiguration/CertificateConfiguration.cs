using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.EntityConfiguration
{
    public class CertificateConfiguration : IEntityTypeConfiguration<Certificate>
    {
        public void Configure(EntityTypeBuilder<Certificate> builder)
        {
            // Tablomuz
            builder.ToTable("Certificates").HasKey(cert => cert.Id);

            // Sütunlar
            builder.Property(cert => cert.Id).HasColumnName("Id").IsRequired();
            builder.Property(cert => cert.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(cert => cert.Url).HasColumnName("Url").IsRequired();
            builder.Property(cert => cert.Name).HasColumnName("Name").IsRequired();

            // İlişki
            builder.HasOne(cert => cert.Student);
                


            builder.HasQueryFilter(cert => !cert.DeletedDate.HasValue);
        }
    }
}