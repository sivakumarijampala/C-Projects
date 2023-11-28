using Microsoft.EntityFrameworkCore;
using StudentAttendance.Models;
using StudentAttendance.Repository;

namespace StudentAttendance
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<StudentAttendanceDbContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("StudentAttendanceConnection")));
            builder.Services.AddControllers();

            //adding repo
            builder.Services.AddScoped<IStudentAttendanceRepo,StudentAttendanceRepoImpl>();

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