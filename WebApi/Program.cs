using Autofac;
using Autofac.Extensions.DependencyInjection;
using Business;
using Business.DependencyResolvers.Autofac;
using Core.CrossCuttingConcerns.Exceptions.Extensions;
using DataAccess;


namespace WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
            builder.Host.ConfigureContainer<ContainerBuilder>(myBuilder => myBuilder.RegisterModule(new AutofacBusinessModule()));


            builder.Services.AddControllers();

            builder.Services.AddBusinessServices();
            builder.Services.AddDataAccessServices(builder.Configuration);
            
            builder.Services.AddAutoMapper(typeof(BusinessServiceRegistration));
            

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
            app.ConfigureCustomExceptionMiddleware();

            app.Run();
        }
    }
}
