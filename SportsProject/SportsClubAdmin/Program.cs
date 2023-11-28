using Microsoft.EntityFrameworkCore;
using SportClubProject.AdminRepository;
using SportClubProject.Repository;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<SportsDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("SportsDbConnection")));



//adding stadium repository
builder.Services.AddScoped<IStadiumsRepository, StadiumRepositoryImpl>();

//adding sports repository 
builder.Services.AddScoped<ISportsRepository, SportRepositoryImpl>();


//adding courts repository
builder.Services.AddScoped<ICourtsRepository, CourtsRepositoryImpl>();

//adding slots repository
builder.Services.AddScoped<ISlotsRepository, SlotsRepositoryImpl>();


//cross origin policy

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder =>
        {
            builder.AllowAnyOrigin()
                   .AllowAnyMethod()
                   .AllowAnyHeader();
        });
});

// Add services to the container.

builder.Services.AddControllers();
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
app.UseCors("AllowOrigin");

app.MapControllers();

app.Run();
