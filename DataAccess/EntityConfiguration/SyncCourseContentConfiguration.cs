﻿using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace DataAccess.EntityConfiguration
{
    public class SyncCourseContentConfiguration : IEntityTypeConfiguration<SyncCourseContent>
    {
        public void Configure(EntityTypeBuilder<SyncCourseContent> builder)
        {
            // Tablomuz
            builder.ToTable("SyncCourseContents").HasKey(scc => scc.Id);

            // Sütunlar
            builder.Property(scc => scc.Id).HasColumnName("Id").IsRequired();
            builder.Property(scc => scc.SyncCourseId).HasColumnName("SyncCourseId").IsRequired();
            builder.Property(scc => scc.Name).HasColumnName("Name").IsRequired();
            builder.Property(scc => scc.Url).HasColumnName("Url").IsRequired();
            builder.Property(scc => scc.Description).HasColumnName("Description").IsRequired();
            builder.Property(scc => scc.StartedDate).HasColumnName("StartedDate").IsRequired();
            builder.Property(scc => scc.EndedDate).HasColumnName("EndedDate").IsRequired();

            // İlişki
            builder.HasOne(scc => scc.SyncCourse);
            builder.HasMany(scc => scc.SyncCourseInstructors);



            builder.HasQueryFilter(scc => !scc.DeletedDate.HasValue);
        }
    }
}