using Ocelot.DependencyInjection;
using Ocelot.Middleware;

namespace ApiGateWayOcelot
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();

            //configure ocelot using appsettings.json file 
            builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);

            //adding ocelot service
            builder.Services.AddOcelot(builder.Configuration);

            var app = builder.Build();

            // Configure the HTTP request pipeline.

            app.UseHttpsRedirection();

            app.UseAuthorization();
            

            app.MapControllers();

            //adding ocelot in middle were
            app.UseOcelot().Wait();

            app.Run();
        }
    }
}