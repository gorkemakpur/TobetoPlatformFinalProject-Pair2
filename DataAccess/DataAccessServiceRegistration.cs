using DataAccess.Abstracts;
using DataAccess.Concretes.EntityFramework;
using DataAccess.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public static class DataAccessServiceRegistration
    {
        public static IServiceCollection AddDataAccessServices(this IServiceCollection services, IConfiguration configuration)
        {

            services.AddDbContext<TobetoPlatformFinalProjectContext>(options => options.UseSqlServer(configuration.GetConnectionString("TobetoPlatformFinalProject")));

            services.AddScoped<IAnnouncementUserDal, EfAnnouncementUserDal>();
            services.AddScoped<ICityDal, EfCityDal>();
            services.AddScoped<IDistrictDal, EfDistrictDal>();
            services.AddScoped<IUserDal, EfUserDal>();
            services.AddScoped<IInstructorDal, EfInstructorDal>();
            services.AddScoped<IAnnouncementDal, EfAnnouncementDal>();
            services.AddScoped<IAnnouncementTypeDal, EfAnnouncementTypeDal>();
            services.AddScoped<IApplicationDal, EfApplicationDal>();
            services.AddScoped<IAsyncCourseDal, EfAsyncCourseDal>();
            services.AddScoped<IAsyncCourseContentDal, EfAsyncCourseContentDal>();
            services.AddScoped<IAsyncCourseDepartmentDal, EfAsyncCourseDepartmentDal>();
            services.AddScoped<ICategoryDal, EfCategoryDal>();
            services.AddScoped<ICertificateDal, EfCertificateDal>();
            services.AddScoped<ICompetenceDal, EfCompetenceDal>();
            services.AddScoped<IDepartmentDal, EfDepartmentDal>();
            services.AddScoped<IEducationDal, EfEducationDal>();
            services.AddScoped<IExperienceDal, EfExperienceDal>();
            services.AddScoped<ILanguageDal, EfLanguageDal>();
            services.AddScoped<ILanguageLevelDal, EfLanguageLevelDal>();
            services.AddScoped<ILanguageTypeDal, EfLanguageTypeDal>();
            services.AddScoped<ISituationDal, EfSituationDal>();
            services.AddScoped<ISocialMediaDal, EfSocialMediaDal>();
            services.AddScoped<ISocialMediaNameDal, EfSocialMediaNameDal>();
            services.AddScoped<IStudentDal, EfStudentDal>();
            services.AddScoped<ISurveyDal, EfSurveyDal>();
            services.AddScoped<ISyncCourseDal, EfSyncCourseDal>();
            services.AddScoped<ISyncCourseContentDal, EfSyncCourseContentDal>();
            services.AddScoped<ISyncCourseDepartmentDal, EfSyncCourseDepartmentDal>();
            services.AddScoped<ISyncCourseInstructorDal, EfSyncCourseInstructorDal>();

            return services;
        }

    }
}
