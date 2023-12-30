using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DataAccess.EntityConfiguration;

public class DepartmentConfiguration : IEntityTypeConfiguration<Department>
{
    public void Configure(EntityTypeBuilder<Department> builder)
    {
        builder.ToTable("Departmens").HasKey(x => x.Id);
        builder.Property(i => i.Name).HasColumnName("Name").IsRequired();
        builder.Property(i => i.Description).HasColumnName("Description").IsRequired();
        //İlişki
        builder.HasMany(i => i.Students);
        builder.HasMany(i => i.AsyncCourseDepartments);
        builder.HasMany(i => i.SyncCourseDepartments);
        
        builder.HasQueryFilter(i => !i.DeletedDate.HasValue); 
    }
}

