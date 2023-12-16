using Business.Abstracts;
using Business.Concretes;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public static class BusinessServiceRegistration
    {
        public static IServiceCollection AddBusinessServices(this IServiceCollection services)
        {
            services.AddScoped<IInstructorService, InstructorManager>();
            //services.AddScoped<ICategoryService, CategoryManager>();
            //services.AddScoped<ICategoryService, CategoryManager>();


            //services.AddSubClassesOfType(Assembly.GetExecutingAssembly(), typeof(BaseBusinessRules));
            //services.AddScoped<ProductBusinessRules>(); üstteki kod bu işleri hallediyor
            //services.AddScoped<CategoryBusinessRules>();

            //services.AddAutoMapper(Assembly.GetExecutingAssembly()); bunu burada yada program.cs içindeki haliyle yazabiliriz

            return services;
        }
    }
}
