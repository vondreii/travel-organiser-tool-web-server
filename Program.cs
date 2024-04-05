using Microsoft.EntityFrameworkCore;
using System.Net;
using System.Text.Json.Serialization;
using TravelOrganiserTool.Data;
using TravelOrganiserTool.Environment;

var builder = WebApplication.CreateBuilder(args);

// Kestral - web server used in ASP.NET Core to host the application
// This is hosting the C# at localhost:5000, this is where it will listen to requests
builder.WebHost.ConfigureKestrel(options =>
{
    options.Listen(IPAddress.Loopback, 5000); 
});

// Add configuration
var configuration = builder.Configuration;
EnvironmentService.Initialize(configuration);
bool isProduction = EnvironmentService.Instance.IsProduction;

// Add Cors so that we can allow requests from the UI
// localhost:4200 or travel-organiser-tool-web.azurewebsites.net
builder.Services.AddCors(options =>
{
    if (isProduction)
    {
        options.AddPolicy("AllowOrigin", builder =>
        {
            builder.WithOrigins("https://travel-organiser-tool-web.azurewebsites.net")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    }
    else
    {
        options.AddPolicy("AllowOrigin", builder =>
        {
            builder.WithOrigins("http://localhost:4200")
                .AllowAnyHeader()
                .AllowAnyMethod();
        });
    }
});

// Configure connection to DB
string connectionString = "Server=DESKTOP-1A7D31U\\SQLEXPRESS;Database=TravelOrganiserTool;Trusted_Connection=True;TrustServerCertificate=True;";

if (isProduction)
{
    connectionString = "Server=tcp:travel-organiser-tool-db.database.windows.net,1433;Initial Catalog=travel-organiser-tool-db;Persist Security Info=False;User ID=travel-organiser-tool-admin;Password=hdue75j728*hs-e5dg7;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
}

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(connectionString);
});

// Configure controllers
builder.Services.AddControllers().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.Preserve;
});

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Apply the CORS policy
app.UseCors("AllowOrigin");

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
    app.UseDeveloperExceptionPage();
}
else
{
    app.UseHttpsRedirection();
}

app.UseAuthorization();

app.MapControllers();

app.Run();
