
using Business;
using Business.Profiles;
using DataAccess;
using AutoMapper;

namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();


            builder.Services.AddBusinessServices();
            builder.Services.AddDataAccessServices(builder.Configuration);

            builder.Services.AddAutoMapper(typeof(InstructorMappingProfile));
            builder.Services.AddAutoMapper(typeof(SituationMappingProfile));
            builder.Services.AddAutoMapper(typeof(StudentMappingProfile));
            builder.Services.AddAutoMapper(typeof(LanguageMappingProfile));
            builder.Services.AddAutoMapper(typeof(LanguageTypeMappingProfile));
            builder.Services.AddAutoMapper(typeof(RoleMappingProfile));

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();
            //app.ConfigureCustomExceptionMiddleware();

            app.Run();
        }
    }
}
