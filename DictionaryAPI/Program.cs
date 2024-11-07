using DictionaryAPI.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Cors;


var builder = WebApplication.CreateBuilder(args);

// CORS Policy
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowFrontend", policy =>
    {
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Add services to the container.
builder.Services.AddDbContext<DictionaryContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DictionaryDB")));

builder.Services.AddControllers();

var app = builder.Build();

// Use CORS policy
app.UseCors("AllowFrontend");

// Configure the HTTP request pipeline.
app.UseAuthorization();

app.MapControllers();

app.Run();
