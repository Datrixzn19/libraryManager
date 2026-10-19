/*
El * indica a NuGet que descargue el parche más reciente de la rama 9.0 
# (por ejemplo, 9.0.2), asegurando total compatibilidad y seguridad sin saltar a la versión 10.
dotnet add package Microsoft.EntityFrameworkCore.Sqlite --version 9.0.*
# Design es obligatorio para ejecutar las migraciones, convertir el código C# a tablas SQL.
# Debe tener exactamente la misma versión que el paquete base.
dotnet add package Microsoft.EntityFrameworkCore.Design --version 9.0.*
*/
using Microsoft.EntityFrameworkCore;
using libraryManager.Models;

namespace libraryManager.Data
{
    //Al heredar de DbContext adquiere toda la lógica para abrir conexiones, ejecutar sentencias SQL y rastrear cambios en los objetos.
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        //DbSet(T) le indica que clases van a pasar a ser tablas 
        public DbSet<Book> Books {get; set;}
    }
}
