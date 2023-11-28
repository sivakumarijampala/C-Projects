
using Microsoft.EntityFrameworkCore;
using SportClubProject.Repository;
using SportClubProject.UserRepository;
using SportsProject.Services;
using Twilio.Clients;

var builder = WebApplication.CreateBuilder(args);


// Add services to the container.
builder.Services.AddDbContext<SportsDbContext>(options =>
   options.UseSqlServer(builder.Configuration.GetConnectionString("SportsDbConnection")));


//twilio service
builder.Services.AddSingleton<TwilioService>();


builder.Services.AddHttpClient<ITwilioRestClient, Twiloclient>();

builder.Services.AddScoped<IUserRepository ,UserRepositoryImpl>();
builder.Services.AddScoped<IStadiumRepo,StadiumRepompl>();
builder.Services.AddScoped<ISportsRepo,SportsRepoImpl>();
builder.Services.AddScoped<ISlotsRepo, SlotsRepoImpl>();
builder.Services.AddScoped<IPaymentRepo,PaymentRepoImpl>();
builder.Services.AddScoped<ICourtsRepo,CourtsRepoImplcs>();
builder.Services.AddScoped<ICouponsRepo,CouponsRepoImpl>();
builder.Services.AddScoped<ICartsRepo,CartsRepoImpl>();
builder.Services.AddScoped<IBookingRepo,BookingRepompl>();

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

app.UseAuthorization();
app.UseCors("AllowOrigin");

app.MapControllers();

app.Run();
