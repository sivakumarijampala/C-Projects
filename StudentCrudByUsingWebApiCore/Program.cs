using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using StudentCrudByUsingWebApiCore;
using StudentCrudByUsingWebApiCore.Jwt;
using StudentCrudByUsingWebApiCore.Models;
using StudentCrudByUsingWebApiCore.StudentRepo;
using StudentCrudByUsingWebApiCore.StudentRepositoryImpl;
using System.Text;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<StudentDbContext>(options =>
options.UseSqlServer(builder.Configuration.GetConnectionString("StudentDbConnection")));


builder.Services.AddScoped<StudentRepository,StudentRepoImpl>();
builder.Services.AddScoped<UserRepo,UserRepoImpl>();
builder.Services.AddScoped<IJwtService, JwtService>();

//cross origin policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin", builder =>
    {
        builder.AllowAnyOrigin()
        .AllowAnyMethod()
        .AllowAnyHeader();
    });
});

builder.Services.AddControllers();

builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;

}).
AddJwtBearer(jwtoptions =>
{
    var configuration = builder.Configuration;
    var key = configuration.GetValue<string>("JwtConfig:Key");
    var keybytes = Encoding.ASCII.GetBytes(key);
    jwtoptions.SaveToken = true;
    TokenValidationParameters tokenValidationParameters = new TokenValidationParameters
    {
        IssuerSigningKey = new SymmetricSecurityKey(keybytes),
        ValidateLifetime = true,
        ValidateAudience = true,
        ValidateIssuer=false
    };
});


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

app.UseAuthentication();
app.UseAuthorization();

app.MapControllers();

app.Run();
