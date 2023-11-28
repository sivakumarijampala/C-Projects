using Microsoft.EntityFrameworkCore;
using SportClubProject.AdminRepository;
using SportClubProject.Repository;
using SportClubProject.UserRepository;

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
builder.Services.AddScoped<IUserRepository, UserRepositoryImpl>();

builder.Services.AddScoped<ISportsRepo, SportsRepoImpl>();
builder.Services.AddScoped<ICourtsRepo, CourtsRepoImplcs>();
builder.Services.AddScoped<ISlotsRepo, SlotsRepoImpl>();
builder.Services.AddScoped<IBookingRepo, BookingRepompl>();
builder.Services.AddScoped<ICartsRepo, CartsRepoImpl>();
builder.Services.AddScoped<ICouponsRepo, CouponsRepoImpl>();
builder.Services.AddScoped<ISlotsRepo, SlotsRepoImpl>();
builder.Services.AddScoped<IPaymentRepo, PaymentRepoImpl>();


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

app.MapControllers();

app.Run();
