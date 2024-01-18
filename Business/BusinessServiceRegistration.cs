using Autofac;
using Business.Abstracts;
using Business.Concretes;
using Castle.DynamicProxy;
using Core.Utilities.Interceptors;
using Microsoft.Extensions.DependencyInjection;
using System.Reflection;

namespace Business
{

    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            #region scopelar
            services.AddScoped<IAnnouncementUserService, AnnouncementUserManager>();
            services.AddScoped<ICityService, CityManager>();
            services.AddScoped<IDistrictService, DistrictManager>();
            services.AddScoped<IUserService, UserManager>();
            services.AddScoped<IRoleService, RoleManager>();
            services.AddScoped<IInstructorService, InstructorManager>();
            services.AddScoped<IAnnouncementService, AnnouncementManager>();
            services.AddScoped<IAnnouncementTypeService, AnnouncementTypeManager>();
            services.AddScoped<IApplicationService, ApplicationManager>();
            services.AddScoped<IAsyncCourseService, AsyncCourseManager>();
            services.AddScoped<IAsyncCourseContentService, AsyncCourseContentManager>();
            services.AddScoped<IAsyncCourseDepartmentService, AsyncCourseDepartmentManager>();
            services.AddScoped<ICategoryService, CategoryManager>();
            services.AddScoped<ICertificateService, CertificateManager>();
            services.AddScoped<ICompetenceService, CompetenceManager>();
            services.AddScoped<IDepartmentService, DepartmentManager>();
            services.AddScoped<IEducationService, EducationManager>();
            services.AddScoped<IExperienceService, ExperienceManager>();
            services.AddScoped<ILanguageService, LanguageManager>();
            services.AddScoped<ILanguageLevelService, LanguageLevelManager>();
            services.AddScoped<ILanguageTypeService, LanguageTypeManager>();
            services.AddScoped<ISituationService, SituationManager>();
            services.AddScoped<ISocialMediaService, SocialMediaManager>();
            services.AddScoped<ISocialMediaNameService, SocialMediaNameManager>();
            services.AddScoped<IStudentService, StudentManager>();
            services.AddScoped<ISurveyService, SurveyManager>();
            services.AddScoped<ISyncCourseService, SyncCourseManager>();
            services.AddScoped<ISyncCourseContentService, SyncCourseContentManager>();
            services.AddScoped<ISyncCourseDepartmentService, SyncCourseDepartmentManager>();
            services.AddScoped<ISyncCourseInstructorService, SyncCourseInstructorManager>();
            #endregion
            
            //services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
            //services.AddScoped<ProductBusinessRules>(); üstteki kod bu işleri hallediyor
            //services.AddScoped<CategoryBusinessRules>();

            //services.AddAutoMapper(Assembly.GetExecutingAssembly()); bunu burada yada program.cs içindeki haliyle yazabiliriz

            return services;
        }

        public static IServiceCollection AddSubClassesOfType(
                    this IServiceCollection services,
                    Assembly assembly,
                    Type type,
                    Func<IServiceCollection, Type, IServiceCollection>? addWithLifeCycle = null)
        {
            var types = assembly.GetTypes().Where(t => t.IsSubclassOf(type) && type != t).ToList();
            foreach (var item in types)
                if (addWithLifeCycle == null)
                    services.AddScoped(item);

                else
                    addWithLifeCycle(services, type);
            return services;
        }
    }
}
