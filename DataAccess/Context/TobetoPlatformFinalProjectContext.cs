using Core.Entities.Concrete;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;


namespace DataAccess.Context;

public class TobetoPlatformFinalProjectContext : DbContext
{
    protected IConfiguration Configuration { get; set; }

    public DbSet<Announcement> Announcements { get; set; }
    public DbSet<AnnouncementType> AnnouncementTypes { get; set; }
    public DbSet<AnnouncementUser> AnnouncementUsers { get; set; }
    public DbSet<Application> Applications { get; set; }
    public DbSet<AsyncCourse> AsyncCourses { get; set; }
    public DbSet<AsyncCourseContent> AsyncCourseContents { get; set; }
    public DbSet<AsyncCourseDepartment> AsyncCourseDepartments { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Certificate> Certificates { get; set; }
    public DbSet<City> Cities { get; set; }
    public DbSet<Competence> Competences { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<District> Districts { get; set; }
    public DbSet<Education> Educations { get; set; }
    public DbSet<Experience> Experiences { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<Language> Languages { get; set; }
    public DbSet<LanguageLevel> LanguageLevels { get; set; }
    public DbSet<LanguageType> LanguageTypes { get; set; }
    public DbSet<Situation> Situations { get; set; }
    public DbSet<SocialMedia> SocialMedias { get; set; }
    public DbSet<SocialMediaName> SocialMediaNames { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Survey> Surveys { get; set; }
    public DbSet<SyncCourse> SyncCourses { get; set; }
    public DbSet<SyncCourseContent> SyncCourseContents { get; set; }
    public DbSet<SyncCourseDepartment> SyncCourseDepartments { get; set; }
    public DbSet<SyncCourseInstructor> SyncCourseInstructors { get; set; }
    //14
    public DbSet<User> Users { get; set; }
    public DbSet<OperationClaim> OperationClaims { get; set; }
    public DbSet<UserOperationClaim> UserOperationClaims { get; set; }


    public TobetoPlatformFinalProjectContext(DbContextOptions dbContextOptions, IConfiguration configuration) : base(dbContextOptions)
    {
        Configuration = configuration;
        Database.EnsureCreated();
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}
