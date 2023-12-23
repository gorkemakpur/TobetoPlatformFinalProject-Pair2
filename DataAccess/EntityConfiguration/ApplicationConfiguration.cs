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
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            //Tablo
            builder.ToTable("Applications").HasKey(i => i.Id);

            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.StudentId).HasColumnName("StudentId").IsRequired();
            builder.Property(i => i.IsDocumentAccepted).HasColumnName("IsDocumentAccepted").IsRequired();
            builder.Property(i => i.IsFormAccepted).HasColumnName("IsFormAccepted").IsRequired();

            //Uniq Key
            //builder.HasIndex(indexExpression: i => i.Type, name: "UK_AnnouncementTypes_Type").IsUnique();

            //İlişki
            builder.HasOne(i => i.Student);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue);
        }
    }
}
