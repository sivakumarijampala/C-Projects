using Microsoft.EntityFrameworkCore;
using StudentAdmision.Models;
using StudentAdmision.Repository;

namespace StudentAdmisionController
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<StudentAdmissionDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAdmissionsConnection"))
            );
            builder.Services.AddControllers();

            //adding repository
            builder.Services.AddScoped<IStudentAdmissionRepo,StudentAdmissionRepoImpl>();

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

            app.Run();
        }
    }
}