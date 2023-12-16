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
    public class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            //Tablo
            builder.ToTable("Instructors").HasKey(i => i.Id);
            //Sütunlar
            builder.Property(i => i.Id).HasColumnName("Id").IsRequired();
            builder.Property(i => i.FirstName).HasColumnName("FirstName").IsRequired();
            builder.Property(i => i.LastName).HasColumnName("LastName").IsRequired();
            builder.Property(i => i.Email).HasColumnName("Email").IsRequired();
            builder.Property(i => i.Password).HasColumnName("Password").IsRequired();
            builder.Property(i => i.ConfirmPassword).HasColumnName("ConfirmPassword").IsRequired();
            builder.Property(i => i.PhoneNumber).HasColumnName("PhoneNumber").IsRequired();
            builder.Property(i => i.About).HasColumnName("About").IsRequired();
            //Uniq Key
            builder.HasIndex(indexExpression: i => i.PhoneNumber, name: "UK_Instructors_PhoneNumber").IsUnique();
            //İlişki
            builder.HasMany(i => i.SyncCourseInstructors);

            builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 


        }
    }
}
