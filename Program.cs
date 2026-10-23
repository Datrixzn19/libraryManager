using libraryManager.Data;
using libraryManager.Models; 
using Microsoft.EntityFrameworkCore;

//Paquetes de entity framework core
//dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.0
//dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.0

//Herramienta global de efcore
// dotnet tool install --global dotnet-ef

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlite(connectionString));


var app = builder.Build();

app.MapGet("/", () => "working");

app.Run();


// Generar la base de datos fisica 
/*
# EF Core escanea tu archivo AppDbContext y el modelo Book.
# Traduce esas clases de C# a instrucciones de creación de tablas SQL y las 
# guarda en una nueva carpeta llamada 'Migrations'
*/
//dotnet ef migrations add InitialCreate

//Crear la base de datos 
/*
 # Lee las instrucciones generadas en el paso anterior y las ejecuta físicamente.
# Como configuramos 'UseSqlite' en Program.cs, este comando creará el  archivo 'library.db' y construirá la tabla 'Books' dentro de él.
 */
//dotnet ef database update