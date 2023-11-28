
using SportsProject.Services;
using Twilio.Clients;

var builder = WebApplication.CreateBuilder(args);


//twilio service
builder.Services.AddSingleton<TwilioService>();

builder.Services.AddHttpClient<ITwilioRestClient, Twiloclient>();

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
