using libraryManager.Data;
using libraryManager.Models; 
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));


var app = builder.Build();

app.MapGet("/", () => "working");

app.Run(); 